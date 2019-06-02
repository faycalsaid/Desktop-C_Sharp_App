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
using Bunifu.Framework.UI;

namespace Main
{
    public partial class m2lAteliers : UserControl
    {
        List<Atelier> MesAtelier = DAOAtelier.getAllAteliers();
        

        public m2lAteliers()
        {
            InitializeComponent();

            InitialisationFlow();
        }


        private void InitialisationFlow()
        {
            for (int i = 0; i < MesAtelier.Count(); i++)
            {
                BunifuCards card = addCard(i);
                this.flowLayoutPanel5.Controls.Add(card);
            }
        }


        private BunifuCards addCard(int i)
        {
            BunifuCards card = new BunifuCards();
            card.Name = "buCards_" + i.ToString();
            card.Size = new Size(564, 220);
            card.Controls.Add(addTitreLabel(i));
            card.Controls.Add(addCapaciteLabel(i));
            card.Controls.Add(addCapaciteValueLabel(i));
            card.Controls.Add(addDateDebut(i));
            card.Controls.Add(addDateFin(i));
            card.Controls.Add(addButtonModifier(i));
            card.Controls.Add(addSeparator(i));
            card.Controls.Add(addButtonSupprimer(i));


            return card;
        }



        private BunifuCustomLabel addTitreLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "buLabel_Libelle_" + i.ToString();
            label.Text = MesAtelier[i].Libelle.ToString();
            label.Location = new Point(206, 14);
            label.AutoSize = true;

            return label;
        }

        private BunifuSeparator addSeparator(int i)
        {
            BunifuSeparator separator = new BunifuSeparator();
            separator.Name = "buSeparator_" + i.ToString();
            separator.Location = new Point(61, 35);
            separator.Size = new Size(425, 28);

            return separator;

        }


        private BunifuCustomLabel addCapaciteLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "buLabel_Capacite_" + i.ToString();
            label.Text = "Capacité";
            label.Location = new Point(104, 71);
            label.AutoSize = true;

            return label;
        }

        private BunifuCustomLabel addCapaciteValueLabel(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "buLabel_Value_Capacite_" + i.ToString();
            label.Text = MesAtelier[i].Capacite.ToString();
            label.Location = new Point(287, 71);
            label.AutoSize = true;

            return label;
        }

        private BunifuCustomLabel addLabelAu(int i)
        {
            BunifuCustomLabel label = new BunifuCustomLabel();
            label.Name = "buLabelD_" + i.ToString();
            label.Text = "au";
            label.Location = new Point(4, 91);
            label.AutoSize = true;

            return label;

        }

       


        private BunifuCustomLabel addDateDebut(int i)
        {
            BunifuCustomLabel date = new BunifuCustomLabel();
            date.Name = "buLabel_Value_DateDebut_" + i.ToString();
            date.Text = MesAtelier[i].HoraireDebut.ToString();
            date.Location = new Point(63, 123);
            date.AutoSize = true;

            return date;
        }


        private BunifuCustomLabel addDateFin(int i)
        {
            BunifuCustomLabel date = new BunifuCustomLabel();
            date.Name = "buLabel_Value_DateFin_" + i.ToString();
            date.Text = MesAtelier[i].HoraireFin.ToString();
            date.Location = new Point(349, 123);
            date.AutoSize = true;

            return date;
        }

        private BunifuFlatButton addButtonModifier(int i)
        {
            BunifuFlatButton Button = new BunifuFlatButton();
            Button.Name = "buFlatButton_" + i.ToString();
            Button.ButtonText = "Modifier";
            Button.Text = "Modifier";
            Button.TextAlign =ContentAlignment.MiddleLeft;
            Button.Location = new Point(49, 157);
            Button.Size = new Size(142, 44);
            Button.Activecolor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            Button.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            Button.Click += new System.EventHandler(bunifuFlatButton1_Click);
            return Button;
        }


        private BunifuFlatButton addButtonSupprimer(int i)
        {
            BunifuFlatButton Button = new BunifuFlatButton();
            Button.Name = "buFlatButton_supp_" + i.ToString();
            Button.ButtonText = "Supprmier";
            Button.Text = "Supprimer";
            Button.TextAlign = ContentAlignment.MiddleLeft;
            Button.Location = new Point(209, 157);
            Button.Size = new Size(142, 44);
            Button.Activecolor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            Button.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            Button.Click += new System.EventHandler(bunifuFlatButton2_Click);
            return Button;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var btn = sender as BunifuFlatButton;
            var i = int.Parse(btn.Name.Last().ToString());
            List<Theme> MesThemes = new List<Theme>();

            string libelle = MesAtelier[i].Libelle.ToString();
            int capacite = MesAtelier[i].Capacite;
            DateTime debut = MesAtelier[i].HoraireDebut;
            DateTime fin = MesAtelier[i].HoraireFin;
            MesThemes = MesAtelier[i].LesThemes;

            int id = MesAtelier[i].Id;

            ModifierAtelierModal atelierModif = new ModifierAtelierModal(libelle, capacite, debut, fin,id);
            atelierModif.Dock = DockStyle.Fill;
            mainForm.Instance.PnlContainer.Controls.Add(atelierModif);

            mainForm.Instance.PnlContainer.Controls["ModifierAtelierModal"].BringToFront();
            mainForm.Instance.ReturnButton.Visible = true;


        }

        private void bunifubtnAjouter_Click(object sender, EventArgs e)
        {
            
            

                AjouterAtelier atelierAjout = new AjouterAtelier();
                atelierAjout.Dock = DockStyle.Fill;
                mainForm.Instance.PnlContainer.Controls.Add(atelierAjout);

                mainForm.Instance.PnlContainer.Controls["AjouterAtelier"].BringToFront();
                mainForm.Instance.ReturnButton.Visible = true;
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DAOAtelier suppr = new DAOAtelier();

            var btn = sender as BunifuFlatButton;
            var i = int.Parse(btn.Name.Last().ToString());

            Console.WriteLine(Parent.Name);
            


            int id = MesAtelier[i].Id;




            suppr.supprimerAtelier(id);

            Form a = new Form();

            foreach (Control item in flowLayoutPanel5.Controls)
            {

                if (item.Name == "i")
                {
                    flowLayoutPanel5.Controls.Remove(item);
                    break; //important step
                }
            }

        }
    }
}
    

