using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Nitro_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Directory.Exists("Caches"))
            {
                Directory.CreateDirectory("Caches");
            }

            if (!File.Exists("Caches\\RemoveNotice.dat"))
            {
                Application.Run(new frmNotice());
            } else
            {
                Application.Run(new frmMain());
            }
        }
    }
}
