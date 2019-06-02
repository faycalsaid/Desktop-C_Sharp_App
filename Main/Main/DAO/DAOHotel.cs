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


        public static void addHotel(String nom, String adresse)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "INSERT INTO Hotel (nom, adresse) VALUES ('" + nom + "', '" + adresse + "')";

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void editHotel(Int32 id, String nom, String adresse)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "UPDATE Hotel SET nom = '" + nom + "', adresse= '" + adresse + "' WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void delHotel(Int32 id)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "DELETE FROM Hotel WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }
    }
}
