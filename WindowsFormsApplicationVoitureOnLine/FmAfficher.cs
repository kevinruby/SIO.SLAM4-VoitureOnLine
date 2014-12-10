using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryVoitureOnLine;

namespace WindowsFormsApplicationVoitureOnLine
{
    public partial class FmAfficher : Form
    {
        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="lesCommandes">Les commandes</param>
        public FmAfficher(List<Commande> lesCommandes)
        {
            double totalCommandes = 0;
            InitializeComponent();
            foreach (Commande c in lesCommandes)
            {
                lbCommandes.Items.Add(c.Chaine());
                totalCommandes += c.Total();
            }
            lbNbCommandes.Text += lesCommandes.Count;
            lbTotalCommandes.Text += totalCommandes.ToString("C");
        }

        /// <summary>
        /// Fermet cette fenêtre lors du clique sur le bouton fermer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
