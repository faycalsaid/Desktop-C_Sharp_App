using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.LogicLayer
{
    class Reservation
    {
        private Int32 idReservation;
        private Int32 idParticipant;
        private Int32 idHotel;
        
        private String nom;
        private String prenom;
        private String nameHotel;

        private Int32 nbJours;

        public Reservation(Int32 idReservation, Int32 idParticipant, Int32 idHotel, Int32 nbJours)
        {
            this.IdReservation = idReservation;
            this.IdParticipant = idParticipant;
            this.IdHotel = idHotel;
            this.nbJours = nbJours;
        }


        public int IdReservation
        {
            get
            {
                return idReservation;
            }

            set
            {
                idReservation = value;
            }
        }

        public int IdParticipant
        {
            get
            {
                return idParticipant;
            }

            set
            {
                idParticipant = value;
            }
        }

        public int IdHotel
        {
            get
            {
                return idHotel;
            }

            set
            {
                idHotel = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string NameHotel
        {
            get
            {
                return nameHotel;
            }

            set
            {
                nameHotel = value;
            }
        }

   

    }
}
