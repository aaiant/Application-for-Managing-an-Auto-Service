using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FDevizeAct : Form
    {
        private int IdClient;
        private string MarcaModel;
        private string NrInmatriculare;
        bool firstImage = false;
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private OleDbDataAdapter adr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public FDevizeAct(int IdClient, string MarcaModel, string NrInmatriculare)
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 900;
            this.IdClient = IdClient;
            this.MarcaModel = MarcaModel;
            this.NrInmatriculare = NrInmatriculare;
            if(this.IdClient != 0)
            {
                refreshClienti2();
                cmbClient.SelectedValue = this.IdClient;
                txtMarcaModel.Text = this.MarcaModel;
                txtNrInmatriculare.Text = this.NrInmatriculare;
            }
            // BETA version
            btnConfirmare.Enabled = false;
        }

        public void refreshClienti(int pozitie)
        {
            MessageBox.Show("Poz: " + pozitie);
            clientiTableAdapter.Fill(dataSet2.Clienti);
            cmbClient.SelectedIndex = pozitie;
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            if (firstImage) { PB.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString(); firstImage = true; }

        }

        private void refreshClienti2()
        {
            con.ConnectionString = repereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdClient, NumeClient FROM Clienti";
            con.Open();
            adr = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            cmbClient.DataSource = null;
            cmbClient.DataSource = dt;
            cmbClient.DisplayMember = "NumeClient";
            cmbClient.ValueMember = "IdClient"; 
            con.Close();
        }

        private void A1()
        {
            //Incarcare DataTable Produse
            repereTableAdapter.Fill(dataSet2.Repere);
            //Incarcare DataTable Clienti
            clientiTableAdapter.Fill(dataSet2.Clienti);

            // Protectie la modificare
            txtDenumireDeviz.ReadOnly = false;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretUnitarDataGridViewTextBoxColumn.ReadOnly = true;
            idReperDataGridViewTextBoxColumn.ReadOnly = true;
            spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            //  BETA version
            btnClienti.Enabled = false;
            btnClienti.Visible = false;

            spImagineDataGridViewTextBoxColumn.Width = 800;
            denumireReperDataGridViewTextBoxColumn.Width = 500;


            if (lblOp.Text == "MODIFICARE DEVIZ") completeazaDeviz(); 
            else if (lblOp.Text == "DEVIZ NOU") cmbClient.SelectedIndex = -1;

        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE DEVIZ")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariDevizeContinut();
                this.Close();
            }
            else if (lblOp.Text == "DEVIZ NOU")
            {
                adaugaInregistrareDevize();
                //cautaInregistrare();
                adaugaInregistrariDevizeContinut();
                golireCampuri();
            }

        }


        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)devizeContinutManevraBindingSource.Current;
            int pozitie = devizeContinutManevraBindingSource.Position + 1;
            if (current == null) return;
            try { current["NrCrt"] = pozitie; }
            catch { }
            
        }

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)repereBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["PretUnitar"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdReper"];
                    dataGridView1.CurrentRow.Cells[7].Value = current["SpImagine"];
                    devizeContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    devizeContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }


        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }


        private void completeazaDeviz()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idCda = (int)current["IdDeviz"];
            txtDenumireDeviz.Text = Convert.ToString(current["DenumireDeviz"]);

            //cmbClient.Text = current["NumeClient"].ToString();


            dateTimePicker1.Value = Convert.ToDateTime(current["DataDeviz"]);

            bs2.MoveFirst();

            dataSet2.DevizeContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet2.DevizeContinutManevraRow r = dataSet2.DevizeContinutManevra.NewDevizeContinutManevraRow();
                r.NrCrt = Convert.ToInt16(current["Nrc"]);
                r.DenumireReper = Convert.ToString(current["DenumireReper"]);
                r.UM = Convert.ToString(current["UM"]);
                r.PretUnitar = Convert.ToDecimal(current["PretUnitar"]);
                r.Cantitate = Convert.ToInt32(current["Cantitate"]);
                r.IdReper = Convert.ToInt32(current["IdReper"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                r.SpImagine = Convert.ToString(current["SpImagine"]);

                dataSet2.DevizeContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in dataSet2.DevizeContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "")
            {
                MessageBox.Show("Completati Client!");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (devizeContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut deviz!");
                dataGridView1.Focus();
                return false;
            }
            if (txtDenumireDeviz.Text == "")
            {
                MessageBox.Show("Completati DenumireDeviz!");
                txtDenumireDeviz.Focus();
                return false;
            }
            if (txtMarcaModel.Text == "")
            {
                MessageBox.Show("Completati MarcaModel!");
                txtDenumireDeviz.Focus();
                return false;
            }
            if (txtNrInmatriculare.Text == "")
            {
                MessageBox.Show("Completati NrInmatriculare!");
                txtDenumireDeviz.Focus();
                return false;
            }
            return true;
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from DevizeContinut Where IdDeviz = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = repereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdDeviz = " + idCda;

            string clauzaSet = "Set DenumireDeviz = '" + txtDenumireDeviz.Text + "',"
                               + "DataDeviz = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdClient = " + cmbClient.SelectedValue 
                               + ", MarcaModel = '" + txtMarcaModel.Text + "',"
                               + " NrInmatriculare = '" + txtNrInmatriculare.Text + "'";

            cmd.CommandText = "Update Devize " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void adaugaInregistrareDevize()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            con.ConnectionString = repereTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            listaCampuri = "DenumireDeviz, DataDeviz, IdClient";
            listaValori = txtDenumireDeviz.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbClient.SelectedValue;

            /*
            cmd.CommandText = "Insert into Devize(" + listaCampuri + ") " +
                              "Select " + listaValori;*/
            cmd.CommandText = "Insert into Devize(DenumireDeviz, DataDeviz, IdClient, MarcaModel, NrInmatriculare) Values (@DenumireDeviz, @DataDeviz, @IdClient, @MarcaModel, @NrInmatriculare)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DenumireDeviz", txtDenumireDeviz.Text);
            cmd.Parameters.AddWithValue("@DataDeviz", d);
            cmd.Parameters.AddWithValue("@IdClient", cmbClient.SelectedValue);
            cmd.Parameters.AddWithValue("@MarcaModel", txtMarcaModel.Text);
            cmd.Parameters.AddWithValue("@NrInmatriculare", txtNrInmatriculare.Text);
            con.Open();
            try { cmd.ExecuteNonQuery(); } catch (Exception ex) { MessageBox.Show(ex.Message);}
            con.Close();
        }

        private void adaugaInregistrariDevizeContinut()
        {
            string listaCampuri = "IdDeviz, Nrc, IdReper, Cantitate, PretUnitar";
            string listaValori;

            con.Open();
            cmd.CommandText = "SELECT MAX(IdDeviz) FROM Devize";
            
            rdr = cmd.ExecuteReader();
            rdr.Read();
            int idDeviz = rdr.GetInt32(0);
            rdr.Close();

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                /*
                listaValori = idCda + "," + r["NrCrt"] + "," + r["IdReper"] + "," + r["Cantitate"] + "," + r["PretUnitar"];

                cmd.CommandText = "Insert into DevizeContinut(" + listaCampuri + ") " + "Select " + listaValori;
                */
                cmd.CommandText = "Insert into DevizeContinut(IdDeviz, Nrc, IdReper, Cantitate, PretUnitar) VALUES (@IdDeviz, @Nrc, @IdReper, @Cantitate, @PretUnitar)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDeviz", idDeviz);
                cmd.Parameters.AddWithValue("@Nrc", int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()));
                cmd.Parameters.AddWithValue("@IdReper", int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString().Trim()));
                cmd.Parameters.AddWithValue("@Cantitate", int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString().Trim()));
                cmd.Parameters.AddWithValue("@PretUnitar", double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString().Trim()));
                try { cmd.ExecuteNonQuery(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            con.Close();
        }

        private void golireCampuri()
        {
            txtDenumireDeviz.Text = "";
            cmbClient.SelectedIndex = -1;
            txtTotal.Text = "";
            txtMarcaModel.Text = "";
            txtNrInmatriculare.Text = "";
            dataSet2.DevizeContinutManevra.Clear();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT COUNT(idDeviz) From Devize Where DenumireDeviz = " + txtDenumireDeviz.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            if(rdr.GetInt32(0) > 0)
            {
             
            }
            rdr.Close();
            con.Close();
        }


        private void FDevizeAct_Load(object sender, EventArgs e)
        {
            A1();
            refreshClienti2();
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void devizeContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            ClientiComboBox f = new ClientiComboBox();
            f.SetMaster(this);
            f.SetSelectVisible();
            f.ShowDialog();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            A3();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void devizeContinutManevraBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }
    }
}
