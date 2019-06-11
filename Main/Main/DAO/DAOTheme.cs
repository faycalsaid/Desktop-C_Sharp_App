using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAO
{
    class DAOTheme
    {

      

        public void creerTheme(Theme unTheme)
        {
            DAOFactory fa = new DAOFactory();
            fa.connexion();
            fa.connecter();

            string requete = "insert into Theme (libelle) values ('" + unTheme.Libelle + "');";

            fa.execSqlWrite(requete);
            fa.deconnecter();
        }

        public void modifierThemer(Theme unTheme)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();

            dao.connecter();
            string requete = "update Atelier set libelle = '" + unTheme.Libelle + "' where id = '" + unTheme.Id + "'";

            dao.execSqlWrite(requete);
            dao.deconnecter();
        }

        public static List<Theme> getAtelierThemes(int atelierId)
        {
            List<Theme> themes = new List<Theme>();


            DAOFactory DB = new DAOFactory();
            DB.connexion();
            DB.connecter();

            String requete = "select id, libelle from theme where id_atelier = " + atelierId + ";";

            SqlDataReader requeteResult = DB.execSqlRead(requete);

            while (requeteResult.Read())
            {

                themes.Add( new Theme(Convert.ToInt16(requeteResult[0]), requeteResult[1].ToString()) );

            }

            return themes;
        }
    }
}
