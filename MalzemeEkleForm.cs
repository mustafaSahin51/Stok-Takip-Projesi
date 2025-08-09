
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

namespace Stok_takip
{
    public partial class MalzemeEkleForm : Form
    {
        public string UrunAdi { get; private set; }
        public decimal Miktar { get; private set; }
        public string Birim { get; private set; }

        public MalzemeEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMalzemeAdi.Text) || nudMiktar.Value <= 0 || string.IsNullOrWhiteSpace(cmbBirim.Text))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UrunAdi = txtMalzemeAdi.Text.Trim();
            Miktar = nudMiktar.Value;
            Birim = cmbBirim.Text;

            // Log ekle
            LoglarFormu.LogEkle(Oturum.KullaniciAdi, $"Malzeme eklendi: {UrunAdi}, {Miktar} {Birim}");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

/*
// using System.Data.SQLite; // Gerekirse ekle (şu an doğrudan veritabanı işlemi yok)

// Eğer bu formda doğrudan veritabanına ekleme yapılmayacaksa (sadece değer döndürülüyorsa) ek bir değişiklige gerek yok.
// Eğer ileride doğrudan SQLite ile veritabanına ekleme yapılacaksa aşağıdaki gibi :

using (var conn = DatabaseHelper.GetConnection())
{
    conn.Open();
    string query = "INSERT INTO Urunler (UrunAdi, Miktar, Birim) VALUES (@UrunAdi, @Miktar, @Birim)";
    using (var cmd = new SQLiteCommand(query, conn))
    {
        cmd.Parameters.AddWithValue("@UrunAdi", UrunAdi);
        cmd.Parameters.AddWithValue("@Miktar", Miktar);
        cmd.Parameters.AddWithValue("@Birim", Birim);
        cmd.ExecuteNonQuery();
    }
}
*/
