
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
using Microsoft.Win32; // sistem modu görme için 
using System.Data.SQLite; // <-- Eklendi

namespace Stok_takip
{
    public partial class SifreSifirlama : Form
    {
        public SifreSifirlama()
        {
            InitializeComponent();
        }

        public SifreSifirlama(bool @checked)
        {
        }

        private void SifreSifirlama_Load(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string cevap1 = txtGuvSor1.Text.Trim();
            string cevap2 = txtGuvSor2.Text.Trim();
            string cevap3 = txtGuvSor3.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(cevap1) || string.IsNullOrEmpty(cevap2) || string.IsNullOrEmpty(cevap3))
            {
                MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM Kullanicilar 
                                     WHERE Kullanici_Ad = @Kullanici_Ad 
                                     AND Guv_Sor1 = @Guv_Sor1 
                                     AND Guv_Sor2 = @Guv_Sor2 
                                     AND Guv_Sor3 = @Guv_Sor3";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Kullanici_Ad", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Guv_Sor1", cevap1);
                        cmd.Parameters.AddWithValue("@Guv_Sor2", cevap2);
                        cmd.Parameters.AddWithValue("@Guv_Sor3", cevap3);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            lblYeniSifre.Visible = true;
                            txtYeniSifre.Visible = true;
                            lblYeniSifreTekrar.Visible = true;
                            txtYeniSifreTekrar.Visible = true;
                            btnSifreyiSifirla.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSifreyiSifirla_Click(object sender, EventArgs e)
        {
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreTekrar = txtYeniSifreTekrar.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();

            if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(yeniSifreTekrar))
            {
                MessageBox.Show("Yeni şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sifreGucu = SifreGucuHesapla(yeniSifre);
            if (sifreGucu < 3)
            {
                MessageBox.Show("Şifre çok zayıf! Lütfen daha güçlü bir şifre seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Kullanicilar SET Kullanici_Sifre = @YeniSifre WHERE Kullanici_Ad = @Kullanici_Ad";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                        cmd.Parameters.AddWithValue("@Kullanici_Ad", kullaniciAdi);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Şifre başarıyla sıfırlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int SifreGucuHesapla(string sifre)
        {
            int guc = 0;
            int ozelKarakterSayisi = System.Text.RegularExpressions.Regex.Matches(sifre, @"[^a-zA-Z0-9]").Count;

            if (sifre.Length >= 8) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[A-Z]")) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[a-z]")) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[0-9]")) guc++;
            if (ozelKarakterSayisi > 0) guc++;

            if (ozelKarakterSayisi >= 4)
                guc = 5;

            return guc;
        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {
            int guc = SifreGucuHesapla(txtYeniSifre.Text);
            prgSifreGucu.Value = guc;
            switch (guc)
            {
                case 0:
                case 1:
                    lblSifreGucu.Text = "Çok Zayıf";
                    lblSifreGucu.ForeColor = Color.Red;
                    break;
                case 2:
                    lblSifreGucu.Text = "Zayıf";
                    lblSifreGucu.ForeColor = Color.OrangeRed;
                    break;
                case 3:
                    lblSifreGucu.Text = "Orta";
                    lblSifreGucu.ForeColor = Color.Orange;
                    break;
                case 4:
                    lblSifreGucu.Text = "Güçlü";
                    lblSifreGucu.ForeColor = Color.Green;
                    break;
                case 5:
                    lblSifreGucu.Text = "Çok Güçlü";
                    lblSifreGucu.ForeColor = Color.DarkGreen;
                    break;
            }
        }

        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                lblUyari.Text = "Şifreler uyuşmuyor!";
            else
                lblUyari.Text = "";
        }

        private void chkTema_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTema.Checked)
            {
                // Koyu tema
                this.BackColor = Color.FromArgb(45, 45, 48);
                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.White;
                    if (c is TextBox || c is ComboBox)
                        c.BackColor = Color.FromArgb(30, 30, 30);
                    else if (c is Button)
                    {
                        c.BackColor = Color.FromArgb(63, 63, 70);
                        c.ForeColor = Color.White;
                        ((Button)c).FlatStyle = FlatStyle.Flat;
                        ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                    }
                }
            }
            else
            {
                // Açık tema
                this.BackColor = Color.FromArgb(230, 242, 255); // Açık mavi
                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.FromArgb(30, 30, 30);
                    if (c is TextBox || c is ComboBox)
                        c.BackColor = Color.White;
                    else if (c is Button)
                    {
                        c.BackColor = Color.FromArgb(102, 178, 255); // Açık mavi buton
                        c.ForeColor = Color.White;
                        ((Button)c).FlatStyle = FlatStyle.Flat;
                        ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(102, 178, 255);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            lblCopyright.Location = new Point(10, this.ClientSize.Height - lblCopyright.Height - 10);
        }

        private bool SistemKoyuModdaMi()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("AppsUseLightTheme");
                        if (value != null)
                        {
                            int kullaniciTema = (int)value;
                            return kullaniciTema == 0; // 0: Koyu, 1: Açık
                        }
                    }
                }
            }
            catch { }
            return false; // Varsayılan açık mod
        }
        private void SifreSifirlama_Load_1(object sender, EventArgs e)
        {
            lblCopyright.Location = new Point(10, this.ClientSize.Height - lblCopyright.Height - 10);

            // Sistem koyu modda ise otomatik olarak koyu temayı başlat
            if (SistemKoyuModdaMi())
                chkTema.Checked = true;
            else
                chkTema.Checked = false;
        }
    }
}
