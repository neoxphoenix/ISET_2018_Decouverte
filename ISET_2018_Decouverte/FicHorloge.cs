using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Decouverte
{
    public partial class EcranHorloge : Form
    {
        float clk_Width, clk_Height;
        float cx, cy;

        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            //timer 
            Chronometre.Interval = 1000; // = 1 sec
            Chronometre.Tick += new EventHandler(this.Chronometre_Tick);
            Chronometre.Start();
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            clk_Width = this.ClientRectangle.Width*0.99f; 
            clk_Height = this.ClientRectangle.Height*0.99f;
            cx = clk_Width / 2; //centre en x
            cy = clk_Height / 2; //centre en y
            //float brdClk = (this.ClientRectangle.Width*0.1f)/2; //Bordure pour l'horloge
            float AigSec = cx*0.9f, AigMin = cx*0.7f, AigHour = cx*0.5f; //Taille des aiguilles

            float[] handCoord = new float[2];

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            this.Text = hh.ToString() + ":" + mm.ToString() + ":" + ss.ToString();

            e.Graphics.DrawEllipse(new Pen(Color.Black, 1), 0, 0, clk_Width, clk_Height); //dessine le cercle

            //Aiguille des secs
            handCoord = msCoord(ss, AigSec);
            e.Graphics.DrawLine(new Pen(Color.Red, 1f), new Point((int)cx, (int)cy), new Point((int)handCoord[0], (int)handCoord[1]));
            //Aiguille des mins
            handCoord = msCoord(mm, AigMin);
            e.Graphics.DrawLine(new Pen(Color.Black, 2f), new Point((int)cx, (int)cy), new Point((int)handCoord[0], (int)handCoord[1]));
            //Aiguille des heures
            handCoord = hrCoord(hh % 12, mm, AigHour);
            e.Graphics.DrawLine(new Pen(Color.Gray, 3f), new Point((int)cx, (int)cy), new Point((int)handCoord[0], (int)handCoord[1]));

        }

        private void Chronometre_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        //Methode pour l'aiguille des minutes et secondes
        private float[] msCoord(float val, float hlen)
        {
            float[] coord = new float[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            { //hlen est ici la taille de l'aiguille, et en même temps le rayon
                coord[0] = cx + (float)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (float)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (float)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (float)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //Methode pour l'aiguille des heures
        private float[] hrCoord(float hval, float mval, float hlen)
        {
            float[] coord = new float[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            float val = (float)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (float)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (float)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (float)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (float)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

    }
}
