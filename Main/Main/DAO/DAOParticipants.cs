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
    class DAOParticipants
    {

        public static List<Participant> getAllParticipants()
        {
            List<Participant> theParticipants = new List<Participant>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = "SELECT id, nom, prenom, id_Hotel FROM Participant;";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                theParticipants.Add(new Participant(Convert.ToInt32(requeteResult[0]), requeteResult[1].ToString(), requeteResult[2].ToString(), Convert.ToInt32(requeteResult[3])));
            }
            DB.deconnecter();

            return theParticipants; 
        }

        public static void addParticipant(String nom, String prenom, Int32 idHotel)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "INSERT INTO Participant  (nom, prenom, id_Hotel) VALUES ('"+nom+ "', '" + prenom + "', '" + idHotel + "')";
            Console.WriteLine(req);

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void editParticipant(Int32 id, String nom, String prenom, Int32 idHotel)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "UPDATE Participant SET nom = '" + nom + "', prenom= '" + prenom + "', id_Hotel= '" + idHotel + "'  WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void delParticipant(Int32 id)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "DELETE FROM Participant WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }

    }
}
