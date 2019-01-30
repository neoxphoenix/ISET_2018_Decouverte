namespace ISET_2018_Decouverte
{
    partial class EcranExpressionsRegulieres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExpressionsRegulieres));
            this.lblExpressionsRegulieres = new System.Windows.Forms.Label();
            this.tbExpressionsReg = new System.Windows.Forms.TextBox();
            this.cbIsValid = new System.Windows.Forms.CheckBox();
            this.cbIsCorrespondance = new System.Windows.Forms.CheckBox();
            this.cbIsRespectCasse = new System.Windows.Forms.CheckBox();
            this.cbRemplacer = new System.Windows.Forms.CheckBox();
            this.cbSeparer = new System.Windows.Forms.CheckBox();
            this.tbRemplacement = new System.Windows.Forms.TextBox();
            this.lblRemplacement = new System.Windows.Forms.Label();
            this.lblATraiter = new System.Windows.Forms.Label();
            this.rtTexteATraiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblExpressionsRegulieres
            // 
            this.lblExpressionsRegulieres.AutoSize = true;
            this.lblExpressionsRegulieres.Location = new System.Drawing.Point(9, 9);
            this.lblExpressionsRegulieres.Name = "lblExpressionsRegulieres";
            this.lblExpressionsRegulieres.Size = new System.Drawing.Size(111, 13);
            this.lblExpressionsRegulieres.TabIndex = 0;
            this.lblExpressionsRegulieres.Text = "Expressions régulières";
            // 
            // tbExpressionsReg
            // 
            this.tbExpressionsReg.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpressionsReg.Location = new System.Drawing.Point(12, 32);
            this.tbExpressionsReg.Name = "tbExpressionsReg";
            this.tbExpressionsReg.Size = new System.Drawing.Size(429, 20);
            this.tbExpressionsReg.TabIndex = 1;
            this.tbExpressionsReg.TextChanged += new System.EventHandler(this.tbExpressionsReg_TextChanged);
            // 
            // cbIsValid
            // 
            this.cbIsValid.AutoSize = true;
            this.cbIsValid.Enabled = false;
            this.cbIsValid.Location = new System.Drawing.Point(12, 58);
            this.cbIsValid.Name = "cbIsValid";
            this.cbIsValid.Size = new System.Drawing.Size(60, 17);
            this.cbIsValid.TabIndex = 2;
            this.cbIsValid.Text = "Validité";
            this.cbIsValid.UseVisualStyleBackColor = true;
            // 
            // cbIsCorrespondance
            // 
            this.cbIsCorrespondance.AutoSize = true;
            this.cbIsCorrespondance.Enabled = false;
            this.cbIsCorrespondance.Location = new System.Drawing.Point(141, 58);
            this.cbIsCorrespondance.Name = "cbIsCorrespondance";
            this.cbIsCorrespondance.Size = new System.Drawing.Size(143, 17);
            this.cbIsCorrespondance.TabIndex = 3;
            this.cbIsCorrespondance.Text = "Correspondance trouvée";
            this.cbIsCorrespondance.UseVisualStyleBackColor = true;
            // 
            // cbIsRespectCasse
            // 
            this.cbIsRespectCasse.AutoSize = true;
            this.cbIsRespectCasse.Location = new System.Drawing.Point(318, 58);
            this.cbIsRespectCasse.Name = "cbIsRespectCasse";
            this.cbIsRespectCasse.Size = new System.Drawing.Size(123, 17);
            this.cbIsRespectCasse.TabIndex = 4;
            this.cbIsRespectCasse.Text = "Respect de la casse";
            this.cbIsRespectCasse.UseVisualStyleBackColor = true;
            this.cbIsRespectCasse.CheckedChanged += new System.EventHandler(this.cbIsRespectCasse_CheckedChanged);
            // 
            // cbRemplacer
            // 
            this.cbRemplacer.AutoSize = true;
            this.cbRemplacer.Location = new System.Drawing.Point(12, 81);
            this.cbRemplacer.Name = "cbRemplacer";
            this.cbRemplacer.Size = new System.Drawing.Size(77, 17);
            this.cbRemplacer.TabIndex = 5;
            this.cbRemplacer.Text = "Remplacer";
            this.cbRemplacer.UseVisualStyleBackColor = true;
            this.cbRemplacer.CheckedChanged += new System.EventHandler(this.cbRemplacer_CheckedChanged);
            // 
            // cbSeparer
            // 
            this.cbSeparer.AutoSize = true;
            this.cbSeparer.Location = new System.Drawing.Point(141, 81);
            this.cbSeparer.Name = "cbSeparer";
            this.cbSeparer.Size = new System.Drawing.Size(63, 17);
            this.cbSeparer.TabIndex = 6;
            this.cbSeparer.Text = "Séparer";
            this.cbSeparer.UseVisualStyleBackColor = true;
            this.cbSeparer.CheckedChanged += new System.EventHandler(this.cbSeparer_CheckedChanged);
            // 
            // tbRemplacement
            // 
            this.tbRemplacement.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemplacement.Location = new System.Drawing.Point(12, 126);
            this.tbRemplacement.Name = "tbRemplacement";
            this.tbRemplacement.Size = new System.Drawing.Size(429, 20);
            this.tbRemplacement.TabIndex = 8;
            // 
            // lblRemplacement
            // 
            this.lblRemplacement.AutoSize = true;
            this.lblRemplacement.Location = new System.Drawing.Point(9, 110);
            this.lblRemplacement.Name = "lblRemplacement";
            this.lblRemplacement.Size = new System.Drawing.Size(118, 13);
            this.lblRemplacement.TabIndex = 7;
            this.lblRemplacement.Text = "Texte de remplacement";
            // 
            // lblATraiter
            // 
            this.lblATraiter.AutoSize = true;
            this.lblATraiter.Location = new System.Drawing.Point(9, 164);
            this.lblATraiter.Name = "lblATraiter";
            this.lblATraiter.Size = new System.Drawing.Size(72, 13);
            this.lblATraiter.TabIndex = 9;
            this.lblATraiter.Text = "Texte à traiter";
            // 
            // rtTexteATraiter
            // 
            this.rtTexteATraiter.Location = new System.Drawing.Point(12, 180);
            this.rtTexteATraiter.Name = "rtTexteATraiter";
            this.rtTexteATraiter.Size = new System.Drawing.Size(429, 205);
            this.rtTexteATraiter.TabIndex = 10;
            this.rtTexteATraiter.Text = resources.GetString("rtTexteATraiter.Text");
            this.rtTexteATraiter.TextChanged += new System.EventHandler(this.rtTexte_TextChanged);
            // 
            // EcranExpressionsRegulieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.rtTexteATraiter);
            this.Controls.Add(this.lblATraiter);
            this.Controls.Add(this.tbRemplacement);
            this.Controls.Add(this.lblRemplacement);
            this.Controls.Add(this.cbSeparer);
            this.Controls.Add(this.cbRemplacer);
            this.Controls.Add(this.cbIsRespectCasse);
            this.Controls.Add(this.cbIsCorrespondance);
            this.Controls.Add(this.cbIsValid);
            this.Controls.Add(this.tbExpressionsReg);
            this.Controls.Add(this.lblExpressionsRegulieres);
            this.Name = "EcranExpressionsRegulieres";
            this.Text = "Exprssions régulières";
            this.Load += new System.EventHandler(this.EcranExpressionsRegulieres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpressionsRegulieres;
        private System.Windows.Forms.TextBox tbExpressionsReg;
        private System.Windows.Forms.CheckBox cbIsValid;
        private System.Windows.Forms.CheckBox cbIsCorrespondance;
        private System.Windows.Forms.CheckBox cbIsRespectCasse;
        private System.Windows.Forms.CheckBox cbRemplacer;
        private System.Windows.Forms.CheckBox cbSeparer;
        private System.Windows.Forms.TextBox tbRemplacement;
        private System.Windows.Forms.Label lblRemplacement;
        private System.Windows.Forms.Label lblATraiter;
        private System.Windows.Forms.RichTextBox rtTexteATraiter;
    }
}