namespace Projeto_FormularioCurso.Formulários
{
    partial class frmConsulta
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
            this.dataSet1 = new Projeto_FormularioCurso.Data.DataSet1();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Projeto_FormularioCurso.Data.DataSet1TableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new Projeto_FormularioCurso.Data.DataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordenadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargahorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.dataSet1;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_FormularioCurso.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.modalidadeDataGridViewTextBoxColumn,
            this.coordenadorDataGridViewTextBoxColumn,
            this.cargahorariaDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cursoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(15, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFiltrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Location = new System.Drawing.Point(15, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(770, 22);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Nome",
            "Area",
            "Modalidade",
            "Coordenador",
            "Carga_horaria",
            "data_inicio"});
            this.cmbProcurar.Location = new System.Drawing.Point(12, 35);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(189, 21);
            this.cmbProcurar.TabIndex = 2;
            this.cmbProcurar.SelectedIndexChanged += new System.EventHandler(this.cbmProcurar_SelectedIndexChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Todos",
            "Igual a",
            "Que começa com",
            "Que contém",
            "Que termina em",
            "Que esteja entre"});
            this.cmbBuscar.Location = new System.Drawing.Point(274, 34);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(201, 21);
            this.cmbBuscar.TabIndex = 3;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbmBuscar_SelectedIndexChanged);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(533, 34);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(685, 35);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.Visible = false;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Procurar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(682, 18);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(43, 13);
            this.lblValor2.TabIndex = 9;
            this.lblValor2.Text = "Valor 2:";
            this.lblValor2.Visible = false;
            this.lblValor2.Click += new System.EventHandler(this.lblValor2_Click);
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Location = new System.Drawing.Point(748, 373);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(37, 13);
            this.lblLinhas.TabIndex = 10;
            this.lblLinhas.Text = "Todos";
            this.lblLinhas.Click += new System.EventHandler(this.label5_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // modalidadeDataGridViewTextBoxColumn
            // 
            this.modalidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modalidadeDataGridViewTextBoxColumn.DataPropertyName = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.HeaderText = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modalidadeDataGridViewTextBoxColumn.Name = "modalidadeDataGridViewTextBoxColumn";
            this.modalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.modalidadeDataGridViewTextBoxColumn.Width = 87;
            // 
            // coordenadorDataGridViewTextBoxColumn
            // 
            this.coordenadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coordenadorDataGridViewTextBoxColumn.DataPropertyName = "Coordenador";
            this.coordenadorDataGridViewTextBoxColumn.HeaderText = "Coordenador";
            this.coordenadorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coordenadorDataGridViewTextBoxColumn.Name = "coordenadorDataGridViewTextBoxColumn";
            this.coordenadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.coordenadorDataGridViewTextBoxColumn.Width = 93;
            // 
            // cargahorariaDataGridViewTextBoxColumn
            // 
            this.cargahorariaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cargahorariaDataGridViewTextBoxColumn.DataPropertyName = "Carga_horaria";
            this.cargahorariaDataGridViewTextBoxColumn.HeaderText = "Carga_horaria";
            this.cargahorariaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cargahorariaDataGridViewTextBoxColumn.Name = "cargahorariaDataGridViewTextBoxColumn";
            this.cargahorariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargahorariaDataGridViewTextBoxColumn.Width = 98;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicioDataGridViewTextBoxColumn.Width = 83;
            // 
            // frmConsulta
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 398);
            this.Controls.Add(this.lblLinhas);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private Data.DataSet1TableAdapters.CursoTableAdapter cursoTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordenadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargahorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
    }
}