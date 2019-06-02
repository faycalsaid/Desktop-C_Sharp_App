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
        private int id;

        private List<Theme> MesThemes = new List<Theme>();

        public ModifierAtelierModal(string libelle, int capacite, DateTime debut, DateTime fin, int id, List<Theme> MesThemes)
        {
            this.libelle = libelle;
            this.capacite = capacite;
            this.debut = debut;
            this.fin = fin;
            this.id = id;
            this.MesThemes = MesThemes;

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
            dtgThemeModif.DataSource = mesThemes();


        }

        public  List<Theme>mesThemes()
        {
            
                return MesThemes;
            
        }
        public void clear()
        {
            txbModifCapacite.Text = String.Empty;
            txbNomModif.Text = String.Empty;
        }

        private void btnModifValid_Click(object sender, EventArgs e)
        {
            Atelier unAtelier;
            DAOAtelier atelier = new DAOAtelier();
            
            int capactieModif = Convert.ToInt32(txbModifCapacite.Text);

            unAtelier = new Atelier(id, txbNomModif.Text,capactieModif, dtpDebut.Value, dtpFin.Value,MesThemes);

            atelier.modifierAtelier(unAtelier);
          
        }

       
    }
}
