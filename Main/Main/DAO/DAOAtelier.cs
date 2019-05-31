using Main.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main.DAO
{
    class DAOAtelier
    {

        public static List<Atelier> getallatelier()
        {
            List<Atelier> MesAtelier = new List<Atelier>();
            DAOFactory fa = new DAOFactory();
            fa.connexion();
            fa.connecter();
            string requete = (" SELECT * from Atelier ");
            SqlDataReader monDR = fa.execSqlRead(requete);


            while (monDR.Read())
            {
                Atelier monAtelier = new Atelier(Convert.ToInt32(monDR[0]), monDR[1].ToString(), Convert.ToInt32(monDR[2]), Convert.ToDateTime(monDR[3]), Convert.ToDateTime(monDR[4]));
                MesAtelier.Add(monAtelier);
            }


            fa.deconnecter();

            return MesAtelier;
        }


        public void creerAtelier(Atelier unAtelier)
        {
            DAOFactory fa = new DAOFactory();
            fa.connexion();
            fa.connecter();

            string requete = "insert into Atelier (libelle, capacite, horaireDebut, horaireFin) values ('" + unAtelier.Libelle + "','" + unAtelier.Capacite + "','"
    + unAtelier.HoraireDebut + "','" + unAtelier.HoraireFin + "');";

            fa.execSqlWrite(requete);
            fa.deconnecter();
        }

        public void modifierAtelier(Atelier unAtelier)
        {
            DAOFactory dao = new DAOFactory();
            dao.connexion();

            dao.connecter();
            string requete = "update Atelier set libelle = '" + unAtelier.Libelle + "', set capacite = '" + unAtelier.Capacite + "', set horaireDebut ='" + unAtelier.HoraireDebut + "', set horaireFin = '" + unAtelier.HoraireFin +"' where id = '" + unAtelier.Id + "'";

            dao.execSqlWrite(requete);
            dao.deconnecter();
        }



           






        }


    }

