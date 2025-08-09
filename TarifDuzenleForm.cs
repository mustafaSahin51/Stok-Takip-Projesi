//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.

using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class TarifDuzenleForm : Form
    {
        private int tarifID;

        public TarifDuzenleForm(int tarifID)
        {
            InitializeComponent();
            this.tarifID = tarifID;
        }

        private void TarifDuzenleForm_Load(object sender, EventArgs e)
        {
            TarifBilgisiGetir();
            MalzemeleriGetir();
        }

        private void TarifBilgisiGetir()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT TarifAdi, Aciklama, Hazirlanis, Porsiyon, HazirlanmaSuresi FROM Tarifler WHERE TarifID = @TarifID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifID", tarifID);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtTarifAdi.Text = dr["TarifAdi"].ToString();
                            txtAciklama.Text = dr["Aciklama"].ToString();
                            txtHazirlanis.Text = dr["Hazirlanis"].ToString();
                            nudPorsiyon.Value = dr["Porsiyon"] != DBNull.Value ? Convert.ToDecimal(dr["Porsiyon"]) : 1;
                            nudSure.Value = dr["HazirlanmaSuresi"] != DBNull.Value ? Convert.ToDecimal(dr["HazirlanmaSuresi"]) : 1;
                        }
                    }
                }
            }
        }

        private void MalzemeleriGetir()
        {
            dgvMalzemeler.Rows.Clear();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UrunAdi, Miktar, Birim FROM TarifIcerik WHERE TarifID = @TarifID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TarifID", tarifID);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvMalzemeler.Rows.Add(
                                dr["UrunAdi"].ToString(),
                                dr["Miktar"].ToString(),
                                dr["Birim"].ToString()
                            );
                        }
                    }
                }
            }
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

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var tran = conn.BeginTransaction();
                try
                {
                    // Tarif güncelle
                    string updateTarif = @"UPDATE Tarifler SET
                        TarifAdi = @TarifAdi,
                        Aciklama = @Aciklama,
                        Hazirlanis = @Hazirlanis,
                        Porsiyon = @Porsiyon,
                        HazirlanmaSuresi = @HazirlanmaSuresi
                        WHERE TarifID = @TarifID";
                    using (var cmdTarif = new SQLiteCommand(updateTarif, conn, tran))
                    {
                        cmdTarif.Parameters.AddWithValue("@TarifAdi", txtTarifAdi.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Aciklama", txtAciklama.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Hazirlanis", txtHazirlanis.Text.Trim());
                        cmdTarif.Parameters.AddWithValue("@Porsiyon", nudPorsiyon.Value);
                        cmdTarif.Parameters.AddWithValue("@HazirlanmaSuresi", nudSure.Value);
                        cmdTarif.Parameters.AddWithValue("@TarifID", tarifID);
                        cmdTarif.ExecuteNonQuery();
                    }

                    // Eski malzemeleri sil
                    string deleteIcerik = "DELETE FROM TarifIcerik WHERE TarifID = @TarifID";
                    using (var cmdDelete = new SQLiteCommand(deleteIcerik, conn, tran))
                    {
                        cmdDelete.Parameters.AddWithValue("@TarifID", tarifID);
                        cmdDelete.ExecuteNonQuery();
                    }

                    // Yeni malzemeleri ekle
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
                            cmdIcerik.Parameters.AddWithValue("@TarifID", tarifID);
                            cmdIcerik.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            cmdIcerik.Parameters.AddWithValue("@Miktar", miktar);
                            cmdIcerik.Parameters.AddWithValue("@Birim", birim);
                            cmdIcerik.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    LoglarFormu.LogEkle(
                        Oturum.KullaniciAdi,
                        $"Tarif güncellendi: TarifID={tarifID}, Tarif Adı={txtTarifAdi.Text.Trim()}"
                    );
                    MessageBox.Show("Tarif başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static void ShowTarifDuzenleForm(int secilenTarifID)
        {
            TarifDuzenleForm frm = new TarifDuzenleForm(secilenTarifID);
            frm.ShowDialog();
        }
    }
}