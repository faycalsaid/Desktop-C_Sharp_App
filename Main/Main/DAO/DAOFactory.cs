using System;
using System.Data.SqlClient;

namespace Main.DAO
{
    class DAOFactory
    {
        SqlConnection maConnexion;


        public void connexion()
        {
            maConnexion = new SqlConnection("Data Source =(localdb)\\LocaldbASL; Initial Catalog = M2L_Test; User Id = admin; Password = Mahfoud69; ");
        }

        public void connecter()
        {
            maConnexion.Open(); //dddddd
        }

        public void deconnecter()
        {
            maConnexion.Close();
        }

        public SqlDataReader execSqlRead(string requete)
        {
            Console.WriteLine("The connexion " + maConnexion);

            SqlCommand maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = maConnexion;

            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = maCommand;

            SqlDataReader myDReader;
            myDReader = maCommand.ExecuteReader();


            return myDReader;

        }

        public void execSqlWrite(string requete)
        {
            SqlCommand maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = maConnexion;

            maCommand.ExecuteNonQuery();
        }
    }
}

