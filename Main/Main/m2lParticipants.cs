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
        private Dictionary<int, string> cSTypeParticipant = new Dictionary<int, string>();

        public m2lParticipants()
        {
            InitializeComponent();
        }

        private void m2lParticipants_Load(object sender, EventArgs e)
        {
            initParticipants();
            initTypeParticipant();
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
                Int32 key = ((KeyValuePair<int, String>)cBoxType.SelectedItem).Key;

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
        private void DgvParticipants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParticipants.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvParticipants.CurrentRow.Selected = true;

                txtBoxNom.Text = dgvParticipants.Rows[e.RowIndex].Cells["FirstNameParticipant"].FormattedValue.ToString();
                txtBoxPrenom.Text = dgvParticipants.Rows[e.RowIndex].Cells["LastNameParticipant"].FormattedValue.ToString();

                cBoxType.SelectedIndex = Convert.ToInt32(dgvParticipants.Rows[e.RowIndex].Cells["idType"].Value.ToString()) - 1;
            }
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
            dgvParticipants.Columns["idType"].Visible = false;

            // on redimensionne automatiquement la largeur des colonnes du datagridview
            dgvParticipants.AutoResizeColumns();

        }

        public void initTypeParticipant()
        {


            foreach (TypeParticipant unType in DAOParticipants.getAllTypePartcipant())
            {

                cSTypeParticipant.Add(unType.IdTypeParticipant, unType.Libelle);
            }

            cBoxType.DataSource = new BindingSource(cSTypeParticipant, null);
            cBoxType.DisplayMember = "Value";
            cBoxType.ValueMember = "Key";
        }
        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Int32 key = ((KeyValuePair<int, String>)cBoxType.SelectedItem).Key;

            DAOParticipants.editParticipant(Convert.ToInt32(dgvParticipants.CurrentRow.Cells[0].Value),
                    txtBoxNom.Text,
                    txtBoxPrenom.Text,
                    key);
            dgvParticipants.DataSource = null;
            dgvParticipants.DataSource = DAOParticipants.getAllParticipants();
        }
    }
}
