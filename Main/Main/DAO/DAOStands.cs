using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Main.DAO
{
    static class DAOStands
    {

        public static List<Stands> getAllStands()
        {
            List<Stands> standsList = new List<Stands>();

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            //Using the @ (verbatim literal) to eliminate all the quotes and concatenations
            String requete = @"SELECT  *,  
                            CASE
                            WHEN id_partenaire is NULL THEN   'FREE'
                            WHEN id_partenaire is not NULL THEN   'BOOKED'
                            ELSE 'ERROR'
                            END AS  available
                            FROM  dbo.stand
							left JOIN dbo.Partenaire 
							ON stand.id_partenaire = Partenaire.id;";



            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {
                if (requeteResult[8].ToString() == "FREE")
                {
                    standsList.Add(new Stands(Convert.ToInt16(requeteResult[0]), float.Parse(requeteResult[1].ToString()),
                        Convert.ToInt16(requeteResult[2]), Convert.ToChar(requeteResult[3]), true));
                }
                else
                {
                    standsList.Add(new Stands(Convert.ToInt16(requeteResult[0]), float.Parse(requeteResult[1].ToString()),
                        Convert.ToInt16(requeteResult[2]), Convert.ToChar(requeteResult[3]), false,
                        new Partenaire(Convert.ToInt16(requeteResult[5]), requeteResult[6].ToString(), requeteResult[7].ToString())));
                }

            }

            return standsList;
        }

        public static void atributePartner(int partnerId ,int standId )
        {
            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            //Using the @ (verbatim literal) to eliminate all the quotes and concatenations
            String requete = "UPDATE Stand SET id_partenaire = " + partnerId + "where id = " + standId + ";" ;

            DB.execSqlWrite(requete);


        }








    }
}

