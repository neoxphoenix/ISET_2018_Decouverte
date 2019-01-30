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
    public partial class FicProgression : Form
    {
        public FicProgression()
        {
            InitializeComponent();
        }
        
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas;
            Cursor Curseur = this.Cursor;
            Random delai = new Random();
            Cursor = Cursors.WaitCursor; // Curseur de style Waiting
            btnExecuter.Enabled = btnExecuter.Enabled = false;
            pbPrincipal.Value = 0;

            for (i=1; i<=8; i++)  
            {
                pbSecondaire.Value = 0;
                pas = 5 + 9 * delai.Next(20);

                for (j=1; j<=20; j++)
                {
                    pbSecondaire.Value = j * 5;
                    System.Threading.Thread.Sleep(pas);
                }
                pbPrincipal.Value = i * 100 / 8;
            }

            btnExecuter.Enabled = btnExecuter.Enabled = true;
            Cursor = Curseur; //Remet le style curseur d'origine
        }
    }
}
