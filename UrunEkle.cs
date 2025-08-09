
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Girdi kontrolleri
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBirim.Text))
            {
                MessageBox.Show("Birim boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Urunler
                        (UrunAdi, Kategori, Barkod, Birim, Miktar, KritikSeviye, Tedarikci, AlisFiyati, SatisFiyati, Aciklama)
                        VALUES
                        (@UrunAdi, @Kategori, @Barkod, @Birim, @Miktar, @KritikSeviye, @Tedarikci, @AlisFiyati, @SatisFiyati, @Aciklama)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Kategori", txtKategori.Text.Trim());
                        cmd.Parameters.AddWithValue("@Barkod", txtBarkod.Text.Trim());
                        cmd.Parameters.AddWithValue("@Birim", txtBirim.Text.Trim());
                        cmd.Parameters.AddWithValue("@Miktar", nudMiktar.Value);
                        cmd.Parameters.AddWithValue("@KritikSeviye", nudKritik.Value);
                        cmd.Parameters.AddWithValue("@Tedarikci", txtTedarikci.Text.Trim());
                        cmd.Parameters.AddWithValue("@AlisFiyati", nudAlis.Value);
                        cmd.Parameters.AddWithValue("@SatisFiyati", nudSatis.Value);
                        cmd.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    // Log ekle
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Ürün eklendi: {txtUrunAdi.Text.Trim()}"
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
