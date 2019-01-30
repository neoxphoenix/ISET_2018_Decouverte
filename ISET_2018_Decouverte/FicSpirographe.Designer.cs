namespace ISET_2018_Decouverte
{
    partial class EcranSpirographe
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
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.lblProfondeur = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lblDensite = new System.Windows.Forms.Label();
            this.tbNbSommets = new System.Windows.Forms.TrackBar();
            this.lblNbSommets = new System.Windows.Forms.Label();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            this.gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommets)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControle
            // 
            this.gbControle.Controls.Add(this.btnFond);
            this.gbControle.Controls.Add(this.btnTrait);
            this.gbControle.Controls.Add(this.tbProfondeur);
            this.gbControle.Controls.Add(this.lblProfondeur);
            this.gbControle.Controls.Add(this.btnGo);
            this.gbControle.Controls.Add(this.tbDensite);
            this.gbControle.Controls.Add(this.lblDensite);
            this.gbControle.Controls.Add(this.tbNbSommets);
            this.gbControle.Controls.Add(this.lblNbSommets);
            this.gbControle.Location = new System.Drawing.Point(2, 12);
            this.gbControle.Name = "gbControle";
            this.gbControle.Size = new System.Drawing.Size(200, 321);
            this.gbControle.TabIndex = 0;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Controle";
            // 
            // btnFond
            // 
            this.btnFond.Location = new System.Drawing.Point(102, 272);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(92, 29);
            this.btnFond.TabIndex = 6;
            this.btnFond.Text = "Fond";
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.Image = global::ISET_2018_Decouverte.Properties.Resources.ICFond;
            this.btnTrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrait.Location = new System.Drawing.Point(6, 272);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(76, 29);
            this.btnTrait.TabIndex = 2;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(2, 167);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(188, 45);
            this.tbProfondeur.TabIndex = 5;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // lblProfondeur
            // 
            this.lblProfondeur.AutoSize = true;
            this.lblProfondeur.Location = new System.Drawing.Point(6, 150);
            this.lblProfondeur.Name = "lblProfondeur";
            this.lblProfondeur.Size = new System.Drawing.Size(152, 13);
            this.lblProfondeur.TabIndex = 4;
            this.lblProfondeur.Text = "Profondeur de dessin (20 à 80)";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(6, 233);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(188, 29);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "G o";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(6, 102);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(188, 45);
            this.tbDensite.TabIndex = 3;
            this.tbDensite.Value = 10;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(10, 85);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(130, 13);
            this.lblDensite.TabIndex = 2;
            this.lblDensite.Text = "Densité de dessin (5 à 20)";
            // 
            // tbNbSommets
            // 
            this.tbNbSommets.Location = new System.Drawing.Point(6, 37);
            this.tbNbSommets.Maximum = 8;
            this.tbNbSommets.Minimum = 3;
            this.tbNbSommets.Name = "tbNbSommets";
            this.tbNbSommets.Size = new System.Drawing.Size(188, 45);
            this.tbNbSommets.TabIndex = 1;
            this.tbNbSommets.Value = 5;
            // 
            // lblNbSommets
            // 
            this.lblNbSommets.AutoSize = true;
            this.lblNbSommets.Location = new System.Drawing.Point(10, 20);
            this.lblNbSommets.Name = "lblNbSommets";
            this.lblNbSommets.Size = new System.Drawing.Size(136, 13);
            this.lblNbSommets.TabIndex = 0;
            this.lblNbSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.gbControle);
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "EcranSpirographe";
            this.Text = "FicSpirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint);
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Label lblProfondeur;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.TrackBar tbNbSommets;
        private System.Windows.Forms.Label lblNbSommets;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}