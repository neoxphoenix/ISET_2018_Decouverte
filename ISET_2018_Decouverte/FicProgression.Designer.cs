namespace ISET_2018_Decouverte
{
    partial class FicProgression
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.lblSecondaire = new System.Windows.Forms.Label();
            this.btnExecuter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.Navy;
            this.lblPrincipal.Location = new System.Drawing.Point(12, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(111, 20);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Fichier (virtuel)";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.BackColor = System.Drawing.Color.Yellow;
            this.pbPrincipal.Location = new System.Drawing.Point(12, 41);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(256, 40);
            this.pbPrincipal.Step = 1;
            this.pbPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPrincipal.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.BackColor = System.Drawing.Color.Yellow;
            this.pbSecondaire.Location = new System.Drawing.Point(14, 126);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(256, 40);
            this.pbSecondaire.Step = 1;
            this.pbSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecondaire.TabIndex = 4;
            // 
            // lblSecondaire
            // 
            this.lblSecondaire.AutoSize = true;
            this.lblSecondaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaire.ForeColor = System.Drawing.Color.Navy;
            this.lblSecondaire.Location = new System.Drawing.Point(14, 94);
            this.lblSecondaire.Name = "lblSecondaire";
            this.lblSecondaire.Size = new System.Drawing.Size(105, 20);
            this.lblSecondaire.TabIndex = 3;
            this.lblSecondaire.Text = "Copie (virtuel)";
            // 
            // btnExecuter
            // 
            this.btnExecuter.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuter.Location = new System.Drawing.Point(18, 195);
            this.btnExecuter.Name = "btnExecuter";
            this.btnExecuter.Size = new System.Drawing.Size(105, 45);
            this.btnExecuter.TabIndex = 5;
            this.btnExecuter.Text = "Executer";
            this.btnExecuter.UseVisualStyleBackColor = true;
            this.btnExecuter.Click += new System.EventHandler(this.btnExecuter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(163, 195);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 45);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FicProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.lblSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FicProgression";
            this.Text = "Barres de Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Label lblSecondaire;
        private System.Windows.Forms.Button btnExecuter;
        private System.Windows.Forms.Button btnQuitter;
    }
}