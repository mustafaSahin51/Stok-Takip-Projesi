
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // <-- Eklendi

namespace Stok_takip
{
    public partial class Tarifler : Form
    {
        public Tarifler()
        {
            InitializeComponent();
            this.btnTarifSil.Click += new System.EventHandler(this.btnTarifSil_Click);
            this.btnIcerikSil.Click += new System.EventHandler(this.btnIcerikSil_Click);
        }

        private void Tarifler_Load(object sender, EventArgs e)
        {
            TarifleriListele();
        }

        private void TarifleriListele()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TarifID, TarifAdi, Porsiyon, HazirlanmaSuresi, EklenmeTarihi FROM Tarifler";
                    using (var da = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTarifler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarifler listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTarifler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTarifler.SelectedRows.Count == 0) return;
            int tarifID = Convert.ToInt32(dgvTarifler.SelectedRows[0].Cells["TarifID"].Value);
            MalzemeleriListele(tarifID);
            TarifDetayGoster(tarifID);
        }

        private void MalzemeleriListele(int tarifID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UrunAdi, Miktar, Birim FROM TarifIcerik WHERE TarifID = @TarifID";
                    using (var da = new SQLiteDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@TarifID", tarifID);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvIcerik.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzemeler listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TarifDetayGoster(int tarifID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Aciklama, Hazirlanis, Porsiyon, HazirlanmaSuresi FROM Tarifler WHERE TarifID = @TarifID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TarifID", tarifID);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtAciklama.Text = dr["Aciklama"].ToString();
                                txtHazirlanis.Text = dr["Hazirlanis"].ToString();
                                txtPorsiyon.Text = dr["Porsiyon"].ToString();
                                txtSure.Text = dr["HazirlanmaSuresi"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarif detayı alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTarifEkle_Click(object sender, EventArgs e)
        {  
            TarifEkleForm ekleForm = new TarifEkleForm();
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                TarifleriListele();
                // Log ekle
                LoglarFormu.LogEkle(Oturum.KullaniciAdi, "Tarif eklendi");
            }
        }

        private void btnIcerikSil_Click(object sender, EventArgs e)
        {
            if (dgvTarifler.SelectedRows.Count == 0 || dgvIcerik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir tarif ve bir malzeme seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int tarifID = Convert.ToInt32(dgvTarifler.SelectedRows[0].Cells["TarifID"].Value);
            string urunAdi = dgvIcerik.SelectedRows[0].Cells["UrunAdi"].Value.ToString();

            var result = MessageBox.Show("Seçili malzemeyi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM TarifIcerik WHERE TarifID = @TarifID AND UrunAdi = @UrunAdi";
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TarifID", tarifID);
                            cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            cmd.ExecuteNonQuery();
                        }
                        MalzemeleriListele(tarifID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Malzeme silinirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTarifSil_Click(object sender, EventArgs e)
        {
            if (dgvTarifler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir tarif seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Seçili tarifi ve tüm malzemelerini silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int tarifID = Convert.ToInt32(dgvTarifler.SelectedRows[0].Cells["TarifID"].Value);
                string tarifAdi = dgvTarifler.SelectedRows[0].Cells["TarifAdi"].Value.ToString();
                using (var conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string deleteTarif = "DELETE FROM Tarifler WHERE TarifID = @TarifID";
                        using (var cmdTarif = new SQLiteCommand(deleteTarif, conn))
                        {
                            cmdTarif.Parameters.AddWithValue("@TarifID", tarifID);
                            cmdTarif.ExecuteNonQuery();
                        }
                        TarifleriListele();
                        dgvIcerik.DataSource = null;
                        txtAciklama.Clear();
                        txtHazirlanis.Clear();
                        txtPorsiyon.Clear();
                        txtSure.Clear();

                        // Log ekle
                        LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Tarif silindi: TarifID={tarifID}, Tarif Adı={tarifAdi}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
