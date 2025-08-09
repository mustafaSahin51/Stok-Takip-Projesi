
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite; // <-- Eklendi
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class MalzemeIhtiyaciForm : Form
    {
        public MalzemeIhtiyaciForm()
        {
            InitializeComponent();
        }

        private void MalzemeIhtiyaciForm_Load(object sender, EventArgs e)
        {
            TarifleriYukle();
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (clbTarifler.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir tarif seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kisiSayisi = (int)nudKisiSayisi.Value;
            List<int> tarifIDler = new List<int>();
            foreach (ComboBoxItem item in clbTarifler.CheckedItems)
                tarifIDler.Add(Convert.ToInt32(item.Value));

            DataTable dt = MalzemeIhtiyaciHesaplaCoklu(tarifIDler, kisiSayisi);
            dgvSonuc.DataSource = dt;

            LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Malzeme ihtiyacı hesaplandı. Seçili tarif sayısı: {clbTarifler.CheckedItems.Count}, Kişi sayısı: {nudKisiSayisi.Value}");
        }

        private DataTable MalzemeIhtiyaciHesapla(int tarifID, int kisiSayisi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Malzeme Adı");
            dt.Columns.Add("Toplam Miktar");
            dt.Columns.Add("Birim");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
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
                                dt.Rows.Add(urunAdi, toplam.ToString("0.##"), birim);
                            }
                        }
                    }
                }
            }
            return dt;
        }

        private DataTable MalzemeIhtiyaciHesaplaCoklu(List<int> tarifIDler, int kisiSayisi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Malzeme Adı");
            dt.Columns.Add("Toplam Miktar");
            dt.Columns.Add("Birim");
            dt.Columns.Add("Stokta Var");
            dt.Columns.Add("Eksik Miktar");
            dt.Columns.Add("Birim Fiyat");
            dt.Columns.Add("Toplam Maliyet");

            decimal genelToplam = 0;

            var toplamlar = new Dictionary<string, (decimal miktar, string birim)>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                foreach (var tarifID in tarifIDler)
                {
                    // Porsiyon bilgilerini al
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

                                    // Birim dönüşümü uygula
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
            foreach (var item in toplamlar)
            {
                string[] parca = item.Key.Split('|');
                string urunAdi = parca[0];
                string anaBirim = item.Value.birim;
                decimal ihtiyac = item.Value.miktar;

                decimal stoktaVar = GetStokMiktari(urunAdi, anaBirim);
                decimal eksik = Math.Max(0, ihtiyac - stoktaVar);

                string stoktaVarStr = stoktaVar > 0 ? $"{stoktaVar:0.##} {anaBirim}" : "-";
                string eksikStr = eksik > 0 ? $"{eksik:0.##} {anaBirim}" : "";

                // Alış fiyatını çek
                decimal birimFiyat = GetAlisFiyati(urunAdi, anaBirim);
                decimal toplamMaliyet = ihtiyac * birimFiyat;
                genelToplam += toplamMaliyet;

                string birimFiyatStr = birimFiyat > 0 ? $"{birimFiyat:0.##} TL/{anaBirim}" : "-";
                string toplamMaliyetStr = toplamMaliyet > 0 ? $"{toplamMaliyet:0.##} TL" : "-";

                dt.Rows.Add(
                    urunAdi,
                    $"{ihtiyac:0.##} {anaBirim}",
                    anaBirim,
                    stoktaVarStr,
                    eksikStr,
                    birimFiyatStr,
                    toplamMaliyetStr
                );
            }

            MessageBox.Show(
                $"Toplam Maliyet: {genelToplam:0.##} TL\nKişi Başı Maliyet: {(kisiSayisi > 0 ? genelToplam / kisiSayisi : 0):0.##} TL",
                "Maliyet Analizi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            return dt;
        }

        // ComboBoxItem yardımcı sınıfı
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private decimal GetStokMiktari(string urunAdi, string birim)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Miktar, Birim FROM Urunler WHERE UrunAdi = @UrunAdi";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            decimal stokMiktar = Convert.ToDecimal(dr["Miktar"]);
                            string stokBirim = dr["Birim"].ToString();
                            var (donusmusStok, anaBirim) = BirimDonusum.Donustur(stokMiktar, stokBirim);
                            return donusmusStok;
                        }
                    }
                }
            }
            return 0;
        }

        private void dgvSonuc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSonuc.Rows)
            {
                if (decimal.TryParse(row.Cells["Eksik Miktar"].Value?.ToString().Split(' ')[0], out decimal eksik) && eksik > 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }

        private void btnStoktanDus_Click(object sender, EventArgs e)
        {
            if (dgvSonuc.DataSource == null || dgvSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Önce malzeme ihtiyacı hesaplaması yapmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eksikSayisi = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvSonuc.Rows)
                {
                    if (row.IsNewRow) continue;
                    string urunAdi = row.Cells["Malzeme Adı"].Value.ToString();
                    string birim = row.Cells["Birim"].Value.ToString();
                    string toplamMiktarStr = row.Cells["Toplam Miktar"].Value.ToString().Split(' ')[0];
                    decimal ihtiyacMiktar = decimal.Parse(toplamMiktarStr);

                    string eksikStr = row.Cells["Eksik Miktar"].Value?.ToString();
                    bool eksikVar = !string.IsNullOrWhiteSpace(eksikStr);

                    if (eksikVar)
                    {
                        eksikSayisi++;
                        continue; // Eksik varsa stoktan düşme!
                    }

                    // Stoktan düş
                    string sql = "UPDATE Urunler SET Miktar = Miktar - @Dusulecek WHERE UrunAdi = @UrunAdi";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Dusulecek", ihtiyacMiktar);
                        cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        cmd.ExecuteNonQuery();
                    }
                    // StokTakibi formu açıksa güncelle
                    if (Program.stokTakibiFormu != null && !Program.stokTakibiFormu.IsDisposed)
                    {
                        Program.stokTakibiFormu.StoklariYenile();
                    }
                }
            }

            if (eksikSayisi > 0)
                MessageBox.Show("Yeterli stoğu olmayan malzemeler stoktan düşülmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Tüm malzemeler stoktan başarıyla düşüldü.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoglarFormu.LogEkle(Oturum.KullaniciAdi, "Malzemeler stoktan düşüldü.");
            }
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

                            var (fiyatBirimCarpan, anaBirim1) = BirimDonusum.Donustur(1, fiyatBirimi);
                            var (ihtiyacBirimCarpan, anaBirim2) = BirimDonusum.Donustur(1, ihtiyacBirimi);

                            if (anaBirim1 == anaBirim2 && fiyatBirimCarpan > 0 && ihtiyacBirimCarpan > 0)
                            {
                                return fiyat / (fiyatBirimCarpan / ihtiyacBirimCarpan);
                            }
                        }
                    }
                }
            }
            return 0;
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dgvSonuc.DataSource == null || dgvSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Dosyası (*.csv)|*.csv";
                sfd.FileName = "MalzemeIhtiyaci.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Sütun başlıkları
                            for (int i = 0; i < dgvSonuc.Columns.Count; i++)
                            {
                                sw.Write(dgvSonuc.Columns[i].HeaderText);
                                if (i < dgvSonuc.Columns.Count - 1)
                                    sw.Write(";" );
                            }
                            sw.WriteLine();

                            // Satırlar
                            foreach (DataGridViewRow row in dgvSonuc.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int i = 0; i < dgvSonuc.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dgvSonuc.Columns.Count - 1)
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
    }

    public static class BirimDonusum
    {
        private static readonly Dictionary<string, (string anaBirim, decimal carpim)> tablo = new Dictionary<string, (string, decimal)>
        {
            { "kg", ("gram", 1000m) },
            { "gram", ("gram", 1m) },
            { "mg", ("gram", 0.001m) },
            { "litre", ("ml", 1000m) },
            { "ml", ("ml", 1m) },
            { "adet", ("adet", 1m) },
            { "yemek kaşığı", ("ml", 15m) },
            { "tatlı kaşığı", ("ml", 5m) },
            { "çay kaşığı", ("ml", 2.5m) },
            { "su bardağı", ("ml", 200m) }
        };

        public static (decimal miktar, string anaBirim) Donustur(decimal miktar, string birim)
        {
            if (tablo.TryGetValue(birim, out var info))
            {
                return (miktar * info.carpim, info.anaBirim);
            }
            // Bilinmeyen birim varsa olduğu gibi döndür
            return (miktar, birim);
        }
    }
}
