namespace ISET_2018_Decouverte
{
    partial class EcranAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranAccueil));
            this.btnPoussez = new System.Windows.Forms.Button();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbImageDepart = new System.Windows.Forms.PictureBox();
            this.frequence1 = new ISET2018_MesControles.Frequence();
            this.boutonColore1 = new ISET2018_MesControles.BoutonColore();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoussez
            // 
            this.btnPoussez.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoussez.Location = new System.Drawing.Point(277, 51);
            this.btnPoussez.Name = "btnPoussez";
            this.btnPoussez.Size = new System.Drawing.Size(120, 44);
            this.btnPoussez.TabIndex = 0;
            this.btnPoussez.Text = "Poussez";
            this.btnPoussez.UseVisualStyleBackColor = true;
            this.btnPoussez.Click += new System.EventHandler(this.btnPoussez_Click);
            // 
            // btnEntrer
            // 
            this.btnEntrer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrer.Location = new System.Drawing.Point(277, 101);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(116, 45);
            this.btnEntrer.TabIndex = 1;
            this.btnEntrer.Text = "Entrez";
            this.btnEntrer.UseVisualStyleBackColor = true;
            this.btnEntrer.Click += new System.EventHandler(this.btnEntrer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(31, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(223, 39);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Decouverte de C#";
            // 
            // pbImageDepart
            // 
            this.pbImageDepart.Image = global::ISET_2018_Decouverte.Properties.Resources._2018_01_24_21_11_52_ELO_technique_digitales_2_pdf____Aucun_titre_de_diapositive____SumatraPDF;
            this.pbImageDepart.Location = new System.Drawing.Point(12, 51);
            this.pbImageDepart.Name = "pbImageDepart";
            this.pbImageDepart.Size = new System.Drawing.Size(259, 137);
            this.pbImageDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageDepart.TabIndex = 3;
            this.pbImageDepart.TabStop = false;
            // 
            // frequence1
            // 
            this.frequence1.Entrees.Add(((ISET2018_MesControles.MonPoint)(resources.GetObject("frequence1.Entrees"))));
            this.frequence1.Entrees.Add(((ISET2018_MesControles.MonPoint)(resources.GetObject("frequence1.Entrees1"))));
            this.frequence1.Entrees.Add(((ISET2018_MesControles.MonPoint)(resources.GetObject("frequence1.Entrees2"))));
            this.frequence1.Location = new System.Drawing.Point(12, 203);
            this.frequence1.Name = "frequence1";
            this.frequence1.Size = new System.Drawing.Size(455, 155);
            this.frequence1.TabIndex = 5;
            this.frequence1.Trait = System.Drawing.Color.Black;
            this.frequence1.XMax = 100;
            this.frequence1.XMin = 0;
            this.frequence1.XYMin = 0;
            this.frequence1.YMax = 100;
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroiteBouton = System.Drawing.Color.DarkBlue;
            this.boutonColore1.CouleurGaucheBouton = System.Drawing.Color.Yellow;
            this.boutonColore1.Location = new System.Drawing.Point(277, 152);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(183, 45);
            this.boutonColore1.TabIndex = 4;
            this.boutonColore1.Text = "B o u t o n";
            this.boutonColore1.TransparenceDroiteBouton = 64;
            this.boutonColore1.TransparenceGaucheBouton = 200;
            this.boutonColore1.UseVisualStyleBackColor = true;
            // 
            // EcranAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 361);
            this.Controls.Add(this.frequence1);
            this.Controls.Add(this.boutonColore1);
            this.Controls.Add(this.pbImageDepart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.btnPoussez);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAccueil";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bienvenue, Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoussez;
        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbImageDepart;
        private ISET2018_MesControles.BoutonColore boutonColore1;
        private ISET2018_MesControles.Frequence frequence1;
    }
}

