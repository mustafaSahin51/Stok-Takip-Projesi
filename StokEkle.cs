
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class StokEkle : Form
    {
        private int urunID;

        public StokEkle(int urunID)
        {
            InitializeComponent();
            this.urunID = urunID;
            UrunBilgisiGetir();
        }

        private void UrunBilgisiGetir()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UrunAdi FROM Urunler WHERE UrunID = @UrunID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        var urunAdi = cmd.ExecuteScalar();
                        lblUrunAdi.Text = "Ürün: " + (urunAdi != null ? urunAdi.ToString() : "");
                    }
                }
                catch
                {
                    lblUrunAdi.Text = "Ürün: ";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal miktar = nudMiktar.Value;
            string aciklama = txtAciklama.Text.Trim();

            if (miktar <= 0)
            {
                MessageBox.Show("Miktar 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Urunler SET Miktar = Miktar + @Miktar WHERE UrunID = @UrunID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Miktar", miktar);
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.ExecuteNonQuery();
                    }

                    // Log ekle
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Stok eklendi: ÜrünID={urunID}, Miktar={miktar}, Açıklama={aciklama}"
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
