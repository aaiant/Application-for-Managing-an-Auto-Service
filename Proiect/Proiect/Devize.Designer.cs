
namespace Proiect
{
    partial class Devize
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireDevizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrInmatriculareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Proiect.DataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.devizeContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdDeviz = new System.Windows.Forms.TextBox();
            this.btnDevizNou = new System.Windows.Forms.Button();
            this.btnModificareDeviz = new System.Windows.Forms.Button();
            this.btnStergereDeviz = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.PictureBox();
            this.devizeTableAdapter = new Proiect.DataSet2TableAdapters.DevizeTableAdapter();
            this.devizeContinutTableAdapter = new Proiect.DataSet2TableAdapters.DevizeContinutTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.idDevizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretUnitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireReperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDevizDataGridViewTextBoxColumn,
            this.dataDevizDataGridViewTextBoxColumn,
            this.IdClient,
            this.marcaModelDataGridViewTextBoxColumn,
            this.nrInmatriculareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devizeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // denumireDevizDataGridViewTextBoxColumn
            // 
            this.denumireDevizDataGridViewTextBoxColumn.DataPropertyName = "DenumireDeviz";
            this.denumireDevizDataGridViewTextBoxColumn.HeaderText = "DenumireDeviz";
            this.denumireDevizDataGridViewTextBoxColumn.Name = "denumireDevizDataGridViewTextBoxColumn";
            this.denumireDevizDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDevizDataGridViewTextBoxColumn
            // 
            this.dataDevizDataGridViewTextBoxColumn.DataPropertyName = "DataDeviz";
            this.dataDevizDataGridViewTextBoxColumn.HeaderText = "DataDeviz";
            this.dataDevizDataGridViewTextBoxColumn.Name = "dataDevizDataGridViewTextBoxColumn";
            this.dataDevizDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "IdClient";
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            this.IdClient.Visible = false;
            // 
            // marcaModelDataGridViewTextBoxColumn
            // 
            this.marcaModelDataGridViewTextBoxColumn.DataPropertyName = "MarcaModel";
            this.marcaModelDataGridViewTextBoxColumn.HeaderText = "MarcaModel";
            this.marcaModelDataGridViewTextBoxColumn.Name = "marcaModelDataGridViewTextBoxColumn";
            this.marcaModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrInmatriculareDataGridViewTextBoxColumn
            // 
            this.nrInmatriculareDataGridViewTextBoxColumn.DataPropertyName = "NrInmatriculare";
            this.nrInmatriculareDataGridViewTextBoxColumn.HeaderText = "NrInmatriculare";
            this.nrInmatriculareDataGridViewTextBoxColumn.Name = "nrInmatriculareDataGridViewTextBoxColumn";
            this.nrInmatriculareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devizeBindingSource
            // 
            this.devizeBindingSource.DataMember = "Devize";
            this.devizeBindingSource.DataSource = this.dataSet2;
            this.devizeBindingSource.PositionChanged += new System.EventHandler(this.devizeBindingSource_PositionChanged);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDevizDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn,
            this.idReperDataGridViewTextBoxColumn,
            this.pretUnitarDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.denumireReperDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.devizeContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 358);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1757, 215);
            this.dataGridView2.TabIndex = 1;
            // 
            // devizeContinutBindingSource
            // 
            this.devizeContinutBindingSource.DataMember = "DevizeContinut";
            this.devizeContinutBindingSource.DataSource = this.dataSet2;
            this.devizeContinutBindingSource.PositionChanged += new System.EventHandler(this.devizeContinutBindingSource_PositionChanged);
            // 
            // txtIdDeviz
            // 
            this.txtIdDeviz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devizeBindingSource, "IdDeviz", true));
            this.txtIdDeviz.Location = new System.Drawing.Point(959, 39);
            this.txtIdDeviz.Name = "txtIdDeviz";
            this.txtIdDeviz.Size = new System.Drawing.Size(128, 20);
            this.txtIdDeviz.TabIndex = 2;
            // 
            // btnDevizNou
            // 
            this.btnDevizNou.Location = new System.Drawing.Point(959, 95);
            this.btnDevizNou.Name = "btnDevizNou";
            this.btnDevizNou.Size = new System.Drawing.Size(128, 23);
            this.btnDevizNou.TabIndex = 3;
            this.btnDevizNou.Text = "Deviz nou";
            this.btnDevizNou.UseVisualStyleBackColor = true;
            this.btnDevizNou.Click += new System.EventHandler(this.btnDevizNou_Click);
            // 
            // btnModificareDeviz
            // 
            this.btnModificareDeviz.Location = new System.Drawing.Point(959, 159);
            this.btnModificareDeviz.Name = "btnModificareDeviz";
            this.btnModificareDeviz.Size = new System.Drawing.Size(128, 23);
            this.btnModificareDeviz.TabIndex = 4;
            this.btnModificareDeviz.Text = "Modificare deviz";
            this.btnModificareDeviz.UseVisualStyleBackColor = true;
            this.btnModificareDeviz.Click += new System.EventHandler(this.btnModificareDeviz_Click);
            // 
            // btnStergereDeviz
            // 
            this.btnStergereDeviz.Location = new System.Drawing.Point(959, 232);
            this.btnStergereDeviz.Name = "btnStergereDeviz";
            this.btnStergereDeviz.Size = new System.Drawing.Size(128, 23);
            this.btnStergereDeviz.TabIndex = 5;
            this.btnStergereDeviz.Text = "Stergere deviz";
            this.btnStergereDeviz.UseVisualStyleBackColor = true;
            this.btnStergereDeviz.Click += new System.EventHandler(this.btnStergereDeviz_Click);
            // 
            // PB
            // 
            this.PB.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.devizeContinutBindingSource, "SpImagine", true));
            this.PB.Location = new System.Drawing.Point(1133, 12);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(636, 315);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 6;
            this.PB.TabStop = false;
            // 
            // devizeTableAdapter
            // 
            this.devizeTableAdapter.ClearBeforeFill = true;
            // 
            // devizeContinutTableAdapter
            // 
            this.devizeContinutTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(959, 294);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // idDevizDataGridViewTextBoxColumn
            // 
            this.idDevizDataGridViewTextBoxColumn.DataPropertyName = "IdDeviz";
            this.idDevizDataGridViewTextBoxColumn.HeaderText = "IdDeviz";
            this.idDevizDataGridViewTextBoxColumn.Name = "idDevizDataGridViewTextBoxColumn";
            this.idDevizDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDevizDataGridViewTextBoxColumn.Visible = false;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrcDataGridViewTextBoxColumn.Visible = false;
            // 
            // idReperDataGridViewTextBoxColumn
            // 
            this.idReperDataGridViewTextBoxColumn.DataPropertyName = "IdReper";
            this.idReperDataGridViewTextBoxColumn.HeaderText = "IdReper";
            this.idReperDataGridViewTextBoxColumn.Name = "idReperDataGridViewTextBoxColumn";
            this.idReperDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReperDataGridViewTextBoxColumn.Visible = false;
            // 
            // pretUnitarDataGridViewTextBoxColumn
            // 
            this.pretUnitarDataGridViewTextBoxColumn.DataPropertyName = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.HeaderText = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.Name = "pretUnitarDataGridViewTextBoxColumn";
            this.pretUnitarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireReperDataGridViewTextBoxColumn
            // 
            this.denumireReperDataGridViewTextBoxColumn.DataPropertyName = "DenumireReper";
            this.denumireReperDataGridViewTextBoxColumn.HeaderText = "DenumireReper";
            this.denumireReperDataGridViewTextBoxColumn.Name = "denumireReperDataGridViewTextBoxColumn";
            this.denumireReperDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            this.spImagineDataGridViewTextBoxColumn.Visible = false;
            // 
            // Devize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 585);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.btnStergereDeviz);
            this.Controls.Add(this.btnModificareDeviz);
            this.Controls.Add(this.btnDevizNou);
            this.Controls.Add(this.txtIdDeviz);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Devize";
            this.Text = "Devize";
            this.Load += new System.EventHandler(this.Devize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devizeContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdDeviz;
        private System.Windows.Forms.Button btnDevizNou;
        private System.Windows.Forms.Button btnModificareDeviz;
        private System.Windows.Forms.Button btnStergereDeviz;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource devizeBindingSource;
        private DataSet2TableAdapters.DevizeTableAdapter devizeTableAdapter;
        private System.Windows.Forms.BindingSource devizeContinutBindingSource;
        private DataSet2TableAdapters.DevizeContinutTableAdapter devizeContinutTableAdapter;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDevizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrInmatriculareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDevizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretUnitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireReperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}