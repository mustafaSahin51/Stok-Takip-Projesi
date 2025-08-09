
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Stok_takip
{
    public partial class Form1 : Form
    {
        private int girisDeneme = 0;
        private int blokSaniye = 30;
        private bool sifreGosteriliyor = false;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            lblCopyright.Location = new Point(10, this.ClientSize.Height - lblCopyright.Height - 10);

            object tema = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\StokTakipApp").GetValue("KoyuTema");
            chkTema.Checked = (tema != null && tema.ToString() == "1");
            this.AcceptButton = btnGiris;
        }

        private void Sifreyi_Goster_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = Sifreyi_Goster_Chkbx.Checked ? '\0' : '*';
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSifre.Focus();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtKullaniciAdi.SelectionStart == 0 && e.KeyChar == ' ')
                e.Handled = true;
            if (e.KeyChar == ' ' && txtKullaniciAdi.Text.EndsWith(" "))
                e.Handled = true;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            int pos = txtKullaniciAdi.SelectionStart;
            txtKullaniciAdi.Text = txtKullaniciAdi.Text.ToLower();
            txtKullaniciAdi.SelectionStart = pos;
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris.PerformClick();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSifre.SelectionStart == 0 && e.KeyChar == ' ')
                e.Handled = true;
            if (e.KeyChar == ' ' && txtSifre.Text.EndsWith(" "))
                e.Handled = true;
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            lblCapsLockUyari.Text = Control.IsKeyLocked(Keys.CapsLock) ? "UYARI: Caps Lock açık!" : "";
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            lblCapsLockUyari.Text = "";
        }

        private void txtSifre_KeyUp(object sender, KeyEventArgs e)
        {
            lblCapsLockUyari.Text = Control.IsKeyLocked(Keys.CapsLock) ? "UYARI: Caps Lock açık!" : "";
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Rol FROM Kullanicilar WHERE Kullanici_Ad = @Kullanici_Ad AND Kullanici_Sifre = @Kullanici_Sifre";
                    using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Kullanici_Ad", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Kullanici_Sifre", sifre);
                        var rol = cmd.ExecuteScalar();
                        if (rol != null)
                        {
                            Oturum.KullaniciAdi = kullaniciAdi;
                            Oturum.Rol = rol.ToString();

                            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            StokTakibi stokTakibiForm = new StokTakibi();
                            stokTakibiForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            girisDeneme++;
                            int kalan = 3 - girisDeneme;
                            if (kalan > 0)
                                lblDenemeHakki.Text = $"Hatalı giriş! Kalan deneme hakkı: {kalan}";
                            if (girisDeneme >= 3)
                            {
                                btnGiris.Enabled = false;
                                lblDenemeHakki.Text = $"Çok fazla deneme! {blokSaniye} sn sonra tekrar deneyin.";
                                timerGirisBlok.Start();
                            }
                            txtSifre.Text = "";
                            txtSifre.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void chkTema_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTema.Checked)
            {
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
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\StokTakipApp").SetValue("KoyuTema", 1);
            }
            else
            {
                this.BackColor = Color.FromArgb(230, 242, 255);
                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.FromArgb(30, 30, 30);
                    if (c is TextBox || c is ComboBox)
                        c.BackColor = Color.White;
                    else if (c is Button)
                    {
                        c.BackColor = Color.FromArgb(102, 178, 255);
                        c.ForeColor = Color.White;
                        ((Button)c).FlatStyle = FlatStyle.Flat;
                        ((Button)c).FlatAppearance.BorderColor = Color.FromArgb(102, 178, 255);
                    }
                }
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\StokTakipApp").SetValue("KoyuTema", 0);
            }
        }

        private void btnSifremiUnuttum_Click_1(object sender, EventArgs e)
        {
            SifreSifirlama sifreSifirlamaForm = new SifreSifirlama();
            DialogResult result = sifreSifirlamaForm.ShowDialog();
        }

        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            KayitFormu kayitFormu = new KayitFormu(chkTema.Checked);
            kayitFormu.ShowDialog();
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
                            return kullaniciTema == 0;
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        private void timerGirisBlok_Tick(object sender, EventArgs e)
        {
            blokSaniye--;
            lblDenemeHakki.Text = $"Çok fazla deneme! {blokSaniye} sn sonra tekrar deneyin.";
            if (blokSaniye <= 0)
            {
                timerGirisBlok.Stop();
                btnGiris.Enabled = true;
                lblDenemeHakki.Text = "";
                blokSaniye = 30;
                girisDeneme = 0;
            }
        }

        private void picSifreGoz_Click(object sender, EventArgs e)
        {
            sifreGosteriliyor = !sifreGosteriliyor;
            txtSifre.PasswordChar = sifreGosteriliyor ? '\0' : '*';
        }
    }
}