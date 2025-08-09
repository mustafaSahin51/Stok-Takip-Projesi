namespace Stok_takip
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        /// içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Kullanici_adi = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.Sifreyi_Goster_Chkbx = new System.Windows.Forms.CheckBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.chkTema = new System.Windows.Forms.CheckBox();
            this.lblDenemeHakki = new System.Windows.Forms.Label();
            this.timerGirisBlok = new System.Windows.Forms.Timer(this.components);
            this.picSifreGoz = new System.Windows.Forms.PictureBox();
            this.lblCapsLockUyari = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSifreGoz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(347, 148);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(372, 32);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSifre.Location = new System.Drawing.Point(347, 209);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(372, 32);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            this.txtSifre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyUp);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // Kullanici_adi
            // 
            this.Kullanici_adi.AutoSize = true;
            this.Kullanici_adi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Kullanici_adi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Kullanici_adi.Location = new System.Drawing.Point(213, 154);
            this.Kullanici_adi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kullanici_adi.Name = "Kullanici_adi";
            this.Kullanici_adi.Size = new System.Drawing.Size(106, 19);
            this.Kullanici_adi.TabIndex = 2;
            this.Kullanici_adi.Text = "Kullanıcı Adı:";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Sifre.Location = new System.Drawing.Point(213, 215);
            this.Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(49, 19);
            this.Sifre.TabIndex = 3;
            this.Sifre.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(347, 271);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(373, 43);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // Sifreyi_Goster_Chkbx
            // 
            this.Sifreyi_Goster_Chkbx.AutoSize = true;
            this.Sifreyi_Goster_Chkbx.Location = new System.Drawing.Point(733, 215);
            this.Sifreyi_Goster_Chkbx.Margin = new System.Windows.Forms.Padding(4);
            this.Sifreyi_Goster_Chkbx.Name = "Sifreyi_Goster_Chkbx";
            this.Sifreyi_Goster_Chkbx.Size = new System.Drawing.Size(109, 20);
            this.Sifreyi_Goster_Chkbx.TabIndex = 5;
            this.Sifreyi_Goster_Chkbx.Text = "Şifreyi Göster";
            this.Sifreyi_Goster_Chkbx.UseVisualStyleBackColor = true;
            this.Sifreyi_Goster_Chkbx.CheckedChanged += new System.EventHandler(this.Sifreyi_Goster_Chkbx_CheckedChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBaslik.Location = new System.Drawing.Point(278, 62);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(476, 35);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Yemekhane Stok Takip Programı";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnSifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSifremiUnuttum.ForeColor = System.Drawing.Color.White;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(540, 332);
            this.btnSifremiUnuttum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(180, 37);
            this.btnSifremiUnuttum.TabIndex = 8;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click_1);
            // 
            // chkTema
            // 
            this.chkTema.AutoSize = true;
            this.chkTema.Location = new System.Drawing.Point(885, 24);
            this.chkTema.Margin = new System.Windows.Forms.Padding(4);
            this.chkTema.Name = "chkTema";
            this.chkTema.Size = new System.Drawing.Size(98, 20);
            this.chkTema.TabIndex = 9;
            this.chkTema.Text = "Koyu Tema";
            this.chkTema.UseVisualStyleBackColor = true;
            this.chkTema.CheckedChanged += new System.EventHandler(this.chkTema_CheckedChanged_1);
            // 
            // lblDenemeHakki
            // 
            this.lblDenemeHakki.AutoSize = true;
            this.lblDenemeHakki.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDenemeHakki.ForeColor = System.Drawing.Color.Red;
            this.lblDenemeHakki.Location = new System.Drawing.Point(347, 250);
            this.lblDenemeHakki.Name = "lblDenemeHakki";
            this.lblDenemeHakki.Size = new System.Drawing.Size(0, 18);
            this.lblDenemeHakki.TabIndex = 11;
            // 
            // timerGirisBlok
            // 
            this.timerGirisBlok.Interval = 1000;
            this.timerGirisBlok.Tick += new System.EventHandler(this.timerGirisBlok_Tick);
            // 
            // picSifreGoz
            // 
            this.picSifreGoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSifreGoz.Image = global::Stok_takip.Properties.Resources.eye;
            this.picSifreGoz.Location = new System.Drawing.Point(726, 209);
            this.picSifreGoz.Name = "picSifreGoz";
            this.picSifreGoz.Size = new System.Drawing.Size(28, 28);
            this.picSifreGoz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSifreGoz.TabIndex = 12;
            this.picSifreGoz.TabStop = false;
            this.picSifreGoz.Click += new System.EventHandler(this.picSifreGoz_Click);
            // 
            // lblCapsLockUyari
            // 
            this.lblCapsLockUyari.AutoSize = true;
            this.lblCapsLockUyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCapsLockUyari.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCapsLockUyari.Location = new System.Drawing.Point(347, 245);
            this.lblCapsLockUyari.Name = "lblCapsLockUyari";
            this.lblCapsLockUyari.Size = new System.Drawing.Size(0, 18);
            this.lblCapsLockUyari.TabIndex = 13;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(347, 332);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(180, 37);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click_1);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(13, 517);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(317, 16);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "© 2025 Yemekhane Otomasyonu Mustafa ŞAHİN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 590);
            this.Controls.Add(this.lblCapsLockUyari);
            this.Controls.Add(this.picSifreGoz);
            this.Controls.Add(this.lblDenemeHakki);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.chkTema);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.Sifreyi_Goster_Chkbx);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.Kullanici_adi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemekhane Stok Takip - Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSifreGoz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label Kullanici_adi;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox Sifreyi_Goster_Chkbx;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.CheckBox chkTema;
        private System.Windows.Forms.Label lblDenemeHakki;
        private System.Windows.Forms.Timer timerGirisBlok;
        private System.Windows.Forms.PictureBox picSifreGoz;
        private System.Windows.Forms.Label lblCapsLockUyari;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblCopyright;
    }
}