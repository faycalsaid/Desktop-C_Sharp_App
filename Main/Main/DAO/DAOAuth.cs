using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAO
{
    class DAOAuth
    {
        public static bool exist(string login, string pwd)
        {
            bool exist = false;

            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = "SELECT COUNT(*) FROM gestionnaires WHERE login = '" + login + "' and pwd = '" + pwd + "';";

            

            SqlDataAdapter requeteResult = DB.singleRowResult(requete);

            DataTable dt = new DataTable();

            requeteResult.Fill(dt);


            if (int.Parse(dt.Rows[0][0].ToString()) == 1)
            {
                exist = true;
            }


            DB.deconnecter();

            

            return exist;
        }

    }
}
