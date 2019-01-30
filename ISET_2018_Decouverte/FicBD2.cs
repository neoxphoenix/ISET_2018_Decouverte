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
    public partial class EcranBD2 : Form
    {
        public EcranBD2()
        {
            InitializeComponent();
            clientBindingSource.PositionChanged += new EventHandler(BougerClient);
        }

        private void EcranBD2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dsPerso.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.dsPerso.Client); //memoire tampon
            //string s = Program.PA.ChConnBD;
            //lblPos.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            //Bouger();
            ActiverNavi(clientBindingSource.Count > 0);
        }

        private void BougerClient(object sender, EventArgs e)
        {
            Bouger();
        }

        private void btnPrem_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = 0;
        }

        private void btnPrec_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position--;
        }

        private void btnSuiv_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position++;
        }

        private void btnDern_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = clientBindingSource.Count - 1;
        }
        private void ActiverNavi(bool lActiv)
        {
            //btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = lActiv;
            btnAjout.Enabled = btnModi.Enabled = btnSupp.Enabled = lActiv;
            tbPrenom.Enabled = tbNom.Enabled = dtDateNaissance.Enabled = !lActiv;
            btnConf.Enabled = btnAnul.Enabled = !lActiv;
        }
        private void Bouger()
        {
            btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = true;
            if (clientBindingSource.Position == 0)
                btnPrem.Enabled = btnPrec.Enabled = false;
            if (clientBindingSource.Position == clientBindingSource.Count - 1)
                btnSuiv.Enabled = btnDern.Enabled = false;
            lblPos.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            //if (clientBindingSource.Count == 0)
            //    btnSupp.Enabled = btnModi.Enabled = false;
            //else
            //    btnSupp.Enabled = btnModi.Enabled = true;
            btnSupp.Enabled = btnModi.Enabled = (clientBindingSource.Count > 0); //equivalent 4 dernieres lignes
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            ActiverNavi(false); 
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            ActiverNavi(false);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous supprimer cet enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                ValiderModif();
                Bouger();
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if (dsPerso.HasChanges())
                ValiderModif();
            else
                MessageBox.Show("Aucune modificaiton");
            ActiverNavi(true);
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit(); //annule
            ActiverNavi(true);
        }
        private void ValiderModif()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(dsPerso.Client).ToString() + " mise(s) à jour effectuée(s)");
            }
            catch
            {
                MessageBox.Show("Echec de la mise à jour");
            }
        }
    }
}
