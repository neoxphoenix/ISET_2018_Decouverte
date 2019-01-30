using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISET2018_CoucheClasses;
using ISET2018_CoucheGestion;

namespace ISET_2018_Decouverte
{
    public partial class EcranBD3 : Form
    {
        private DataTable dtpersonne;
        private BindingSource bsPersonne; 
        private string sChConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jona\source\repos\ISET_2018_Decouverte\ISET_2018_Decouverte\BD_Perso.mdf;Integrated Security=True";
  
        public EcranBD3()
        {
            InitializeComponent();
            RemplirDGV();
            if (dgvPersonne.Rows.Count > 0)
            {
                Activer(true);
                dgvPersonne.Rows[0].Selected = true;
            }
            else
            {
                Activer(false);
            }
        }

        private void Activer(bool lNavigation)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lNavigation;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !lNavigation;
            dtpNai.Enabled = tbNom.Enabled = tbPre.Enabled = !lNavigation;
            dgvPersonne.Enabled = lNavigation;
            if (lNavigation)
                dgvPersonne.Focus();
            else
                tbPre.Focus();
        }
        private void RemplirDGV()
        {
            dtpersonne = new DataTable();
            dtpersonne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtpersonne.Columns.Add("Afficher");
            List<C_Personne> lTmp = new G_Personne(sChConn).Lire("Nom");
            foreach (C_Personne Tmp in lTmp)
                dtpersonne.Rows.Add(Tmp.ID, Tmp.PRE + " " + Tmp.NOM);
            bsPersonne = new BindingSource();
            bsPersonne.DataSource = dtpersonne;
            dgvPersonne.DataSource = bsPersonne;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbPre.Text = tbNom.Text = "";
            dtpNai.Value = DateTime.Today;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text = dgvPersonne.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne Tmp = new G_Personne(sChConn).Lire_ID(int.Parse(tbId.Text));
                tbPre.Text = Tmp.PRE;
                tbNom.Text = Tmp.NOM;
                dtpNai.Value = (Tmp.NAI == null ? DateTime.Today : (DateTime)Tmp.NAI); /* CETTE LIGNE EST L'EQUIVALENT DE :
                if (Tmp.NAI == null) { dtpNai.Value = DateTime.Today; }     else { dtpNai.Value = (DateTime)Tmp.NAI; } */
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {

                int nID = (int)dgvPersonne.SelectedRows[0].Cells["ID"].Value;
                new G_Personne(sChConn).Supprimer(nID);
                bsPersonne.RemoveCurrent();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner le nom");
            }
            else
                {
                if (tbId.Text == "")
                {
                    //Mode ajout
                    int nID = new G_Personne(sChConn).Ajouter(tbNom.Text, tbPre.Text, dtpNai.Value);
                    dtpersonne.Rows.Add(nID, tbPre.Text + " " + tbNom.Text);
                }
                else
                {
                    //Mode édition
                    int nID = int.Parse(tbId.Text);
                    new G_Personne(sChConn).Modifier(nID, tbNom.Text, tbPre.Text, dtpNai.Value);
                    for (int i = 0; i < dtpersonne.Rows.Count; i++)
                        if ((int)dtpersonne.Rows[i]["ID"] == nID)
                        {
                            dtpersonne.Rows[i]["Afficher"] = tbPre.Text + " " + tbNom.Text;
                            break;
                        }
                }
                Activer(true);
            }
        }
    }
}
