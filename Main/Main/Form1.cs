using System;
using System.Windows.Forms;

namespace Main
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
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

        private void btnStands_Click(object sender, EventArgs e)
        {
            m2lStands1.BringToFront();
        }

        private void BtnHotels_Click(object sender, EventArgs e)
        {
            m2lHotel1.BringToFront();
        }
    }
}
