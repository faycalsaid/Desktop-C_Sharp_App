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

            String requete = "SELECT Participant.id, nom, prenom, idType, libelle as Type FROM Participant inner join TypeParticipant on idtype = TypeParticipant.id;";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                theParticipants.Add(new Participant(Convert.ToInt32(requeteResult[0]), requeteResult[1].ToString(), requeteResult[2].ToString(), Convert.ToInt32(requeteResult[3]), requeteResult[4].ToString()));
            }
            DB.deconnecter();

            return theParticipants; 
        }

        public static List<TypeParticipant> getAllTypePartcipant()
        {
            List<TypeParticipant> theTypeParticipants = new List<TypeParticipant>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = "SELECT id, libelle FROM TypeParticipant;";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                theTypeParticipants.Add(new TypeParticipant(Convert.ToInt32(requeteResult[0]), requeteResult[1].ToString()));
            }
            DB.deconnecter();

            return theTypeParticipants;
        }



        public static void addParticipant(String nom, String prenom, Int32 idType)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "INSERT INTO Participant  (nom, prenom, id_Hotel) VALUES ('"+nom+ "', '" + prenom + "', '" + idHotel + "')";

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void editParticipant(Int32 id, String nom, String prenom, Int32 idType)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

            string req = "UPDATE Participant SET nom = '" + nom + "', prenom= '" + prenom + "', idType= '" + idType + "'  WHERE id = '" + id + "'";

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
