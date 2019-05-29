using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Main.DAO;
using Main.LogicLayer;

namespace Main
{
    public partial class m2lParticipants : UserControl
    {
        private Dictionary<int, string> comboSource = new Dictionary<int, string>();

        public m2lParticipants()
        {
            InitializeComponent();
        }

        private void m2lParticipants_Load(object sender, EventArgs e)
        {
            initParticipants();
            initHotel();
        }

        #region Btn DGV

        private void btnDeleteParticipants_Click(object sender, EventArgs e)
        {
            DAOParticipants.delParticipant(Convert.ToInt32(dgvParticipants.CurrentRow.Cells[0].Value));
            dgvParticipants.DataSource = null;
            dgvParticipants.DataSource = DAOParticipants.getAllParticipants();
        }

        private void btnAddParticipants_Click_1(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "Nom Participant" || txtBoxPrenom.Text == "Prénom Participant")
            {
                MessageBox.Show("Vous devez écrir dans les champs");
            }
            else
            {
                Int32 key = ((KeyValuePair<int, String>)cBoxHotel.SelectedItem).Key;

                DAOParticipants.addParticipant(txtBoxNom.Text,
                        txtBoxPrenom.Text, key);
                dgvParticipants.DataSource = null;
                dgvParticipants.DataSource = DAOParticipants.getAllParticipants();

                txtBoxNom.Text = "Nom Participant";
                txtBoxPrenom.Text = "Prénom Participant";
            }
        }
        #endregion

        #region Event DVG
        private void dgvParticipants_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DAOParticipants.editParticipant(Convert.ToInt32(dgvParticipants.CurrentRow.Cells[0].Value),
                    Convert.ToString(dgvParticipants.CurrentRow.Cells[1].Value),
                    Convert.ToString(dgvParticipants.CurrentRow.Cells[2].Value),
                    Convert.ToInt32(dgvParticipants.CurrentRow.Cells[3].Value));
        }
        #endregion

        #region txtBox Nom

        private void txtBoxNom_Enter(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "Nom Participant")
            {
                txtBoxNom.Text = "";
            }
        }

        private void txtBoxNom_Leave(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "")
            {
                txtBoxNom.Text = "Nom Participant";
            }
        }
        #endregion

        #region txtBox Prenom
        private void txtBoxPrenom_Enter(object sender, EventArgs e)
        {
            if (txtBoxPrenom.Text == "Prénom Participant")
            {
                txtBoxPrenom.Text = "";
            }
        }

        private void txtBoxPrenom_Leave(object sender, EventArgs e)
        {
            if (txtBoxPrenom.Text == "")
            {
                txtBoxPrenom.Text = "Prénom Participant";
            }
        }
        #endregion


        #region Init Donnée
        public void initParticipants()
        {
            //Participant unPart = new Participant(1, "m2l", "mtrp");
            dgvParticipants.DataSource = null;
            dgvParticipants.DataSource = DAOParticipants.getAllParticipants();


            // on redimensionne automatiquement la largeur des colonnes du datagridview
            dgvParticipants.AutoResizeColumns();

        }

        public void initHotel()
        {
            comboSource.Clear();

            foreach (Hotel unHotel in DAOHotel.getAllHotels())
            {
                comboSource.Add(unHotel.IdHotel, unHotel.Name);
            }

            cBoxHotel.DataSource = new BindingSource(comboSource, null);
            cBoxHotel.DisplayMember = "Value";
            cBoxHotel.ValueMember = "Key";
        }
        #endregion

        private void cBoxHotel_Enter(object sender, EventArgs e)
        {
            initHotel();
        }
    }
}
