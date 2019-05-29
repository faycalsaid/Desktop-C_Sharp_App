using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.LogicLayer
{
    class Participant
    {
        private Int32 idParticipant;
        private String firstNameParticipant;
        private String lastNameParticipant;
        private Int32 idHotel;

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

        public string FirstNameParticipant
        {
            get
            {
                return firstNameParticipant;
            }

            set
            {
                firstNameParticipant = value;
            }
        }

        public string LastNameParticipant
        {
            get
            {
                return lastNameParticipant;
            }

            set
            {
                lastNameParticipant = value;
            }
        }

        public Int32 IdHotel
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

        public Participant(Int32 idParticipant, string firstNameParticipant, string lastNameParticipant, Int32 idHotel)
        {
            this.IdParticipant = idParticipant;
            this.FirstNameParticipant = firstNameParticipant;
            this.LastNameParticipant = lastNameParticipant;
            this.idHotel = idHotel;
        }
    }
}
