
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite; // <-- Eklendi
using System.Linq;
using System.Windows.Forms;     
using Microsoft.VisualBasic;

namespace Stok_takip
{
    public partial class MenulerFormu : Form
    {
        public MenulerFormu()
        {
            InitializeComponent();
        }

        private void MenulerFormu_Load(object sender, EventArgs e)
        {
            TarifleriYukle();
            MenuleriYukle();
        }

        private void TarifleriYukle()
        {
            clbTarifler.Items.Clear();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT TarifID, TarifAdi FROM Tarifler";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        clbTarifler.Items.Add(new ComboBoxItem
                        {
                            Text = dr["TarifAdi"].ToString(),
                            Value = dr["TarifID"]
                        });
                    }
                }
            }
        }

        private void MenuleriYukle()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT m.MenuID, m.Tarih, t.TarifAdi, m.KisiSayisi
                                 FROM Menuler m
                                 INNER JOIN Tarifler t ON m.TarifID = t.TarifID
                                 WHERE m.Tarih = @Tarih
                                 ORDER BY m.MenuID DESC";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tarih", dtpTarih.Value.Date);
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMenuler.DataSource = dt;
                    }
                }
            }

            if (dgvMenuler.Columns.Contains("MenuID"))
                dgvMenuler.Columns["MenuID"].Visible = false;
            if (dgvMenuler.Columns.Contains("Tarih"))
                dgvMenuler.Columns["Tarih"].HeaderText = "Tarih";
            if (dgvMenuler.Columns.Contains("TarifAdi"))
                dgvMenuler.Columns["TarifAdi"].HeaderText = "Tarif Adı";
            if (dgvMenuler.Columns.Contains("KisiSayisi"))
                dgvMenuler.Columns["KisiSayisi"].HeaderText = "Kişi Sayısı";
        }

        private void btnMenuyeEkle_Click(object sender, EventArgs e)
        {
            if (clbTarifler.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir tarif seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kisiSayisi = (int)nudKisiSayisi.Value;
            DateTime tarih = dtpTarih.Value.Date;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                foreach (ComboBoxItem item in clbTarifler.CheckedItems)
                {
                    string query = "INSERT INTO Menuler (Tarih, TarifID, KisiSayisi) VALUES (@Tarih, @TarifID, @KisiSayisi)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@TarifID", item.Value);
                        cmd.Parameters.AddWithValue("@KisiSayisi", kisiSayisi);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            var tarifAdlari = new List<string>();
            foreach (var item in clbTarifler.CheckedItems)
            {
                if (item is ComboBoxItem cbi)
                    tarifAdlari.Add(cbi.Text);
            }
            LoglarFormu.LogEkle(
                Oturum.KullaniciAdi,
                $"Menü eklendi: Tarih={dtpTarih.Value:dd.MM.yyyy}, Kişi Sayısı={nudKisiSayisi.Value}, Tarifler={string.Join(", ", tarifAdlari)}"
);
            MessageBox.Show("Menüye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MenuleriYukle();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            MenuleriYukle();
        }

        private void btnTopluIhtiyacHesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            // 1. Seçili tarih aralığındaki tüm menüleri çek
            DataTable menuler = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT TarifID, KisiSayisi FROM Menuler
                                 WHERE Tarih >= @Baslangic AND Tarih <= @Bitis";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@Bitis", bitis);
                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(menuler);
                    }
                }
            }

            if (menuler.Rows.Count == 0)
            {
                MessageBox.Show("Seçili tarih aralığında menü bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Tarif ve kişi sayılarını grupla
            var tarifler = new List<(int TarifID, int KisiSayisi)>();
            foreach (DataRow row in menuler.Rows)
                tarifler.Add((Convert.ToInt32(row["TarifID"]), Convert.ToInt32(row["KisiSayisi"])));

            // 3. Tüm tarifler için malzeme ihtiyacını hesapla ve topla
            var toplamlar = new Dictionary<string, (decimal miktar, string birim)>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                foreach (var (tarifID, kisiSayisi) in tarifler)
                {
                    // Tarifin porsiyon bilgisini al
                    using (var cmdPorsiyon = new SQLiteCommand("SELECT Porsiyon FROM Tarifler WHERE TarifID = @TarifID", conn))
                    {
                        cmdPorsiyon.Parameters.AddWithValue("@TarifID", tarifID);
                        int tarifPorsiyon = Convert.ToInt32(cmdPorsiyon.ExecuteScalar());

                        // Malzemeleri al
                        using (var cmdMalzeme = new SQLiteCommand("SELECT UrunAdi, Miktar, Birim FROM TarifIcerik WHERE TarifID = @TarifID", conn))
                        {
                            cmdMalzeme.Parameters.AddWithValue("@TarifID", tarifID);
                            using (var dr = cmdMalzeme.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    string urunAdi = dr["UrunAdi"].ToString();
                                    decimal miktar = Convert.ToDecimal(dr["Miktar"]);
                                    string birim = dr["Birim"].ToString();
                                    decimal toplam = (miktar / tarifPorsiyon) * kisiSayisi;

                                    // Birim dönüşümü uygula (BirimDonusum.Donustur fonksiyonunu kullanabilirsiniz)
                                    var (donusmusMiktar, anaBirim) = BirimDonusum.Donustur(toplam, birim);
                                    string key = urunAdi + "|" + anaBirim;

                                    if (toplamlar.ContainsKey(key))
                                        toplamlar[key] = (toplamlar[key].miktar + donusmusMiktar, anaBirim);
                                    else
                                        toplamlar.Add(key, (donusmusMiktar, anaBirim));
                                }
                            }
                        }
                    }
                }
            }

            // 4. Sonuçları DataGridView'de göster
            DataTable dtSonuc = new DataTable();
            dtSonuc.Columns.Add("Malzeme Adı");
            dtSonuc.Columns.Add("Toplam Miktar");
            dtSonuc.Columns.Add("Birim");

            foreach (var item in toplamlar)
            {
                string[] parca = item.Key.Split('|');
                string urunAdi = parca[0];
                string anaBirim = item.Value.birim;
                decimal ihtiyac = item.Value.miktar;

                dtSonuc.Rows.Add(urunAdi, ihtiyac.ToString("0.##"), anaBirim);
            }

            // 5. Maliyet analizi
            decimal genelToplam = 0;
            int toplamKisi = 0;

            foreach (var (tarifID, kisiSayisi) in tarifler)
                toplamKisi += kisiSayisi;

            dtSonuc.Columns.Add("Birim Fiyat");
            dtSonuc.Columns.Add("Toplam Maliyet");

            foreach (var item in toplamlar)
            {
                string[] parca = item.Key.Split('|');
                string urunAdi = parca[0];
                string anaBirim = item.Value.birim;
                decimal ihtiyac = item.Value.miktar;

                // Alış fiyatını çek
                decimal birimFiyat = GetAlisFiyati(urunAdi, anaBirim);
                decimal toplamMaliyet = ihtiyac * birimFiyat;
                genelToplam += toplamMaliyet;

                string birimFiyatStr = birimFiyat > 0 ? $"{birimFiyat:0.##} TL/{anaBirim}" : "-";
                string toplamMaliyetStr = toplamMaliyet > 0 ? $"{toplamMaliyet:0.##} TL" : "-";

                dtSonuc.Rows.Add(urunAdi, ihtiyac.ToString("0.##"), anaBirim, birimFiyatStr, toplamMaliyetStr);
            }

            // Sonuçları göster
            dgvMenuler.DataSource = dtSonuc;

            // Genel maliyet ve kişi başı maliyet mesajı
            MessageBox.Show(
                $"Toplam Maliyet: {genelToplam:0.##} TL\nKişi Başı Maliyet: {(toplamKisi > 0 ? genelToplam / toplamKisi : 0):0.##} TL",
                "Maliyet Analizi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Kritik stok kontrolü ve uyarı
            List<string> kritikUrunler = new List<string>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                foreach (var item in toplamlar)
                {
                    string[] parca = item.Key.Split('|');
                    string urunAdi = parca[0];
                    string anaBirim = item.Value.birim;
                    decimal ihtiyac = item.Value.miktar;

                    // Stok ve kritik seviye bilgisini çek
                    string query = "SELECT Miktar, KritikSeviye, Birim FROM Urunler WHERE UrunAdi = @UrunAdi";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                decimal stokMiktar = Convert.ToDecimal(dr["Miktar"]);
                                decimal kritikSeviye = Convert.ToDecimal(dr["KritikSeviye"]);
                                string stokBirim = dr["Birim"].ToString();

                                // Birim dönüşümü (stok birimi ile ihtiyac birimi farklıysa)
                                decimal stokMiktarDonusmus = stokMiktar;
                                if (stokBirim != anaBirim)
                                {
                                    var (donusmus, _) = BirimDonusum.Donustur(stokMiktar, stokBirim);
                                    stokMiktarDonusmus = donusmus;
                                }

                                if (stokMiktarDonusmus < ihtiyac || stokMiktarDonusmus < kritikSeviye)
                                {
                                    kritikUrunler.Add($"{urunAdi} (Stok: {stokMiktarDonusmus:0.##} {anaBirim}, İhtiyaç: {ihtiyac:0.##} {anaBirim})");
                                }
                            }
                        }
                    }
                }

                if (kritikUrunler.Count > 0)
                {
                    MessageBox.Show(
                        "Stokta yetersiz veya kritik seviyede olan malzemeler:\n\n" +
                        string.Join("\n", kritikUrunler),
                        "Kritik Stok Uyarısı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show("Tüm malzemeler stokta yeterli seviyede.", "Stok Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dgvMenuler.DataSource == null || dgvMenuler.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Dosyası (*.csv)|*.csv";
                sfd.FileName = "TopluMalzemeIhtiyaci.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Sütun başlıkları
                            for (int i = 0; i < dgvMenuler.Columns.Count; i++)
                            {
                                sw.Write(dgvMenuler.Columns[i].HeaderText);
                                if (i < dgvMenuler.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();

                            // Satırlar
                            foreach (DataGridViewRow row in dgvMenuler.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int i = 0; i < dgvMenuler.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dgvMenuler.Columns.Count - 1)
                                        sw.Write(";");
                                }
                                sw.WriteLine();
                            }
                        }
                        MessageBox.Show("Excel (CSV) dosyası başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Aktarım sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            if (dgvMenuler.SelectedRows.Count == 0)
                return;

            int menuID = Convert.ToInt32(dgvMenuler.SelectedRows[0].Cells["MenuID"].Value);
            var result = MessageBox.Show("Seçili menüyü silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("DELETE FROM Menuler WHERE MenuID = @MenuID", conn))
                    {
                        cmd.Parameters.AddWithValue("@MenuID", menuID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MenuleriYukle();

                // Loglama eklendi
                LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Menü silindi: MenuID={menuID}");
            }
        }

        private void btnMenuSil_Click(object sender, EventArgs e)
        {
            if (dgvMenuler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir menü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Seçili menüyü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            int menuID = Convert.ToInt32(dgvMenuler.SelectedRows[0].Cells["MenuID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Menuler WHERE MenuID = @MenuID", conn))
                {
                    cmd.Parameters.AddWithValue("@MenuID", menuID);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Menü silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MenuleriYukle();

            // Loglama eklendi
            LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Menü silindi: MenuID={menuID}");
        }

        private void menuGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMenuler.SelectedRows.Count == 0)
                return;

            int menuID = Convert.ToInt32(dgvMenuler.SelectedRows[0].Cells["MenuID"].Value);
            int kisiSayisi = Convert.ToInt32(dgvMenuler.SelectedRows[0].Cells["KisiSayisi"].Value);

            // Basit bir input ile kişi sayısı güncelleme
            string input = Interaction.InputBox("Yeni kişi sayısını girin:", "Kişi Sayısı Güncelle", kisiSayisi.ToString());
            if (int.TryParse(input, out int yeniKisiSayisi) && yeniKisiSayisi > 0)
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("UPDATE Menuler SET KisiSayisi = @KisiSayisi WHERE MenuID = @MenuID", conn))
                    {
                        cmd.Parameters.AddWithValue("@KisiSayisi", yeniKisiSayisi);
                        cmd.Parameters.AddWithValue("@MenuID", menuID);
                        cmd.ExecuteNonQuery();
                    }
                }
            MenuleriYukle();

            // Loglama eklendi
            LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Menü güncellendi: MenuID={menuID}, Yeni Kişi Sayısı={yeniKisiSayisi}");
        }

        private void dgvMenuler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvMenuler.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                    dgvMenuler.Rows[hti.RowIndex].Selected = true;
            }
        }

        // ComboBoxItem yardımcı sınıfı
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private decimal GetAlisFiyati(string urunAdi, string ihtiyacBirimi)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT AlisFiyati, Birim FROM Urunler WHERE UrunAdi = @UrunAdi";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            decimal fiyat = Convert.ToDecimal(dr["AlisFiyati"]);
                            string fiyatBirimi = dr["Birim"].ToString();

                            if (fiyatBirimi == ihtiyacBirimi)
                                return fiyat;

                            // Birim dönüşümü gerekiyorsa
                            var (donusmusMiktar, anaBirim) = BirimDonusum.Donustur(1, fiyatBirimi);
                            decimal donusmusFiyat = fiyat / donusmusMiktar;
                            return donusmusFiyat;
                        }
                    }
                }
            }
            return 0;
        }

        private void StokDus(int tarifID, int kisiSayisi)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Tarifin porsiyon bilgisini al
                using (var cmdPorsiyon = new SQLiteCommand("SELECT Porsiyon FROM Tarifler WHERE TarifID = @TarifID", conn))
                {
                    cmdPorsiyon.Parameters.AddWithValue("@TarifID", tarifID);
                    int tarifPorsiyon = Convert.ToInt32(cmdPorsiyon.ExecuteScalar());

                    // Tarifin malzemelerini al
                    using (var cmdMalzeme = new SQLiteCommand("SELECT UrunAdi, Miktar, Birim FROM TarifIcerik WHERE TarifID = @TarifID", conn))
                    {
                        cmdMalzeme.Parameters.AddWithValue("@TarifID", tarifID);
                        using (var dr = cmdMalzeme.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string urunAdi = dr["UrunAdi"].ToString();
                                decimal miktar = Convert.ToDecimal(dr["Miktar"]);
                                string birim = dr["Birim"].ToString();
                                decimal toplamIhtiyac = (miktar / tarifPorsiyon) * kisiSayisi;

                                // Stok miktarını ve birimini al
                                decimal stokMiktar = 0;
                                string stokBirim = "";
                                using (var cmdStok = new SQLiteCommand("SELECT Miktar, Birim FROM Urunler WHERE UrunAdi = @UrunAdi", conn))
                                {
                                    cmdStok.Parameters.AddWithValue("@UrunAdi", urunAdi);
                                    using (var drStok = cmdStok.ExecuteReader())
                                    {
                                        if (drStok.Read())
                                        {
                                            stokMiktar = Convert.ToDecimal(drStok["Miktar"]);
                                            stokBirim = drStok["Birim"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show($"{urunAdi} stoklarda bulunamadı!", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            continue;
                                        }
                                    }
                                }

                                // Birim dönüşümü (stok birimi ile ihtiyac birimi farklıysa)
                                decimal dusulecekMiktar = toplamIhtiyac;
                                if (stokBirim != birim)
                                {
                                    var (donusmus, _) = BirimDonusum.Donustur(toplamIhtiyac, birim);
                                    dusulecekMiktar = donusmus;
                                }

                                // Yeterli stok var mı kontrol et
                                if (stokMiktar < dusulecekMiktar)
                                {
                                    MessageBox.Show($"{urunAdi} için stok yetersiz! (Stok: {stokMiktar} {stokBirim}, Gerekli: {dusulecekMiktar} {stokBirim})", "Stok Yetersiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    continue;
                                }

                                // Stoktan düş
                                using (var cmdDus = new SQLiteCommand("UPDATE Urunler SET Miktar = Miktar - @Dusulecek WHERE UrunAdi = @UrunAdi", conn))
                                {
                                    cmdDus.Parameters.AddWithValue("@Dusulecek", dusulecekMiktar);
                                    cmdDus.Parameters.AddWithValue("@UrunAdi", urunAdi);
                                    cmdDus.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnMenuKopyala_Click(object sender, EventArgs e)
        {
            // Menü kopyalama işlemi burada yapılacak.
            MessageBox.Show("Menü kopyalama işlemi henüz uygulanmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenuOner_Click(object sender, EventArgs e)
        {
            // Menü öneri işlemi burada yapılacak.
            MessageBox.Show("Menü öneri işlemi henüz uygulanmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
