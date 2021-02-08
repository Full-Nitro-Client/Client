using AutoUpdaterDotNET;
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
        // Create a new ProgramSettings called 'settings'.
        static ProgramSettings settings = new ProgramSettings();

        // Create a new frmMain called 'Form'.
        public static frmMain Form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable the application's visual styles.
            Application.EnableVisualStyles();
            // Set the compatible text rendering default to false.
            Application.SetCompatibleTextRenderingDefault(false);

            // If the Caches directory doesn't exist.
            if (!Directory.Exists("Caches"))
            {
                // Create the Caches directory.
                Directory.CreateDirectory("Caches");
            }

            // If the Caches RemoveNotice doesn't exist.
            if (!File.Exists("Caches\\RemoveNotice.dat"))
            {
                // Set 'notice' to frmNotice.
                frmNotice notice = new frmNotice();
                // Open 'notice'.
                notice.Show();
                // Run the program.
                Application.Run();
            }
            else
            {
                // Set from to a new frmMain.
                Form = new frmMain();
                // Run the program.
                Application.Run(Form);
            }

            // Start the updater with the NEW url.
            AutoUpdater.Start(settings.UpdateURL + settings.UpdateURLXML);

            // Write a line to the console with the settings.
            Console.WriteLine("\n\nSettings:\nVersion: " + settings.Version + "\nBeta: " + settings.Beta + "\n\nUpdate URL: " + settings.UpdateURL + "\nUpdate Structure: " + settings.UpdateURL + settings.UpdateURLStruct + "\nUpdate XML: " + settings.UpdateURL + settings.UpdateURLXML + "\n\n");
        }
    }
}
