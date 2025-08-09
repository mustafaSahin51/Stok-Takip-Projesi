namespace Stok_takip
{
    partial class UrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblKritik = new System.Windows.Forms.Label();
            this.nudKritik = new System.Windows.Forms.NumericUpDown();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.lblAlis = new System.Windows.Forms.Label();
            this.nudAlis = new System.Windows.Forms.NumericUpDown();
            this.lblSatis = new System.Windows.Forms.Label();
            this.nudSatis = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKritik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(30, 20);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(61, 17);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 17);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 22);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(30, 55);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 17);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(120, 52);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(200, 22);
            this.txtKategori.TabIndex = 3;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(30, 90);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(54, 17);
            this.lblBarkod.TabIndex = 4;
            this.lblBarkod.Text = "Barkod:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(120, 87);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(200, 22);
            this.txtBarkod.TabIndex = 5;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(30, 125);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(43, 17);
            this.lblBirim.TabIndex = 6;
            this.lblBirim.Text = "Birim:";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(120, 122);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(200, 22);
            this.txtBirim.TabIndex = 7;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(30, 160);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 8;
            this.lblMiktar.Text = "Miktar:";
            // 
            // nudMiktar
            // 
            this.nudMiktar.DecimalPlaces = 2;
            this.nudMiktar.Location = new System.Drawing.Point(120, 158);
            this.nudMiktar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(200, 22);
            this.nudMiktar.TabIndex = 9;
            // 
            // lblKritik
            // 
            this.lblKritik.AutoSize = true;
            this.lblKritik.Location = new System.Drawing.Point(30, 195);
            this.lblKritik.Name = "lblKritik";
            this.lblKritik.Size = new System.Drawing.Size(80, 17);
            this.lblKritik.TabIndex = 10;
            this.lblKritik.Text = "Kritik Seviye:";
            // 
            // nudKritik
            // 
            this.nudKritik.DecimalPlaces = 2;
            this.nudKritik.Location = new System.Drawing.Point(120, 193);
            this.nudKritik.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudKritik.Name = "nudKritik";
            this.nudKritik.Size = new System.Drawing.Size(200, 22);
            this.nudKritik.TabIndex = 11;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(30, 230);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(70, 17);
            this.lblTedarikci.TabIndex = 12;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(120, 227);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(200, 22);
            this.txtTedarikci.TabIndex = 13;
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(30, 265);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(65, 17);
            this.lblAlis.TabIndex = 14;
            this.lblAlis.Text = "Alış Fiyatı:";
            // 
            // nudAlis
            // 
            this.nudAlis.DecimalPlaces = 2;
            this.nudAlis.Location = new System.Drawing.Point(120, 263);
            this.nudAlis.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudAlis.Name = "nudAlis";
            this.nudAlis.Size = new System.Drawing.Size(200, 22);
            this.nudAlis.TabIndex = 15;
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(30, 300);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(73, 17);
            this.lblSatis.TabIndex = 16;
            this.lblSatis.Text = "Satış Fiyatı:";
            // 
            // nudSatis
            // 
            this.nudSatis.DecimalPlaces = 2;
            this.nudSatis.Location = new System.Drawing.Point(120, 298);
            this.nudSatis.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudSatis.Name = "nudSatis";
            this.nudSatis.Size = new System.Drawing.Size(200, 22);
            this.nudSatis.TabIndex = 17;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(30, 335);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(65, 17);
            this.lblAciklama.TabIndex = 18;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 332);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 22);
            this.txtAciklama.TabIndex = 19;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(102, 178, 255);
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(120, 370);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 35);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Gray;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(230, 370);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 35);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 430);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nudSatis);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.nudAlis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.txtTedarikci);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.nudKritik);
            this.Controls.Add(this.lblKritik);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKritik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblKritik;
        private System.Windows.Forms.NumericUpDown nudKritik;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.NumericUpDown nudAlis;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.NumericUpDown nudSatis;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
    }
}