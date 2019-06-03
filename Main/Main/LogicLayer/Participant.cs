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
        private Int32 idType;
        private String libelleType;

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

        public int IdType
        {
            get
            {
                return idType;
            }

            set
            {
                idType = value;
            }
        }

        public string LibelleType
        {
            get
            {
                return libelleType;
            }

            set
            {
                libelleType = value;
            }
        }

        public String ToStringName()
        {
            return LastNameParticipant + FirstNameParticipant;
        }

        public Participant(Int32 idParticipant, string firstNameParticipant, string lastNameParticipant, Int32 idType, String libelleType)
        {
            this.IdParticipant = idParticipant;
            this.FirstNameParticipant = firstNameParticipant;
            this.LastNameParticipant = lastNameParticipant;
            this.IdType = idType;
            this.LibelleType = libelleType;
        }
    }
}
