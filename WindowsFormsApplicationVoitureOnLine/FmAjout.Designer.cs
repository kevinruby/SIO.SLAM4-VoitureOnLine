namespace WindowsFormsApplicationVoitureOnLine
{
    partial class FmAjout
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesSimulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBoxType = new System.Windows.Forms.GroupBox();
            this.rdBtnLimousine = new System.Windows.Forms.RadioButton();
            this.rdBtnFamiale = new System.Windows.Forms.RadioButton();
            this.rdBtnCompacte = new System.Windows.Forms.RadioButton();
            this.rdBtnCitadine = new System.Windows.Forms.RadioButton();
            this.ckBox4portes = new System.Windows.Forms.CheckBox();
            this.ckBoxCabriolet = new System.Windows.Forms.CheckBox();
            this.lbVoitureOnLine = new System.Windows.Forms.Label();
            this.cboxFinInt = new System.Windows.Forms.ComboBox();
            this.lbFinInt = new System.Windows.Forms.Label();
            this.lbFinExt = new System.Windows.Forms.Label();
            this.cBoxFinExt = new System.Windows.Forms.ComboBox();
            this.lbCouleur = new System.Windows.Forms.Label();
            this.cBoxCouleur = new System.Windows.Forms.ComboBox();
            this.lbMotorisation = new System.Windows.Forms.Label();
            this.cBoxMotorisation = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pictureBoxVoiture = new System.Windows.Forms.PictureBox();
            this.lbClient = new System.Windows.Forms.Label();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.lbSelection = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesSimulationsToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // afficherLesSimulationsToolStripMenuItem
            // 
            this.afficherLesSimulationsToolStripMenuItem.Name = "afficherLesSimulationsToolStripMenuItem";
            this.afficherLesSimulationsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.afficherLesSimulationsToolStripMenuItem.Text = "Afficher les simulations";
            this.afficherLesSimulationsToolStripMenuItem.Click += new System.EventHandler(this.afficherLesSimulationsToolStripMenuItem_Click);
            // 
            // gpBoxType
            // 
            this.gpBoxType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpBoxType.Controls.Add(this.rdBtnLimousine);
            this.gpBoxType.Controls.Add(this.rdBtnFamiale);
            this.gpBoxType.Controls.Add(this.rdBtnCompacte);
            this.gpBoxType.Controls.Add(this.rdBtnCitadine);
            this.gpBoxType.Location = new System.Drawing.Point(12, 146);
            this.gpBoxType.Name = "gpBoxType";
            this.gpBoxType.Size = new System.Drawing.Size(148, 117);
            this.gpBoxType.TabIndex = 2;
            this.gpBoxType.TabStop = false;
            this.gpBoxType.Text = "Type";
            // 
            // rdBtnLimousine
            // 
            this.rdBtnLimousine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdBtnLimousine.AutoSize = true;
            this.rdBtnLimousine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnLimousine.Location = new System.Drawing.Point(7, 91);
            this.rdBtnLimousine.Name = "rdBtnLimousine";
            this.rdBtnLimousine.Size = new System.Drawing.Size(81, 17);
            this.rdBtnLimousine.TabIndex = 3;
            this.rdBtnLimousine.TabStop = true;
            this.rdBtnLimousine.Text = "Limousine";
            this.rdBtnLimousine.UseVisualStyleBackColor = true;
            this.rdBtnLimousine.CheckedChanged += new System.EventHandler(this.rdBtnLimousine_CheckedChanged);
            // 
            // rdBtnFamiale
            // 
            this.rdBtnFamiale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdBtnFamiale.AutoSize = true;
            this.rdBtnFamiale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFamiale.Location = new System.Drawing.Point(7, 67);
            this.rdBtnFamiale.Name = "rdBtnFamiale";
            this.rdBtnFamiale.Size = new System.Drawing.Size(74, 17);
            this.rdBtnFamiale.TabIndex = 2;
            this.rdBtnFamiale.TabStop = true;
            this.rdBtnFamiale.Text = "Familiale";
            this.rdBtnFamiale.UseVisualStyleBackColor = true;
            this.rdBtnFamiale.CheckedChanged += new System.EventHandler(this.rdBtnFamiale_CheckedChanged);
            // 
            // rdBtnCompacte
            // 
            this.rdBtnCompacte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdBtnCompacte.AutoSize = true;
            this.rdBtnCompacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCompacte.Location = new System.Drawing.Point(7, 43);
            this.rdBtnCompacte.Name = "rdBtnCompacte";
            this.rdBtnCompacte.Size = new System.Drawing.Size(81, 17);
            this.rdBtnCompacte.TabIndex = 1;
            this.rdBtnCompacte.TabStop = true;
            this.rdBtnCompacte.Text = "Compacte";
            this.rdBtnCompacte.UseVisualStyleBackColor = true;
            this.rdBtnCompacte.CheckedChanged += new System.EventHandler(this.rdBtnCompacte_CheckedChanged);
            // 
            // rdBtnCitadine
            // 
            this.rdBtnCitadine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdBtnCitadine.AutoSize = true;
            this.rdBtnCitadine.Checked = true;
            this.rdBtnCitadine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCitadine.Location = new System.Drawing.Point(6, 19);
            this.rdBtnCitadine.Name = "rdBtnCitadine";
            this.rdBtnCitadine.Size = new System.Drawing.Size(71, 17);
            this.rdBtnCitadine.TabIndex = 0;
            this.rdBtnCitadine.TabStop = true;
            this.rdBtnCitadine.Text = "Citadine";
            this.rdBtnCitadine.UseVisualStyleBackColor = true;
            this.rdBtnCitadine.CheckedChanged += new System.EventHandler(this.rdBtnCitadine_CheckedChanged);
            // 
            // ckBox4portes
            // 
            this.ckBox4portes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBox4portes.AutoSize = true;
            this.ckBox4portes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBox4portes.Location = new System.Drawing.Point(18, 285);
            this.ckBox4portes.Name = "ckBox4portes";
            this.ckBox4portes.Size = new System.Drawing.Size(73, 17);
            this.ckBox4portes.TabIndex = 3;
            this.ckBox4portes.Text = "4 Portes";
            this.ckBox4portes.UseVisualStyleBackColor = true;
            this.ckBox4portes.CheckedChanged += new System.EventHandler(this.ckBox4portes_CheckedChanged);
            // 
            // ckBoxCabriolet
            // 
            this.ckBoxCabriolet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBoxCabriolet.AutoSize = true;
            this.ckBoxCabriolet.Enabled = false;
            this.ckBoxCabriolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxCabriolet.Location = new System.Drawing.Point(18, 309);
            this.ckBoxCabriolet.Name = "ckBoxCabriolet";
            this.ckBoxCabriolet.Size = new System.Drawing.Size(76, 17);
            this.ckBoxCabriolet.TabIndex = 4;
            this.ckBoxCabriolet.Text = "Cabriolet";
            this.ckBoxCabriolet.UseVisualStyleBackColor = true;
            this.ckBoxCabriolet.CheckedChanged += new System.EventHandler(this.ckBoxCabriolet_CheckedChanged);
            // 
            // lbVoitureOnLine
            // 
            this.lbVoitureOnLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVoitureOnLine.AutoSize = true;
            this.lbVoitureOnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoitureOnLine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbVoitureOnLine.Location = new System.Drawing.Point(4, 33);
            this.lbVoitureOnLine.Name = "lbVoitureOnLine";
            this.lbVoitureOnLine.Size = new System.Drawing.Size(442, 73);
            this.lbVoitureOnLine.TabIndex = 5;
            this.lbVoitureOnLine.Text = "Voiture on line";
            // 
            // cboxFinInt
            // 
            this.cboxFinInt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboxFinInt.FormattingEnabled = true;
            this.cboxFinInt.Items.AddRange(new object[] {
            "Young",
            "Sport",
            "Green",
            "Carbon"});
            this.cboxFinInt.Location = new System.Drawing.Point(576, 165);
            this.cboxFinInt.Name = "cboxFinInt";
            this.cboxFinInt.Size = new System.Drawing.Size(180, 21);
            this.cboxFinInt.TabIndex = 6;
            // 
            // lbFinInt
            // 
            this.lbFinInt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbFinInt.AutoSize = true;
            this.lbFinInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinInt.Location = new System.Drawing.Point(576, 146);
            this.lbFinInt.Name = "lbFinInt";
            this.lbFinInt.Size = new System.Drawing.Size(105, 13);
            this.lbFinInt.TabIndex = 8;
            this.lbFinInt.Text = "Finition intérieure";
            // 
            // lbFinExt
            // 
            this.lbFinExt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbFinExt.AutoSize = true;
            this.lbFinExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinExt.Location = new System.Drawing.Point(576, 193);
            this.lbFinExt.Name = "lbFinExt";
            this.lbFinExt.Size = new System.Drawing.Size(108, 13);
            this.lbFinExt.TabIndex = 10;
            this.lbFinExt.Text = "Finition extérieure";
            // 
            // cBoxFinExt
            // 
            this.cBoxFinExt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBoxFinExt.FormattingEnabled = true;
            this.cBoxFinExt.Items.AddRange(new object[] {
            "Urban",
            "Metro",
            "New",
            "Express"});
            this.cBoxFinExt.Location = new System.Drawing.Point(576, 212);
            this.cBoxFinExt.Name = "cBoxFinExt";
            this.cBoxFinExt.Size = new System.Drawing.Size(180, 21);
            this.cBoxFinExt.TabIndex = 9;
            // 
            // lbCouleur
            // 
            this.lbCouleur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCouleur.AutoSize = true;
            this.lbCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCouleur.Location = new System.Drawing.Point(576, 243);
            this.lbCouleur.Name = "lbCouleur";
            this.lbCouleur.Size = new System.Drawing.Size(50, 13);
            this.lbCouleur.TabIndex = 12;
            this.lbCouleur.Text = "Couleur";
            // 
            // cBoxCouleur
            // 
            this.cBoxCouleur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBoxCouleur.FormattingEnabled = true;
            this.cBoxCouleur.Items.AddRange(new object[] {
            "Métalisée",
            "Bleu",
            "Rouge",
            "Noir",
            "Blanc"});
            this.cBoxCouleur.Location = new System.Drawing.Point(576, 262);
            this.cBoxCouleur.Name = "cBoxCouleur";
            this.cBoxCouleur.Size = new System.Drawing.Size(180, 21);
            this.cBoxCouleur.TabIndex = 11;
            // 
            // lbMotorisation
            // 
            this.lbMotorisation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMotorisation.AutoSize = true;
            this.lbMotorisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotorisation.Location = new System.Drawing.Point(576, 289);
            this.lbMotorisation.Name = "lbMotorisation";
            this.lbMotorisation.Size = new System.Drawing.Size(76, 13);
            this.lbMotorisation.TabIndex = 14;
            this.lbMotorisation.Text = "Motorisation";
            // 
            // cBoxMotorisation
            // 
            this.cBoxMotorisation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cBoxMotorisation.FormattingEnabled = true;
            this.cBoxMotorisation.Items.AddRange(new object[] {
            "Essence",
            "Gasoil",
            "Hybride"});
            this.cBoxMotorisation.Location = new System.Drawing.Point(576, 308);
            this.cBoxMotorisation.Name = "cBoxMotorisation";
            this.cBoxMotorisation.Size = new System.Drawing.Size(180, 21);
            this.cBoxMotorisation.TabIndex = 13;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(535, 474);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(153, 474);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(345, 474);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // pictureBoxVoiture
            // 
            this.pictureBoxVoiture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxVoiture.Image = global::WindowsFormsApplicationVoitureOnLine.Properties.Resources.citadine2portes;
            this.pictureBoxVoiture.Location = new System.Drawing.Point(168, 146);
            this.pictureBoxVoiture.Name = "pictureBoxVoiture";
            this.pictureBoxVoiture.Size = new System.Drawing.Size(398, 282);
            this.pictureBoxVoiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVoiture.TabIndex = 18;
            this.pictureBoxVoiture.TabStop = false;
            // 
            // lbClient
            // 
            this.lbClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(517, 78);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(39, 13);
            this.lbClient.TabIndex = 19;
            this.lbClient.Text = "Client";
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxClient.Location = new System.Drawing.Point(584, 78);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(180, 20);
            this.txtBoxClient.TabIndex = 20;
            // 
            // lbSelection
            // 
            this.lbSelection.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSelection.AutoSize = true;
            this.lbSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelection.ForeColor = System.Drawing.Color.Green;
            this.lbSelection.Location = new System.Drawing.Point(117, 437);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(0, 18);
            this.lbSelection.TabIndex = 21;
            // 
            // FmAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbSelection);
            this.Controls.Add(this.txtBoxClient);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.pictureBoxVoiture);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lbMotorisation);
            this.Controls.Add(this.cBoxMotorisation);
            this.Controls.Add(this.lbCouleur);
            this.Controls.Add(this.cBoxCouleur);
            this.Controls.Add(this.lbFinExt);
            this.Controls.Add(this.cBoxFinExt);
            this.Controls.Add(this.lbFinInt);
            this.Controls.Add(this.cboxFinInt);
            this.Controls.Add(this.lbVoitureOnLine);
            this.Controls.Add(this.ckBoxCabriolet);
            this.Controls.Add(this.ckBox4portes);
            this.Controls.Add(this.gpBoxType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FmAjout";
            this.Text = "Choisissez votre voiture";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBoxType.ResumeLayout(false);
            this.gpBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesSimulationsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpBoxType;
        private System.Windows.Forms.RadioButton rdBtnLimousine;
        private System.Windows.Forms.RadioButton rdBtnFamiale;
        private System.Windows.Forms.RadioButton rdBtnCompacte;
        private System.Windows.Forms.RadioButton rdBtnCitadine;
        private System.Windows.Forms.CheckBox ckBox4portes;
        private System.Windows.Forms.CheckBox ckBoxCabriolet;
        private System.Windows.Forms.Label lbVoitureOnLine;
        private System.Windows.Forms.ComboBox cboxFinInt;
        private System.Windows.Forms.Label lbFinInt;
        private System.Windows.Forms.Label lbFinExt;
        private System.Windows.Forms.ComboBox cBoxFinExt;
        private System.Windows.Forms.Label lbCouleur;
        private System.Windows.Forms.ComboBox cBoxCouleur;
        private System.Windows.Forms.Label lbMotorisation;
        private System.Windows.Forms.ComboBox cBoxMotorisation;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureBoxVoiture;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Label lbSelection;
    }
}

