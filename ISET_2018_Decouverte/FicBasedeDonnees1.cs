using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ISET_2018_Decouverte
{
    public partial class EcranBD1 : Form
    {
        private string sChConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = 'D:\Coding\db\perso.mdb'";
        public EcranBD1()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            lbContenu.Items.Clear();
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT PRE,NOM FROM Client ORDER BY NOM";
            OleDbDataReader dr = Comm.ExecuteReader();
            while (dr.Read())
                lbContenu.Items.Add(dr["PRE"].ToString() + " " + dr["NOM"]);
            dr.Close();
            Conn.Close();
        }

        private void btnCompter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT COUNT(NOM) FROM Client";
            int nb = (int)Comm.ExecuteScalar();
            MessageBox.Show(nb.ToString() + " enregistrements");
            Conn.Close();
        }

        private void btnSauver_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "INSERT INTO Client(NOM,PRE) VALUES('"
                + tbNom.Text + "','" + tbPrenom.Text + "')";
            int nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + " enregistrements effectué(s)");
            Conn.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(sChConn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "DELETE FROM Client WHERE NOM = '" + tbSup.Text + "'";
            int nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + " suppression(s) effectuée(s)");
            Conn.Close();
        }
    }
}
