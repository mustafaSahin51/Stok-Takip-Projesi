namespace Stok_takip
{
    partial class StokTakibi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStokCikar = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnTarifler = new System.Windows.Forms.Button();
            this.btnMalzemeIhtiyaciHesapla = new System.Windows.Forms.Button();
            this.btnLoglariGoruntule = new System.Windows.Forms.Button();
            this.btnMenuler = new System.Windows.Forms.Button();
            this.btnStoklariYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(30, 80);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(473, 619);
            this.dgvUrunler.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location = new System.Drawing.Point(128, 27);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 30);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArama.Location = new System.Drawing.Point(30, 33);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(79, 19);
            this.lblArama.TabIndex = 2;
            this.lblArama.Text = "Ürün Ara:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.Location = new System.Drawing.Point(473, 30);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 27);
            this.cmbKategori.TabIndex = 3;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKategori.Location = new System.Drawing.Point(377, 33);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(75, 19);
            this.lblKategori.TabIndex = 4;
            this.lblKategori.Text = "Kategori:";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(523, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 40);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(523, 130);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(523, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStokEkle.ForeColor = System.Drawing.Color.White;
            this.btnStokEkle.Location = new System.Drawing.Point(523, 250);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(120, 40);
            this.btnStokEkle.TabIndex = 8;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnStokCikar
            // 
            this.btnStokCikar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokCikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnStokCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokCikar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStokCikar.ForeColor = System.Drawing.Color.White;
            this.btnStokCikar.Location = new System.Drawing.Point(523, 300);
            this.btnStokCikar.Name = "btnStokCikar";
            this.btnStokCikar.Size = new System.Drawing.Size(120, 40);
            this.btnStokCikar.TabIndex = 9;
            this.btnStokCikar.Text = "Stok Çıkar";
            this.btnStokCikar.UseVisualStyleBackColor = false;
            this.btnStokCikar.Click += new System.EventHandler(this.btnStokCikar_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(30, 719);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(317, 16);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "© 2025 Yemekhane Otomasyonu Mustafa ŞAHİN";
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // btnTarifler
            // 
            this.btnTarifler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTarifler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnTarifler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTarifler.ForeColor = System.Drawing.Color.White;
            this.btnTarifler.Location = new System.Drawing.Point(523, 356);
            this.btnTarifler.Name = "btnTarifler";
            this.btnTarifler.Size = new System.Drawing.Size(120, 40);
            this.btnTarifler.TabIndex = 11;
            this.btnTarifler.Text = "Tarifler";
            this.btnTarifler.UseVisualStyleBackColor = false;
            this.btnTarifler.Click += new System.EventHandler(this.btnTarifler_Click);
            // 
            // btnMalzemeIhtiyaciHesapla
            // 
            this.btnMalzemeIhtiyaciHesapla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMalzemeIhtiyaciHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnMalzemeIhtiyaciHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeIhtiyaciHesapla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMalzemeIhtiyaciHesapla.ForeColor = System.Drawing.Color.White;
            this.btnMalzemeIhtiyaciHesapla.Location = new System.Drawing.Point(523, 475);
            this.btnMalzemeIhtiyaciHesapla.Name = "btnMalzemeIhtiyaciHesapla";
            this.btnMalzemeIhtiyaciHesapla.Size = new System.Drawing.Size(120, 112);
            this.btnMalzemeIhtiyaciHesapla.TabIndex = 12;
            this.btnMalzemeIhtiyaciHesapla.Text = "Malzeme İhtiyacı Hesapla";
            this.btnMalzemeIhtiyaciHesapla.UseVisualStyleBackColor = false;
            this.btnMalzemeIhtiyaciHesapla.Click += new System.EventHandler(this.btnMalzemeIhtiyaciHesapla_Click);
            // 
            // btnLoglariGoruntule
            // 
            this.btnLoglariGoruntule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoglariGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoglariGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoglariGoruntule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoglariGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnLoglariGoruntule.Location = new System.Drawing.Point(523, 406);
            this.btnLoglariGoruntule.Name = "btnLoglariGoruntule";
            this.btnLoglariGoruntule.Size = new System.Drawing.Size(120, 53);
            this.btnLoglariGoruntule.TabIndex = 13;
            this.btnLoglariGoruntule.Text = "Logları Görüntüle";
            this.btnLoglariGoruntule.UseVisualStyleBackColor = false;
            this.btnLoglariGoruntule.Click += new System.EventHandler(this.btnLoglariGoruntule_Click);
            // 
            // btnMenuler
            // 
            this.btnMenuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnMenuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuler.ForeColor = System.Drawing.Color.White;
            this.btnMenuler.Location = new System.Drawing.Point(523, 593);
            this.btnMenuler.Name = "btnMenuler";
            this.btnMenuler.Size = new System.Drawing.Size(120, 40);
            this.btnMenuler.TabIndex = 14;
            this.btnMenuler.Text = "Menüler";
            this.btnMenuler.UseVisualStyleBackColor = false;
            this.btnMenuler.Click += new System.EventHandler(this.btnMenuler_Click);
            // 
            // btnStoklariYenile
            // 
            this.btnStoklariYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoklariYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStoklariYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoklariYenile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStoklariYenile.ForeColor = System.Drawing.Color.White;
            this.btnStoklariYenile.Location = new System.Drawing.Point(523, 639);
            this.btnStoklariYenile.Name = "btnStoklariYenile";
            this.btnStoklariYenile.Size = new System.Drawing.Size(120, 60);
            this.btnStoklariYenile.TabIndex = 15;
            this.btnStoklariYenile.Text = "Tabloyu Güncelle";
            this.btnStoklariYenile.UseVisualStyleBackColor = false;
            this.btnStoklariYenile.Click += new System.EventHandler(this.btnStoklariYenile_Click);
            // 
            // StokTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(673, 749);
            this.Controls.Add(this.btnMenuler);
            this.Controls.Add(this.btnLoglariGoruntule);
            this.Controls.Add(this.btnMalzemeIhtiyaciHesapla);
            this.Controls.Add(this.btnTarifler);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnStokCikar);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnStoklariYenile);
            this.Name = "StokTakibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.StokTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnStokCikar;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnTarifler;
        private System.Windows.Forms.Button btnMalzemeIhtiyaciHesapla;
        private System.Windows.Forms.Button btnLoglariGoruntule;
        private System.Windows.Forms.Button btnMenuler;
        private System.Windows.Forms.Button btnStoklariYenile;
    }
}