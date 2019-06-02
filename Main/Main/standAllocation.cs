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
using MaterialSkin.Controls;

namespace Main
{
    public partial class standAllocation : UserControl
    {
        private string location;
        private string area;
        private int dbId; //Data base Stand ID;
        private bool available;
        private List<Partenaire> partners = new List<Partenaire>();
        public standAllocation(string location, string area, int dbId, bool available)
        {
            this.location = location;
            this.area = area;
            this.dbId = dbId;
            this.available = available;

            this.partners = DAOPartenaires.getAllPartners();

            InitializeComponent();

            this.initValues();

        }
        private void initValues ()
        {
            cBoxPartners.DataSource = partners;
            cBoxPartners.DisplayMember = "Nom";
            initLabels();

            if(available)
            {
                Console.WriteLine("Passed");
                cleanModal();
            }

        }

        private void initLabels()
        {
            mtrlLabelLocalisation.Text = this.location;
            mtrlLabelLocalisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mtrlLabelLocalisation.ForeColor = System.Drawing.Color.OrangeRed;
            mtrlLabelArea.Text = this.area;
            mtrlLabelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mtrlLabelArea.ForeColor = System.Drawing.Color.OrangeRed;
        }

        private void AttributeButton_Click(object sender, EventArgs e)
        {
            Partenaire p = cBoxPartners.SelectedItem as Partenaire;
            DAOStands.atributePartner(p.Id, dbId);
        }

        private void CBoxPartners_SelectedValueChanged(object sender, EventArgs e)
        {
            Partenaire p = cBoxPartners.SelectedItem as Partenaire;
            mtrlLabelPartner.Text = p.Nom;
            mtrlLabelCity.Text = p.Ville;
        }

        private void UnassignBtn_Click(object sender, EventArgs e)
        {
            DAOStands.unassignPartner(dbId);
            cleanModal();
        }

        private void cleanModal()
        {
            mtrlLabelPartner.ResetText();
            mtrlLabelCity.ResetText();
            cBoxPartners.ResetText();
        }

    }
}
