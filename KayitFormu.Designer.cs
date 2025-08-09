namespace Stok_takip
{
    partial class KayitFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.                                                                                               
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.chkSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.chkTema = new System.Windows.Forms.CheckBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.prgSifreGucu = new System.Windows.Forms.ProgressBar();
            this.lblSifreGucu = new System.Windows.Forms.Label();
            this.lblGuvenlikBaslik = new System.Windows.Forms.Label();
            this.lblSoru1 = new System.Windows.Forms.Label();
            this.txtGuvSor1 = new System.Windows.Forms.TextBox();
            this.lblSoru2 = new System.Windows.Forms.Label();
            this.txtGuvSor2 = new System.Windows.Forms.TextBox();
            this.lblSoru3 = new System.Windows.Forms.Label();
            this.txtGuvSor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBaslik.Location = new System.Drawing.Point(120, 30);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(297, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kullanıcı Kayıt Ekranı";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(60, 90);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(122, 22);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSifre.Location = new System.Drawing.Point(60, 140);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(55, 22);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSifreTekrar.Location = new System.Drawing.Point(60, 190);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(112, 22);
            this.lblSifreTekrar.TabIndex = 3;
            this.lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(180, 87);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(220, 32);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSifre.Location = new System.Drawing.Point(180, 137);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(220, 32);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSifreTekrar.Location = new System.Drawing.Point(178, 190);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(220, 32);
            this.txtSifreTekrar.TabIndex = 6;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            // 
            // chkSifreyiGoster
            // 
            this.chkSifreyiGoster.AutoSize = true;
            this.chkSifreyiGoster.Location = new System.Drawing.Point(424, 146);
            this.chkSifreyiGoster.Name = "chkSifreyiGoster";
            this.chkSifreyiGoster.Size = new System.Drawing.Size(109, 20);
            this.chkSifreyiGoster.TabIndex = 7;
            this.chkSifreyiGoster.Text = "Şifreyi Göster";
            this.chkSifreyiGoster.UseVisualStyleBackColor = true;
            this.chkSifreyiGoster.CheckedChanged += new System.EventHandler(this.chkSifreyiGoster_CheckedChanged);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(558, 127);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(100, 35);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(664, 127);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 35);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // chkTema
            // 
            this.chkTema.AutoSize = true;
            this.chkTema.Location = new System.Drawing.Point(511, 12);
            this.chkTema.Name = "chkTema";
            this.chkTema.Size = new System.Drawing.Size(98, 20);
            this.chkTema.TabIndex = 10;
            this.chkTema.Text = "Koyu Tema";
            this.chkTema.UseVisualStyleBackColor = true;
            this.chkTema.CheckedChanged += new System.EventHandler(this.chkTema_CheckedChanged);
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(438, 196);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 18);
            this.lblUyari.TabIndex = 11;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(12, 752);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(317, 16);
            this.lblCopyright.TabIndex = 12;
            this.lblCopyright.Text = "© 2025 Yemekhane Otomasyonu Mustafa ŞAHİN";
            // 
            // prgSifreGucu
            // 
            this.prgSifreGucu.Location = new System.Drawing.Point(558, 87);
            this.prgSifreGucu.Maximum = 5;
            this.prgSifreGucu.Name = "prgSifreGucu";
            this.prgSifreGucu.Size = new System.Drawing.Size(220, 22);
            this.prgSifreGucu.TabIndex = 13;
            // 
            // lblSifreGucu
            // 
            this.lblSifreGucu.Location = new System.Drawing.Point(793, 87);
            this.lblSifreGucu.Name = "lblSifreGucu";
            this.lblSifreGucu.Size = new System.Drawing.Size(100, 20);
            this.lblSifreGucu.TabIndex = 14;
            // 
            // lblGuvenlikBaslik
            // 
            this.lblGuvenlikBaslik.AutoSize = true;
            this.lblGuvenlikBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuvenlikBaslik.Location = new System.Drawing.Point(60, 311);
            this.lblGuvenlikBaslik.Name = "lblGuvenlikBaslik";
            this.lblGuvenlikBaslik.Size = new System.Drawing.Size(173, 24);
            this.lblGuvenlikBaslik.TabIndex = 15;
            this.lblGuvenlikBaslik.Text = "Güvenlik Soruları";
            // 
            // lblSoru1
            // 
            this.lblSoru1.AutoSize = true;
            this.lblSoru1.Location = new System.Drawing.Point(60, 351);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(196, 16);
            this.lblSoru1.TabIndex = 16;
            this.lblSoru1.Text = "İlkokul öğretmeninizin adı nedir?";
            // 
            // txtGuvSor1
            // 
            this.txtGuvSor1.Location = new System.Drawing.Point(272, 351);
            this.txtGuvSor1.Name = "txtGuvSor1";
            this.txtGuvSor1.Size = new System.Drawing.Size(180, 22);
            this.txtGuvSor1.TabIndex = 17;
            // 
            // lblSoru2
            // 
            this.lblSoru2.AutoSize = true;
            this.lblSoru2.Location = new System.Drawing.Point(60, 391);
            this.lblSoru2.Name = "lblSoru2";
            this.lblSoru2.Size = new System.Drawing.Size(170, 16);
            this.lblSoru2.TabIndex = 18;
            this.lblSoru2.Text = "En sevdiğiniz yemek nedir?";
            // 
            // txtGuvSor2
            // 
            this.txtGuvSor2.Location = new System.Drawing.Point(272, 391);
            this.txtGuvSor2.Name = "txtGuvSor2";
            this.txtGuvSor2.Size = new System.Drawing.Size(180, 22);
            this.txtGuvSor2.TabIndex = 19;
            // 
            // lblSoru3
            // 
            this.lblSoru3.AutoSize = true;
            this.lblSoru3.Location = new System.Drawing.Point(60, 431);
            this.lblSoru3.Name = "lblSoru3";
            this.lblSoru3.Size = new System.Drawing.Size(155, 16);
            this.lblSoru3.TabIndex = 20;
            this.lblSoru3.Text = "Doğduğunuz şehir nedir?";
            // 
            // txtGuvSor3
            // 
            this.txtGuvSor3.Location = new System.Drawing.Point(272, 428);
            this.txtGuvSor3.Name = "txtGuvSor3";
            this.txtGuvSor3.Size = new System.Drawing.Size(180, 22);
            this.txtGuvSor3.TabIndex = 21;
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(828, 777);
            this.Controls.Add(this.lblGuvenlikBaslik);
            this.Controls.Add(this.lblSoru1);
            this.Controls.Add(this.txtGuvSor1);
            this.Controls.Add(this.lblSoru2);
            this.Controls.Add(this.txtGuvSor2);
            this.Controls.Add(this.lblSoru3);
            this.Controls.Add(this.txtGuvSor3);
            this.Controls.Add(this.prgSifreGucu);
            this.Controls.Add(this.lblSifreGucu);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.chkTema);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.chkSifreyiGoster);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "KayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.KayitFormu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.CheckBox chkSifreyiGoster;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.CheckBox chkTema;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ProgressBar prgSifreGucu;
        private System.Windows.Forms.Label lblSifreGucu;
        private System.Windows.Forms.Label lblGuvenlikBaslik;
        private System.Windows.Forms.Label lblSoru1;
        private System.Windows.Forms.TextBox txtGuvSor1;
        private System.Windows.Forms.Label lblSoru2;
        private System.Windows.Forms.TextBox txtGuvSor2;
        private System.Windows.Forms.Label lblSoru3;
        private System.Windows.Forms.TextBox txtGuvSor3;


    }
}