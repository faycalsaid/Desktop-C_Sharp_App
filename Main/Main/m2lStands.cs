using Bunifu.Framework.UI;
using Main.DAO;
using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public partial class m2lStands : UserControl
    {
        private List<Stands> standsList = DAOStands.getAllStands();
        private List<Partenaire> partnersList = DAOPartenaires.getAllPartners();
        private string[] partnersNouns = DAOPartenaires.partnersNouns().ToArray();
        public m2lStands()
        {
            InitializeComponent();

            initFlowLayout();
        }

        //initialize the flowLayout with cards
        public void initFlowLayout()
        {
           
            for (int i = 0; i < standsList.Count(); i++)
            {
                BunifuCards card = generateCard(i);
                this.flowLayoutPanel1.Controls.Add(card);
                this.flowLayoutPanel1.Dock = DockStyle.Fill;
            }
        }

        // generate cards as much as available stands in the database
        // works as a controller for generating cards
        private BunifuCards generateCard(int i)
        {
            BunifuCards card = new BunifuCards();
            card.Name = "bCards_" + i.ToString();
            card.Size = new Size(157, 188);
            card.color = Color.BlueViolet;
            card.Margin = new Padding(5, 2, 5, 2);
            card.Controls.Add(generateAreaLabel(i));
            card.Controls.Add(generateLocationLabel(i));
            card.Controls.Add(generatAreaValueLabel(i));
            card.Controls.Add(generateLocationValueLabel(i));

            if (standsList[i].Available)
            {
                card.Controls.Add(generateAvailabilityIcon(i));
                card.Controls.Add(generatetAributeStandBtn(i));
                //card.Controls.Add(generatePartnersList(i));
            }
            else
            {
                card.Controls.Add(generateUnavailabilityIcon(i));
                card.Controls.Add(generatePartnerLabel(i));

            }
            Console.WriteLine("Card Id :" + card.Name.Last().ToString());
            return card;
        }

        private BunifuCustomLabel generateAreaLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "bLabel_Area_" + i.ToString();
            label.Text = "Surface";
            label.Location = new Point(3, 26);
            label.AutoSize = true;

            return label;
        }

        //Generate a label with the area of the stands
        private BunifuCustomLabel generatAreaValueLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "bLabel_Area_Value" + i.ToString();
            label.Text = standsList[i].Area.ToString() + " M²";
            label.Location = new Point(92, 26);
            label.AutoSize = true;

            return label;
        }

        private BunifuCustomLabel generateLocationLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "bLabel_Location_" + i.ToString();
            label.Text = "Localisation";
            label.Location = new Point(3, 45);
            label.AutoSize = true;

            return label;
        }

        private BunifuCustomLabel generateLocationValueLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "bLabel_Location_Value_" + i.ToString();
            label.Text = standsList[i].NumAllee.ToString() + " " + standsList[i].NumOrdre.ToString();
            label.Location = new Point(92, 43);
            label.AutoSize = true;
            label.ForeColor = System.Drawing.Color.Red;

            return label;
        }

        private BunifuImageButton generateAvailabilityIcon(int i)
        {
            BunifuImageButton icon = new BunifuImageButton();
            icon.BackColor = Color.Transparent;
            icon.Name = "bImage_AvailableIcon" + i.ToString();
            icon.Image = global::Main.Properties.Resources.availableBooking;
            icon.Location = new Point(113, 145);
            icon.ImageActive = null;
            icon.Size = new System.Drawing.Size(32, 31);
            icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            icon.TabIndex = 1;
            icon.TabStop = false;
            icon.Zoom = 10;


            return icon;
        }

        private BunifuImageButton generateUnavailabilityIcon(int i)
        {
            BunifuImageButton icon = new BunifuImageButton();
            icon.BackColor = System.Drawing.Color.Transparent;
            icon.Name = "bImage_AvailableIcon" + i.ToString();
            icon.Image = global::Main.Properties.Resources.notAvailable;
            icon.Location = new Point(113, 145);
            icon.ImageActive = null;
            icon.Size = new System.Drawing.Size(32, 31);
            icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            icon.TabIndex = 1;
            icon.TabStop = false;
            icon.Zoom = 10;


            return icon;
        }

        //Generate a label of the owner of the stand if it's booked
        private BunifuCustomLabel generatePartnerLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "bLabel_Partner_" + i.ToString();
            label.Text = standsList[i].Partenaire.Nom;
            label.Location = new Point(3, 145);
            label.AutoSize = true;

            return label;
        }


        //private BunifuDropdown generatePartnersList(int i)
        //{
        //    BunifuDropdown dropDown = new BunifuDropdown();
        //    dropDown.Name = "bDropdown_Partners_" + i.ToString();
        //    dropDown.Items = partnersNouns;
        //    dropDown.Location = new Point(23, 96);
        //    dropDown.Size = new Size(101, 42);
        //    dropDown.AutoSize = true;

        //    return dropDown;
        //}

        private BunifuThinButton2 generatetAributeStandBtn(int i)
        {
            BunifuThinButton2 button = new BunifuThinButton2();
            button.Name = "attributeBtn_" + i.ToString();
            button.Click += new EventHandler(this.generateStandAffectModal);
            button.Size = new Size(114, 39);
            button.Location = new Point(18, 72);
            return button;
        }


        private void generateStandAffectModal(object sender, System.EventArgs e)
        {
          
            var btn = sender as BunifuThinButton2;
            var i = int.Parse(btn.Name.Last().ToString());

            string location = standsList[i].NumAllee.ToString() + " " + standsList[i].NumOrdre.ToString();
            string area = standsList[i].Area.ToString() + " M²";
            int id = standsList[i].Id;

            confirmStandsModal actualModal = new confirmStandsModal(location, area, id);
            actualModal.Dock = DockStyle.Fill;
            mainForm.Instance.PnlContainer.Controls.Add(actualModal);

            mainForm.Instance.PnlContainer.Controls["confirmStandsModal"].BringToFront();
            mainForm.Instance.ReturnButton.Visible = true;


           
        }

    }
}
