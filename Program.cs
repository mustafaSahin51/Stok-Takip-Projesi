
//© 2025 Mustafa Şahin. Tüm hakları saklıdır. Bu yazılımın izinsiz dağıtılması, çoğaltılması veya değiştirilmesi yasaktır.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip
{
    internal static class Program
    {
        // StokTakibi formuna global erişim için static referans
        public static StokTakibi stokTakibiFormu;

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // StokTakibi formunu oluştur ve referansa ata
            stokTakibiFormu = new StokTakibi();

            // Ana formu başlat (örnek: Form1'de bir butonla stokTakibiFormu.Show() çağırabilirsiniz)
            Application.Run(new Form1());
        }
    }
}
