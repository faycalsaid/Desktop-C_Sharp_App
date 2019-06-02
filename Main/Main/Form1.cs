using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace Main
{
    public partial class mainForm : Form
    {
        static mainForm _obj;


        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnReturn.Visible = false;
            _obj = this;

            m2lStands ucStands = new m2lStands();
            m2lParticipants ucParticipants = new m2lParticipants();
            m2lHotel ucHotel = new m2lHotel();
            m2lAteliers ucAtelier = new m2lAteliers();

            ucStands.Dock = DockStyle.Fill;
            ucParticipants.Dock = DockStyle.Fill;
            ucHotel.Dock = DockStyle.Fill;
            ucAtelier.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(ucStands);
            panelContainer.Controls.Add(ucParticipants);
            panelContainer.Controls.Add(ucHotel);
            panelContainer.Controls.Add(ucAtelier);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Close App
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimze the app in toolbar
        }

        private void BtnAteliers_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["m2lAteliers"].BringToFront();
        }

        private void BtnParticipants_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["m2lParticipants"].BringToFront();
        }

        private void BtnHotels_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["m2lHotel"].BringToFront();
        }

        private void btnStands_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["m2lStands"].BringToFront();          
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            //Delete 

            foreach (Control item in panelContainer.Controls)
            {
                if (item.Name == "standAllocation")
                {
                    panelContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            foreach (Control item in panelContainer.Controls)
            {
                if (item.Name == "m2lStands")
                {
                    panelContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            m2lStands ucStands = new m2lStands();
            ucStands.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucStands);

            panelContainer.Controls["m2lStands"].BringToFront();

            btnReturn.Visible = false;
        }


        //Return an instance of actual form (Made for Stands)
        //@Feycce
        public static mainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new mainForm();
                }

                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public BunifuImageButton ReturnButton
        {
            get { return btnReturn; }
            set { btnReturn = value; }
        }

        
    }
}
