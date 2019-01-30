namespace ISET_2018_Decouverte
{
    partial class EcranBD1
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
            this.lbContenu = new System.Windows.Forms.ListBox();
            this.btnCharger = new System.Windows.Forms.Button();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnSauver = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tbSup = new System.Windows.Forms.TextBox();
            this.btnCompter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContenu
            // 
            this.lbContenu.FormattingEnabled = true;
            this.lbContenu.Location = new System.Drawing.Point(12, 12);
            this.lbContenu.Name = "lbContenu";
            this.lbContenu.Size = new System.Drawing.Size(401, 147);
            this.lbContenu.TabIndex = 0;
            // 
            // btnCharger
            // 
            this.btnCharger.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCharger.Location = new System.Drawing.Point(12, 165);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(401, 23);
            this.btnCharger.TabIndex = 1;
            this.btnCharger.Text = "C h a r g e r";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(12, 194);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(320, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 220);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(320, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btnSauver
            // 
            this.btnSauver.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSauver.Location = new System.Drawing.Point(338, 202);
            this.btnSauver.Name = "btnSauver";
            this.btnSauver.Size = new System.Drawing.Size(75, 31);
            this.btnSauver.TabIndex = 4;
            this.btnSauver.Text = "Sauver";
            this.btnSauver.UseVisualStyleBackColor = true;
            this.btnSauver.Click += new System.EventHandler(this.btnSauver_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSupprimer.Location = new System.Drawing.Point(338, 262);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // tbSup
            // 
            this.tbSup.Location = new System.Drawing.Point(12, 265);
            this.tbSup.Name = "tbSup";
            this.tbSup.Size = new System.Drawing.Size(320, 20);
            this.tbSup.TabIndex = 5;
            // 
            // btnCompter
            // 
            this.btnCompter.Location = new System.Drawing.Point(12, 298);
            this.btnCompter.Name = "btnCompter";
            this.btnCompter.Size = new System.Drawing.Size(397, 23);
            this.btnCompter.TabIndex = 7;
            this.btnCompter.Text = "Compter";
            this.btnCompter.UseVisualStyleBackColor = true;
            this.btnCompter.Click += new System.EventHandler(this.btnCompter_Click);
            // 
            // EcranBD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 333);
            this.Controls.Add(this.btnCompter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tbSup);
            this.Controls.Add(this.btnSauver);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.lbContenu);
            this.Name = "EcranBD1";
            this.Text = "base de données \'CONSOLE\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContenu;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnSauver;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox tbSup;
        private System.Windows.Forms.Button btnCompter;
    }
}