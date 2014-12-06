using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoitureOnLine
{
    public class Commande
    {
        /// <summary>
        /// Le nom du client.
        /// </summary>
        private String nomClient;

        /// <summary>
        /// Une voiture.
        /// </summary>
        private Voiture uneVoiture;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="nomClient">Le nom du client</param>
        /// <param name="uneVoiture">Une voiture</param>
        public Commande(String nomClient, Voiture uneVoiture)
        {
            this.nomClient = nomClient;
            this.uneVoiture = uneVoiture;
        }
        
        /// <summary>
        /// Le prix de la commande.
        /// </summary>
        /// <returns>Le prix de la commande</returns>
        public double Total()
        {
            return uneVoiture.Prix();
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public String Chaine()
        {
            return String.Format("{0} a choisi une voiture {1}", this.nomClient, this.uneVoiture.Chaine());
        }
    }
}