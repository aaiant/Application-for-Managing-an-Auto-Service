using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Repere : Form
    {
        const int IdReperIndex = 0;
        const int DenumireReperIndex = 1;
        const int UMIndex = 2;
        const int PretUnitarIndex = 3;
        const int SpImagineIndex = 4;

        private OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Repere()
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 1200;
        }

        private void Repere_Load(object sender, EventArgs e)
        {
            //A1
            config(true);
            refresh();
            dataGridView1.Columns[IdReperIndex].ReadOnly = true;
            denumireReperDataGridViewTextBoxColumn.Width = 500;
            spImagineDataGridViewTextBoxColumn.Width = 800;
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DenumireReperIndex].ReadOnly = v;
            dataGridView1.Columns[UMIndex].ReadOnly = v;
            dataGridView1.Columns[PretUnitarIndex].ReadOnly = v;
            dataGridView1.Columns[SpImagineIndex].ReadOnly = v;
            txtSpImagine.ReadOnly = false;
           

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void refresh()
        {
            repereTableAdapter.Fill(dataSet1.Repere);
            pictureBox1.ImageLocation = txtSpImagine.Text;

        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Repere)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireReper"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireReper la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
                if (r["UM"] == DBNull.Value)
                {
                    MessageBox.Show("Completati UM la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
                if (r["PretUnitar"] == DBNull.Value)
                {
                    MessageBox.Show("Completati PretUnitar la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
                if (r["SpImagine"] == DBNull.Value)
                {
                    MessageBox.Show("Completati SpImagine la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                repereTableAdapter.Update(dataSet1.Repere);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta!");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele!");
            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader rdr;
            con.ConnectionString = repereTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(IdReper) FROM DevizeContinut WHERE IdReper = @IdReper";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdReper", int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim()));
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0)
            {
                MessageBox.Show("Reper referit in tabelul DevizeContinut! Nu se poate sterge!");
                rdr.Close();
                con.Close();
                e.Cancel = true;
                return;
            }
            rdr.Close();
            con.Close();
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;

        }

        private void txtSpImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled == false)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName; ;
                    dataGridView1.CurrentRow.Cells[SpImagineIndex].Value = s;
                    pictureBox1.ImageLocation = s;
                    dataGridView1.EndEdit();
                }
            }
        }

        private void repereBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = txtSpImagine.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
