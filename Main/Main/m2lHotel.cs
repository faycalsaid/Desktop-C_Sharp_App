using System;
using System.Windows.Forms;
using Main.DAO;

namespace Main
{
    public partial class m2lHotel : UserControl
    {
        public m2lHotel()
        {
            InitializeComponent();
        }

        private void m2lHotelcs_Load(object sender, EventArgs e)
        {
            initHotel();
        }

        #region Init Donnée
        public void initHotel()
        {
            dgvHotel.DataSource = null;
            dgvHotel.DataSource = DAOHotel.getAllHotels();


            // on redimensionne automatiquement la largeur des colonnes du datagridview
            dgvHotel.AutoResizeColumns();
        }
        #endregion

        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            DAOHotel.delHotel(Convert.ToInt32(dgvHotel.CurrentRow.Cells[0].Value));
            dgvHotel.DataSource = null;
            dgvHotel.DataSource = DAOHotel.getAllHotels();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (txtBoxNameHotel.Text == "Nom Hotel" || txtBoxAddress.Text == "Adresse Hotel")
            {
                MessageBox.Show("Vous devez écrir dans les champs");
            }
            else
            {
                DAOHotel.addHotel(txtBoxNameHotel.Text, txtBoxAddress.Text);
                dgvHotel.DataSource = null;
                dgvHotel.DataSource = DAOHotel.getAllHotels();

                txtBoxNameHotel.Text = "Nom Hotel";
                txtBoxAddress.Text = "Adresse Hotel";


            }
        }

        #region Event DVG
        private void dgvHotel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DAOHotel.editHotel(Convert.ToInt32(dgvHotel.CurrentRow.Cells[0].Value),
                    Convert.ToString(dgvHotel.CurrentRow.Cells[1].Value),
                    Convert.ToString(dgvHotel.CurrentRow.Cells[2].Value));
        }
        #endregion

        #region txtBox NomHotel

        private void txtBoxNameHotel_Enter(object sender, EventArgs e)
        {
            if (txtBoxNameHotel.Text == "Nom Hotel")
            {
                txtBoxNameHotel.Text = "";
            }
        }

        private void txtBoxNameHotel_Leave(object sender, EventArgs e)
        {
            if (txtBoxNameHotel.Text == "")
            {
                txtBoxNameHotel.Text = "Nom Hotel";
            }
        }

        #endregion

        #region AdresseHotel

        private void txtBoxAddress_Enter(object sender, EventArgs e)
        {
            if (txtBoxAddress.Text == "Adresse Hotel")
            {
                txtBoxAddress.Text = "";
            }

        }

        private void txtBoxAddress_Leave(object sender, EventArgs e)
        {
            if (txtBoxAddress.Text == "")
            {
                txtBoxAddress.Text = "Adresse Hotel";
            }
        }
        #endregion
    }
}
