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
    public partial class EcranAccueil : Form
    {
        int ImgSet = 0;
        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void btnPoussez_Click(object sender, EventArgs e)
        {
            if (ImgSet == 0)
            {
                lblTitre.Text = "Image 1";
                pbImageDepart.Image = global::ISET_2018_Decouverte.Properties.Resources._2018_01_24_20_44_42_ELO_technique_digitales_2_pdf____Aucun_titre_de_diapositive____SumatraPDF;
                ImgSet = 1;
            }
            else
            {
                lblTitre.Text = "Image 2";
                this.pbImageDepart.Image = global::ISET_2018_Decouverte.Properties.Resources._2018_01_24_21_11_52_ELO_technique_digitales_2_pdf____Aucun_titre_de_diapositive____SumatraPDF;
                ImgSet = 0;
            }
        }


        private void btnEntrer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
