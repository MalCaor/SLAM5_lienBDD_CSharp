using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM5_lienBDD_CSharp
{
    public static class Modele
    {
        private static Entities maConnexion;
        public static COMPOSITEUR lecompoChoisi;

        public static void trouveCompositeurId(int id)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idCompositeur==id);

            lecompoChoisi = (COMPOSITEUR) LQuery.ToList().First();
        }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new Entities();
        }
        public static List<VILLE> listeville()
        {
            return maConnexion.VILLE.ToList();
        }

        public static List<SALLE> listesalles()
        {
            return maConnexion.SALLE.ToList();
        }

        public static List<BATIMENT> listebati()
        {
            return maConnexion.BATIMENT.ToList();
        }

        public static List<TYPEOEUVRE> listetypoeuvre()
        {
            return maConnexion.TYPEOEUVRE.ToList();
        }

        public static List<COMPOSITEUR> listecomp()
        {
            return maConnexion.COMPOSITEUR.ToList();
        }

        public static List<NATIONALITE> listenat()
        {
            return maConnexion.NATIONALITE.ToList();
        }
        public static List<STYLE> listestyle()
        {
            return maConnexion.STYLE.ToList();
        }

        public static Object CompositeurParNationalite(int idNation)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idNation == idNation)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque,x.idCompositeur })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }
        public static Object CompositeurParStyle(int idstyle)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idStyle == idstyle)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }
        public static void ajoutCompo(COMPOSITEUR c)
        {
            maConnexion.COMPOSITEUR.Add(c);
            maConnexion.SaveChanges();
        }

        public static void SupprCompparID(int ID)
        {
            maConnexion.COMPOSITEUR.Remove(maConnexion.COMPOSITEUR.Find(ID));
            maConnexion.SaveChanges();
        }

        public static void savechange()
        {
            maConnexion.SaveChanges();
        }
    }
}
