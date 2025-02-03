
namespace Proiect
{
    partial class FDevizeAct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDenumireDeviz = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtDenumireDeviz = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Proiect.DataSet2();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireReperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.repereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretUnitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizeContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new Proiect.DataSet2TableAdapters.ClientiTableAdapter();
            this.repereTableAdapter = new Proiect.DataSet2TableAdapters.RepereTableAdapter();
            this.PB = new System.Windows.Forms.PictureBox();
            this.txtMarcaModel = new System.Windows.Forms.TextBox();
            this.txtNrInmatriculare = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblInmatriculare = new System.Windows.Forms.Label();
            this.btnClienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumireDeviz
            // 
            this.lblDenumireDeviz.AutoSize = true;
            this.lblDenumireDeviz.Location = new System.Drawing.Point(52, 58);
            this.lblDenumireDeviz.Name = "lblDenumireDeviz";
            this.lblDenumireDeviz.Size = new System.Drawing.Size(82, 13);
            this.lblDenumireDeviz.TabIndex = 0;
            this.lblDenumireDeviz.Text = "Denumire Deviz";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(55, 113);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(55, 167);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(783, 53);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(35, 13);
            this.lblOp.TabIndex = 3;
            this.lblOp.Text = "label1";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(624, 48);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtDenumireDeviz
            // 
            this.txtDenumireDeviz.Location = new System.Drawing.Point(157, 50);
            this.txtDenumireDeviz.Name = "txtDenumireDeviz";
            this.txtDenumireDeviz.Size = new System.Drawing.Size(200, 20);
            this.txtDenumireDeviz.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(157, 158);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 7;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(624, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(677, 156);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCrtDataGridViewTextBoxColumn,
            this.denumireReperDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretUnitarDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idReperDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devizeContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1779, 241);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.Visible = false;
            // 
            // denumireReperDataGridViewTextBoxColumn
            // 
            this.denumireReperDataGridViewTextBoxColumn.DataPropertyName = "DenumireReper";
            this.denumireReperDataGridViewTextBoxColumn.DataSource = this.repereBindingSource;
            this.denumireReperDataGridViewTextBoxColumn.DisplayMember = "DenumireReper";
            this.denumireReperDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireReperDataGridViewTextBoxColumn.HeaderText = "DenumireReper";
            this.denumireReperDataGridViewTextBoxColumn.Name = "denumireReperDataGridViewTextBoxColumn";
            this.denumireReperDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireReperDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // repereBindingSource
            // 
            this.repereBindingSource.DataMember = "Repere";
            this.repereBindingSource.DataSource = this.dataSet2;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            // 
            // pretUnitarDataGridViewTextBoxColumn
            // 
            this.pretUnitarDataGridViewTextBoxColumn.DataPropertyName = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.HeaderText = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.Name = "pretUnitarDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idReperDataGridViewTextBoxColumn
            // 
            this.idReperDataGridViewTextBoxColumn.DataPropertyName = "IdReper";
            this.idReperDataGridViewTextBoxColumn.HeaderText = "IdReper";
            this.idReperDataGridViewTextBoxColumn.Name = "idReperDataGridViewTextBoxColumn";
            this.idReperDataGridViewTextBoxColumn.Visible = false;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Visible = false;
            // 
            // devizeContinutManevraBindingSource
            // 
            this.devizeContinutManevraBindingSource.DataMember = "DevizeContinutManevra";
            this.devizeContinutManevraBindingSource.DataSource = this.dataSet2;
            this.devizeContinutManevraBindingSource.PositionChanged += new System.EventHandler(this.devizeContinutManevraBindingSource_PositionChanged);
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // repereTableAdapter
            // 
            this.repereTableAdapter.ClearBeforeFill = true;
            // 
            // PB
            // 
            this.PB.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.devizeContinutManevraBindingSource, "SpImagine", true));
            this.PB.Location = new System.Drawing.Point(1146, 15);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(304, 203);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 12;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtMarcaModel
            // 
            this.txtMarcaModel.Location = new System.Drawing.Point(157, 209);
            this.txtMarcaModel.Name = "txtMarcaModel";
            this.txtMarcaModel.Size = new System.Drawing.Size(200, 20);
            this.txtMarcaModel.TabIndex = 13;
            // 
            // txtNrInmatriculare
            // 
            this.txtNrInmatriculare.Location = new System.Drawing.Point(157, 261);
            this.txtNrInmatriculare.Name = "txtNrInmatriculare";
            this.txtNrInmatriculare.Size = new System.Drawing.Size(200, 20);
            this.txtNrInmatriculare.TabIndex = 14;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(55, 215);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "MarcaModel";
            // 
            // lblInmatriculare
            // 
            this.lblInmatriculare.AutoSize = true;
            this.lblInmatriculare.Location = new System.Drawing.Point(58, 267);
            this.lblInmatriculare.Name = "lblInmatriculare";
            this.lblInmatriculare.Size = new System.Drawing.Size(78, 13);
            this.lblInmatriculare.TabIndex = 16;
            this.lblInmatriculare.Text = "NrInmatriculare";
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(373, 157);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(43, 23);
            this.btnClienti.TabIndex = 11;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // FDevizeAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 693);
            this.Controls.Add(this.lblInmatriculare);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNrInmatriculare);
            this.Controls.Add(this.txtMarcaModel);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDenumireDeviz);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDenumireDeviz);
            this.Name = "FDevizeAct";
            this.Text = "FDevizeAct";
            this.Load += new System.EventHandler(this.FDevizeAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumireDeviz;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtDenumireDeviz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DataSet2TableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.BindingSource repereBindingSource;
        private DataSet2TableAdapters.RepereTableAdapter repereTableAdapter;
        private System.Windows.Forms.BindingSource devizeContinutManevraBindingSource;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.TextBox txtMarcaModel;
        private System.Windows.Forms.TextBox txtNrInmatriculare;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblInmatriculare;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireReperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretUnitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClienti;
    }
}