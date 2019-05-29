using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.LogicLayer
{
    class Hotel
    {
        private Int32 idHotel;
        private String name;
        private String adress;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public Hotel(Int32 idHotel, String name, String adress)
        {
            this.IdHotel = idHotel;
            this.Name = name;
            this.Adress = adress;
        }
    }
}
