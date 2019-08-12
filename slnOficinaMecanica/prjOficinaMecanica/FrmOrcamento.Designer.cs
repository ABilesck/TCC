namespace prjOficinaMecanica
{
    partial class FrmOrcamento
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
            System.Windows.Forms.Label iDAutomovelLabel;
            System.Windows.Forms.Label iDProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoUnitarioLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGravarProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.iDProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.tccProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tcc_produtoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.tcc_produtoOrcamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iDAutomovelComboBox = new System.Windows.Forms.ComboBox();
            this.tcc_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcc_OrcamentoDataGridView = new System.Windows.Forms.DataGridView();
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
            this.tcc_produtoOrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_produtoOrcamentoTableAdapter();
            this.tcc_ProdutoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ProdutoTableAdapter();
            this.tccProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ClienteTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ClienteTableAdapter();
            this.tccAutomovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_AutomovelTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_AutomovelTableAdapter();
            iDAutomovelLabel = new System.Windows.Forms.Label();
            iDProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitarioLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDAutomovelLabel
            // 
            iDAutomovelLabel.AutoSize = true;
            iDAutomovelLabel.Location = new System.Drawing.Point(6, 73);
            iDAutomovelLabel.Name = "iDAutomovelLabel";
            iDAutomovelLabel.Size = new System.Drawing.Size(71, 13);
            iDAutomovelLabel.TabIndex = 9;
            iDAutomovelLabel.Text = "IDAutomovel:";
            // 
            // iDProdutoLabel
            // 
            iDProdutoLabel.AutoSize = true;
            iDProdutoLabel.Location = new System.Drawing.Point(24, 64);
            iDProdutoLabel.Name = "iDProdutoLabel";
            iDProdutoLabel.Size = new System.Drawing.Size(58, 13);
            iDProdutoLabel.TabIndex = 3;
            iDProdutoLabel.Text = "IDProduto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(19, 90);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 5;
            quantidadeLabel.Text = "quantidade:";
            // 
            // precoUnitarioLabel
            // 
            precoUnitarioLabel.AutoSize = true;
            precoUnitarioLabel.Location = new System.Drawing.Point(6, 111);
            precoUnitarioLabel.Name = "precoUnitarioLabel";
            precoUnitarioLabel.Size = new System.Drawing.Size(76, 13);
            precoUnitarioLabel.TabIndex = 7;
            precoUnitarioLabel.Text = "preco Unitario:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tcc_produtoOrcamentoDataGridView);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(iDAutomovelLabel);
            this.tabPage1.Controls.Add(this.iDAutomovelComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(107, 314);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(188, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGravarProduto);
            this.groupBox1.Controls.Add(this.btnCancelarProduto);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(iDProdutoLabel);
            this.groupBox1.Controls.Add(this.iDProdutoComboBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeNumericUpDown);
            this.groupBox1.Controls.Add(precoUnitarioLabel);
            this.groupBox1.Controls.Add(this.btnNovoProduto);
            this.groupBox1.Location = new System.Drawing.Point(9, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 191);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnGravarProduto
            // 
            this.btnGravarProduto.Location = new System.Drawing.Point(96, 151);
            this.btnGravarProduto.Name = "btnGravarProduto";
            this.btnGravarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnGravarProduto.TabIndex = 10;
            this.btnGravarProduto.Text = "Gravar";
            this.btnGravarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(177, 151);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProduto.TabIndex = 9;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(88, 111);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "R$ 0,00";
            // 
            // iDProdutoComboBox
            // 
            this.iDProdutoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iDProdutoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.iDProdutoComboBox.DataSource = this.tccProdutoBindingSource1;
            this.iDProdutoComboBox.DisplayMember = "descricao";
            this.iDProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDProdutoComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.iDProdutoComboBox.Location = new System.Drawing.Point(88, 61);
            this.iDProdutoComboBox.Name = "iDProdutoComboBox";
            this.iDProdutoComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDProdutoComboBox.TabIndex = 4;
            this.iDProdutoComboBox.ValueMember = "IDProduto";
            // 
            // tccProdutoBindingSource1
            // 
            this.tccProdutoBindingSource1.DataMember = "tcc_Produto";
            this.tccProdutoBindingSource1.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tcc_produtoOrcamentoBindingSource, "quantidade", true));
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(88, 88);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.quantidadeNumericUpDown.TabIndex = 6;
            // 
            // tcc_produtoOrcamentoBindingSource
            // 
            this.tcc_produtoOrcamentoBindingSource.DataMember = "tcc_produtoOrcamento";
            this.tcc_produtoOrcamentoBindingSource.DataSource = this.banco;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(7, 20);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProduto.TabIndex = 0;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            // 
            // tcc_produtoOrcamentoDataGridView
            // 
            this.tcc_produtoOrcamentoDataGridView.AllowUserToAddRows = false;
            this.tcc_produtoOrcamentoDataGridView.AllowUserToDeleteRows = false;
            this.tcc_produtoOrcamentoDataGridView.AutoGenerateColumns = false;
            this.tcc_produtoOrcamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_produtoOrcamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tcc_produtoOrcamentoDataGridView.DataSource = this.tcc_produtoOrcamentoBindingSource;
            this.tcc_produtoOrcamentoDataGridView.Location = new System.Drawing.Point(316, 7);
            this.tcc_produtoOrcamentoDataGridView.Name = "tcc_produtoOrcamentoDataGridView";
            this.tcc_produtoOrcamentoDataGridView.ReadOnly = true;
            this.tcc_produtoOrcamentoDataGridView.RowHeadersVisible = false;
            this.tcc_produtoOrcamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_produtoOrcamentoDataGridView.Size = new System.Drawing.Size(446, 330);
            this.tcc_produtoOrcamentoDataGridView.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precoUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "precoUnitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tccClienteBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "IDCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // iDAutomovelComboBox
            // 
            this.iDAutomovelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_OrcamentoBindingSource, "IDAutomovel", true));
            this.iDAutomovelComboBox.DataSource = this.tccAutomovelBindingSource;
            this.iDAutomovelComboBox.DisplayMember = "modelo";
            this.iDAutomovelComboBox.FormattingEnabled = true;
            this.iDAutomovelComboBox.Location = new System.Drawing.Point(9, 89);
            this.iDAutomovelComboBox.Name = "iDAutomovelComboBox";
            this.iDAutomovelComboBox.Size = new System.Drawing.Size(254, 21);
            this.iDAutomovelComboBox.TabIndex = 10;
            this.iDAutomovelComboBox.ValueMember = "IDAutomovel";
            // 
            // tcc_OrcamentoBindingSource
            // 
            this.tcc_OrcamentoBindingSource.DataMember = "tcc_Orcamento";
            this.tcc_OrcamentoBindingSource.DataSource = this.banco;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tcc_OrcamentoDataGridView);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcc_OrcamentoDataGridView
            // 
            this.tcc_OrcamentoDataGridView.AutoGenerateColumns = false;
            this.tcc_OrcamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_OrcamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tcc_OrcamentoDataGridView.DataSource = this.tcc_OrcamentoBindingSource;
            this.tcc_OrcamentoDataGridView.Location = new System.Drawing.Point(6, 88);
            this.tcc_OrcamentoDataGridView.Name = "tcc_OrcamentoDataGridView";
            this.tcc_OrcamentoDataGridView.Size = new System.Drawing.Size(756, 253);
            this.tcc_OrcamentoDataGridView.TabIndex = 20;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataConsulta";
            this.dataGridViewTextBoxColumn6.HeaderText = "dataConsulta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IDAutomovel";
            this.dataGridViewTextBoxColumn7.HeaderText = "IDAutomovel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(687, 59);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(171, 59);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCancelar.TabIndex = 19;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            // 
            // tbnAlterar
            // 
            this.tbnAlterar.Location = new System.Drawing.Point(90, 59);
            this.tbnAlterar.Name = "tbnAlterar";
            this.tbnAlterar.Size = new System.Drawing.Size(75, 23);
            this.tbnAlterar.TabIndex = 18;
            this.tbnAlterar.Text = "&Alterar";
            this.tbnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(9, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(638, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pesquisar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbOrdenar.Location = new System.Drawing.Point(641, 32);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
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
            this.cmbFiltro.Location = new System.Drawing.Point(514, 32);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(9, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(499, 20);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
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
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = this.tcc_OrcamentoTableAdapter;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = this.tcc_produtoOrcamentoTableAdapter;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = this.tcc_ProdutoTableAdapter;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_produtoOrcamentoTableAdapter
            // 
            this.tcc_produtoOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_ProdutoTableAdapter
            // 
            this.tcc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tccProdutoBindingSource
            // 
            this.tccProdutoBindingSource.DataMember = "tcc_Produto";
            this.tccProdutoBindingSource.DataSource = this.banco;
            // 
            // iDProdutoBindingSource
            // 
            this.iDProdutoBindingSource.DataMember = "IDProduto";
            this.iDProdutoBindingSource.DataSource = this.tccProdutoBindingSource;
            // 
            // tccClienteBindingSource
            // 
            this.tccClienteBindingSource.DataMember = "tcc_Cliente";
            this.tccClienteBindingSource.DataSource = this.banco;
            // 
            // tcc_ClienteTableAdapter
            // 
            this.tcc_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tccAutomovelBindingSource
            // 
            this.tccAutomovelBindingSource.DataMember = "tcc_Automovel";
            this.tccAutomovelBindingSource.DataSource = this.banco;
            // 
            // tcc_AutomovelTableAdapter
            // 
            this.tcc_AutomovelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmOrcamento";
            this.Text = "FrmOrcamento";
            this.Load += new System.EventHandler(this.FrmOrcamento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).EndInit();
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
        private BancoTableAdapters.tcc_produtoOrcamentoTableAdapter tcc_produtoOrcamentoTableAdapter;
        private System.Windows.Forms.BindingSource tcc_produtoOrcamentoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox iDProdutoComboBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.DataGridView tcc_produtoOrcamentoDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox iDAutomovelComboBox;
        private System.Windows.Forms.Button btnGravarProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BancoTableAdapters.tcc_ProdutoTableAdapter tcc_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tccProdutoBindingSource;
        private System.Windows.Forms.BindingSource tccProdutoBindingSource1;
        private System.Windows.Forms.BindingSource iDProdutoBindingSource;
        private System.Windows.Forms.DataGridView tcc_OrcamentoDataGridView;
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
        private System.Windows.Forms.BindingSource tccClienteBindingSource;
        private BancoTableAdapters.tcc_ClienteTableAdapter tcc_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource tccAutomovelBindingSource;
        private BancoTableAdapters.tcc_AutomovelTableAdapter tcc_AutomovelTableAdapter;
    }
}