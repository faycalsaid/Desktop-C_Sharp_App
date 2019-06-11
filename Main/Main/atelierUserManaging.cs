using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.DAO;

namespace Main
{
    public partial class AtelierUserManaging : UserControl
    {
        private int atelierId;
        public AtelierUserManaging(int id)
        {
            InitializeComponent();

            this.atelierId = id;

            fillDataGridViews(); 
        }
        
        public void fillDataGridViews()
        {
            dataGridViewParticipants.DataSource = null;
            dataGridViewParticipants.DataSource = DAOAtelier.getAllParticipants();

            dgvAtelierParticipants.DataSource = null;
            dgvAtelierParticipants.DataSource = DAOAtelier.getAteliersParticipants(atelierId);


        }

        private void cleanAndRefresh()
        {
            foreach (Control item in mainForm.Instance.PnlContainer.Controls)
            {

                if (item.Name == "AtelierUserManaging")
                {
                    mainForm.Instance.PnlContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            AtelierUserManaging ucManaging = new AtelierUserManaging(atelierId);
            ucManaging.Dock = DockStyle.Fill;
            mainForm.Instance.PnlContainer.Controls.Add(ucManaging);

            mainForm.Instance.PnlContainer.Controls["AtelierUserManaging"].BringToFront();
        }

        private void BtnReturnAt_Click(object sender, EventArgs e)
        {
            foreach (Control item in mainForm.Instance.PnlContainer.Controls)
            {

                if (item.Name == "AtelierUserManaging")
                {
                    mainForm.Instance.PnlContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            mainForm.Instance.PnlContainer.Controls["ModifierAtelierModal"].BringToFront();
        }

        private void DgvAtelierParticipants_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            dataGridViewParticipants.Rows[e.RowIndex].Cells["Nom"].FormattedValue.ToString();
            Console.WriteLine("Passed");
        }


        private void AddParticipantBtn_Click(object sender, EventArgs e)
        {
            int partId = Int16.Parse(dataGridViewParticipants.CurrentRow.Cells["idParticipant"].Value.ToString());
            string nomP = dataGridViewParticipants.CurrentRow.Cells["nom"].Value.ToString();
            string prenomP = dataGridViewParticipants.CurrentRow.Cells["prenom"].Value.ToString();

            if(isDuplicate(nomP , prenomP))
            {
                MessageBox.Show(nomP + " " + prenomP + " particie déja à L'atelier");
            }
            else
            {
                DAOAtelier.addParticipant(atelierId, partId);
                cleanAndRefresh();
            }


        }

        private void DelParticipantBtn_Click(object sender, EventArgs e)
        {
            string nomP = dgvAtelierParticipants.CurrentRow.Cells["Nom"].Value.ToString();
            string prenomP = dgvAtelierParticipants.CurrentRow.Cells["Prenom"].Value.ToString();

            DAOAtelier.deleteParticipant(nomP, prenomP, atelierId);

            cleanAndRefresh();
        }



        private bool isDuplicate(string nomP, string prenomP)
        {
            bool duplicate = false;
            bool empty = (dgvAtelierParticipants.Rows.Count == 0) ? true : false;

            if (empty)
            {
                Console.WriteLine("Empty Ok");
                duplicate = false;
            }
            else
            {
                Console.WriteLine("Else isDuplicate");
                foreach (DataGridViewRow row in dgvAtelierParticipants.Rows)
                {
                    if (row.Cells["Nom"].Value.Equals(nomP))
                    {

                        Console.WriteLine("erorr ya jedek");

                        // row exists

                        duplicate = true;
                        break;
                    }
                }
            }


            return duplicate;
        }
    }
}
