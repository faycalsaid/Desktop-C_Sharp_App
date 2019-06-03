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
    class DAOReservation
    {
        public static List<Reservation> getAllReservation()
        {
            List<Reservation> theReservation = new List<Reservation>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

                String requete = "SELECT ReservationHotel.id, idParticipant, idHotel, nbJour, Participant.nom, prenom, Hotel.nom " +
                "FROM ReservationHotel inner join Participant on idParticipant = Participant.id inner join Hotel on idHotel = Hotel.id;";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

                while (requeteResult.Read())
                {
                Reservation uneReservation = new Reservation(Convert.ToInt32(requeteResult[0]),
                    Convert.ToInt32(requeteResult[1]),
                    Convert.ToInt32(requeteResult[2]),
                    Convert.ToInt32(requeteResult[3]));

                    uneReservation.Nom = requeteResult[4].ToString();
                    uneReservation.Prenom = requeteResult[5].ToString();
                    uneReservation.NameHotel = requeteResult[6].ToString();

                    theReservation.Add(uneReservation);
                    
                    
                }
                DB.deconnecter();

            return theReservation;
        }

        public static void addReservation(Int32 idParticipant, Int32 idHotel, Int32 nbJour)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

                string req = "INSERT INTO ReservationHotel (idParticipant, idHotel, nbJour) VALUES ('" + idParticipant + "', '" + idHotel + "', '" + nbJour + "')";
                Console.WriteLine(req);

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void editReservation(Int32 id, Int32 idParticipant, Int32 idHotel, Int32 nbJour)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

                string req = "UPDATE ReservationHotel SET idParticipant= '" + idParticipant + "', idHotel= '" + idHotel + "', nbJour= '" + nbJour + "' WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }

        public static void delReservation(Int32 id)
        {
            DAOFactory db = new DAOFactory();

            db.connexion();
            db.connecter();

                string req = "DELETE FROM ReservationHotel WHERE id = '" + id + "'";

            db.execSqlWrite(req);
            db.deconnecter();
        }
    }
}
