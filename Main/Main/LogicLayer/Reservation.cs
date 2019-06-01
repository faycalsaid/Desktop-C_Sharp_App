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
        private Int32 nbJours;



        public Reservation(Int32 idReservation, Int32 idParticipant, Int32 idHotel, Int32 nbJours)
        {
            this.IdReservation = idReservation;
            this.IdParticipant = idParticipant;
            this.IdHotel = idHotel;
            this.NbJours = nbJours;
        }


        public int IdReservation { get => idReservation; set => idReservation = value; }
        public int IdParticipant { get => idParticipant; set => idParticipant = value; }
        public int IdHotel { get => idHotel; set => idHotel = value; }
        public int NbJours { get => nbJours; set => nbJours = value; }
    }
}
