using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.LogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace Main.LogicLayer
{
    class TypeParticipant
    {
        private Int32 idTypeParticipant;
        private String libelle;

        public TypeParticipant(Int32 idTypeParticipant, String libelle)
        {
            this.IdTypeParticipant = idTypeParticipant;
            this.Libelle = libelle;
        }

        public int IdTypeParticipant
        {
            get
            {
                return idTypeParticipant;
            }

            set
            {
                idTypeParticipant = value;
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
    }
}
