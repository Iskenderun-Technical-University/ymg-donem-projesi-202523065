using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAÇ_KİRALAMA_OTOMASYON
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new AnaSayfa());
            //Application.Run(new MüşteriEkle());
             Application.Run(new loginform());    //ilk bu açılacak
            // Application.Run(new SİFRELEME());
           // Application.Run(new rapor());
           
        }
    }
}
