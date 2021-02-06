using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Nitro_Client.Controls
{
    public partial class frmGotoURL : Form
    {
        public frmGotoURL()
        {
            InitializeComponent();
        }

        public string URL_GOTO
        {
            get { return tbURL.Text; }
        }

        private void frmGotoURL_Load(object sender, EventArgs e)
        {

        }

        private void btnGotoURL_Click(object sender, EventArgs e)
        {
            var content = this.tbURL.Text;
            var parent = this.Parent as frmMain;
            parent.URL_GOTO = tbURL.Text;
        }
    }
}
