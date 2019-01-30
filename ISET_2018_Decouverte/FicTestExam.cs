using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ISET_2018_Decouverte
{
    public partial class EcranTestExam : Form
    {
        private TreeNode NoeudRacine; //Permet de gérer le TreeView

        public EcranTestExam()
        {
            InitializeComponent();
            /*
            //Directory.GetDirectories("c");
            string[] Disques = Environment.GetLogicalDrives(); //renvoie une chaine de caractère par disque trouvé donc on le stock dans un tableau de string
            foreach (string Disque in Disques)
                textBox1.Text += Disque + " | ";

            string[] sReps = Directory.GetDirectories("D:\\");
            foreach (string sRep in sReps)
            
                textBox1.Text += sRep + " | ";
                */

            FillTreeView(treeView1);
        }

        private List<LstDet> GenereList()
        {
            List<LstDet> lDisques = new List<LstDet>();
            List<string> Repertoires = new List<string>();
            string[] Disques = Environment.GetLogicalDrives();
            foreach (string Disque in Disques)
            {
                string[] sReps = Directory.GetDirectories(Disque);
                foreach (string sRep in sReps)
                    Repertoires.Add(sRep);
                lDisques.Add(new LstDet(Disque, Repertoires));
            }
            return lDisques;
        }

        private void FillTreeView(TreeView TreeAuChoix)
        {
            List<LstDet> TreeGetDirectory = GenereList();
            NoeudRacine = new TreeNode("Disques :");
            treeView1.Nodes.Add(NoeudRacine); 
            foreach (LstDet Disque in TreeGetDirectory)
            {
                TreeNode NoeudDisque = new TreeNode(Disque.Nom1);
                NoeudRacine.Nodes.Add(NoeudDisque);
                foreach (string Rep in Disque.Lst1)
                    NoeudDisque.Nodes.Add(Rep);
            }
        }

        private void CreateHTML()
        {
            List<LstDet> TreeGetDirectory = GenereList();
            StreamWriter sw = new StreamWriter("test.html");
            foreach (LstDet Disque in TreeGetDirectory)
            {
                sw.WriteLine(Disque.Nom1);
                foreach (string Rep in Disque.Lst1)
                    sw.WriteLine(Rep);
                sw.WriteLine("---");
            }
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CreateHTML();

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }


        }
    }
}
