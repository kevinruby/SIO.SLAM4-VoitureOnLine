using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureOnLine
{
    public class Compacte : Voiture
    {
        /// <summary>
        /// Si c'est un cabriolet.
        /// </summary>
        private bool cabriolet;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="finitionInt">La finition intérieur</param>
        /// <param name="finitionExt">La finition extérieur</param>
        /// <param name="couleur">La couleur</param>
        /// <param name="motorisation">La motorisation</param>
        /// <param name="cabriolet">Si c'est un cabriolet</param>
        public Compacte(String finitionInt, String finitionExt, String couleur, String motorisation, bool cabriolet)
            : base(finitionInt, finitionExt, couleur, motorisation)
        {
            this.cabriolet = cabriolet;
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public override double Prix()
        {
            double prix = base.Prix() + 7000;
            if (this.cabriolet)
            {
                prix += 3000;
            }
            return prix;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override String Chaine()
        {
            String txtCabriolet = "";
            if (this.cabriolet)
            {
                txtCabriolet = "cabriolet";
            }
            return String.Format("Compacte {0}, {1}", txtCabriolet, base.Chaine());
        }
    }
}