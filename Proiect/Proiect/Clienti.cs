using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Clienti : Form
    {
        private Form master;
        private bool selectie;

        public Clienti()
        {
            InitializeComponent();
        }

        public void SetMaster(Form caller)
        {
            master = caller;
        }

        public void SetSelectVisible()
        {
            selectie = true;
        }


        private void Clienti_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            clientiTableAdapter.Fill(dataSet1.Clienti);

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdClient.ReadOnly = true;

            numeClientDataGridViewTextBoxColumn.Width = 200;
            adresaDataGridViewTextBoxColumn.Width = 300;

            A3();
        }

        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtNumeClient.Focus();

            // Golire campuri
            golireCampuri();
        }


        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtNumeClient.Focus();
                refresh_grid(clientiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(clientiBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata!");
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNumeClient.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdClient From Devize where IdClient=" + txtIdClient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Client referit in tabelul Devize! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            cmd.CommandText = "Delete From Clienti Where IdClient = " + txtIdClient.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(clientiBindingSource.Position);

        }




        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void protectiePanel(bool v)
        {
            txtNumeClient.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
            txtAdresa.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtIdClient.Text = "";
            txtNumeClient.Text = "";
            txtNrTelefon.Text = "";
            txtAdresa.Text = "";
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtIdClient.DataBindings.Add("Text", clientiBindingSource, "IdClient");
                txtNumeClient.DataBindings.Add("Text", clientiBindingSource, "NumeClient");
                txtNrTelefon.DataBindings.Add("Text", clientiBindingSource, "NrTelefon");
                txtAdresa.DataBindings.Add("Text", clientiBindingSource, "Adresa");
            }
            else
            {
                txtIdClient.DataBindings.Clear();
                txtNumeClient.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
            }
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, NrTelefon, Adresa
            if (txtNumeClient.Text == "")
            {
                MessageBox.Show("Completati NumeClient!");
                txtNumeClient.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati NrTelefon!");
                txtNrTelefon.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati Adresa!");
                txtNrTelefon.Focus();
                return false;
            }
            return true;
        }

        private void refresh_grid(int p)
        {
            clientiTableAdapter.Fill(dataSet1.Clienti);
            clientiBindingSource.Position = p;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "SELECT COUNT(NrTelefon) FROM Clienti WHERE NrTelefon = @NrTelefon";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            OleDbDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if(rdr.GetInt32(0) > 0)
            {
                MessageBox.Show("Exista deja o persoana cu acest nr de telefon!");
                rdr.Close();
                con.Close();
                return;
            }

            rdr.Close();

            listaCampuri = "NumeClient, NrTelefon, Adresa";
            listaValori = "'" + txtNumeClient.Text + "'" +
                          ",'" + txtNrTelefon.Text + "'" +
                          ",'" + txtAdresa.Text + "'";

            cmd.CommandText = "Insert into Clienti(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "SELECT COUNT(NrTelefon) FROM Clienti WHERE NrTelefon = @NrTelefon";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            OleDbDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (rdr.GetInt32(0) > 0)
            {
                MessageBox.Show("Exista deja o persoana cu acest nr de telefon!");
                rdr.Close();
                con.Close();
                return;
            }

            rdr.Close();

            listaSet = "NumeClient = '" + txtNumeClient.Text + "'," +
                       "NrTelefon = '" + txtNrTelefon.Text + "'," +
                       "Adresa = '" + txtAdresa.Text + "'";

            cmd.CommandText = "Update Clienti Set " + listaSet + " Where IdClient=" + txtIdClient.Text;

            //MessageBox.Show(cmd.CommandText);

            cmd.ExecuteNonQuery();

            con.Close();
        }


        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void txtNumeClient_Leave(object sender, EventArgs e)
        {

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader rdr;
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(IdClient) FROM Devize WHERE IdClient = @IdClient";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdClient", int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim()));
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if(rdr.GetInt32(0) > 0)
            {
                MessageBox.Show("Client referit in tabelul Devize! Nu se poate sterge!");
                rdr.Close();
                con.Close();
                return;
            }
            rdr.Close();
            con.Close();
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }
    }
}
