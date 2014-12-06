using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureOnLine
{
    public class Voiture
    {
        /// <summary>
        /// La couleur.
        /// </summary>
        private String couleur;

        /// <summary>
        /// La finition extérieur.
        /// </summary>
        private String finitionExt;

        /// <summary>
        /// La finition intérieur.
        /// </summary>
        private String finitionInt;

        /// <summary>
        /// La motorisation.
        /// </summary>
        private String motorisation;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="finitionInt">La finition intérieur</param>
        /// <param name="finitionExt">La finition extérieur</param>
        /// <param name="couleur">La couleur</param>
        /// <param name="motorisation">La motorisation</param>
        public Voiture(String finitionInt, String finitionExt, String couleur, String motorisation)
        {
            this.couleur = couleur;
            this.finitionExt = finitionExt;
            this.finitionInt = finitionInt;
            this.motorisation = motorisation;
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public virtual double Prix()
        {
            double prix = 10000;
            switch (motorisation)
            {
                case "Hybride" :
                    prix += 5000;
                    break;

                case "Gasoil":
                    prix += 2000;
                    break;
            }
            return prix;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public virtual String Chaine()
        {
            return String.Format("finition intérieur : {0}, finition extérieur : {1}, couleur : {2}, motorisation : {3}, Prix : {4}", 
                this.finitionInt, this.finitionExt, this.couleur, this.motorisation, this.Prix());
        }
    }
}