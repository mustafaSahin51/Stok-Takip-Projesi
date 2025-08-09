
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
using System.Data.SQLite; // SqlClient yerine
using Microsoft.Win32;  // sistem koyu mod kontrolü için 

namespace Stok_takip
{
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        public KayitFormu(bool koyuMod = false)
        {
            InitializeComponent();
            if (koyuMod)
                chkTema.Checked = true;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;
            string guvSor1 = txtGuvSor1.Text.Trim();
            string guvSor2 = txtGuvSor2.Text.Trim();
            string guvSor3 = txtGuvSor3.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(guvSor1) || string.IsNullOrWhiteSpace(guvSor2) || string.IsNullOrWhiteSpace(guvSor3))
            {
                MessageBox.Show("Tüm güvenlik sorularını cevaplamalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sifre.Length > 20)
            {
                MessageBox.Show("Şifre en fazla 20 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Kullanıcı adı var mı kontrolü
                    string kontrolQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE Kullanici_Ad = @Kullanici_Ad";
                    using (var cmd = new SQLiteCommand(kontrolQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Kullanici_Ad", kullaniciAdi);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Kayıt ekle
                    string insertQuery = @"INSERT INTO Kullanicilar 
                        (Kullanici_Ad, Kullanici_Sifre, Guv_Sor1, Guv_Sor2, Guv_Sor3) 
                        VALUES (@Kullanici_Ad, @Kullanici_Sifre, @Guv_Sor1, @Guv_Sor2, @Guv_Sor3)";
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Kullanici_Ad", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Kullanici_Sifre", sifre);
                        cmd.Parameters.AddWithValue("@Guv_Sor1", guvSor1);
                        cmd.Parameters.AddWithValue("@Guv_Sor2", guvSor2);
                        cmd.Parameters.AddWithValue("@Guv_Sor3", guvSor3);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitFormu_Load(object sender, EventArgs e)
        {
            if (SistemKoyuModdaMi())
                chkTema.Checked = true;
            else
                chkTema.Checked = false;

            lblCopyright.Location = new Point(10, this.ClientSize.Height - lblCopyright.Height - 10);
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
                    if (c is TextBox)
                        c.BackColor = Color.FromArgb(30, 30, 30);
                    else if (c is Button)
                    {
                        c.BackColor = Color.FromArgb(63, 63, 70);
                        c.ForeColor = Color.White;
                        ((Button)c).FlatStyle = FlatStyle.Flat;
                        ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                    }
                    ApplyTheme(c);
                }
                lblUyari.ForeColor = Color.OrangeRed;
                lblCopyright.ForeColor = Color.LightGray;
            }
            else
            {
                // Açık tema
                this.BackColor = Color.FromArgb(230, 242, 255);
                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.FromArgb(30, 30, 30);
                    if (c is TextBox)
                        c.BackColor = Color.White;
                    else if (c is Button)
                    {
                        c.BackColor = Color.FromArgb(102, 178, 255);
                        c.ForeColor = Color.White;
                        ((Button)c).FlatStyle = FlatStyle.Flat;
                        ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(102, 178, 255);
                    }
                    ApplyTheme(c);
                }
                lblUyari.ForeColor = Color.Red;
                lblCopyright.ForeColor = Color.Gray;
            }
        }

        private void ApplyTheme(Control c)
        {
            lblGuvenlikBaslik.ForeColor = c.ForeColor;
            lblSoru1.ForeColor = c.ForeColor;
            lblSoru2.ForeColor = c.ForeColor;
            lblSoru3.ForeColor = c.ForeColor;
            txtGuvSor1.BackColor = c.BackColor;
            txtGuvSor2.BackColor = c.BackColor;
            txtGuvSor3.BackColor = c.BackColor;
            txtGuvSor1.ForeColor = c.ForeColor;
            txtGuvSor2.ForeColor = c.ForeColor;
            txtGuvSor3.ForeColor = c.ForeColor;
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool goster = chkSifreyiGoster.Checked;
            txtSifre.UseSystemPasswordChar = !goster;
            txtSifreTekrar.UseSystemPasswordChar = !goster;
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
                lblUyari.Text = "Şifreler uyuşmuyor!";
            else
                lblUyari.Text = "";
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            int guc = SifreGucuHesapla(txtSifre.Text);
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

        private int SifreGucuHesapla(string sifre)
        {
            int guc = 0;
            int ozelKarakterSayisi = System.Text.RegularExpressions.Regex.Matches(sifre, @"[^a-zA-Z0-9]").Count;

            if (sifre.Length >= 8) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[A-Z]")) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[a-z]")) guc++;
            if (System.Text.RegularExpressions.Regex.IsMatch(sifre, "[0-9]")) guc++;
            if (ozelKarakterSayisi > 0) guc++;

            // Eğer 4 veya daha fazla özel karakter varsa, doğrudan maksimum güç
            if (ozelKarakterSayisi >= 4)
                guc = 5;

            return guc;
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            lblCopyright.Location = new Point(10, this.ClientSize.Height - lblCopyright.Height - 10);
        }

        private void KayitFormu_Load_1(object sender, EventArgs e)
        {       

        }
    }
}
