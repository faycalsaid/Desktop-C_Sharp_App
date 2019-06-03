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
    public partial class AjouterAtelier : UserControl
    {
        public AjouterAtelier()
        {
            InitializeComponent();
        }

        
        private void btnAjoutValid_Click_1(object sender, EventArgs e)
        {
            m2lAteliers atelierAjout = new m2lAteliers();
            Atelier unAtelier;
            DAOAtelier ajouter = new DAOAtelier();

            int capaciteAjout = Convert.ToInt32(txbCapaciteAjouter.Text);

            unAtelier = new Atelier(txbNomAjouter.Text, capaciteAjout, dtpdebutAjouter.Value, dtpFinAjouter.Value);

            ajouter.creerAtelier(unAtelier);

            atelierAjout.Refresh();
        }
    }
}
