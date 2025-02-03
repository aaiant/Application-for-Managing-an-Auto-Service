using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect
{
    public partial class ClientiComboBox : Form
    {
        private Form master;
        private bool selectie;

        public ClientiComboBox()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 500;
        }

        public void SetMaster(Form caller)
        {
            master = caller;
        }

        public void SetSelectVisible()
        {
            selectie = true;
        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;

            btnActualizare.Enabled = v;

            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;

            if (selectie) btnSelectare.Visible = v;
        }

        private void refresh()
        {
            int pozitie;
            pozitie = clientiBindingSource.Position;
            clientiTableAdapter.Fill(dataSet2.Clienti);
            clientiBindingSource.Position = pozitie;
        }


        private void ClientiComboBox_Load(object sender, EventArgs e)
        {
            btnSelectare.Visible = false;
            config(true);
            refresh();
            numeClientDataGridViewTextBoxColumn.Width = 300;
            adresaDataGridViewTextBoxColumn.Width = 300;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                clientiTableAdapter.Update(dataSet2.Clienti);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();

        }

        private void btnSelectare_Click(object sender, EventArgs e)
        {
            FDevizeAct f = (FDevizeAct)master;
            MessageBox.Show("" + clientiBindingSource.Position);
            f.refreshClienti(clientiBindingSource.Position);
            this.Close();

        }



        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }
    }
}
