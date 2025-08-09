namespace Stok_takip
{
    partial class TarifEkleForm
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
            this.lblTarifAdi = new System.Windows.Forms.Label();
            this.txtTarifAdi = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblHazirlanis = new System.Windows.Forms.Label();
            this.txtHazirlanis = new System.Windows.Forms.TextBox();
            this.lblPorsiyon = new System.Windows.Forms.Label();
            this.nudPorsiyon = new System.Windows.Forms.NumericUpDown();
            this.lblSure = new System.Windows.Forms.Label();
            this.nudSure = new System.Windows.Forms.NumericUpDown();
            this.lblMalzemeAdi = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblBirim = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.dgvMalzemeler = new System.Windows.Forms.DataGridView();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarifAdi
            // 
            this.lblTarifAdi.AutoSize = true;
            this.lblTarifAdi.Location = new System.Drawing.Point(30, 20);
            this.lblTarifAdi.Name = "lblTarifAdi";
            this.lblTarifAdi.Size = new System.Drawing.Size(60, 16);
            this.lblTarifAdi.TabIndex = 0;
            this.lblTarifAdi.Text = "Tarif Adı:";
            // 
            // txtTarifAdi
            // 
            this.txtTarifAdi.Location = new System.Drawing.Point(120, 17);
            this.txtTarifAdi.Name = "txtTarifAdi";
            this.txtTarifAdi.Size = new System.Drawing.Size(250, 22);
            this.txtTarifAdi.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(30, 55);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(66, 16);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 52);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 40);
            this.txtAciklama.TabIndex = 3;
            // 
            // lblHazirlanis
            // 
            this.lblHazirlanis.AutoSize = true;
            this.lblHazirlanis.Location = new System.Drawing.Point(30, 100);
            this.lblHazirlanis.Name = "lblHazirlanis";
            this.lblHazirlanis.Size = new System.Drawing.Size(69, 16);
            this.lblHazirlanis.TabIndex = 4;
            this.lblHazirlanis.Text = "Hazırlanış:";
            // 
            // txtHazirlanis
            // 
            this.txtHazirlanis.Location = new System.Drawing.Point(120, 97);
            this.txtHazirlanis.Multiline = true;
            this.txtHazirlanis.Name = "txtHazirlanis";
            this.txtHazirlanis.Size = new System.Drawing.Size(250, 60);
            this.txtHazirlanis.TabIndex = 5;
            // 
            // lblPorsiyon
            // 
            this.lblPorsiyon.AutoSize = true;
            this.lblPorsiyon.Location = new System.Drawing.Point(30, 170);
            this.lblPorsiyon.Name = "lblPorsiyon";
            this.lblPorsiyon.Size = new System.Drawing.Size(63, 16);
            this.lblPorsiyon.TabIndex = 6;
            this.lblPorsiyon.Text = "Porsiyon:";
            // 
            // nudPorsiyon
            // 
            this.nudPorsiyon.Location = new System.Drawing.Point(120, 168);
            this.nudPorsiyon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPorsiyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsiyon.Name = "nudPorsiyon";
            this.nudPorsiyon.Size = new System.Drawing.Size(80, 22);
            this.nudPorsiyon.TabIndex = 7;
            this.nudPorsiyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(220, 170);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(102, 16);
            this.lblSure.TabIndex = 8;
            this.lblSure.Text = "Hazırlama Süre:";
            // 
            // nudSure
            // 
            this.nudSure.Location = new System.Drawing.Point(325, 168);
            this.nudSure.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSure.Name = "nudSure";
            this.nudSure.Size = new System.Drawing.Size(80, 22);
            this.nudSure.TabIndex = 9;
            this.nudSure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMalzemeAdi
            // 
            this.lblMalzemeAdi.AutoSize = true;
            this.lblMalzemeAdi.Location = new System.Drawing.Point(30, 210);
            this.lblMalzemeAdi.Name = "lblMalzemeAdi";
            this.lblMalzemeAdi.Size = new System.Drawing.Size(88, 16);
            this.lblMalzemeAdi.TabIndex = 10;
            this.lblMalzemeAdi.Text = "Malzeme Adı:";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(130, 207);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(120, 22);
            this.txtMalzemeAdi.TabIndex = 11;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(260, 210);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(46, 16);
            this.lblMiktar.TabIndex = 12;
            this.lblMiktar.Text = "Miktar:";
            // 
            // nudMiktar
            // 
            this.nudMiktar.DecimalPlaces = 2;
            this.nudMiktar.Location = new System.Drawing.Point(315, 207);
            this.nudMiktar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(70, 22);
            this.nudMiktar.TabIndex = 13;
            this.nudMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(400, 210);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(40, 16);
            this.lblBirim.TabIndex = 14;
            this.lblBirim.Text = "Birim:";
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "gram",
            "ml",
            "adet",
            "yemek kaşığı",
            "tatlı kaşığı",
            "çay kaşığı",
            "su bardağı"});
            this.cmbBirim.Location = new System.Drawing.Point(450, 207);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(100, 24);
            this.cmbBirim.TabIndex = 15;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(570, 205);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(120, 28);
            this.btnMalzemeEkle.TabIndex = 16;
            this.btnMalzemeEkle.Text = "Malzeme Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // dgvMalzemeler
            // 
            this.dgvMalzemeler.AllowUserToAddRows = false;
            this.dgvMalzemeler.AllowUserToDeleteRows = false;
            this.dgvMalzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMalzemeler.Location = new System.Drawing.Point(30, 250);
            this.dgvMalzemeler.MultiSelect = false;
            this.dgvMalzemeler.Name = "dgvMalzemeler";
            this.dgvMalzemeler.ReadOnly = true;
            this.dgvMalzemeler.RowHeadersWidth = 51;
            this.dgvMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMalzemeler.Size = new System.Drawing.Size(660, 180);
            this.dgvMalzemeler.TabIndex = 17;
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Location = new System.Drawing.Point(30, 440);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(120, 32);
            this.btnMalzemeSil.TabIndex = 18;
            this.btnMalzemeSil.Text = "Malzeme Sil";
            this.btnMalzemeSil.UseVisualStyleBackColor = true;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(480, 440);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 32);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(590, 440);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 32);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TarifEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 506);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnMalzemeSil);
            this.Controls.Add(this.dgvMalzemeler);
            this.Controls.Add(this.btnMalzemeEkle);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.lblMalzemeAdi);
            this.Controls.Add(this.nudSure);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.nudPorsiyon);
            this.Controls.Add(this.lblPorsiyon);
            this.Controls.Add(this.txtHazirlanis);
            this.Controls.Add(this.lblHazirlanis);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtTarifAdi);
            this.Controls.Add(this.lblTarifAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TarifEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tarif Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarifAdi;
        private System.Windows.Forms.TextBox txtTarifAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblHazirlanis;
        private System.Windows.Forms.TextBox txtHazirlanis;
        private System.Windows.Forms.Label lblPorsiyon;
        private System.Windows.Forms.NumericUpDown nudPorsiyon;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.NumericUpDown nudSure;
        private System.Windows.Forms.Label lblMalzemeAdi;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.DataGridView dgvMalzemeler;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}