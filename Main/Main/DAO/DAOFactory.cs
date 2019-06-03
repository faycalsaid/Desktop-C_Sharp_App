using System;
using System.Data.SqlClient;

namespace Main.DAO
{
    class DAOFactory
    {
        SqlConnection maConnexion;


        public void connexion()
        {
            maConnexion = new SqlConnection("Data Source =172.17.21.10; Initial Catalog = SIO2_M2L_TeamB; User Id = SIO2-dev; Password = btssio-slam-2019; ");
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

            SqlCommand maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = maConnexion;

            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = maCommand;

            SqlDataReader myDReader;
            myDReader = maCommand.ExecuteReader();


            return myDReader;

        }

        public SqlDataAdapter singleRowResult(string request)
        {
            SqlDataAdapter sda = new SqlDataAdapter(request, maConnexion);

            return sda;
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

