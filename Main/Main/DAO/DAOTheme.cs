using Main.LogicLayer;
using System;
using System.Collections.Generic;
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
    }
}
