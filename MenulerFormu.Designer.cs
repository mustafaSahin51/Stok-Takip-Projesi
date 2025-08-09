namespace Stok_takip
{
    partial class MenulerFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.CheckedListBox clbTarifler;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.Button btnMenuyeEkle;
        private System.Windows.Forms.DataGridView dgvMenuler;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTarifler;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnTopluIhtiyacHesapla;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSil;
        private System.Windows.Forms.ToolStripMenuItem menuGuncelle;
        private System.Windows.Forms.Button btnMenuKopyala;
        private System.Windows.Forms.Button btnMenuOner;
        private System.Windows.Forms.Button btnMenuSil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.clbTarifler = new System.Windows.Forms.CheckedListBox();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnMenuyeEkle = new System.Windows.Forms.Button();
            this.dgvMenuler = new System.Windows.Forms.DataGridView();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTarifler = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnTopluIhtiyacHesapla = new System.Windows.Forms.Button();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuKopyala = new System.Windows.Forms.Button();
            this.btnMenuOner = new System.Windows.Forms.Button();
            this.btnMenuSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(30, 40);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 1;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // clbTarifler
            // 
            this.clbTarifler.CheckOnClick = true;
            this.clbTarifler.FormattingEnabled = true;
            this.clbTarifler.Location = new System.Drawing.Point(30, 95);
            this.clbTarifler.Name = "clbTarifler";
            this.clbTarifler.Size = new System.Drawing.Size(300, 106);
            this.clbTarifler.TabIndex = 3;
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Location = new System.Drawing.Point(30, 235);
            this.nudKisiSayisi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(120, 22);
            this.nudKisiSayisi.TabIndex = 5;
            this.nudKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMenuyeEkle
            // 
            this.btnMenuyeEkle.Location = new System.Drawing.Point(30, 270);
            this.btnMenuyeEkle.Name = "btnMenuyeEkle";
            this.btnMenuyeEkle.Size = new System.Drawing.Size(120, 35);
            this.btnMenuyeEkle.TabIndex = 6;
            this.btnMenuyeEkle.Text = "Menüye Ekle";
            this.btnMenuyeEkle.UseVisualStyleBackColor = true;
            this.btnMenuyeEkle.Click += new System.EventHandler(this.btnMenuyeEkle_Click);
            // 
            // dgvMenuler
            // 
            this.dgvMenuler.AllowUserToAddRows = false;
            this.dgvMenuler.AllowUserToDeleteRows = false;
            this.dgvMenuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuler.Location = new System.Drawing.Point(350, 40);
            this.dgvMenuler.Name = "dgvMenuler";
            this.dgvMenuler.ReadOnly = true;
            this.dgvMenuler.RowHeadersWidth = 51;
            this.dgvMenuler.Size = new System.Drawing.Size(420, 350);
            this.dgvMenuler.TabIndex = 7;
            this.dgvMenuler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMenuler_MouseDown);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(30, 20);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 16);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblTarifler
            // 
            this.lblTarifler.AutoSize = true;
            this.lblTarifler.Location = new System.Drawing.Point(30, 75);
            this.lblTarifler.Name = "lblTarifler";
            this.lblTarifler.Size = new System.Drawing.Size(52, 16);
            this.lblTarifler.TabIndex = 2;
            this.lblTarifler.Text = "Tarifler:";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(30, 215);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(71, 16);
            this.lblKisiSayisi.TabIndex = 4;
            this.lblKisiSayisi.Text = "Kişi Sayısı:";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(350, 10);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(140, 22);
            this.dtpBaslangic.TabIndex = 8;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(500, 10);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(140, 22);
            this.dtpBitis.TabIndex = 9;
            // 
            // btnTopluIhtiyacHesapla
            // 
            this.btnTopluIhtiyacHesapla.Location = new System.Drawing.Point(650, 8);
            this.btnTopluIhtiyacHesapla.Name = "btnTopluIhtiyacHesapla";
            this.btnTopluIhtiyacHesapla.Size = new System.Drawing.Size(120, 28);
            this.btnTopluIhtiyacHesapla.TabIndex = 10;
            this.btnTopluIhtiyacHesapla.Text = "Toplu Malzeme İhtiyacı";
            this.btnTopluIhtiyacHesapla.UseVisualStyleBackColor = true;
            this.btnTopluIhtiyacHesapla.Click += new System.EventHandler(this.btnTopluIhtiyacHesapla_Click);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Location = new System.Drawing.Point(650, 408);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(120, 30);
            this.btnExcelAktar.TabIndex = 11;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSil,
            this.menuGuncelle});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // menuSil
            // 
            this.menuSil.Name = "menuSil";
            this.menuSil.Size = new System.Drawing.Size(133, 22);
            this.menuSil.Text = "Sil";
            this.menuSil.Click += new System.EventHandler(this.menuSil_Click);
            // 
            // menuGuncelle
            // 
            this.menuGuncelle.Name = "menuGuncelle";
            this.menuGuncelle.Size = new System.Drawing.Size(133, 22);
            this.menuGuncelle.Text = "Güncelle";
            this.menuGuncelle.Click += new System.EventHandler(this.menuGuncelle_Click);
            // 
            // btnMenuKopyala
            // 
            this.btnMenuKopyala.Location = new System.Drawing.Point(500, 408);
            this.btnMenuKopyala.Name = "btnMenuKopyala";
            this.btnMenuKopyala.Size = new System.Drawing.Size(120, 30);
            this.btnMenuKopyala.TabIndex = 12;
            this.btnMenuKopyala.Text = "Menüyü Kopyala";
            this.btnMenuKopyala.UseVisualStyleBackColor = true;
            this.btnMenuKopyala.Click += new System.EventHandler(this.btnMenuKopyala_Click);
            // 
            // btnMenuOner
            // 
            this.btnMenuOner.Location = new System.Drawing.Point(350, 408);
            this.btnMenuOner.Name = "btnMenuOner";
            this.btnMenuOner.Size = new System.Drawing.Size(120, 30);
            this.btnMenuOner.TabIndex = 13;
            this.btnMenuOner.Text = "Menü Öner";
            this.btnMenuOner.UseVisualStyleBackColor = true;
            this.btnMenuOner.Click += new System.EventHandler(this.btnMenuOner_Click);
            // 
            // btnMenuSil
            // 
            this.btnMenuSil.Location = new System.Drawing.Point(30, 341);
            this.btnMenuSil.Name = "btnMenuSil";
            this.btnMenuSil.Size = new System.Drawing.Size(120, 30);
            this.btnMenuSil.TabIndex = 10;
            this.btnMenuSil.Text = "Menü Sil";
            this.btnMenuSil.UseVisualStyleBackColor = true;
            this.btnMenuSil.Click += new System.EventHandler(this.btnMenuSil_Click);
            // 
            // MenulerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuOner);
            this.Controls.Add(this.btnMenuKopyala);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnTopluIhtiyacHesapla);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dgvMenuler);
            this.Controls.Add(this.btnMenuyeEkle);
            this.Controls.Add(this.nudKisiSayisi);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.clbTarifler);
            this.Controls.Add(this.lblTarifler);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnMenuSil);
            this.Name = "MenulerFormu";
            this.Text = "Menü Planlama";
            this.Load += new System.EventHandler(this.MenulerFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}