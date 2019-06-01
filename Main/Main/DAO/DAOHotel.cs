using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.LogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace Main.DAO
{
    class DAOHotel
    {
        public static List<Hotel> getAllHotels()
        {
            List<Hotel> theHotels = new List<Hotel>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = "SELECT id, nom, adresse FROM Hotel;";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                theHotels.Add(new Hotel(Convert.ToInt32(requeteResult[0]), requeteResult[1].ToString(), requeteResult[2].ToString()));
            }
            DB.deconnecter();

            return theHotels;
        }
    }
}
