using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.LogicLayer
{
    public class Theme
    {
        private int id ;
        private string libelle;
   

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




        public Theme(int unid, string unlibelle)
        {
            Id = unid;
            Libelle = unlibelle;
            

        }
    }

   
}
