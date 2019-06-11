using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main.DAO
{
    static class DAOAtelier
    {

        public static List<Atelier> getAllAteliers()
        {
            List<Atelier> ateliers = new List<Atelier>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = @"SELECT  * from Atelier";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {

                ateliers.Add(new Atelier(Convert.ToInt16(requeteResult[0]), requeteResult[1].ToString(),
                    Convert.ToInt16(requeteResult[2]), Convert.ToDateTime(requeteResult[3]), Convert.ToDateTime(requeteResult[4])));

            }


            return ateliers;

        }

        public static DataTable getAllParticipants()
        {
            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = @"SELECT Participant.id AS idParticipant, nom, prenom, idType, libelle as Type 
                            FROM Participant inner join TypeParticipant on idtype = TypeParticipant.id;";

            SqlDataAdapter requeteResult = DB.execSqlDataTableRequest(requete);

            DataTable dt = new DataTable();

            requeteResult.Fill(dt);

            DB.deconnecter();



            return dt;
        }

        public static void creerAtelier(Atelier unAtelier)
        {
            DAOFactory fa = new DAOFactory();
            fa.connexion();
            fa.connecter();

            string requete = "insert into Atelier (libelle, capacite, horaireDebut, horaireFin) values ('" + unAtelier.Libelle + "','" + unAtelier.Capacite + "','"
    + Convert.ToDateTime(unAtelier.HoraireDebut) + "','" +Convert.ToDateTime(unAtelier.HoraireFin)+ "');";

            fa.execSqlWrite(requete);
            fa.deconnecter();
        }

        public static void modifierAtelier(Atelier unAtelier)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();

            dao.connecter();
            string requete = "update Atelier set libelle = '" + unAtelier.Libelle + "', capacite = '" + unAtelier.Capacite + "', horaireDebut ='" + unAtelier.HoraireDebut + "', horaireFin = '" + unAtelier.HoraireFin +"' where id = '" + unAtelier.Id + "'";

            dao.execSqlWrite(requete);
            dao.deconnecter();
        }


        public static void supprimerAtelier(int atelierId)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();

            dao.connecter();
            string requete = @"delete from Theme_atelier where id_atelier ="+ atelierId + ";"
                                + "delete from Atelier where id =" + atelierId + ";";

            dao.execSqlWrite(requete);
            dao.deconnecter();
        }

        public static void deleteParticipant(string nom, string prenom, int idAtelier)
        {
            DAOFactory db = new DAOFactory();
            db.connexion();

            db.connecter();
            string requete = @"DELETE FROM Participe WHERE	id_Participant in 
                            (SELECT id  FROM Participant WHERE nom = '" + nom + "' AND prenom = '" + prenom + "') " +
                            "AND id_Atelier = " + idAtelier;

            db.execSqlWrite(requete);
            db.deconnecter();
        }

        public static void addParticipant(int participantId, int atelierId)
        {
            DAOFactory db = new DAOFactory();
            db.connexion();

            db.connecter();
            string requete = "INSERT INTO Participe VALUES ( "+ participantId + "," + atelierId + "); ";

            db.execSqlWrite(requete);
            db.deconnecter();
        }
        public static DataTable getAteliersParticipants(int atelierId)
        {
            bool exist = false;

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = @"SELECT P.nom AS Nom, P.prenom AS Prenom, TP.libelle AS TypeParticipant, H.nom AS Hotel, H.adresse AS HotelAdress  FROM Participant P INNER JOIN Hotel H 
                            ON P.id_Hotel = H.id
                            INNER JOIN TypeParticipant TP ON P.idType = TP.id
                            INNER JOIN Participe PR ON P.id = PR.id_Participant
                            WHERE PR.id_Atelier =" + atelierId + " ;";

            SqlDataAdapter requeteResult = DB.execSqlDataTableRequest(requete);

            DataTable dt = new DataTable();

            requeteResult.Fill(dt);

            DB.deconnecter();

            Console.WriteLine("Passed in DAO");



            return dt;
        }
    }


}


    

