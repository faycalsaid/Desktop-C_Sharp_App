using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Controls.Add(new m2lAteliers());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Close App
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimze the app in toolbar
        }

        private void btnAteliers_Click(object sender, EventArgs e)
        {
            m2lAteliers1.BringToFront();
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            m2lParticipants1.BringToFront();
        }
    }
}
