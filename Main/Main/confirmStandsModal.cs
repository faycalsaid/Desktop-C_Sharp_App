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
    public partial class confirmStandsModal : UserControl
    {
        private string location;
        private string area;
        private int dbId; //Data base Stand ID;
        private List<Partenaire> partners = new List<Partenaire>();
        public confirmStandsModal(string location, string area, int dbId)
        {
            this.location = location;
            this.area = area;
            this.dbId = dbId;

            this.partners = DAOPartenaires.getAllPartners();

            InitializeComponent();

            this.initValues();

            testInsert();
        }

        public void testInsert()
        {
            DAOStands.atributePartner(2,2);
        }

        private void initValues ()
        {
            localisationTxtBox.Text = this.location;
            areaTxtBox.Text = this.area;

            cBoxPartners.DataSource = partners;
            cBoxPartners.DisplayMember = "Nom";

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Partenaire p = cBoxPartners.SelectedItem as Partenaire;
            Console.WriteLine("Slected Item " + p.Id);
            DAOStands.atributePartner(p.Id,dbId);
        }
    }
}
