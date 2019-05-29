using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Main.DAO
{
    class DAOPartenaires
    {
        public static List<Partenaire> getAllPartners()
        {
            List<Partenaire> partnersList = new List<Partenaire>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            //Using the @ (verbatim literal) to eliminate all the quotes and concatenations
            String requete = "SELECT * from Partenaire";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                partnersList.Add(new Partenaire(Convert.ToInt16(requeteResult[0]), requeteResult[1].ToString(), requeteResult[2].ToString()));
            }

            return partnersList;
        }

        public static List<string> partnersNouns()
        {
            List<string> partnersNouns = new List<string>();


            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            //Using the @ (verbatim literal) to eliminate all the quotes and concatenations
            String requete = "SELECT nom from Partenaire";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                partnersNouns.Add(requeteResult[0].ToString());
            }

            return partnersNouns;


        }

    }
}
