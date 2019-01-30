using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ISET_2018_Decouverte
{
    public partial class EcranSpirographe : Form
    {
        //Variables
        private Color Fond, Trait;
        private GraphicsPath GraphEnr; //pr enregistrer l'image en mémoire

        public EcranSpirographe()
        {
            InitializeComponent();
            Fond = Color.DarkBlue;
            Trait = Color.Cyan;
        }

        private double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if(dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Trait = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void btnFond_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                Rectangle zone = new Rectangle(new Point(248, 0), ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(Fond), zone); //dessine le fond
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr);
            }
        }
        //Bouton GO
        private void btnGo_Click(object sender, EventArgs e)
        {
            int nSom = tbNbSommets.Value;
            int nDen = tbDensite.Value;
            int nPro = 100 - tbProfondeur.Value; //Afin d'aller à 20% de la distance
            GraphEnr = new GraphicsPath();
            Rectangle zone = new Rectangle(new Point(248, 0), ClientSize);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), zone);
            int xc = (gbControle.ClientSize.Width) + (ClientSize.Width - gbControle.ClientSize.Width) / 2;
            int yc = ClientSize.Height / 2;
            int rayon = 9 * Math.Min(ClientSize.Width - gbControle.ClientSize.Width, ClientSize.Height) / 20; //Afin d'avoir 90%
            float[] sX = new float[nSom + 1];
            float[] sY = new float[nSom + 1];
            for(int i=0; i<=nSom; i++)
            {
                sX[i] = (int)(xc + rayon * Math.Cos(2 * Math.PI * i / nSom));
                sY[i] = (int)(yc + rayon * Math.Sin(2 * Math.PI * i / nSom));
            }
            while(d(sX[0], sY[0], xc, yc) > rayon * nPro/100) //tant que la distance d'un des sommets est supérieur à une certaine valeur on continue 
            {
                //Dessine
                for(int i = 1; i <= nSom; i++)
                {
                    gr.DrawLine(new Pen(Trait), sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    GraphEnr.AddLine(sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    Application.DoEvents(); //Permet d'empecher que la fenetre se bloque en regardant s'il s'est passé quelque chose
                    Thread.Sleep(15); // Ralenti
                }
                //Calcule
                for (int i=0; i< nSom; i++)
                {
                    sX[i] = sX[i] + (sX[1 + i] - sX[i]) / nDen; //Prepare le point suivant à redessiner
                    sY[i] = sY[i] + (sY[1 + i] - sY[i]) / nDen; 
                }
                sX[nSom] = sX[0];
                sY[nSom] = sY[0];
            }
        }

    }
}
