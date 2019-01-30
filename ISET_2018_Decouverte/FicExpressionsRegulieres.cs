using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ISET_2018_Decouverte
{
    public partial class EcranExpressionsRegulieres : Form
    {
        public EcranExpressionsRegulieres()
        {
            InitializeComponent();
        }

        private void cbIsRespectCasse_CheckedChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase),rtTexteATraiter);
        }

        private void cbSeparer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeparer.Checked)
            {
                if (tbExpressionsReg.Text.Trim() != "")
                {
                    string[] tTmp = DecouperOccurrence(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                    foreach (string s in tTmp)
                        MessageBox.Show(s);
                }
                else
                {
                    MessageBox.Show("Renseigner une expression avant de 'découper'");
                    cbSeparer.Checked = false;
                }
            }
            
        }

        private void cbRemplacer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemplacer.Checked)
                MessageBox.Show(RemplacerOccurrence(tbExpressionsReg.Text, rtTexteATraiter.Text, tbRemplacement.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase));
            cbRemplacer.Checked = false;
        }

        private void EcranExpressionsRegulieres_Load(object sender, EventArgs e)
        {
            tbExpressionsReg_TextChanged(null, null);
        }

        private void tbExpressionsReg_TextChanged(object sender, EventArgs e)
        {
            if (cbIsValid.Checked = Validite(tbExpressionsReg.Text))
            {
                cbIsCorrespondance.Checked = Correspondance(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                MettreEnEvidence(TrouverOccurrences(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtTexteATraiter);
            }
        }

        private void rtTexte_TextChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(tbExpressionsReg.Text, rtTexteATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtTexteATraiter);
        }

        private bool Validite(string sExpressionReguliere)
        {
            try
            {
                Regex test = new Regex(sExpressionReguliere);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Correspondance(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
 	    {
            try
 	        {
                Regex exp = new Regex(sExpressionReguliere, roParametres);
                return exp.IsMatch(sAVerifier);
 	        }

 	        catch
 	        {
                return false;
            }
        }

        private MatchCollection TrouverOccurrences(string sExpressionReguliere, 
                                                    string sAVerifier, 
                                                    RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Matches(sAVerifier);
        }

        private void MettreEnEvidence(MatchCollection Occurences, RichTextBox Controle)
        {
            Controle.Select(0, Controle.Text.Length);
            Controle.SelectionBackColor = Color.Transparent;
            foreach (Match Occurence in Occurences)
            {
                Controle.Select(Occurence.Index, Occurence.Length);
                Controle.SelectionBackColor = Color.Silver;
            }
        }

        private string RemplacerOccurrence(string sExpressionReguliere,
                                            string sTexteDepart,
                                            string sRemplacement,
                                            RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Replace(sTexteDepart, sRemplacement);
        }

        public string[] DecouperOccurrence(string sExpressionReguliere,
                                            string sATraiter,
                                            RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Split(sATraiter);
        }


    }
}
