using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureOnLine
{
    public class Citadine : Voiture
    {
        /// <summary>
        /// 2 portes ou 4 portes.
        /// </summary>
        private bool quatrePortes;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="finitionInt">La finition intérieur</param>
        /// <param name="finitionExt">La finition extérieur</param>
        /// <param name="couleur">La couleur</param>
        /// <param name="motorisation">La motorisation</param>
        /// <param name="quatrePortes">2 portes ou 4 portes</param>
        public Citadine(String finitionInt, String finitionExt, String couleur, String motorisation, bool quatrePortes)
            : base(finitionInt, finitionExt, couleur, motorisation)
        {
            this.quatrePortes = quatrePortes;
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public override double Prix()
        {
            double prix = base.Prix();
            if (!quatrePortes)
            {
                prix -= 2000;
            }
            return prix;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override String Chaine()
        {
            String nbPortes = "deux";
            if (quatrePortes)
            {
                nbPortes = "quatre";
            }
            return String.Format("Citadine {0} portes, {1}", nbPortes, base.Chaine()); 
        }
    }
}