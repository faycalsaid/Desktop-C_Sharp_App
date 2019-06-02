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
            Atelier unAtelier;
            DAOAtelier atelier = new DAOAtelier();
            
            int capactieModif = Convert.ToInt32(txbModifCapacite.Text);

            unAtelier = new Atelier(atelierId, txbNomModif.Text,capactieModif, dtpDebut.Value, dtpFin.Value);

            atelier.modifierAtelier(unAtelier);
          
        }

       
    }
}
