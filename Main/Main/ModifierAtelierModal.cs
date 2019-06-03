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

            this.Focus();


        }

        public void iniValue()
        {
            txbNomModif.Text = libelle;
            txbModifCapacite.Text = capacite.ToString();
            dtpDebut .Value = debut;
            dtpFin.Value = fin;
            dtgThemeModif.DataSource = this.ateliersThemes;


        }

        public  List<Theme>mesThemes()
        {
            
                return ateliersThemes;
            
        }
        public void clear()
        {
            txbModifCapacite.ResetText();
            txbNomModif.ResetText();
        }

        private void btnModifValid_Click(object sender, EventArgs e)
        {
            m2lAteliers atelierAjout = new m2lAteliers();
            Atelier unAtelier;
            DAOAtelier atelier = new DAOAtelier();
            
            int capactieModif = Convert.ToInt32(txbModifCapacite.Text);

            unAtelier = new Atelier(atelierId, txbNomModif.Text,capactieModif, dtpDebut.Value, dtpFin.Value);

            atelier.modifierAtelier(unAtelier);

            atelierAjout.Refresh();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DAOAtelier suppr = new DAOAtelier();
            m2lAteliers atelierAjout = new m2lAteliers();

            suppr.supprimerAtelier(atelierId);

           


                

            

        




        }

        private void BtnReturnAt_Click(object sender, EventArgs e)
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
    }
}
