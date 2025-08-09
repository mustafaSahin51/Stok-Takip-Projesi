//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.


using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class UrunGuncelle : Form
    {
        private int urunID;

        public UrunGuncelle(int urunID)
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
                    string query = "SELECT UrunAdi, Kategori, Barkod, Birim, Miktar, KritikSeviye, Tedarikci, AlisFiyati, SatisFiyati, Aciklama FROM Urunler WHERE UrunID = @UrunID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtUrunAdi.Text = dr["UrunAdi"].ToString();
                                txtKategori.Text = dr["Kategori"].ToString();
                                txtBarkod.Text = dr["Barkod"].ToString();
                                txtBirim.Text = dr["Birim"].ToString();
                                nudMiktar.Value = dr["Miktar"] != DBNull.Value ? Convert.ToDecimal(dr["Miktar"]) : 0;
                                nudKritik.Value = dr["KritikSeviye"] != DBNull.Value ? Convert.ToDecimal(dr["KritikSeviye"]) : 0;
                                txtTedarikci.Text = dr["Tedarikci"].ToString();
                                nudAlis.Value = dr["AlisFiyati"] != DBNull.Value ? Convert.ToDecimal(dr["AlisFiyati"]) : 0;
                                nudSatis.Value = dr["SatisFiyati"] != DBNull.Value ? Convert.ToDecimal(dr["SatisFiyati"]) : 0;
                                txtAciklama.Text = dr["Aciklama"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün bilgisi alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
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
                    string query = @"UPDATE Urunler SET
                        UrunAdi = @UrunAdi,
                        Kategori = @Kategori,
                        Barkod = @Barkod,
                        Birim = @Birim,
                        Miktar = @Miktar,
                        KritikSeviye = @KritikSeviye,
                        Tedarikci = @Tedarikci,
                        AlisFiyati = @AlisFiyati,
                        SatisFiyati = @SatisFiyati,
                        Aciklama = @Aciklama
                        WHERE UrunID = @UrunID";
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
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.ExecuteNonQuery();
                    }

                    // Log ekle
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Ürün güncellendi: UrunID={urunID}, Ürün Adı={txtUrunAdi.Text.Trim()}"
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
