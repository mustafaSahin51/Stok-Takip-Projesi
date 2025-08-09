namespace Stok_takip
{
    partial class MalzemeIhtiyaciForm
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
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblTarifler = new System.Windows.Forms.Label();
            this.clbTarifler = new System.Windows.Forms.CheckedListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.btnStoktanDus = new System.Windows.Forms.Button();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(30, 25);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(71, 16);
            this.lblKisiSayisi.TabIndex = 0;
            this.lblKisiSayisi.Text = "Kişi Sayısı:";
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Location = new System.Drawing.Point(110, 23);
            this.nudKisiSayisi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(80, 22);
            this.nudKisiSayisi.TabIndex = 1;
            this.nudKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTarifler
            // 
            this.lblTarifler.AutoSize = true;
            this.lblTarifler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarifler.Location = new System.Drawing.Point(220, 20);
            this.lblTarifler.Name = "lblTarifler";
            this.lblTarifler.Size = new System.Drawing.Size(63, 19);
            this.lblTarifler.TabIndex = 2;
            this.lblTarifler.Text = "Tarifler";
            // 
            // clbTarifler
            // 
            this.clbTarifler.CheckOnClick = true;
            this.clbTarifler.FormattingEnabled = true;
            this.clbTarifler.Location = new System.Drawing.Point(220, 50);
            this.clbTarifler.Name = "clbTarifler";
            this.clbTarifler.Size = new System.Drawing.Size(300, 123);
            this.clbTarifler.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(540, 50);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 40);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dgvSonuc
            // 
            this.dgvSonuc.AllowUserToAddRows = false;
            this.dgvSonuc.AllowUserToDeleteRows = false;
            this.dgvSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuc.Location = new System.Drawing.Point(30, 200);
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.ReadOnly = true;
            this.dgvSonuc.RowHeadersWidth = 51;
            this.dgvSonuc.Size = new System.Drawing.Size(700, 250);
            this.dgvSonuc.TabIndex = 5;
            this.dgvSonuc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSonuc_DataBindingComplete);
            // 
            // btnStoktanDus
            // 
            this.btnStoktanDus.Location = new System.Drawing.Point(540, 100);
            this.btnStoktanDus.Name = "btnStoktanDus";
            this.btnStoktanDus.Size = new System.Drawing.Size(120, 40);
            this.btnStoktanDus.TabIndex = 6;
            this.btnStoktanDus.Text = "Stoktan Düş";
            this.btnStoktanDus.UseVisualStyleBackColor = true;
            this.btnStoktanDus.Click += new System.EventHandler(this.btnStoktanDus_Click);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Location = new System.Drawing.Point(540, 150);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(120, 40);
            this.btnExcelAktar.TabIndex = 7;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // MalzemeIhtiyaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnStoktanDus);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.clbTarifler);
            this.Controls.Add(this.lblTarifler);
            this.Controls.Add(this.nudKisiSayisi);
            this.Controls.Add(this.lblKisiSayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MalzemeIhtiyaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MalzemeIhtiyaciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.Label lblTarifler;
        private System.Windows.Forms.CheckedListBox clbTarifler;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.Button btnStoktanDus;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}