namespace ISET_2018_Decouverte
{
    partial class EcranListe
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
            this.lblFichier = new System.Windows.Forms.Label();
            this.lbPersonnes = new System.Windows.Forms.ListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.dlgOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFichier
            // 
            this.lblFichier.AutoSize = true;
            this.lblFichier.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichier.Location = new System.Drawing.Point(12, 9);
            this.lblFichier.Name = "lblFichier";
            this.lblFichier.Size = new System.Drawing.Size(97, 21);
            this.lblFichier.TabIndex = 0;
            this.lblFichier.Text = "Nom de fichier";
            // 
            // lbPersonnes
            // 
            this.lbPersonnes.FormattingEnabled = true;
            this.lbPersonnes.Location = new System.Drawing.Point(12, 33);
            this.lbPersonnes.Name = "lbPersonnes";
            this.lbPersonnes.Size = new System.Drawing.Size(260, 95);
            this.lbPersonnes.Sorted = true;
            this.lbPersonnes.TabIndex = 1;
            this.lbPersonnes.DoubleClick += new System.EventHandler(this.lbPersonnes_DoubleClick);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(12, 134);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 178);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 223);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 265);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.btnAnnuler);
            this.gbDetails.Controls.Add(this.btnConfirmer);
            this.gbDetails.Controls.Add(this.tbNom);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.cbQualite);
            this.gbDetails.Location = new System.Drawing.Point(93, 136);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(179, 152);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details personne";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(98, 123);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(9, 123);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 9;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(9, 68);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(164, 20);
            this.tbNom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // cbQualite
            // 
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "MonDamoiseau",
            "Indéfini"});
            this.cbQualite.Location = new System.Drawing.Point(6, 19);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(167, 21);
            this.cbQualite.TabIndex = 7;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(172, 7);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(100, 20);
            this.tbInfo.TabIndex = 11;
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.lbPersonnes);
            this.Controls.Add(this.lblFichier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranListe";
            this.Text = "Manipulation de listes";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.ListBox lbPersonnes;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOuvrir;
        private System.Windows.Forms.SaveFileDialog dlgEnregistrer;
        private System.Windows.Forms.TextBox tbInfo;
    }
}