using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FStart : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public FStart()
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 900;
        }

        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=..\\..\\..\\BD_Proiect.accdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void FStart_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);

        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti f = new Clienti();
            f.ShowDialog();

        }

        private void repereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repere f = new Repere();
            f.ShowDialog();
        }

        private void devizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devize f = new Devize();
            f.ShowDialog();
        }
    }
}
