using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Stok_takip
{
    public static class DatabaseHelper
    {
        // EXE'nin olduðu klasörün altýndaki database/sqlite/data.sqlite dosyasýný hedefler
        private static readonly string dbPath = Path.Combine(
            Application.StartupPath, "database", "sqlite", "data.sqlite");

        public static string ConnectionString =>
            $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}