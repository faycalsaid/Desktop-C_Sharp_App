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
using Main.LogicLayer;
namespace Main
{
    public partial class ModifierAtelierModal : UserControl
    {
        private string libelle;
        private int capacite;
        private DateTime debut;
        private DateTime fin;
        private int atelierId;
        private Atelier atelier;

        private List<Theme> ateliersThemes = new List<Theme>();

        public ModifierAtelierModal(string libelle, int capacite, DateTime debut, DateTime fin, int id)
        {
            this.libelle = libelle;
            this.capacite = capacite;
            this.debut = debut;
            this.fin = fin;
            this.atelierId = id;
            this.ateliersThemes = DAOTheme.getAtelierThemes(id);

            InitializeComponent();
            this.iniValue();

            dataGridViewParticipants.DataSource = DAOAtelier.getAteliersParticipants(id);
            dtgThemeModif.DataSource = DAOTheme.getAtelierThemes(id);

            this.Focus();
 


        }

        public void iniValue()
        {
            txbNomModif.Text = libelle;
            txbModifCapacite.Text = capacite.ToString();
            dtpDebut .Value = debut;
            dtpFin.Value = fin;
        }
        public void clear()
        {
            txbModifCapacite.ResetText();
            txbNomModif.ResetText();
        }


        //Release used ressources and return to the parent control 
        private void cleanAndReturn()
        {
            foreach (Control item in mainForm.Instance.PnlContainer.Controls)
            {

                if (item.Name == "ModifierAtelierModal")
                {
                    mainForm.Instance.PnlContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            foreach (Control item in mainForm.Instance.PnlContainer.Controls)
            {
                if (item.Name == "m2lAteliers")
                {
                    mainForm.Instance.PnlContainer.Controls.Remove(item);
                    item.Dispose(); // Release all the resources used by the control
                    break;
                }
            }

            m2lAteliers ucAtelier = new m2lAteliers();
            ucAtelier.Dock = DockStyle.Fill;
            mainForm.Instance.PnlContainer.Controls.Add(ucAtelier);

            mainForm.Instance.PnlContainer.Controls["m2lAteliers"].BringToFront();
        }


        private void BtnReturnAt_Click(object sender, EventArgs e)
        {
            cleanAndReturn();
        }

        private void BtnAddParticipants_Click(object sender, EventArgs e)
        {
            AtelierUserManaging actualModal = new AtelierUserManaging(atelierId);
            actualModal.Dock = DockStyle.Fill;
            mainForm.Instance.PnlContainer.Controls.Add(actualModal);

            mainForm.Instance.PnlContainer.Controls["AtelierUserManaging"].BringToFront();
        }

        private void DeleteAtelierBtn_Click(object sender, EventArgs e)
        {
            m2lAteliers atelierAjout = new m2lAteliers();

            DAOAtelier.supprimerAtelier(atelierId);

            cleanAndReturn();

        }

        private void ValidateModificationBtn_Click(object sender, EventArgs e)
        {
            m2lAteliers atelierAjout = new m2lAteliers();
            Atelier unAtelier;

            int capactieModif = Convert.ToInt32(txbModifCapacite.Text);

            unAtelier = new Atelier(atelierId, txbNomModif.Text, capactieModif, dtpDebut.Value, dtpFin.Value);

            DAOAtelier.modifierAtelier(unAtelier);

            cleanAndReturn();
        }
    }
}
