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
    public partial class EcranIntegrales : Form
    {
        static private double fctPolynome(double x)
        {
            return x * x - 3 * x + 4;
        }
        static private double fctCosinus(double x)
        {
            return Math.Cos(x);
        }
        delegate double fctAIntegrer(double a); //delegate permet de préparer à avoir un pointeur
        public EcranIntegrales()
        {
            InitializeComponent();
        }

        private void btnPolynome_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbInt;
            if ((double.TryParse(tbGauche.Text, out a)) &&
                (double.TryParse(tbDroite.Text, out b)) &&
                (int.TryParse(tbIntervalle.Text, out nbInt)))
            {
                lbResultat.Items.Clear();
                fctAIntegrer f = new fctAIntegrer(fctPolynome);
                for (int i = 0; i < 5; i++, nbInt*=2)
                {
                    lbResultat.Items.Add("Nb int = " + nbInt + " => " + IntegrationRectangleGauche(f, a, b, nbInt));
                    //nbInt *= 2;
                }
            }
            else
                MessageBox.Show("Vérifier vos entrées");
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbInt;
            if ((double.TryParse(tbGauche.Text, out a)) &&
                (double.TryParse(tbDroite.Text, out b)) &&
                (int.TryParse(tbIntervalle.Text, out nbInt)))
            {
                lbResultat.Items.Clear();
                fctAIntegrer f = new fctAIntegrer(fctCosinus);
                for (int i = 0; i < 5; i++, nbInt *= 2)
                {
                    lbResultat.Items.Add("Nb int = " + nbInt + " => " + IntegrationRectangleGauche(f, a, b, nbInt));
                }
            }
            else
                MessageBox.Show("Vérifier vos entrées");
        }

        static double IntegrationRectangleGauche(fctAIntegrer f, double bg, double bd, int n)
        {
            double Aire = 0;
            double x = bg;
            double p = (bd - bg) / n;
            for (int i=0; i < n; i++)
            {
                Aire += p * f(x);
                x += p;
            }
            return Aire;
        }
    }
}
