using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureOnLine
{
    public class Limousine : Voiture
    {
        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="finitionInt">La finition intérieur</param>
        /// <param name="finitionExt">La finition extérieur</param>
        /// <param name="couleur">La couleur</param>
        /// <param name="motorisation">La motorisation</param>
        public Limousine(String finitionInt, String finitionExt, String couleur, String motorisation)
            : base(finitionInt, finitionExt, couleur, motorisation)
        {
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public override double Prix()
        {
            return base.Prix() + 20000;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override String Chaine()
        {
            return String.Format("Limousine, {0}", base.Chaine());
        }
    }
}