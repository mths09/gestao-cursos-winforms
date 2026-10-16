namespace Projeto_FormularioCurso.Formulários
{
    partial class frmCadPessoa
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label modalidadeLabel;
            System.Windows.Forms.Label coordenadorLabel;
            System.Windows.Forms.Label carga_horariaLabel;
            System.Windows.Forms.Label data_inicioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPessoa));
            this.pessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataSet1 = new Projeto_FormularioCurso.Data.DataSet1();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Projeto_FormularioCurso.Data.DataSet1TableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new Projeto_FormularioCurso.Data.DataSet1TableAdapters.TableAdapterManager();
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.modalidadeTextBox = new System.Windows.Forms.TextBox();
            this.coordenadorTextBox = new System.Windows.Forms.TextBox();
            this.carga_horariaTextBox = new System.Windows.Forms.TextBox();
            this.data_inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            modalidadeLabel = new System.Windows.Forms.Label();
            coordenadorLabel = new System.Windows.Forms.Label();
            carga_horariaLabel = new System.Windows.Forms.Label();
            data_inicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).BeginInit();
            this.pessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(29, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(29, 99);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(29, 125);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(32, 13);
            areaLabel.TabIndex = 6;
            areaLabel.Text = "Area:";
            // 
            // modalidadeLabel
            // 
            modalidadeLabel.AutoSize = true;
            modalidadeLabel.Location = new System.Drawing.Point(29, 151);
            modalidadeLabel.Name = "modalidadeLabel";
            modalidadeLabel.Size = new System.Drawing.Size(65, 13);
            modalidadeLabel.TabIndex = 8;
            modalidadeLabel.Text = "Modalidade:";
            // 
            // coordenadorLabel
            // 
            coordenadorLabel.AutoSize = true;
            coordenadorLabel.Location = new System.Drawing.Point(29, 177);
            coordenadorLabel.Name = "coordenadorLabel";
            coordenadorLabel.Size = new System.Drawing.Size(71, 13);
            coordenadorLabel.TabIndex = 10;
            coordenadorLabel.Text = "Coordenador:";
            // 
            // carga_horariaLabel
            // 
            carga_horariaLabel.AutoSize = true;
            carga_horariaLabel.Location = new System.Drawing.Point(29, 203);
            carga_horariaLabel.Name = "carga_horariaLabel";
            carga_horariaLabel.Size = new System.Drawing.Size(73, 13);
            carga_horariaLabel.TabIndex = 12;
            carga_horariaLabel.Text = "Carga horaria:";
            // 
            // data_inicioLabel
            // 
            data_inicioLabel.AutoSize = true;
            data_inicioLabel.Location = new System.Drawing.Point(29, 230);
            data_inicioLabel.Name = "data_inicioLabel";
            data_inicioLabel.Size = new System.Drawing.Size(58, 13);
            data_inicioLabel.TabIndex = 14;
            data_inicioLabel.Text = "data inicio:";
            // 
            // pessoaBindingNavigator
            // 
            this.pessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaBindingNavigator.BackColor = System.Drawing.Color.SteelBlue;
            this.pessoaBindingNavigator.BindingSource = this.cursoBindingSource;
            this.pessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaBindingNavigator.DeleteItem = null;
            this.pessoaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.pessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaBindingNavigator.Name = "pessoaBindingNavigator";
            this.pessoaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaBindingNavigator.Size = new System.Drawing.Size(760, 31);
            this.pessoaBindingNavigator.TabIndex = 0;
            this.pessoaBindingNavigator.Text = "bindingNavigator1";
            this.pessoaBindingNavigator.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Checked = true;
            this.bindingNavigatorMoveLastItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
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
            // cursoDataGridView
            // 
            this.cursoDataGridView.AutoGenerateColumns = false;
            this.cursoDataGridView.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cursoDataGridView.DataSource = this.cursoBindingSource;
            this.cursoDataGridView.Location = new System.Drawing.Point(0, 284);
            this.cursoDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.RowHeadersWidth = 62;
            this.cursoDataGridView.RowTemplate.Height = 28;
            this.cursoDataGridView.Size = new System.Drawing.Size(744, 175);
            this.cursoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn3.HeaderText = "Area";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modalidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modalidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Coordenador";
            this.dataGridViewTextBoxColumn5.HeaderText = "Coordenador";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Carga_horaria";
            this.dataGridViewTextBoxColumn6.HeaderText = "Carga_horaria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "data_inicio";
            this.dataGridViewTextBoxColumn7.HeaderText = "data_inicio";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(108, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(114, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(108, 96);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(211, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(108, 122);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(211, 20);
            this.areaTextBox.TabIndex = 7;
            // 
            // modalidadeTextBox
            // 
            this.modalidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Modalidade", true));
            this.modalidadeTextBox.Location = new System.Drawing.Point(108, 148);
            this.modalidadeTextBox.Name = "modalidadeTextBox";
            this.modalidadeTextBox.Size = new System.Drawing.Size(211, 20);
            this.modalidadeTextBox.TabIndex = 9;
            // 
            // coordenadorTextBox
            // 
            this.coordenadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Coordenador", true));
            this.coordenadorTextBox.Location = new System.Drawing.Point(108, 174);
            this.coordenadorTextBox.Name = "coordenadorTextBox";
            this.coordenadorTextBox.Size = new System.Drawing.Size(211, 20);
            this.coordenadorTextBox.TabIndex = 11;
            // 
            // carga_horariaTextBox
            // 
            this.carga_horariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Carga_horaria", true));
            this.carga_horariaTextBox.Location = new System.Drawing.Point(108, 200);
            this.carga_horariaTextBox.Name = "carga_horariaTextBox";
            this.carga_horariaTextBox.Size = new System.Drawing.Size(114, 20);
            this.carga_horariaTextBox.TabIndex = 13;
            // 
            // data_inicioDateTimePicker
            // 
            this.data_inicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoBindingSource, "data_inicio", true));
            this.data_inicioDateTimePicker.Location = new System.Drawing.Point(108, 226);
            this.data_inicioDateTimePicker.Name = "data_inicioDateTimePicker";
            this.data_inicioDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.data_inicioDateTimePicker.TabIndex = 15;
            // 
            // frmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(760, 459);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(modalidadeLabel);
            this.Controls.Add(this.modalidadeTextBox);
            this.Controls.Add(coordenadorLabel);
            this.Controls.Add(this.coordenadorTextBox);
            this.Controls.Add(carga_horariaLabel);
            this.Controls.Add(this.carga_horariaTextBox);
            this.Controls.Add(data_inicioLabel);
            this.Controls.Add(this.data_inicioDateTimePicker);
            this.Controls.Add(this.cursoDataGridView);
            this.Controls.Add(this.pessoaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadPessoa";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).EndInit();
            this.pessoaBindingNavigator.ResumeLayout(false);
            this.pessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator pessoaBindingNavigator;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private Data.DataSet1TableAdapters.CursoTableAdapter cursoTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cursoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox modalidadeTextBox;
        private System.Windows.Forms.TextBox coordenadorTextBox;
        private System.Windows.Forms.TextBox carga_horariaTextBox;
        private System.Windows.Forms.DateTimePicker data_inicioDateTimePicker;
        private System.Windows.Forms.ToolStripTextBox pessoaBidingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}