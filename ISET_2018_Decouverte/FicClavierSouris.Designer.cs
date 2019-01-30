namespace ISET_2018_Decouverte
{
    partial class EcranClavierSouris
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
            this.lblClavier = new System.Windows.Forms.Label();
            this.btnRaz = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblDroitee = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.lblAbscisse = new System.Windows.Forms.Label();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.lblOrdonnee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(12, 9);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(79, 13);
            this.lblClavier.TabIndex = 0;
            this.lblClavier.Text = "Suivi du clavier";
            // 
            // btnRaz
            // 
            this.btnRaz.Location = new System.Drawing.Point(12, 254);
            this.btnRaz.Name = "btnRaz";
            this.btnRaz.Size = new System.Drawing.Size(118, 23);
            this.btnRaz.TabIndex = 1;
            this.btnRaz.Text = "Remise à zéro";
            this.btnRaz.UseVisualStyleBackColor = true;
            this.btnRaz.Click += new System.EventHandler(this.btnRaz_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(136, 254);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(118, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(10, 25);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(244, 225);
            this.lbClavier.TabIndex = 3;
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(267, 9);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(53, 13);
            this.lblGauche.TabIndex = 4;
            this.lblGauche.Text = "A gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(260, 25);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.ReadOnly = true;
            this.tbGauche.Size = new System.Drawing.Size(72, 20);
            this.tbGauche.TabIndex = 5;
            this.tbGauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(260, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 226);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(338, 25);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.ReadOnly = true;
            this.tbDroite.Size = new System.Drawing.Size(72, 20);
            this.tbDroite.TabIndex = 8;
            this.tbDroite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDroitee
            // 
            this.lblDroitee.AutoSize = true;
            this.lblDroitee.Location = new System.Drawing.Point(346, 9);
            this.lblDroitee.Name = "lblDroitee";
            this.lblDroitee.Size = new System.Drawing.Size(43, 13);
            this.lblDroitee.TabIndex = 7;
            this.lblDroitee.Text = "A droite";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(470, 25);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.ReadOnly = true;
            this.tbPosX.Size = new System.Drawing.Size(72, 20);
            this.tbPosX.TabIndex = 10;
            this.tbPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAbscisse
            // 
            this.lblAbscisse.AutoSize = true;
            this.lblAbscisse.Location = new System.Drawing.Point(478, 9);
            this.lblAbscisse.Name = "lblAbscisse";
            this.lblAbscisse.Size = new System.Drawing.Size(49, 13);
            this.lblAbscisse.TabIndex = 9;
            this.lblAbscisse.Text = "Abscisse";
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(548, 25);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.ReadOnly = true;
            this.tbPosY.Size = new System.Drawing.Size(72, 20);
            this.tbPosY.TabIndex = 12;
            this.tbPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOrdonnee
            // 
            this.lblOrdonnee.AutoSize = true;
            this.lblOrdonnee.Location = new System.Drawing.Point(555, 9);
            this.lblOrdonnee.Name = "lblOrdonnee";
            this.lblOrdonnee.Size = new System.Drawing.Size(54, 13);
            this.lblOrdonnee.TabIndex = 11;
            this.lblOrdonnee.Text = "Ordonnée";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 289);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.lblOrdonnee);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.lblAbscisse);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblDroitee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.lbClavier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRaz);
            this.Controls.Add(this.lblClavier);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClavierSouris";
            this.Text = "Suivi du Clavier et de la souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Button btnRaz;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblDroitee;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label lblAbscisse;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label lblOrdonnee;
    }
}