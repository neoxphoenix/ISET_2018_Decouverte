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
    public partial class EcranEditeur : Form
    {
        private bool lModifie = false; //Pour voir si on a pas toucher au textbox
        private string NomFichier = "";

        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void EnregistrerFichier()
        {
            if(NomFichier == "")
                if(dlgSauverFichier.ShowDialog() == DialogResult.OK)
                    NomFichier = dlgSauverFichier.FileName;
            if(NomFichier != "")
            {
                rtbText.SaveFile(NomFichier);
                lModifie = false;
            }
        }
        private void VerifierSauver()
        {
            if (lModifie)
                if (MessageBox.Show("Enregistrer la modification ?", "Texte modifié", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    EnregistrerFichier();
        }

        private void BoutonNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbText.Clear();
            NomFichier = "";
            lModifie = false;
            rtbText.Focus();
        }

        private void BoutonOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if(dlgouvrirFichier.ShowDialog() == DialogResult.OK )
            {
                NomFichier = dlgouvrirFichier.FileName;
                rtbText.LoadFile(NomFichier);
            }
            lModifie = false;

        }

        private void BoutonEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerFichier();
        }

        private void BoutonQuitter_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            Close();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            lModifie = true;
        }

        private void meeCouper_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void meeCopier_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void meeColler_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void mefjGauche_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mefjDroite_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mefjCentre_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mefPolice_Click(object sender, EventArgs e)
        {
            if (dlgPolice.ShowDialog() == DialogResult.OK)
                rtbText.SelectionFont = new Font(dlgPolice.Font, dlgPolice.Font.Style);
        }

        private void mefcGras_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbText.SelectionFont.Bold)
            NouvellePolice = PoliceActuelle.Style ^ FontStyle.Bold;
            //else
            //   NouvellePolice = FontStyle.Bold;
            rtbText.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void mefcItalique_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            // if (rtbText.SelectionFont.Italic)
            NouvellePolice = PoliceActuelle.Style ^ FontStyle.Italic;
            // L'opérateur "^" est un opérateur logique XOR, dans ce cas-ci on active/désactive le bold tout en gardant toutes les autres modifs (italique, gras, etc.) telles qu'elles étaient activées
            // else
            //     NouvellePolice = FontStyle.Italic;
            rtbText.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);

        }

        private void mefcSouligne_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            NouvellePolice = PoliceActuelle.Style ^ FontStyle.Underline;
            rtbText.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);

        }

        private void mefcBarre_Click(object sender, EventArgs e)
        {
            textBox1.Text = rtbText.SelectionFont.Style.ToString();
            System.Drawing.Font PoliceActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            NouvellePolice = PoliceActuelle.Style ^ FontStyle.Strikeout;
            rtbText.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);

        }
    }
}
