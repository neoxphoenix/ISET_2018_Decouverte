namespace ISET_2018_Decouverte
{
    partial class EcranEditeur
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
            this.mEditeur = new System.Windows.Forms.MenuStrip();
            this.meFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mefOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mefSauver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mefQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.meEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.meeColler = new System.Windows.Forms.ToolStripMenuItem();
            this.meFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mefJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mefPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.mefCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcSouligne = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgouvrirFichier = new System.Windows.Forms.OpenFileDialog();
            this.dlgSauverFichier = new System.Windows.Forms.SaveFileDialog();
            this.dlgPolice = new System.Windows.Forms.FontDialog();
            this.pBarreBouton = new System.Windows.Forms.Panel();
            this.BoutonQuitter = new System.Windows.Forms.Button();
            this.BoutonEnregistrer = new System.Windows.Forms.Button();
            this.BoutonOuvrir = new System.Windows.Forms.Button();
            this.BoutonNouveau = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mEditeur.SuspendLayout();
            this.pBarreBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEditeur
            // 
            this.mEditeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meFichier,
            this.meEditer,
            this.meFormat});
            this.mEditeur.Location = new System.Drawing.Point(0, 0);
            this.mEditeur.Name = "mEditeur";
            this.mEditeur.Size = new System.Drawing.Size(402, 24);
            this.mEditeur.TabIndex = 0;
            this.mEditeur.Text = "menuStrip1";
            // 
            // meFichier
            // 
            this.meFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefNouveau,
            this.mefOuvrir,
            this.mefSauver,
            this.toolStripMenuItem1,
            this.mefQuitter});
            this.meFichier.Name = "meFichier";
            this.meFichier.Size = new System.Drawing.Size(54, 20);
            this.meFichier.Text = "Fichier";
            // 
            // mefNouveau
            // 
            this.mefNouveau.Name = "mefNouveau";
            this.mefNouveau.Size = new System.Drawing.Size(122, 22);
            this.mefNouveau.Text = "Nouveau";
            this.mefNouveau.Click += new System.EventHandler(this.BoutonNouveau_Click);
            // 
            // mefOuvrir
            // 
            this.mefOuvrir.Name = "mefOuvrir";
            this.mefOuvrir.Size = new System.Drawing.Size(122, 22);
            this.mefOuvrir.Text = "Ouvrir";
            this.mefOuvrir.Click += new System.EventHandler(this.BoutonOuvrir_Click);
            // 
            // mefSauver
            // 
            this.mefSauver.Name = "mefSauver";
            this.mefSauver.Size = new System.Drawing.Size(122, 22);
            this.mefSauver.Text = "Sauver";
            this.mefSauver.Click += new System.EventHandler(this.BoutonEnregistrer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // mefQuitter
            // 
            this.mefQuitter.Name = "mefQuitter";
            this.mefQuitter.Size = new System.Drawing.Size(122, 22);
            this.mefQuitter.Text = "Quitter";
            this.mefQuitter.Click += new System.EventHandler(this.BoutonQuitter_Click);
            // 
            // meEditer
            // 
            this.meEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meeCouper,
            this.meeCopier,
            this.meeColler});
            this.meEditer.Name = "meEditer";
            this.meEditer.Size = new System.Drawing.Size(49, 20);
            this.meEditer.Text = "Editer";
            // 
            // meeCouper
            // 
            this.meeCouper.Name = "meeCouper";
            this.meeCouper.Size = new System.Drawing.Size(113, 22);
            this.meeCouper.Text = "Couper";
            this.meeCouper.Click += new System.EventHandler(this.meeCouper_Click);
            // 
            // meeCopier
            // 
            this.meeCopier.Name = "meeCopier";
            this.meeCopier.Size = new System.Drawing.Size(113, 22);
            this.meeCopier.Text = "Copier";
            this.meeCopier.Click += new System.EventHandler(this.meeCopier_Click);
            // 
            // meeColler
            // 
            this.meeColler.Name = "meeColler";
            this.meeColler.Size = new System.Drawing.Size(113, 22);
            this.meeColler.Text = "Coller";
            this.meeColler.Click += new System.EventHandler(this.meeColler_Click);
            // 
            // meFormat
            // 
            this.meFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefJustifier,
            this.mefPolice,
            this.mefCaractere});
            this.meFormat.Name = "meFormat";
            this.meFormat.Size = new System.Drawing.Size(57, 20);
            this.meFormat.Text = "Format";
            // 
            // mefJustifier
            // 
            this.mefJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefjGauche,
            this.mefjDroite,
            this.mefjCentre});
            this.mefJustifier.Name = "mefJustifier";
            this.mefJustifier.Size = new System.Drawing.Size(124, 22);
            this.mefJustifier.Text = "Justifier";
            // 
            // mefjGauche
            // 
            this.mefjGauche.Name = "mefjGauche";
            this.mefjGauche.Size = new System.Drawing.Size(114, 22);
            this.mefjGauche.Text = "Gauche";
            this.mefjGauche.Click += new System.EventHandler(this.mefjGauche_Click);
            // 
            // mefjDroite
            // 
            this.mefjDroite.Name = "mefjDroite";
            this.mefjDroite.Size = new System.Drawing.Size(114, 22);
            this.mefjDroite.Text = "Droite";
            this.mefjDroite.Click += new System.EventHandler(this.mefjDroite_Click);
            // 
            // mefjCentre
            // 
            this.mefjCentre.Name = "mefjCentre";
            this.mefjCentre.Size = new System.Drawing.Size(114, 22);
            this.mefjCentre.Text = "Centré";
            this.mefjCentre.Click += new System.EventHandler(this.mefjCentre_Click);
            // 
            // mefPolice
            // 
            this.mefPolice.Name = "mefPolice";
            this.mefPolice.Size = new System.Drawing.Size(124, 22);
            this.mefPolice.Text = "Police";
            this.mefPolice.Click += new System.EventHandler(this.mefPolice_Click);
            // 
            // mefCaractere
            // 
            this.mefCaractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefcGras,
            this.mefcItalique,
            this.mefcSouligne,
            this.mefcBarre});
            this.mefCaractere.Name = "mefCaractere";
            this.mefCaractere.Size = new System.Drawing.Size(124, 22);
            this.mefCaractere.Text = "Caractère";
            // 
            // mefcGras
            // 
            this.mefcGras.Name = "mefcGras";
            this.mefcGras.Size = new System.Drawing.Size(120, 22);
            this.mefcGras.Text = "Gras";
            this.mefcGras.Click += new System.EventHandler(this.mefcGras_Click);
            // 
            // mefcItalique
            // 
            this.mefcItalique.Name = "mefcItalique";
            this.mefcItalique.Size = new System.Drawing.Size(120, 22);
            this.mefcItalique.Text = "Italique";
            this.mefcItalique.Click += new System.EventHandler(this.mefcItalique_Click);
            // 
            // mefcSouligne
            // 
            this.mefcSouligne.Name = "mefcSouligne";
            this.mefcSouligne.Size = new System.Drawing.Size(120, 22);
            this.mefcSouligne.Text = "Souligné";
            this.mefcSouligne.Click += new System.EventHandler(this.mefcSouligne_Click);
            // 
            // mefcBarre
            // 
            this.mefcBarre.Name = "mefcBarre";
            this.mefcBarre.Size = new System.Drawing.Size(120, 22);
            this.mefcBarre.Text = "Barré";
            this.mefcBarre.Click += new System.EventHandler(this.mefcBarre_Click);
            // 
            // dlgouvrirFichier
            // 
            this.dlgouvrirFichier.FileName = "openFileDialog1";
            this.dlgouvrirFichier.Filter = "Nos fichiers(*.mesdocs)|*.mesdocs|Tous fichiers(*.*)|*.*";
            // 
            // dlgSauverFichier
            // 
            this.dlgSauverFichier.Filter = "Nos fichiers(*.mesdocs)|*.mesdocs|Tous fichiers(*.*)|*.*";
            // 
            // pBarreBouton
            // 
            this.pBarreBouton.Controls.Add(this.textBox1);
            this.pBarreBouton.Controls.Add(this.BoutonQuitter);
            this.pBarreBouton.Controls.Add(this.BoutonEnregistrer);
            this.pBarreBouton.Controls.Add(this.BoutonOuvrir);
            this.pBarreBouton.Controls.Add(this.BoutonNouveau);
            this.pBarreBouton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarreBouton.Location = new System.Drawing.Point(0, 24);
            this.pBarreBouton.Name = "pBarreBouton";
            this.pBarreBouton.Size = new System.Drawing.Size(402, 49);
            this.pBarreBouton.TabIndex = 1;
            // 
            // BoutonQuitter
            // 
            this.BoutonQuitter.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.exit;
            this.BoutonQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonQuitter.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BoutonQuitter.Location = new System.Drawing.Point(141, 3);
            this.BoutonQuitter.Name = "BoutonQuitter";
            this.BoutonQuitter.Size = new System.Drawing.Size(40, 40);
            this.BoutonQuitter.TabIndex = 2;
            this.BoutonQuitter.UseVisualStyleBackColor = true;
            this.BoutonQuitter.Click += new System.EventHandler(this.BoutonQuitter_Click);
            // 
            // BoutonEnregistrer
            // 
            this.BoutonEnregistrer.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.save;
            this.BoutonEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonEnregistrer.Location = new System.Drawing.Point(95, 3);
            this.BoutonEnregistrer.Name = "BoutonEnregistrer";
            this.BoutonEnregistrer.Size = new System.Drawing.Size(40, 40);
            this.BoutonEnregistrer.TabIndex = 2;
            this.BoutonEnregistrer.UseVisualStyleBackColor = true;
            this.BoutonEnregistrer.Click += new System.EventHandler(this.BoutonEnregistrer_Click);
            // 
            // BoutonOuvrir
            // 
            this.BoutonOuvrir.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.Open_icon;
            this.BoutonOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonOuvrir.Location = new System.Drawing.Point(49, 3);
            this.BoutonOuvrir.Name = "BoutonOuvrir";
            this.BoutonOuvrir.Size = new System.Drawing.Size(40, 40);
            this.BoutonOuvrir.TabIndex = 1;
            this.BoutonOuvrir.UseVisualStyleBackColor = true;
            this.BoutonOuvrir.Click += new System.EventHandler(this.BoutonOuvrir_Click);
            // 
            // BoutonNouveau
            // 
            this.BoutonNouveau.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.newfile;
            this.BoutonNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoutonNouveau.Location = new System.Drawing.Point(3, 3);
            this.BoutonNouveau.Name = "BoutonNouveau";
            this.BoutonNouveau.Size = new System.Drawing.Size(40, 40);
            this.BoutonNouveau.TabIndex = 0;
            this.BoutonNouveau.UseVisualStyleBackColor = true;
            this.BoutonNouveau.Click += new System.EventHandler(this.BoutonNouveau_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 73);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(402, 193);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 266);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.pBarreBouton);
            this.Controls.Add(this.mEditeur);
            this.MainMenuStrip = this.mEditeur;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de texte";
            this.mEditeur.ResumeLayout(false);
            this.mEditeur.PerformLayout();
            this.pBarreBouton.ResumeLayout(false);
            this.pBarreBouton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mEditeur;
        private System.Windows.Forms.ToolStripMenuItem meFichier;
        private System.Windows.Forms.ToolStripMenuItem mefNouveau;
        private System.Windows.Forms.ToolStripMenuItem mefOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mefSauver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mefQuitter;
        private System.Windows.Forms.ToolStripMenuItem meEditer;
        private System.Windows.Forms.ToolStripMenuItem meeCouper;
        private System.Windows.Forms.ToolStripMenuItem meeCopier;
        private System.Windows.Forms.ToolStripMenuItem meeColler;
        private System.Windows.Forms.ToolStripMenuItem meFormat;
        private System.Windows.Forms.ToolStripMenuItem mefJustifier;
        private System.Windows.Forms.ToolStripMenuItem mefjGauche;
        private System.Windows.Forms.ToolStripMenuItem mefjDroite;
        private System.Windows.Forms.ToolStripMenuItem mefjCentre;
        private System.Windows.Forms.ToolStripMenuItem mefPolice;
        private System.Windows.Forms.ToolStripMenuItem mefCaractere;
        private System.Windows.Forms.ToolStripMenuItem mefcGras;
        private System.Windows.Forms.ToolStripMenuItem mefcItalique;
        private System.Windows.Forms.ToolStripMenuItem mefcSouligne;
        private System.Windows.Forms.ToolStripMenuItem mefcBarre;
        private System.Windows.Forms.OpenFileDialog dlgouvrirFichier;
        private System.Windows.Forms.SaveFileDialog dlgSauverFichier;
        private System.Windows.Forms.FontDialog dlgPolice;
        private System.Windows.Forms.Panel pBarreBouton;
        private System.Windows.Forms.Button BoutonQuitter;
        private System.Windows.Forms.Button BoutonEnregistrer;
        private System.Windows.Forms.Button BoutonOuvrir;
        private System.Windows.Forms.Button BoutonNouveau;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox textBox1;
    }
}