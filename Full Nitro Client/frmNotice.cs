using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Nitro_Client
{
    public partial class frmNotice : ModernForm
    {
        public frmNotice()
        {
            // Initialize the form.
            InitializeComponent();
        }

        // If the user has pressed the exit button.
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Quit the application.
            Application.Exit();
        }

        // If the user has pressed the agree button.
        private void btnAgree_Click(object sender, EventArgs e)
        {
            // If the check box is checked.
            if (cbNeverShowAgain.Checked == true)
            {
                // Create the RemoveNotice.dat file under the Caches folder.
                File.Create("Caches\\RemoveNotice.dat");
            }

            // Hide the application.
            this.Hide();
            // Create a new 'frmMain' called 'main'.
            frmMain main = new frmMain();
            // Show the 'main' form.
            main.Show();
        }

        private void frmNotice_Load(object sender, EventArgs e)
        {

        }
    }
}
