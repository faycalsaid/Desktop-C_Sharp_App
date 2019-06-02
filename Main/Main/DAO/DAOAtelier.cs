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
            List<Theme> MesTheme = new List<Theme>();
            DAOFactory fa = new DAOFactory();
            DAOFactory da = new DAOFactory();
            fa.connexion();
            fa.connecter();

            string requete2;
            da.connexion();
            da.connecter();

            string requete = (" SELECT * from Atelier ");
            SqlDataReader monDR = fa.execSqlRead(requete);

            
            
                requete2 = ("SELECT id_theme,theme_atelier.libelle from theme_atelier inner join Atelier on theme_atelier.id_theme = Atelier.id where id_atelier =" + Convert.ToInt32(monDR.Read()));

        

                SqlDataReader monFR = da.execSqlRead(requete2);






                while (monFR.Read())
                {
                    Theme monTheme = new Theme(Convert.ToInt32(monFR[0]), monFR[1].ToString());
                    MesTheme.Add(monTheme);
                }
                


                
                while (monDR.Read())
                {
                    Atelier monAtelier = new Atelier(Convert.ToInt32(monDR[0]), monDR[1].ToString(), Convert.ToInt32(monDR[2]), Convert.ToDateTime(monDR[3]), Convert.ToDateTime(monDR[4]), MesTheme);
                    MesAtelier.Add(monAtelier);


                    


                    
                    




                }
                

            
            fa.deconnecter();
            da.deconnecter();
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
            string requete = "update Atelier set libelle = '" + unAtelier.Libelle + "', capacite = '" + unAtelier.Capacite + "', horaireDebut ='" + unAtelier.HoraireDebut + "', horaireFin = '" + unAtelier.HoraireFin +"' where id = '" + unAtelier.Id + "'";

            dao.execSqlWrite(requete);
            dao.deconnecter();
        }



           






        }


    }

