namespace WindowsFormsApplicationVoitureOnLine
{
    partial class FmAfficher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCommandes = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lbNbCommandes = new System.Windows.Forms.Label();
            this.lbTotalCommandes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCommandes
            // 
            this.lbCommandes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCommandes.FormattingEnabled = true;
            this.lbCommandes.Location = new System.Drawing.Point(13, 13);
            this.lbCommandes.Name = "lbCommandes";
            this.lbCommandes.Size = new System.Drawing.Size(759, 199);
            this.lbCommandes.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(358, 272);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lbNbCommandes
            // 
            this.lbNbCommandes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNbCommandes.AutoSize = true;
            this.lbNbCommandes.Location = new System.Drawing.Point(12, 242);
            this.lbNbCommandes.Name = "lbNbCommandes";
            this.lbNbCommandes.Size = new System.Drawing.Size(131, 13);
            this.lbNbCommandes.TabIndex = 2;
            this.lbNbCommandes.Text = "Nombre de commandes :  ";
            // 
            // lbTotalCommandes
            // 
            this.lbTotalCommandes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTotalCommandes.AutoSize = true;
            this.lbTotalCommandes.Location = new System.Drawing.Point(524, 242);
            this.lbTotalCommandes.Name = "lbTotalCommandes";
            this.lbTotalCommandes.Size = new System.Drawing.Size(120, 13);
            this.lbTotalCommandes.TabIndex = 3;
            this.lbTotalCommandes.Text = "Total des commandes : ";
            // 
            // FmAfficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.lbTotalCommandes);
            this.Controls.Add(this.lbNbCommandes);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lbCommandes);
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "FmAfficher";
            this.Text = "Liste des commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommandes;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lbNbCommandes;
        private System.Windows.Forms.Label lbTotalCommandes;
    }
}