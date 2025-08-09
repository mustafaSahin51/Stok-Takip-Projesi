namespace Stok_takip
{
    partial class SifreSifirlama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSoru1 = new System.Windows.Forms.Label();
            this.txtGuvSor1 = new System.Windows.Forms.TextBox();
            this.lblSoru2 = new System.Windows.Forms.Label();
            this.txtGuvSor2 = new System.Windows.Forms.TextBox();
            this.lblSoru3 = new System.Windows.Forms.Label();
            this.txtGuvSor3 = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.pnlYeniSifre = new System.Windows.Forms.Panel();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreyiSifirla = new System.Windows.Forms.Button();
            this.prgSifreGucu = new System.Windows.Forms.ProgressBar();
            this.lblSifreGucu = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.chkTema = new System.Windows.Forms.CheckBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlYeniSifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBaslik.Location = new System.Drawing.Point(110, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(293, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Şifre Sıfırlama Ekranı";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(60, 70);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(122, 22);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(247, 60);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(220, 32);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // lblSoru1
            // 
            this.lblSoru1.AutoSize = true;
            this.lblSoru1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoru1.Location = new System.Drawing.Point(60, 110);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(244, 19);
            this.lblSoru1.TabIndex = 3;
            this.lblSoru1.Text = "İlkokul öğretmeninizin adı nedir?";
            // 
            // txtGuvSor1
            // 
            this.txtGuvSor1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuvSor1.Location = new System.Drawing.Point(354, 107);
            this.txtGuvSor1.Name = "txtGuvSor1";
            this.txtGuvSor1.Size = new System.Drawing.Size(180, 30);
            this.txtGuvSor1.TabIndex = 4;
            // 
            // lblSoru2
            // 
            this.lblSoru2.AutoSize = true;
            this.lblSoru2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoru2.Location = new System.Drawing.Point(60, 150);
            this.lblSoru2.Name = "lblSoru2";
            this.lblSoru2.Size = new System.Drawing.Size(209, 19);
            this.lblSoru2.TabIndex = 5;
            this.lblSoru2.Text = "En sevdiğiniz yemek nedir?";
            // 
            // txtGuvSor2
            // 
            this.txtGuvSor2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuvSor2.Location = new System.Drawing.Point(354, 147);
            this.txtGuvSor2.Name = "txtGuvSor2";
            this.txtGuvSor2.Size = new System.Drawing.Size(180, 30);
            this.txtGuvSor2.TabIndex = 6;
            // 
            // lblSoru3
            // 
            this.lblSoru3.AutoSize = true;
            this.lblSoru3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoru3.Location = new System.Drawing.Point(60, 190);
            this.lblSoru3.Name = "lblSoru3";
            this.lblSoru3.Size = new System.Drawing.Size(193, 19);
            this.lblSoru3.TabIndex = 7;
            this.lblSoru3.Text = "Doğduğunuz şehir nedir?";
            // 
            // txtGuvSor3
            // 
            this.txtGuvSor3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGuvSor3.Location = new System.Drawing.Point(354, 187);
            this.txtGuvSor3.Name = "txtGuvSor3";
            this.txtGuvSor3.Size = new System.Drawing.Size(180, 30);
            this.txtGuvSor3.TabIndex = 8;
            // 
            // btnDogrula
            // 
            this.btnDogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnDogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogrula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDogrula.ForeColor = System.Drawing.Color.White;
            this.btnDogrula.Location = new System.Drawing.Point(200, 230);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(120, 32);
            this.btnDogrula.TabIndex = 9;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // pnlYeniSifre
            // 
            this.pnlYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYeniSifre.Controls.Add(this.lblYeniSifre);
            this.pnlYeniSifre.Controls.Add(this.txtYeniSifre);
            this.pnlYeniSifre.Controls.Add(this.lblYeniSifreTekrar);
            this.pnlYeniSifre.Controls.Add(this.txtYeniSifreTekrar);
            this.pnlYeniSifre.Controls.Add(this.btnSifreyiSifirla);
            this.pnlYeniSifre.Controls.Add(this.prgSifreGucu);
            this.pnlYeniSifre.Controls.Add(this.lblSifreGucu);
            this.pnlYeniSifre.Location = new System.Drawing.Point(27, 297);
            this.pnlYeniSifre.Name = "pnlYeniSifre";
            this.pnlYeniSifre.Size = new System.Drawing.Size(553, 163);
            this.pnlYeniSifre.TabIndex = 20;
            this.pnlYeniSifre.Visible = false;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYeniSifre.Location = new System.Drawing.Point(32, 20);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(85, 19);
            this.lblYeniSifre.TabIndex = 0;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtYeniSifre.Location = new System.Drawing.Point(156, 9);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(250, 30);
            this.txtYeniSifre.TabIndex = 1;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(17, 86);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(135, 19);
            this.lblYeniSifreTekrar.TabIndex = 2;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(158, 75);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(250, 30);
            this.txtYeniSifreTekrar.TabIndex = 3;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            this.txtYeniSifreTekrar.TextChanged += new System.EventHandler(this.txtYeniSifreTekrar_TextChanged);
            // 
            // btnSifreyiSifirla
            // 
            this.btnSifreyiSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnSifreyiSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreyiSifirla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSifreyiSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifreyiSifirla.Location = new System.Drawing.Point(156, 117);
            this.btnSifreyiSifirla.Name = "btnSifreyiSifirla";
            this.btnSifreyiSifirla.Size = new System.Drawing.Size(120, 28);
            this.btnSifreyiSifirla.TabIndex = 4;
            this.btnSifreyiSifirla.Text = "Şifreyi Sıfırla";
            this.btnSifreyiSifirla.UseVisualStyleBackColor = false;
            this.btnSifreyiSifirla.Click += new System.EventHandler(this.btnSifreyiSifirla_Click);
            // 
            // prgSifreGucu
            // 
            this.prgSifreGucu.Location = new System.Drawing.Point(158, 53);
            this.prgSifreGucu.Maximum = 5;
            this.prgSifreGucu.Name = "prgSifreGucu";
            this.prgSifreGucu.Size = new System.Drawing.Size(250, 10);
            this.prgSifreGucu.TabIndex = 5;
            // 
            // lblSifreGucu
            // 
            this.lblSifreGucu.Location = new System.Drawing.Point(390, 15);
            this.lblSifreGucu.Name = "lblSifreGucu";
            this.lblSifreGucu.Size = new System.Drawing.Size(100, 20);
            this.lblSifreGucu.TabIndex = 6;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(60, 415);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 18);
            this.lblUyari.TabIndex = 15;
            // 
            // chkTema
            // 
            this.chkTema.AutoSize = true;
            this.chkTema.Location = new System.Drawing.Point(573, 20);
            this.chkTema.Name = "chkTema";
            this.chkTema.Size = new System.Drawing.Size(98, 20);
            this.chkTema.TabIndex = 16;
            this.chkTema.Text = "Koyu Tema";
            this.chkTema.UseVisualStyleBackColor = true;
            this.chkTema.CheckedChanged += new System.EventHandler(this.chkTema_CheckedChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(12, 540);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(317, 16);
            this.lblCopyright.TabIndex = 17;
            this.lblCopyright.Text = "© 2025 Yemekhane Otomasyonu Mustafa ŞAHİN";
            // 
            // SifreSifirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(701, 574);
            this.Controls.Add(this.pnlYeniSifre);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.chkTema);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.txtGuvSor3);
            this.Controls.Add(this.lblSoru3);
            this.Controls.Add(this.txtGuvSor2);
            this.Controls.Add(this.lblSoru2);
            this.Controls.Add(this.txtGuvSor1);
            this.Controls.Add(this.lblSoru1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnDogrula);
            this.Name = "SifreSifirlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırlama";
            this.Load += new System.EventHandler(this.SifreSifirlama_Load_1);
            this.pnlYeniSifre.ResumeLayout(false);
            this.pnlYeniSifre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSoru1;
        private System.Windows.Forms.TextBox txtGuvSor1;
        private System.Windows.Forms.Label lblSoru2;
        private System.Windows.Forms.TextBox txtGuvSor2;
        private System.Windows.Forms.Label lblSoru3;
        private System.Windows.Forms.TextBox txtGuvSor3;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Panel pnlYeniSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Button btnSifreyiSifirla;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.CheckBox chkTema;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ProgressBar prgSifreGucu;
        private System.Windows.Forms.Label lblSifreGucu;
    }
}