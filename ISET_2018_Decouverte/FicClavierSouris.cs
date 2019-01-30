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
    public partial class EcranClavierSouris : Form
    {
        // IL FAUT ACTIVER LE "KEYPREVIEW" dans les options de la fenêtre
        int nGauche, nDroit;

        public EcranClavierSouris()
        {
            InitializeComponent();
            btnRaz_Click(null, null); //On met null afin d'utiliser la méthode sans avoir besoin des arguments
        }

        private void btnRaz_Click(object sender, EventArgs e)
        {
            lbClavier.Items.Clear();
            nGauche = nDroit = 0;
            tbGauche.Text = tbDroite.Text = "0";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            tbPosX.Text = e.X.ToString();
            tbPosY.Text = e.Y.ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    nGauche++;
                    tbGauche.Text = nGauche.ToString();
                    break;
                case MouseButtons.Right:
                    nDroit++;
                    tbDroite.Text = nDroit.ToString();
                    break;
            }
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "Touche pressée : " + e.KeyChar;
            lbClavier.Items.Insert(0, s);
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            string s = "Touche enfoncée" + e.KeyCode + ", valeur : " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            string s = "Touche relachée" + e.KeyCode + ", valeur : " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
