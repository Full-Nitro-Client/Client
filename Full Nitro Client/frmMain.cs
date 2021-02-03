using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Using for all of the browser stuff.
using CefSharp;
using CefSharp.WinForms;
using RED7Studios.UI.Forms;

namespace Full_Nitro_Client
{
    public partial class frmMain : ModernForm
    {
        // Create a public ChromiumWebBrowser called 'chromeBrowser'.
        public ChromiumWebBrowser chromeBrowser;

        string cacheDirBase = "Caches";

        public frmMain()
        {
            // Initialize the form.
            InitializeComponent();
            // Initialize the browser.
            InitializeChromium();

            //this.Text = chromeBrowser.Address + " - Full Nitro Client";

            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
            chromeBrowser.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;
        }

        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\jQuery.js"));

            // If the Enable Gold Membership file exists.
            if (File.Exists(cacheDirBase + "\\EnableGoldMembership.dat"))
            {
                // If the URL is the garage or racing.
                if (chromeBrowser.Address.Contains("nitrotype.com/garage")
                 || chromeBrowser.Address.Contains("nitrotype.com/race"))
                {
                    // Write a line to the console saying it is executing.
                    Console.WriteLine("Executing Membership.js Script!");
                    // Execute the give gold membership script.
                    chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\Membership.js"));
                }
            }

            if (chromeBrowser.Address.Contains("nitrotype.com/race"))
            {
                // Write a line to the console saying it is executing.
                Console.WriteLine("Executing Bot.js Script!");
                // Execute the give gold membership script.
                chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\Bot.js"));
            }
        }

        private void ChromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            // chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\Membership.js"));
            //this.Text = chromeBrowser.Address + " - Full Nitro Client";
        }

        public void InitializeChromium()
        {
            // Create a new CefSettings called 'settings'.
            CefSettings settings = new CefSettings();
            // Set up the cache path.
            settings.CachePath = Path.GetFullPath(Application.StartupPath) + @"\Caches";
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.nitrotype.com/login")
            {
                Dock = DockStyle.Fill
            };

            // Add it to the form and fill it to the form window.
            tableLayoutPanel1.Controls.Add(chromeBrowser);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var membership = giveYourselfGoldMembershipToolStripMenuItem;
            if (File.Exists(cacheDirBase + "\\EnableGoldMembership.dat"))
            {
                membership.Text = "ON " + membership.Text;
            }
            else
            {
                membership.Text = "OFF " + membership.Text;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle a shutdown.
            HandleShutdown();
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }

        // Inefficent.
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void HandleRestart()
        {
            // Shutdown the CEF process.
            Cef.Shutdown();
            // Restart the application.
            Application.Restart();
        }

        private void HandleShutdown()
        {
            // Shutdown CEF process.
            Cef.Shutdown();
            // Reset all of the caches.
            ResetCaches();
            // Exit the application.
            Application.Exit();
        }

        private void giveYourselfGoldMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new membership variable for the tool strip menu item.
            var membership = giveYourselfGoldMembershipToolStripMenuItem;

            if (membership.Text.Contains("OFF "))
            {   
                // Create the dat file to enable the membership.
                File.Create(cacheDirBase + "\\EnableGoldMembership.dat");
                // Handle a restart.
                HandleRestart();
            }
            else if (membership.Text.Contains("ON "))
            {
                // Shutdown the CEF process.
                Cef.Shutdown();
                // Delete the dat file to disable the membership.
                File.Delete(cacheDirBase + "\\EnableGoldMembership.dat");
                // Reset the local storage.
                ResetLocalStorage();
                // Reset the caches.
                ResetCaches();
                // Handle a restart.
                HandleRestart();
            }
        }

        private void ResetLocalStorage()
        {
            try
            {
                // Delete the local storage.
                Directory.Delete(cacheDirBase + "\\Local Storage", true);
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void ResetCaches()
        {
            try
            {
                // Delete the cache.
                Directory.Delete(cacheDirBase + "\\Cache", true);
                // Delete the code cache.
                Directory.Delete(cacheDirBase + "\\Code Cache", true);
                // Delete the GPU cache.
                Directory.Delete(cacheDirBase + "\\GPUCache", true);
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void ResetStorages()
        {
            // Delete the session storage.
            Directory.Delete(cacheDirBase + "\\Session Storage", true);
            // Delete the blob storage.
            Directory.Delete(cacheDirBase + "\\blob_storage", true);
        }

        private void ResetEverything()
        {
            try
            {
                // Reset local storage.
                ResetLocalStorage();
                // Reset all caches.
                ResetCaches();
                // Reset all storages.
                ResetStorages();
            }
            catch (Exception ex)
            {
                // Write a line to the console with the error.
                Console.WriteLine("FATAL ERROR: " + ex.Message);
            }
        }

        private void dangerResetEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Shutdown the CEF process.
            Cef.Shutdown();
            // Delete the EnableMembership data file.
            File.Delete(cacheDirBase + "\\EnableGoldMembership.dat");
            // Delete the Remove Notice data file.
            File.Delete(cacheDirBase + "\\RemoveNotice.dat");
            // Reset all data and cache.
            ResetEverything();
            // Handle a restart.
            HandleRestart();
        }

        private void giveYourselfMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write a line to the console saying it is executing.
            Console.WriteLine("Executing OneMillion.js Script!");
            // Execute the give gold membership script.
            chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\OneMillion.js"));
            // Reload the browser.
            chromeBrowser.Reload();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new AboutForm called 'about'.
            AboutForm about = new AboutForm();
            // Open the 'about' form as a dialog.
            about.ShowDialog();
            // Write a line to the console saying it was opened.
            Console.WriteLine("Opened the about form!");
        }

        private void activateBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(cacheDirBase + "\\NitroTyper.exe");
        }

        private void openDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }
    }
}
