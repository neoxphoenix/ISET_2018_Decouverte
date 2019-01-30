namespace ISET_2018_Decouverte
{
    partial class EcranDessinePoint
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
            this.tbNbrePoints = new System.Windows.Forms.TrackBar();
            this.btnDessiner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStatusY = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNbrePoints = new System.Windows.Forms.Label();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbrePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNbrePoints
            // 
            this.tbNbrePoints.Location = new System.Drawing.Point(114, 12);
            this.tbNbrePoints.Maximum = 25;
            this.tbNbrePoints.Minimum = 10;
            this.tbNbrePoints.Name = "tbNbrePoints";
            this.tbNbrePoints.Size = new System.Drawing.Size(153, 45);
            this.tbNbrePoints.TabIndex = 0;
            this.tbNbrePoints.Value = 10;
            this.tbNbrePoints.ValueChanged += new System.EventHandler(this.tbNbrePoints_ValueChanged);
            // 
            // btnDessiner
            // 
            this.btnDessiner.Location = new System.Drawing.Point(15, 34);
            this.btnDessiner.Name = "btnDessiner";
            this.btnDessiner.Size = new System.Drawing.Size(75, 23);
            this.btnDessiner.TabIndex = 1;
            this.btnDessiner.Text = "Dessiner";
            this.btnDessiner.UseVisualStyleBackColor = true;
            this.btnDessiner.Click += new System.EventHandler(this.btnDessiner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de points :";
            // 
            // tbStatusY
            // 
            this.tbStatusY.Location = new System.Drawing.Point(430, 2);
            this.tbStatusY.Multiline = true;
            this.tbStatusY.Name = "tbStatusY";
            this.tbStatusY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatusY.Size = new System.Drawing.Size(223, 55);
            this.tbStatusY.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 308);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNbrePoints
            // 
            this.lblNbrePoints.AutoSize = true;
            this.lblNbrePoints.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrePoints.Location = new System.Drawing.Point(141, 46);
            this.lblNbrePoints.Name = "lblNbrePoints";
            this.lblNbrePoints.Size = new System.Drawing.Size(105, 14);
            this.lblNbrePoints.TabIndex = 5;
            this.lblNbrePoints.Text = "10 / 25 points";
            // 
            // btnFond
            // 
            this.btnFond.Location = new System.Drawing.Point(310, 5);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(75, 23);
            this.btnFond.TabIndex = 6;
            this.btnFond.Text = "Fond";
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.Location = new System.Drawing.Point(310, 34);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(75, 23);
            this.btnTrait.TabIndex = 7;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // EcranDessinePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 375);
            this.Controls.Add(this.btnTrait);
            this.Controls.Add(this.btnFond);
            this.Controls.Add(this.lblNbrePoints);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbStatusY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDessiner);
            this.Controls.Add(this.tbNbrePoints);
            this.Name = "EcranDessinePoint";
            this.Text = "Dessine Points Fréquence";
            ((System.ComponentModel.ISupportInitialize)(this.tbNbrePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbNbrePoints;
        private System.Windows.Forms.Button btnDessiner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStatusY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNbrePoints;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}