namespace prjOficinaMecanica
{
    partial class FrmServico
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
            System.Windows.Forms.Label iDMecanicoLabel;
            System.Windows.Forms.Label iDOrcamentoLabel;
            System.Windows.Forms.Label dataInicioLabel;
            System.Windows.Forms.Label dataFimLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.iDMecanicoComboBox = new System.Windows.Forms.ComboBox();
            this.tcc_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.tccMecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvOrcamento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcc_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisaCancelar = new System.Windows.Forms.Button();
            this.tbnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tcc_OrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_OrcamentoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.tcc_ServicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ServicoTableAdapter();
            iDMecanicoLabel = new System.Windows.Forms.Label();
            iDOrcamentoLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            dataFimLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDMecanicoLabel
            // 
            iDMecanicoLabel.AutoSize = true;
            iDMecanicoLabel.Location = new System.Drawing.Point(11, 71);
            iDMecanicoLabel.Name = "iDMecanicoLabel";
            iDMecanicoLabel.Size = new System.Drawing.Size(69, 16);
            iDMecanicoLabel.TabIndex = 1;
            iDMecanicoLabel.Text = "IDMecanico:";
            // 
            // iDOrcamentoLabel
            // 
            iDOrcamentoLabel.AutoSize = true;
            iDOrcamentoLabel.Location = new System.Drawing.Point(6, 38);
            iDOrcamentoLabel.Name = "iDOrcamentoLabel";
            iDOrcamentoLabel.Size = new System.Drawing.Size(77, 16);
            iDOrcamentoLabel.TabIndex = 3;
            iDOrcamentoLabel.Text = "IDOrcamento:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(20, 103);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(63, 16);
            dataInicioLabel.TabIndex = 5;
            dataInicioLabel.Text = "data Inicio:";
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(193, 103);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(55, 16);
            dataFimLabel.TabIndex = 7;
            dataFimLabel.Text = "data Fim:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.lblOrcamento);
            this.tabPage1.Controls.Add(iDMecanicoLabel);
            this.tabPage1.Controls.Add(this.iDMecanicoComboBox);
            this.tabPage1.Controls.Add(iDOrcamentoLabel);
            this.tabPage1.Controls.Add(dataInicioLabel);
            this.tabPage1.Controls.Add(this.dataInicioDateTimePicker);
            this.tabPage1.Controls.Add(dataFimLabel);
            this.tabPage1.Controls.Add(this.dataFimDateTimePicker);
            this.tabPage1.Controls.Add(this.dgvOrcamento);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(707, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 455);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(305, 455);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 7);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(85, 38);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(14, 16);
            this.lblOrcamento.TabIndex = 9;
            this.lblOrcamento.Text = "0";
            // 
            // iDMecanicoComboBox
            // 
            this.iDMecanicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_ServicoBindingSource, "IDMecanico", true));
            this.iDMecanicoComboBox.DataSource = this.tccMecanicoBindingSource;
            this.iDMecanicoComboBox.DisplayMember = "razaoSocial";
            this.iDMecanicoComboBox.FormattingEnabled = true;
            this.iDMecanicoComboBox.Location = new System.Drawing.Point(88, 68);
            this.iDMecanicoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDMecanicoComboBox.Name = "iDMecanicoComboBox";
            this.iDMecanicoComboBox.Size = new System.Drawing.Size(292, 24);
            this.iDMecanicoComboBox.TabIndex = 2;
            this.iDMecanicoComboBox.ValueMember = "IDMecanico";
            // 
            // tcc_ServicoBindingSource
            // 
            this.tcc_ServicoBindingSource.DataMember = "tcc_Servico";
            this.tcc_ServicoBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccMecanicoBindingSource
            // 
            this.tccMecanicoBindingSource.DataMember = "tcc_Mecanico";
            this.tccMecanicoBindingSource.DataSource = this.banco;
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tcc_ServicoBindingSource, "dataInicio", true));
            this.dataInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(88, 101);
            this.dataInicioDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(99, 23);
            this.dataInicioDateTimePicker.TabIndex = 6;
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tcc_ServicoBindingSource, "dataFim", true));
            this.dataFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(249, 101);
            this.dataFimDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(95, 23);
            this.dataFimDateTimePicker.TabIndex = 8;
            // 
            // dgvOrcamento
            // 
            this.dgvOrcamento.AllowUserToAddRows = false;
            this.dgvOrcamento.AllowUserToDeleteRows = false;
            this.dgvOrcamento.AutoGenerateColumns = false;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvOrcamento.DataSource = this.tcc_OrcamentoBindingSource;
            this.dgvOrcamento.Location = new System.Drawing.Point(386, 7);
            this.dgvOrcamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrcamento.Name = "dgvOrcamento";
            this.dgvOrcamento.ReadOnly = true;
            this.dgvOrcamento.RowHeadersVisible = false;
            this.dgvOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamento.Size = new System.Drawing.Size(306, 476);
            this.dgvOrcamento.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDOrcamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDOrcamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataConsulta";
            this.dataGridViewTextBoxColumn2.HeaderText = "dataConsulta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDAutomovel";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDAutomovel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tcc_OrcamentoBindingSource
            // 
            this.tcc_OrcamentoBindingSource.DataMember = "tcc_Orcamento";
            this.tcc_OrcamentoBindingSource.DataSource = this.banco;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tcc_ServicoDataGridView);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnPesquisaCancelar);
            this.tabPage2.Controls.Add(this.tbnAlterar);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmbOrdenar);
            this.tabPage2.Controls.Add(this.cmbFiltro);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(707, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcc_ServicoDataGridView
            // 
            this.tcc_ServicoDataGridView.AllowUserToAddRows = false;
            this.tcc_ServicoDataGridView.AllowUserToDeleteRows = false;
            this.tcc_ServicoDataGridView.AutoGenerateColumns = false;
            this.tcc_ServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_ServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tcc_ServicoDataGridView.DataSource = this.tcc_ServicoBindingSource;
            this.tcc_ServicoDataGridView.Location = new System.Drawing.Point(6, 101);
            this.tcc_ServicoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcc_ServicoDataGridView.Name = "tcc_ServicoDataGridView";
            this.tcc_ServicoDataGridView.ReadOnly = true;
            this.tcc_ServicoDataGridView.RowHeadersVisible = false;
            this.tcc_ServicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_ServicoDataGridView.Size = new System.Drawing.Size(689, 383);
            this.tcc_ServicoDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDMecanico";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDMecanico";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDOrcamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDOrcamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataInicio";
            this.dataGridViewTextBoxColumn6.HeaderText = "dataInicio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dataFim";
            this.dataGridViewTextBoxColumn7.HeaderText = "dataFim";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(620, 65);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(168, 65);
            this.btnPesquisaCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisaCancelar.TabIndex = 19;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            // 
            // tbnAlterar
            // 
            this.tbnAlterar.Location = new System.Drawing.Point(87, 65);
            this.tbnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnAlterar.Name = "tbnAlterar";
            this.tbnAlterar.Size = new System.Drawing.Size(75, 28);
            this.tbnAlterar.TabIndex = 18;
            this.tbnAlterar.Text = "&Alterar";
            this.tbnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(6, 65);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pesquisar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbOrdenar.Location = new System.Drawing.Point(574, 32);
            this.cmbOrdenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 24);
            this.cmbOrdenar.TabIndex = 14;
            this.cmbOrdenar.Text = "Código";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Documento Social",
            "Nome"});
            this.cmbFiltro.Location = new System.Drawing.Point(447, 32);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 32);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(435, 23);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesquisar:";
            // 
            // tcc_OrcamentoTableAdapter
            // 
            this.tcc_OrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = null;
            this.tableAdapterManager.tcc_ClienteTableAdapter = null;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = this.tcc_MecanicoTableAdapter;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = this.tcc_ServicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_MecanicoTableAdapter
            // 
            this.tcc_MecanicoTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_ServicoTableAdapter
            // 
            this.tcc_ServicoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 554);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmServico";
            this.Text = "FrmServico";
            this.Load += new System.EventHandler(this.FrmServico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_OrcamentoBindingSource;
        private BancoTableAdapters.tcc_OrcamentoTableAdapter tcc_OrcamentoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BancoTableAdapters.tcc_ServicoTableAdapter tcc_ServicoTableAdapter;
        private System.Windows.Forms.BindingSource tcc_ServicoBindingSource;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.ComboBox iDMecanicoComboBox;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private System.Windows.Forms.BindingSource tccMecanicoBindingSource;
        private System.Windows.Forms.DataGridView tcc_ServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisaCancelar;
        private System.Windows.Forms.Button tbnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
    }
}