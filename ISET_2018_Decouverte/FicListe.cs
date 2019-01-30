using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // biblio pr enregistrer
using System.Runtime.InteropServices;

namespace ISET_2018_Decouverte
{
    public partial class EcranListe : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int LB_Lire = 0x0199; // lire
        private const int LB_Ecrire = 0x019A; // ecrire
        private string NomFichier = "";

        //Init
        public EcranListe()
        {
            InitializeComponent();
        }

        private void Activer(bool lDetail)
        {
            lbPersonnes.Enabled = !lDetail;
            btnOuvrir.Enabled = btnEnregistrer.Enabled = btnAjouter.Enabled = btnSupprimer.Enabled = !lDetail;
            gbDetails.Enabled = lDetail;
            if (lDetail)
            {
                tbNom.Text = "";
                cbQualite.SelectedIndex = 0; //Selectionne le 1er index de la liste
                cbQualite.Focus();
            }
            else
                lbPersonnes.Focus();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int n = lbPersonnes.Items.Add(tbNom.Text + "(" + cbQualite.Text + ")");
            SendMessage(lbPersonnes.Handle, LB_Ecrire, n, lbPersonnes.Items.Count);
            Activer(false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int nItem = lbPersonnes.SelectedIndex;
            if (nItem >= 0)
            {
                int n = SendMessage(lbPersonnes.Handle, LB_Lire, nItem, 0);
                lbPersonnes.Items.RemoveAt(nItem);
                //tbInfo.Text = "n:" + n.ToString() + "T:" + lbPersonnes.Items.Count + "| ";

                for(int i=0; i<lbPersonnes.Items.Count; i++)
                {
                    int p = SendMessage(lbPersonnes.Handle, LB_Lire, i, 0);
                    if (p > n)
                        SendMessage(lbPersonnes.Handle, LB_Ecrire, i, p - 1);
                    //SendMessage(lbPersonnes.Handle, LB_Ecrire, i, numEncodage - 1);
                    //tbInfo.Text += p + " ";
                }
            }
            else
                MessageBox.Show("Aucune personne sélectionnée");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (dlgEnregistrer.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgEnregistrer.FileName);
                NomFichier = dlgEnregistrer.FileName;
                for(int i=0; i< lbPersonnes.Items.Count; i++)
                {
                    int n = SendMessage(lbPersonnes.Handle, LB_Lire, i, 0);
                    sw.WriteLine(lbPersonnes.Items[i] + "#" + n);
                }
                sw.Close();
                lblFichier.Text = NomFichier.Substring(1 + NomFichier.LastIndexOf('\\'));
                //On a rajouter '1 +' afin d'avoir UN CARACTERE après le dernier slash
            }
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if(NomFichier != "")
                dlgOuvrir.FileName = NomFichier;
            dlgOuvrir.Filter = "Fichiers texte| *.txt| Tous fichiers|*.*";

            if (dlgOuvrir.ShowDialog() == DialogResult.OK); //Cree un dialog avec OK
            {
                lbPersonnes.Items.Clear(); // Efface les items
                NomFichier = dlgOuvrir.FileName;
                StreamReader sr = new StreamReader(NomFichier);
                string lecture;
                while ((lecture = sr.ReadLine()) != null)
                {
                    String[] sModif = lecture.Split('#'); //Le split va séparer les strings à chaque rencontre ici d'un #
                    int n = lbPersonnes.Items.Add(sModif[0]); //Dans le tableau en 0 se trouve le nom de la personne, à gauche du #
                    SendMessage(lbPersonnes.Handle, LB_Ecrire, n, int.Parse(sModif[1])); //En position 1 se trouve le numéro, se trouvant à droite
                }
                sr.Close();
                lblFichier.Text = NomFichier.Substring(1 + NomFichier.LastIndexOf('\\'));
            }
        }

        private void lbPersonnes_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonnes.SelectedIndex >= 0)
            {
                int n = SendMessage(lbPersonnes.Handle, LB_Lire, lbPersonnes.SelectedIndex, 0);
                MessageBox.Show(lbPersonnes.Text + " en position " + (1 + lbPersonnes.SelectedIndex) + " (tri)," + n + " (encodage)");
            }
        }
    }
}
