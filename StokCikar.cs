
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class StokCikar : Form
    {
        private int urunID;
        private decimal mevcutMiktar = 0;

        public StokCikar(int urunID)
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
                    string query = "SELECT UrunAdi, Miktar FROM Urunler WHERE UrunID = @UrunID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                lblUrunAdi.Text = "Ürün: " + dr["UrunAdi"].ToString();
                                mevcutMiktar = Convert.ToDecimal(dr["Miktar"]);
                            }
                        }
                    }
                }
                catch
                {
                    lblUrunAdi.Text = "Ürün: ";
                }
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            decimal miktar = nudMiktar.Value;
            string aciklama = txtAciklama.Text.Trim();

            if (miktar <= 0)
            {
                MessageBox.Show("Miktar 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (miktar > mevcutMiktar)
            {
                MessageBox.Show("Stokta yeterli miktar yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Urunler SET Miktar = Miktar - @Miktar WHERE UrunID = @UrunID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Miktar", miktar);
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.ExecuteNonQuery();
                    }

                    // Log ekle
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Stoktan çıkarıldı: ÜrünID={urunID}, Miktar={miktar}, Açıklama={aciklama}"
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok çıkarılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
