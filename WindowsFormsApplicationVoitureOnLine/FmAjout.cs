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
    public partial class FmAjout : Form
    {
        /// <summary>
        /// La liste des commandes.
        /// </summary>
        private List<Commande> lesCommandes;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        public FmAjout()
        {
            InitializeComponent();
            lesCommandes = new List<Commande>();
        }

        /// <summary>
        /// Initialise l'interface graphique à son état initiale en cliquant sur le bouton Annuler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            InitZones();
        }

        /// <summary>
        /// Initialise l'interface graphique à son état initiale.
        /// </summary>
        private void InitZones()
        {
            rdBtnCitadine.Checked = true;
            ckBox4portes.Checked = false;
            ckBoxCabriolet.Checked = false;
            txtBoxClient.Text = "";
            cboxFinInt.Text = "";
            cBoxFinExt.Text = "";
            cBoxCouleur.Text = "";
            cBoxMotorisation.Text = "";
            ckBox4portes.Enabled = true;
            ckBoxCabriolet.Enabled = false;
        }

        /// <summary>
        /// Quitte l'application lors du clique sur le bouton Quitter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ouvre la FmAfficher qui affiche les commandes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afficherLesSimulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmAfficher fm = new FmAfficher(lesCommandes);
            fm.Show();
        }

        /// <summary>
        /// Ajoute une commande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            Voiture laVoiture = null;
            if(txtBoxClient.Text != "" 
                && cboxFinInt.Text != "" 
                && cBoxFinExt.Text != "" 
                && cBoxCouleur.Text != "" 
                && cBoxMotorisation.Text != "")
            {
                if (rdBtnCitadine.Checked)
                {
                    laVoiture = new Citadine(cboxFinInt.Text, cBoxFinExt.Text, cBoxCouleur.Text, cBoxMotorisation.Text, ckBox4portes.Checked);
                }
                else if (rdBtnCompacte.Checked)
                {
                    laVoiture = new Compacte(cboxFinInt.Text, cBoxFinExt.Text, cBoxCouleur.Text, cBoxMotorisation.Text, ckBoxCabriolet.Checked);
                }
                else if (rdBtnFamiale.Checked)
                {
                    laVoiture = new Familiale(cboxFinInt.Text, cBoxFinExt.Text, cBoxCouleur.Text, cBoxMotorisation.Text);
                }
                else
                {
                    laVoiture = new Limousine(cboxFinInt.Text, cBoxFinExt.Text, cBoxCouleur.Text, cBoxMotorisation.Text);
                }
                lesCommandes.Add(new Commande(txtBoxClient.Text, laVoiture));
                lbSelection.ForeColor = System.Drawing.Color.Green;
                lbSelection.Text = String.Format("Sélection enregistrée. Prix : {0}", laVoiture.Prix().ToString("C"));
                InitZones();
            }
            else
            {
                lbSelection.ForeColor = System.Drawing.Color.Red;
                lbSelection.Text = "Veillez remplir tous les champs !";
            }
        }

        /// <summary>
        /// Active et désactive les checkbox en fonction du radio bouton sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnCitadine_CheckedChanged(object sender, EventArgs e)
        {
            ckBox4portes.Enabled = true;
            ckBoxCabriolet.Enabled = false;
            pictureBoxVoiture.Image = Properties.Resources.citadine2portes;
        }

        /// <summary>
        /// Active et désactive les checkbox en fonction du radio bouton sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnCompacte_CheckedChanged(object sender, EventArgs e)
        {
            ckBox4portes.Enabled = false;
            ckBoxCabriolet.Enabled = true;
            pictureBoxVoiture.Image = Properties.Resources.compacte;
        }

        /// <summary>
        /// Active et désactive les checkbox en fonction du radio bouton sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnFamiale_CheckedChanged(object sender, EventArgs e)
        {
            ckBox4portes.Enabled = false;
            ckBoxCabriolet.Enabled = false;
            pictureBoxVoiture.Image = Properties.Resources.familiale;
        }

        /// <summary>
        /// Active et désactive les checkbox en fonction du radio bouton sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnLimousine_CheckedChanged(object sender, EventArgs e)
        {
            ckBox4portes.Enabled = false;
            ckBoxCabriolet.Enabled = false;
            pictureBoxVoiture.Image = Properties.Resources.limousine;
        }

        private void ckBox4portes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox4portes.Checked == true)
            {
                pictureBoxVoiture.Image = Properties.Resources.citadine4portes;
            }
            else
            {
                pictureBoxVoiture.Image = Properties.Resources.citadine2portes;
            }
        }

        private void ckBoxCabriolet_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxCabriolet.Checked == true)
            {
                pictureBoxVoiture.Image = Properties.Resources.CompacteCab;
            }
            else
            {
                pictureBoxVoiture.Image = Properties.Resources.compacte;
            }
        }
    }
}