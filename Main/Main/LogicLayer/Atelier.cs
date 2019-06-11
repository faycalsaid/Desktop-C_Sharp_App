using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.LogicLayer
{
    class Atelier
    {
        #region Propriété privée
        //Propriété privée

        private int id;
        private string libelle;
        private int capacite;
        private DateTime horaireDebut;
        private DateTime horaireFin;
     
        private List<Theme> lesThemes;


        #endregion

        #region Accesseurs
        //Accesseurs
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public int Capacite
        {
            get
            {
                return capacite;
            }

            set
            {
                capacite = value;
            }
        }

        public DateTime HoraireDebut
        {
            get
            {
                return horaireDebut;
            }

            set
            {
                horaireDebut = value;
            }
        }

        public DateTime HoraireFin
        {
            get
            {
                return horaireFin;
            }

            set
            {
                horaireFin = value;
            }
        }

        

       
        public List<Theme> LesThemes
        {
            get
            {
                return lesThemes;
            }


        }

       

        public void ajouterTheme(Theme unTheme)
        {
            lesThemes.Add(unTheme);

        }






        #endregion


        #region Méthodes publique
        // Méthodes publique
        public Atelier(int unId, string unLibelle, int uneCapacite, DateTime unHoraireDebut, DateTime unHoraireFin)
        {
            this.id = unId;
            this.libelle = unLibelle;
            this.capacite = uneCapacite;
            this.horaireDebut = unHoraireDebut;
            this.horaireFin = unHoraireFin;

        }

        public Atelier(string unLibelle, int uneCapacite, DateTime unHoraireDebut, DateTime unHoraireFin)
        {
            this.libelle = unLibelle;
            this.capacite = uneCapacite;
            this.horaireDebut = unHoraireDebut;
            this.horaireFin = unHoraireFin;

        }

        public Atelier()
        {
        }


        #endregion
    }
}


