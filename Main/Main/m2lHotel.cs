using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main.DAO;
using Main.LogicLayer;

namespace Main
{
    public partial class m2lHotel : UserControl
    {

        private Dictionary<int, string> cSHotel = new Dictionary<int, string>();
        private Dictionary<int, string> cSParticipant = new Dictionary<int, string>();

        public m2lHotel()
        {
            InitializeComponent();
        }

        private void m2lHotelcs_Load(object sender, EventArgs e)
        {
            initDonne();
        }

        #region Init Donnée
        public void initDonne()
        {
            loadDGV();

            //Remplire Combobox Hotel
            foreach (Hotel unHotel in DAOHotel.getAllHotels())
            {
                cSHotel.Add(unHotel.IdHotel, unHotel.Name);
            }

            cBoxHotel.DataSource = new BindingSource(cSHotel, null);
            cBoxHotel.DisplayMember = "Value";
            cBoxHotel.ValueMember = "Key";


            //Remplire Combobox Participant
            foreach (Participant unParticipant in DAOParticipants.getAllParticipants())
            {
                cSParticipant.Add(unParticipant.IdParticipant, unParticipant.ToStringName());
            }

            cBoxParticipant.DataSource = new BindingSource(cSParticipant, null);
            cBoxParticipant.DisplayMember = "Value";
            cBoxParticipant.ValueMember = "Key";


        }

        public void loadDGV()
        {
            dgvHotel.DataSource = null;
            dgvHotel.DataSource = DAOReservation.getAllReservation();
            dgvHotel.Columns["IdParticipant"].Visible = false;
            dgvHotel.Columns["IdHotel"].Visible = false;

            // on redimensionne automatiquement la largeur des colonnes du datagridview
            dgvHotel.AutoResizeColumns();
        }
        #endregion

        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            DAOReservation.delReservation(Convert.ToInt32(dgvHotel.CurrentRow.Cells[0].Value));

            loadDGV();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (txtBoxNbJour.Text == "Nombre de jours réservation")
            {
                MessageBox.Show("Vous devez remplir les champs");
            }
            else
            {
                Int32 idParticipant = ((KeyValuePair<int, String>)cBoxParticipant.SelectedItem).Key;
                Int32 idHotel = ((KeyValuePair<int, String>)cBoxHotel.SelectedItem).Key;

                DAOReservation.addReservation(idParticipant, idHotel, Convert.ToInt32(txtBoxNbJour.Text));

                loadDGV();

                txtBoxNbJour.Text = "Nombre de jours réservation";


            }
        }

        #region Event DVG
        private void DgvHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHotel.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHotel.CurrentRow.Selected = true;

                txtBoxNbJour.Text = dgvHotel.Rows[e.RowIndex].Cells["NbJours"].FormattedValue.ToString();

                cBoxHotel.SelectedIndex = Convert.ToInt32(dgvHotel.Rows[e.RowIndex].Cells["IdParticipant"].Value.ToString()) - 1;
                cBoxHotel.SelectedIndex = Convert.ToInt32(dgvHotel.Rows[e.RowIndex].Cells["IdHotel"].Value.ToString()) - 1;

            }
        }
        #endregion

        #region txtBox NomHotel

        private void TxtBoxNbJour_Enter(object sender, EventArgs e)
        {
            if (txtBoxNbJour.Text == "Nombre de jours réservation")
            {
                txtBoxNbJour.Text = "";
            }
        }

        private void TxtBoxNbJour_Leave(object sender, EventArgs e)
        {
            if (txtBoxNbJour.Text == "")
            {
                txtBoxNbJour.Text = "Nombre de jours réservation";
            }
        }

        #endregion

        private void BtnEditReservation_Click(object sender, EventArgs e)
        {
            Int32 idParticipant = ((KeyValuePair<int, String>)cBoxParticipant.SelectedItem).Key;
            Int32 idHotel = ((KeyValuePair<int, String>)cBoxHotel.SelectedItem).Key;


            DAOReservation.editReservation(Convert.ToInt32(dgvHotel.CurrentRow.Cells[0].Value),
                    idParticipant,
                    idHotel,
                    Convert.ToInt32(txtBoxNbJour.Text));

            loadDGV();
        }
    }
}
