namespace Stok_takip
{
    partial class Tarifler
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
            this.dgvTarifler = new System.Windows.Forms.DataGridView();
            this.dgvIcerik = new System.Windows.Forms.DataGridView();
            this.btnTarifEkle = new System.Windows.Forms.Button();
            this.btnTarifDuzenle = new System.Windows.Forms.Button();
            this.btnTarifSil = new System.Windows.Forms.Button();
            this.btnIcerikEkle = new System.Windows.Forms.Button();
            this.btnIcerikSil = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblHazirlanis = new System.Windows.Forms.Label();
            this.txtHazirlanis = new System.Windows.Forms.TextBox();
            this.lblPorsiyon = new System.Windows.Forms.Label();
            this.txtPorsiyon = new System.Windows.Forms.TextBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarifler
            // 
            this.dgvTarifler.AllowUserToAddRows = false;
            this.dgvTarifler.AllowUserToDeleteRows = false;
            this.dgvTarifler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTarifler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarifler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifler.Location = new System.Drawing.Point(30, 80);
            this.dgvTarifler.MultiSelect = false;
            this.dgvTarifler.Name = "dgvTarifler";
            this.dgvTarifler.ReadOnly = true;
            this.dgvTarifler.RowHeadersWidth = 51;
            this.dgvTarifler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifler.Size = new System.Drawing.Size(400, 500);
            this.dgvTarifler.TabIndex = 0;
            this.dgvTarifler.SelectionChanged += new System.EventHandler(this.dgvTarifler_SelectionChanged);
            // 
            // dgvIcerik
            // 
            this.dgvIcerik.AllowUserToAddRows = false;
            this.dgvIcerik.AllowUserToDeleteRows = false;
            this.dgvIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIcerik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIcerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcerik.Location = new System.Drawing.Point(460, 80);
            this.dgvIcerik.MultiSelect = false;
            this.dgvIcerik.Name = "dgvIcerik";
            this.dgvIcerik.ReadOnly = true;
            this.dgvIcerik.RowHeadersWidth = 51;
            this.dgvIcerik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIcerik.Size = new System.Drawing.Size(500, 250);
            this.dgvIcerik.TabIndex = 1;
            // 
            // btnTarifEkle
            // 
            this.btnTarifEkle.Location = new System.Drawing.Point(30, 25);
            this.btnTarifEkle.Name = "btnTarifEkle";
            this.btnTarifEkle.Size = new System.Drawing.Size(110, 40);
            this.btnTarifEkle.TabIndex = 2;
            this.btnTarifEkle.Text = "Tarif Ekle";
            this.btnTarifEkle.UseVisualStyleBackColor = true;
            this.btnTarifEkle.Click += new System.EventHandler(this.btnTarifEkle_Click);
            // 
            // btnTarifDuzenle
            // 
            this.btnTarifDuzenle.Location = new System.Drawing.Point(150, 25);
            this.btnTarifDuzenle.Name = "btnTarifDuzenle";
            this.btnTarifDuzenle.Size = new System.Drawing.Size(110, 40);
            this.btnTarifDuzenle.TabIndex = 3;
            this.btnTarifDuzenle.Text = "Düzenle";
            this.btnTarifDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnTarifSil
            // 
            this.btnTarifSil.Location = new System.Drawing.Point(270, 25);
            this.btnTarifSil.Name = "btnTarifSil";
            this.btnTarifSil.Size = new System.Drawing.Size(110, 40);
            this.btnTarifSil.TabIndex = 4;
            this.btnTarifSil.Text = "Sil";
            this.btnTarifSil.UseVisualStyleBackColor = true;
            this.btnTarifSil.Click += new System.EventHandler(this.btnTarifSil_Click);
            // 
            // btnIcerikEkle
            // 
            this.btnIcerikEkle.Location = new System.Drawing.Point(460, 25);
            this.btnIcerikEkle.Name = "btnIcerikEkle";
            this.btnIcerikEkle.Size = new System.Drawing.Size(120, 40);
            this.btnIcerikEkle.TabIndex = 5;
            this.btnIcerikEkle.Text = "Malzeme Ekle";
            this.btnIcerikEkle.UseVisualStyleBackColor = true;
            // 
            // btnIcerikSil
            // 
            this.btnIcerikSil.Location = new System.Drawing.Point(590, 25);
            this.btnIcerikSil.Name = "btnIcerikSil";
            this.btnIcerikSil.Size = new System.Drawing.Size(120, 40);
            this.btnIcerikSil.TabIndex = 6;
            this.btnIcerikSil.Text = "Malzeme Sil";
            this.btnIcerikSil.UseVisualStyleBackColor = true;
            this.btnIcerikSil.Click += new System.EventHandler(this.btnIcerikSil_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(460, 350);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(66, 16);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(540, 347);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.Size = new System.Drawing.Size(420, 50);
            this.txtAciklama.TabIndex = 8;
            // 
            // lblHazirlanis
            // 
            this.lblHazirlanis.AutoSize = true;
            this.lblHazirlanis.Location = new System.Drawing.Point(460, 410);
            this.lblHazirlanis.Name = "lblHazirlanis";
            this.lblHazirlanis.Size = new System.Drawing.Size(69, 16);
            this.lblHazirlanis.TabIndex = 9;
            this.lblHazirlanis.Text = "Hazırlanış:";
            // 
            // txtHazirlanis
            // 
            this.txtHazirlanis.Location = new System.Drawing.Point(540, 407);
            this.txtHazirlanis.Multiline = true;
            this.txtHazirlanis.Name = "txtHazirlanis";
            this.txtHazirlanis.ReadOnly = true;
            this.txtHazirlanis.Size = new System.Drawing.Size(420, 90);
            this.txtHazirlanis.TabIndex = 10;
            // 
            // lblPorsiyon
            // 
            this.lblPorsiyon.AutoSize = true;
            this.lblPorsiyon.Location = new System.Drawing.Point(460, 510);
            this.lblPorsiyon.Name = "lblPorsiyon";
            this.lblPorsiyon.Size = new System.Drawing.Size(63, 16);
            this.lblPorsiyon.TabIndex = 11;
            this.lblPorsiyon.Text = "Porsiyon:";
            // 
            // txtPorsiyon
            // 
            this.txtPorsiyon.Location = new System.Drawing.Point(540, 507);
            this.txtPorsiyon.Name = "txtPorsiyon";
            this.txtPorsiyon.ReadOnly = true;
            this.txtPorsiyon.Size = new System.Drawing.Size(60, 22);
            this.txtPorsiyon.TabIndex = 12;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(620, 510);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(102, 16);
            this.lblSure.TabIndex = 13;
            this.lblSure.Text = "Hazırlama Süre:";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(730, 507);
            this.txtSure.Name = "txtSure";
            this.txtSure.ReadOnly = true;
            this.txtSure.Size = new System.Drawing.Size(60, 22);
            this.txtSure.TabIndex = 14;
            // 
            // Tarifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.txtPorsiyon);
            this.Controls.Add(this.lblPorsiyon);
            this.Controls.Add(this.txtHazirlanis);
            this.Controls.Add(this.lblHazirlanis);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnIcerikSil);
            this.Controls.Add(this.btnIcerikEkle);
            this.Controls.Add(this.btnTarifSil);
            this.Controls.Add(this.btnTarifDuzenle);
            this.Controls.Add(this.btnTarifEkle);
            this.Controls.Add(this.dgvIcerik);
            this.Controls.Add(this.dgvTarifler);
            this.Name = "Tarifler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifler";
            this.Load += new System.EventHandler(this.Tarifler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarifler;
        private System.Windows.Forms.DataGridView dgvIcerik;
        private System.Windows.Forms.Button btnTarifEkle;
        private System.Windows.Forms.Button btnTarifDuzenle;
        private System.Windows.Forms.Button btnTarifSil;
        private System.Windows.Forms.Button btnIcerikEkle;
        private System.Windows.Forms.Button btnIcerikSil;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblHazirlanis;
        private System.Windows.Forms.TextBox txtHazirlanis;
        private System.Windows.Forms.Label lblPorsiyon;
        private System.Windows.Forms.TextBox txtPorsiyon;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox txtSure;
    }
}