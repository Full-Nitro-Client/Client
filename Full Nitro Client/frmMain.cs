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

        // The string for the cache directory.
        string cacheDirBase = "Caches";

        public frmMain()
        {
            // Initialize the form.
            InitializeComponent();
            // Initialize the browser.
            InitializeChromium();

            // Create a new frame load end function for scripts.
            chromeBrowser.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;
        }

        public string URL_GOTO
        {
            set => chromeBrowser.Load(value);
        }

        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            RunScript("jQuery", false);

            // If the Enable Gold Membership file exists.
            if (File.Exists(cacheDirBase + "\\EnableGoldMembership.dat"))
            {
                // If the URL is the garage or racing.
                if (chromeBrowser.Address.Contains("nitrotype.com/garage"))
                {
                    RunScript("Membership", false);
                }
            }

            if (File.Exists(cacheDirBase + "\\GiveAllCars.dat"))
            {
                if (chromeBrowser.Address.Contains("nitrotype.com/garage"))
                {
                    RunScript("AllCars", false);
                }
            }

            if (chromeBrowser.Address.Contains("nitrotype.com/race"))
            {
                // RunScript("Bot");
            }
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
                // Dock it to fill.
                Dock = DockStyle.Fill
            };

            // Add it to the form and fill it to the form window.
            tlpMain.Controls.Add(chromeBrowser);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Create a new variable for the tool strip item.
            var membership = giveYourselfMembershipToolStripMenuItem;

            // If the enable gold membership file exists.
            if (File.Exists(cacheDirBase + "\\EnableGoldMembership.dat"))
            {
                // Set the text to ON with the original text.
                membership.Text = "ON " + membership.Text;
            }
            else
            {
                // Set the text to OFF with the original text.
                membership.Text = "OFF " + membership.Text;
            }



            // Create a new variable for the tool strip item.
            var cars = giveYourselfAllCarsToolStripMenuItem;

            // If the enable gold membership file exists.
            if (File.Exists(cacheDirBase + "\\GiveAllCars.dat"))
            {
                // Set the text to ON with the original text.
                cars.Text = "ON " + cars.Text;
            }
            else
            {
                // Set the text to OFF with the original text.
                cars.Text = "OFF " + cars.Text;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle a shutdown.
            HandleShutdown();
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
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new AboutForm called 'about'.
            frmAbout about = new frmAbout();
            // Open the 'about' form as a dialog.
            about.ShowDialog();
            // Write a line to the console saying it was opened.
            Console.WriteLine("Opened the about form!");
        }

        private void activateBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start the auto typer.
            Process.Start(cacheDirBase + "\\NitroTyper.exe");
        }

        private void openDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the chromium dev tools.
            chromeBrowser.ShowDevTools();
        }

        private void giveYourselfMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new membership variable for the tool strip menu item.
            var membership = giveYourselfMembershipToolStripMenuItem;

            // If the membership text contains OFF.
            if (membership.Text.Contains("OFF "))
            {
                // Create the dat file to enable the membership.
                File.Create(cacheDirBase + "\\EnableGoldMembership.dat");
                // Handle a restart.
                HandleRestart();
            }
            // Else if the membership text contains ON.2
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

        private void RunScript(string name, bool reload)
        {
            // Write a line to the console saying it is executing.
            Console.WriteLine("Executing " + name + ".js Script!");
            // Execute the script.
            chromeBrowser.ExecuteScriptAsync(File.ReadAllText(cacheDirBase + "\\" + name +".js"));
            if (reload == true)
            {
                // Reload the browser.
                chromeBrowser.Reload();
            }
        }

        private void giveYourselfOneMillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunScript("OneMillion", true);
        }

        private void secretModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the title bar text to "Browser [BETA]".
            this.Text = "Browser [BETA]";
            // Hide the navbar.
            navbar.Visible = false;
            // Remove the first row in the table layout panel.
            Modules.TableLayoutHelper.RemoveArbitraryRow(tlpMain, 0); // https://stackoverflow.com/questions/15535214/removing-a-specific-row-in-tablelayoutpanel
            // Goto Google to make it look believable.
            URL_GOTO = "https://google.com";
        }

        private void giveYourselfAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new membership variable for the tool strip menu item.
            var cars = giveYourselfAllCarsToolStripMenuItem;

            // If the membership text contains OFF.
            if (cars.Text.Contains("OFF "))
            {
                // Create the dat file to enable the membership.
                File.Create(cacheDirBase + "\\GiveAllCars.dat");
                // Handle a restart.
                HandleRestart();
            }
            // Else if the membership text contains ON.
            else if (cars.Text.Contains("ON "))
            {
                // Shutdown the CEF process.
                Cef.Shutdown();
                // Delete the dat file to disable the membership.
                File.Delete(cacheDirBase + "\\GiveAllCars.dat");
                // Reset the local storage.
                ResetLocalStorage();
                // Reset the caches.
                ResetCaches();
                // Handle a restart.
                HandleRestart();
            }
        }

        private void gotoURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Full_Nitro_Client.Controls.frmGotoURL uc = new Full_Nitro_Client.Controls.frmGotoURL();
            uc.ShowDialog();
        }
    }
}
