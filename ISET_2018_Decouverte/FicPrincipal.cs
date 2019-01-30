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
    public partial class FicPrincipal : Form
    {
        public FicPrincipal()
        {
            InitializeComponent();
            //FicAccueil fa = new EcranAccueil();
        }

        private void mQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FicPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FicPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Souhaitez réellement quitter ?", "Votre souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void mAide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aide f = new Aide();
            f.ShowDialog();
            this.Show();
        }

        private void mfProgression_Click(object sender, EventArgs e)
        {
            FicProgression f = new FicProgression();
            f.ShowDialog();
        }

        private void mNonDefini_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void mfEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void mfHorloge_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.ShowDialog();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.ShowDialog();
        }

        private void dessinePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranDessinePoint f = new EcranDessinePoint();
            f.ShowDialog();
        }

        private void mfCarnaval_Click(object sender, EventArgs e)
        {
            EcranCarnaval f = new EcranCarnaval();
            f.ShowDialog();
        }

        private void mfClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.ShowDialog();
        }

        private void mfExplorateur_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();
            f.ShowDialog();
        }

        private void mfBD1_Click(object sender, EventArgs e)
        {
            EcranBD1 f = new EcranBD1();
            f.ShowDialog();
        }

        private void baseDeDonnées2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranBD2 f = new EcranBD2();
            f.ShowDialog();
        }

        private void baseDeDonnées3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranBD3 f = new EcranBD3();
            f.ShowDialog();
        }

        private void dinerDesPhilosophesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranDinerPhilosophes f = new EcranDinerPhilosophes();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EcranExpressionsRegulieres f = new EcranExpressionsRegulieres();
            f.ShowDialog();
        }

        private void intégralesMathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranIntegrales f = new EcranIntegrales();
            f.ShowDialog();
        }

        private void testPourLexamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranTestExam f = new EcranTestExam();
            f.ShowDialog();
        }
    }
}
