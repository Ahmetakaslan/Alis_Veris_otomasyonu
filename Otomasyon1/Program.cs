using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        // ( 09.10.2022) eksiklikler veya fazlalıkları göxden geçir
        // ( 10.10.2022 ) iyleşitirme olarak generic yapıları kullan
        //
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAnaSayfa());
        }
    }
}
