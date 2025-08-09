
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class LoglarFormu : Form
    {
        public LoglarFormu()
        {
            InitializeComponent();
        }

        private void LoglarFormu_Load(object sender, EventArgs e)
        {
            LoglariYukle();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoglariYukle(string arama = "")
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT KullaniciAdi AS 'Kullanıcı', Islem AS 'İşlem', strftime('%d.%m.%Y %H:%M', Tarih) AS 'Tarih' FROM Loglar";
                if (!string.IsNullOrWhiteSpace(arama))
                    query += " WHERE KullaniciAdi LIKE @arama OR Islem LIKE @arama";
                query += " ORDER BY LogID DESC";

                using (var da = new SQLiteDataAdapter(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(arama))
                        da.SelectCommand.Parameters.AddWithValue("@arama", "%" + arama + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            LoglariYukle(txtAra.Text);
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Dosyası (*.csv)|*.csv";
                sfd.FileName = "Loglar.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Sütun başlıkları
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                sw.Write(dataGridView1.Columns[i].HeaderText);
                                if (i < dataGridView1.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();

                            // Satırlar
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dataGridView1.Columns.Count - 1)
                                        sw.Write(";");
                                }
                                sw.WriteLine();
                            }
                        }
                        MessageBox.Show("Excel (CSV) dosyası başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Aktarım sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void LogEkle(string kullaniciAdi, string islem)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("INSERT INTO Loglar (KullaniciAdi, Islem) VALUES (@KullaniciAdi, @Islem)", conn))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Islem", islem);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
