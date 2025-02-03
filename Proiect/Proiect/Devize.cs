using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Devize : Form
    {
        public Devize()
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 900;
        }

        private void Devize_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.DevizeContinut' table. You can move, or remove it, as needed.
            this.devizeContinutTableAdapter.Fill(this.dataSet2.DevizeContinut);
            refreshGrid();
            filtreazaDetaliu();
            denumireReperDataGridViewTextBoxColumn.Width = 500;
            spImagineDataGridViewTextBoxColumn.Width = 800;
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            denumireDevizDataGridViewTextBoxColumn.Width = 200;
            dataDevizDataGridViewTextBoxColumn.Width = 200;
            marcaModelDataGridViewTextBoxColumn.Width = 200;
        }

        private void refreshGrid()
        {
            devizeTableAdapter.Fill(dataSet2.Devize);
            devizeContinutTableAdapter.Fill(dataSet2.DevizeContinut);
        }
        private void filtreazaDetaliu()
        {
            try
            {
                devizeContinutBindingSource.Filter = "IdDeviz=" + txtIdDeviz.Text;
            }
            catch { }
        }

        private void devizeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }

        private void btnDevizNou_Click(object sender, EventArgs e)
        {
            FDevizeAct f = new FDevizeAct(0, null, null);
            f.completeazaTitlu("DEVIZ NOU");
            f.ShowDialog();
        }

        private void btnModificareDeviz_Click(object sender, EventArgs e)
        {
            FDevizeAct f = new FDevizeAct(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim()),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim(),
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim());
            f.completeazaTitlu("MODIFICARE DEVIZ");
            f.bs1 = devizeBindingSource;
            f.bs2 = devizeContinutBindingSource;
            f.ShowDialog();
            refreshGrid();

        }

        private void btnStergereDeviz_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = devizeTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From DevizeContinut Where IdDeviz = " + txtIdDeviz.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Devize Where IdDeviz = " + txtIdDeviz.Text;
            //MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();

        }

        private void devizeContinutBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //PB.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
