
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // <-- Eklendi

namespace Stok_takip
{
    public partial class StokTakibi : Form
    {
        public StokTakibi()
        {
            InitializeComponent();
            this.Resize += new EventHandler(this.StokTakibi_Resize);
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        }

        private void StokTakibi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            KategorileriDoldur();
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UrunID, UrunAdi, Kategori, Barkod, Birim, Miktar, KritikSeviye, Tedarikci, AlisFiyati, SatisFiyati, Aciklama, EklenmeTarihi FROM Urunler";
                    using (var da = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUrunler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UrunleriFiltrele()
        {
            string arama = txtArama.Text.Trim();
            string kategori = cmbKategori.SelectedItem != null ? cmbKategori.SelectedItem.ToString() : "";

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UrunID, UrunAdi, Kategori, Barkod, Birim, Miktar, KritikSeviye, Tedarikci, AlisFiyati, SatisFiyati, Aciklama, EklenmeTarihi FROM Urunler WHERE 1=1";
                    if (!string.IsNullOrEmpty(arama))
                        query += " AND UrunAdi LIKE @UrunAdi";
                    if (!string.IsNullOrEmpty(kategori) && kategori != "Tümü")
                        query += " AND Kategori = @Kategori";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(arama))
                            cmd.Parameters.AddWithValue("@UrunAdi", "%" + arama + "%");
                        if (!string.IsNullOrEmpty(kategori) && kategori != "Tümü")
                            cmd.Parameters.AddWithValue("@Kategori", kategori);

                        using (var da = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvUrunler.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Filtreleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KategorileriDoldur()
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Tümü");
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Kategori FROM Urunler WHERE Kategori IS NOT NULL AND Kategori <> ''";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbKategori.Items.Add(dr[0].ToString());
                        }
                    }
                }
                catch { }
            }
            cmbKategori.SelectedIndex = 0;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            UrunleriFiltrele();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriFiltrele();
        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void StokTakibi_Resize(object sender, EventArgs e)
        {
            lblCopyright.Location = new Point(30, this.ClientSize.Height - lblCopyright.Height - 10);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Seçili ürünü silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
                using (var conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Urunler WHERE UrunID = @UrunID";
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UrunID", urunID);
                            cmd.ExecuteNonQuery();
                        }
                        UrunleriListele();
                        LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Ürün silindi: UrunID={urunID}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle ekleForm = new UrunEkle();
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                UrunleriListele();
                KategorileriDoldur();
                LoglarFormu.LogEkle(Oturum.KullaniciAdi, "Yeni ürün eklendi.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
            UrunGuncelle guncelleForm = new UrunGuncelle(urunID);
            if (guncelleForm.ShowDialog() == DialogResult.OK)
            {
                UrunleriListele();
                KategorileriDoldur();
                LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Ürün güncellendi: UrunID={urunID}");
            }
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen stok eklenecek bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
            StokEkle stokEkleForm = new StokEkle(urunID);
            if (stokEkleForm.ShowDialog() == DialogResult.OK)
            {
                UrunleriListele();
            }
        }

        private void btnStokCikar_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen stok çıkarılacak bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
            StokCikar stokCikarForm = new StokCikar(urunID);
            if (stokCikarForm.ShowDialog() == DialogResult.OK)
            {
                UrunleriListele();
            }
        }

        private void btnTarifler_Click(object sender, EventArgs e)
        {
            Tarifler tariflerForm = new Tarifler();
            tariflerForm.ShowDialog();
        }

        private void btnMalzemeIhtiyaciHesapla_Click(object sender, EventArgs e)
        {
            MalzemeIhtiyaciForm frm = new MalzemeIhtiyaciForm();
            frm.ShowDialog();
        }

        private void btnLoglariGoruntule_Click(object sender, EventArgs e)
        {
            LoglarFormu logForm = new LoglarFormu();
            logForm.ShowDialog();
        }

        private void btnMenuler_Click(object sender, EventArgs e)
        {
            MenulerFormu menulerFormu = new MenulerFormu();
            menulerFormu.ShowDialog();
        }

        public void StoklariYenile()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Urunler";
                using (var da = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUrunler.DataSource = dt;
                }
            }
        }

        private void btnStoklariYenile_Click(object sender, EventArgs e)
        {
            UrunleriListele();
            KategorileriDoldur();
            MessageBox.Show("Stoklar güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
