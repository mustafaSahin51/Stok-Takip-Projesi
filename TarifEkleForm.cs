//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite; // <-- Eklendi
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class TarifEkleForm : Form
    {
        public TarifEkleForm()
        {
            InitializeComponent();
            dgvMalzemeler.Columns.Add("UrunAdi", "Malzeme Adı");
            dgvMalzemeler.Columns.Add("Miktar", "Miktar");
            dgvMalzemeler.Columns.Add("Birim", "Birim");
        }

        private void TarifEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtMalzemeAdi.Text.Trim();
            decimal miktar = nudMiktar.Value;
            string birim = cmbBirim.Text;

            if (string.IsNullOrEmpty(urunAdi) || miktar <= 0 || string.IsNullOrEmpty(birim))
            {
                MessageBox.Show("Malzeme adı, miktar ve birim zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvMalzemeler.Rows.Add(urunAdi, miktar, birim);
            txtMalzemeAdi.Clear();
            nudMiktar.Value = 1;
            cmbBirim.SelectedIndex = -1;
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (dgvMalzemeler.SelectedRows.Count > 0)
            {
                dgvMalzemeler.Rows.RemoveAt(dgvMalzemeler.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Silmek için bir malzeme seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (string.IsNullOrWhiteSpace(txtTarifAdi.Text))
            {
                MessageBox.Show("Tarif adı zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvMalzemeler.Rows.Count == 0)
            {
                MessageBox.Show("En az bir malzeme eklemelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long yeniTarifID = -1;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var tran = conn.BeginTransaction();
                try
                {
                    // Tarif ekle
                    string insertTarif = @"INSERT INTO Tarifler (TarifAdi, Aciklama, Hazirlanis, Porsiyon, HazirlanmaSuresi)
                                           VALUES (@TarifAdi, @Aciklama, @Hazirlanis, @Porsiyon, @HazirlanmaSuresi);";
                    using (var cmdTarif = new SQLiteCommand(insertTarif, conn, tran))
                    {
                        cmdTarif.Parameters.AddWithValue("@TarifAdi", txtTarifAdi.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Hazirlanis", txtHazirlanis.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Porsiyon", nudPorsiyon.Value);
                        cmdTarif.Parameters.AddWithValue("@HazirlanmaSuresi", nudSure.Value);
                        cmdTarif.ExecuteNonQuery();
                    }

                    // Son eklenen ID'yi al
                    using (var cmdID = new SQLiteCommand("SELECT last_insert_rowid();", conn, tran))
                    {
                        yeniTarifID = (long)cmdID.ExecuteScalar();
                    }

                    // Malzemeleri ekle
                    foreach (DataGridViewRow row in dgvMalzemeler.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string urunAdi = row.Cells["UrunAdi"].Value.ToString();
                        decimal miktar = Convert.ToDecimal(row.Cells["Miktar"].Value);
                        string birim = row.Cells["Birim"].Value.ToString();

                        string insertIcerik = @"INSERT INTO TarifIcerik (TarifID, UrunAdi, Miktar, Birim)
                                                VALUES (@TarifID, @UrunAdi, @Miktar, @Birim)";
                        using (var cmdIcerik = new SQLiteCommand(insertIcerik, conn, tran))
                        {
                            cmdIcerik.Parameters.AddWithValue("@TarifID", yeniTarifID);
                            cmdIcerik.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            cmdIcerik.Parameters.AddWithValue("@Miktar", miktar);
                            cmdIcerik.Parameters.AddWithValue("@Birim", birim);
                            cmdIcerik.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();

                    // Tarif ekleme işlemi başarılıysa:
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Tarif eklendi: Tarif Adı={txtTarifAdi.Text.Trim()}"
                    );
                    MessageBox.Show("Tarif başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
