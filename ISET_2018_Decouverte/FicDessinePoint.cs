using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Decouverte
{
    public partial class EcranDessinePoint : Form
    {
        int x, y, cx, cy, xprec = 0, correctScale, xmax;
        Random randNum = new Random();
        List<Point> PointsList = new List<Point>();
        Color Fond, Trait;
        GraphicsPath GraphEnr; //pr enregistrer l'image en mémoire

        public EcranDessinePoint()
        {
            InitializeComponent();
            Fond = Color.Transparent;
            Trait = Color.Black;
        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Trait = dlgCouleur.Color;
                pictureBox1.Invalidate();
            }
        }

        private void btnFond_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                pictureBox1.Refresh();
            }
        }


        private void tbNbrePoints_ValueChanged(object sender, EventArgs e)
        {
            lblNbrePoints.Text = tbNbrePoints.Value.ToString() + "/ 25 points";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                tbStatusY.Text = "zeze";
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr);
            }
        }

        private void btnDessiner_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            GraphEnr = new GraphicsPath();
            cx = pictureBox1.Width;
            cy = pictureBox1.Height;
            xprec = 0;
            tbStatusY.Text = "";
            PointsList.Clear();
            pictureBox1.BackColor = Fond;
            pictureBox1.Refresh();

            gr.DrawLine(new Pen(Color.Red, 1), new Point(0, cy/2), new Point(cx, cy/2));
            PointsList.Add(new Point(0,0)); //ajout du x de référence pour débuter le tracé

            for (int i = 1; i < tbNbrePoints.Value; i++)
            {
                x = randNum.Next(xprec + 5, xprec + 20);
                y = randNum.Next(-100, 100);
                xprec = x;

                PointsList.Add(new Point(x, y));
            }
            //PointsList.ForEach(el => tbStatusY.Text += el.ToString());
            xmax = PointsList[PointsList.Count() -1 ].X;
            correctScale = cx / xmax;
            //tbStatusY.Text = xmax.ToString() + " | " + correctScale;

            int nbrePointsMax = PointsList.Count();
            //Dessine les points
            for (int j = 1; j < nbrePointsMax-1; j++)
            {
                //gr.DrawLine(new Pen(Color.Black, 2), PointsList[j-1], new Point(PointsList[j].X,PointsList[j-1].Y));
                //gr.DrawLine(new Pen(Color.Black, 2), new Point(PointsList[j].X, PointsList[j - 1].Y), PointsList[j]);
                gr.DrawLine(new Pen(Trait, 2), new Point(PointsList[j-1].X * correctScale, PointsList[j-1].Y + (cy / 2)), new Point(PointsList[j].X * correctScale, PointsList[j - 1].Y + (cy / 2)));
                gr.DrawLine(new Pen(Trait, 2), new Point(PointsList[j].X * correctScale, PointsList[j - 1].Y + (cy / 2)), new Point(PointsList[j].X * correctScale, PointsList[j].Y + (cy / 2)));
                GraphEnr.AddLine(new Point(PointsList[j - 1].X * correctScale, PointsList[j - 1].Y + (cy / 2)), new Point(PointsList[j].X * correctScale, PointsList[j - 1].Y + (cy / 2)));
                GraphEnr.AddLine(new Point(PointsList[j].X * correctScale, PointsList[j - 1].Y + (cy / 2)), new Point(PointsList[j].X * correctScale, PointsList[j].Y + (cy / 2)));

            }
        }


    }
}
