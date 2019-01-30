namespace ISET_2018_Decouverte
{
    partial class EcranBD2
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
            this.components = new System.ComponentModel.Container();
            this.lblPre = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPerso = new ISET_2018_Decouverte.dsPerso();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrem = new System.Windows.Forms.Button();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.clientTableAdapter = new ISET_2018_Decouverte.dsPersoTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPre.Location = new System.Drawing.Point(9, 9);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(41, 12);
            this.lblPre.TabIndex = 0;
            this.lblPre.Text = "Prenom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.tbPrenom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(12, 25);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(274, 22);
            this.tbPrenom.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dsPerso;
            // 
            // dsPerso
            // 
            this.dsPerso.DataSetName = "dsPerso";
            this.dsPerso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbNom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(12, 66);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(274, 22);
            this.tbNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNom.Location = new System.Drawing.Point(12, 50);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(23, 12);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.dtDateNaissance.Location = new System.Drawing.Point(13, 117);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.Size = new System.Drawing.Size(270, 20);
            this.dtDateNaissance.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de naissance";
            // 
            // btnPrem
            // 
            this.btnPrem.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrem.Location = new System.Drawing.Point(12, 143);
            this.btnPrem.Name = "btnPrem";
            this.btnPrem.Size = new System.Drawing.Size(35, 35);
            this.btnPrem.TabIndex = 6;
            this.btnPrem.Text = "| <";
            this.btnPrem.UseVisualStyleBackColor = true;
            this.btnPrem.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnPrec
            // 
            this.btnPrec.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrec.Location = new System.Drawing.Point(53, 143);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(35, 35);
            this.btnPrec.TabIndex = 7;
            this.btnPrec.Text = "<";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSuiv.Location = new System.Drawing.Point(207, 143);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(35, 35);
            this.btnSuiv.TabIndex = 8;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // btnDern
            // 
            this.btnDern.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDern.Location = new System.Drawing.Point(248, 143);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(35, 35);
            this.btnDern.TabIndex = 9;
            this.btnDern.Text = "> |";
            this.btnDern.UseVisualStyleBackColor = true;
            this.btnDern.Click += new System.EventHandler(this.btnDern_Click);
            // 
            // lblPos
            // 
            this.lblPos.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.Color.White;
            this.lblPos.Location = new System.Drawing.Point(94, 143);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(107, 35);
            this.lblPos.TabIndex = 10;
            this.lblPos.Text = "p / y";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAjout.Location = new System.Drawing.Point(10, 184);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(82, 30);
            this.btnAjout.TabIndex = 11;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnModi.Location = new System.Drawing.Point(107, 184);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(82, 30);
            this.btnModi.TabIndex = 12;
            this.btnModi.Text = "Modifier";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSupp.Location = new System.Drawing.Point(204, 184);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(82, 30);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAnul.Location = new System.Drawing.Point(150, 220);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(82, 30);
            this.btnAnul.TabIndex = 15;
            this.btnAnul.Text = "Annuler";
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConf.Location = new System.Drawing.Point(53, 220);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(82, 30);
            this.btnConf.TabIndex = 14;
            this.btnConf.Text = "Confirmer";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // EcranBD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 256);
            this.Controls.Add(this.btnAnul);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnDern);
            this.Controls.Add(this.btnSuiv);
            this.Controls.Add(this.btnPrec);
            this.Controls.Add(this.btnPrem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDateNaissance);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblPre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBD2";
            this.Text = "Gestion de base de données 2";
            this.Load += new System.EventHandler(this.EcranBD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DateTimePicker dtDateNaissance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrem;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnConf;
        private dsPerso dsPerso;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dsPersoTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}