namespace ISET_2018_Decouverte
{
    partial class EcranIntegrales
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
            this.lbResultat = new System.Windows.Forms.ListBox();
            this.btnPolynome = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.tbIntervalle = new System.Windows.Forms.TextBox();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.lblGauche = new System.Windows.Forms.Label();
            this.lblDroite = new System.Windows.Forms.Label();
            this.lblIntervalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultat
            // 
            this.lbResultat.FormattingEnabled = true;
            this.lbResultat.Location = new System.Drawing.Point(12, 77);
            this.lbResultat.Name = "lbResultat";
            this.lbResultat.Size = new System.Drawing.Size(260, 173);
            this.lbResultat.TabIndex = 0;
            // 
            // btnPolynome
            // 
            this.btnPolynome.Location = new System.Drawing.Point(12, 272);
            this.btnPolynome.Name = "btnPolynome";
            this.btnPolynome.Size = new System.Drawing.Size(260, 23);
            this.btnPolynome.TabIndex = 1;
            this.btnPolynome.Text = "Polynome : x * x - 3 * x + 4";
            this.btnPolynome.UseVisualStyleBackColor = true;
            this.btnPolynome.Click += new System.EventHandler(this.btnPolynome_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Location = new System.Drawing.Point(12, 301);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(260, 23);
            this.btnCosinus.TabIndex = 2;
            this.btnCosinus.Text = "Cosinus";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.btnCosinus_Click);
            // 
            // tbIntervalle
            // 
            this.tbIntervalle.Location = new System.Drawing.Point(227, 25);
            this.tbIntervalle.Name = "tbIntervalle";
            this.tbIntervalle.Size = new System.Drawing.Size(45, 20);
            this.tbIntervalle.TabIndex = 3;
            this.tbIntervalle.Text = "2";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(123, 25);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(45, 20);
            this.tbDroite.TabIndex = 4;
            this.tbDroite.Text = "2";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(12, 25);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(45, 20);
            this.tbGauche.TabIndex = 5;
            this.tbGauche.Text = "0";
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(12, 9);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(45, 13);
            this.lblGauche.TabIndex = 6;
            this.lblGauche.Text = "Gauche";
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Location = new System.Drawing.Point(127, 9);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(35, 13);
            this.lblDroite.TabIndex = 7;
            this.lblDroite.Text = "Droite";
            // 
            // lblIntervalle
            // 
            this.lblIntervalle.AutoSize = true;
            this.lblIntervalle.Location = new System.Drawing.Point(222, 9);
            this.lblIntervalle.Name = "lblIntervalle";
            this.lblIntervalle.Size = new System.Drawing.Size(50, 13);
            this.lblIntervalle.TabIndex = 8;
            this.lblIntervalle.Text = "Intervalle";
            // 
            // EcranIntegrales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.lblIntervalle);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.tbIntervalle);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btnPolynome);
            this.Controls.Add(this.lbResultat);
            this.Name = "EcranIntegrales";
            this.Text = "Calcul d\'intégrales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResultat;
        private System.Windows.Forms.Button btnPolynome;
        private System.Windows.Forms.Button btnCosinus;
        private System.Windows.Forms.TextBox tbIntervalle;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.Label lblIntervalle;
    }
}