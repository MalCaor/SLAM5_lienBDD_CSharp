﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM5_lienBDD_CSharp
{
    public static class Modele
    {
        private static Entities maConnexion;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new Entities();
        }
        public static List<VILLE> listeville()
        {
            return maConnexion.VILLE.ToList();
        }
    }
}