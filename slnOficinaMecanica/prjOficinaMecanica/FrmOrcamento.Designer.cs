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
            this.tcc_produtoOrcamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_produtoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGravarProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.iDProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tccClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.iDAutomovelComboBox = new System.Windows.Forms.ComboBox();
            this.tccAutomovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tcc_ClienteTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ClienteTableAdapter();
            this.tcc_AutomovelTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_AutomovelTableAdapter();
            this.tcc_produtoOrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_produtoOrcamentoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            iDAutomovelLabel = new System.Windows.Forms.Label();
            iDProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitarioLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDAutomovelLabel
            // 
            iDAutomovelLabel.AutoSize = true;
            iDAutomovelLabel.Location = new System.Drawing.Point(6, 90);
            iDAutomovelLabel.Name = "iDAutomovelLabel";
            iDAutomovelLabel.Size = new System.Drawing.Size(75, 16);
            iDAutomovelLabel.TabIndex = 9;
            iDAutomovelLabel.Text = "IDAutomovel:";
            // 
            // iDProdutoLabel
            // 
            iDProdutoLabel.AutoSize = true;
            iDProdutoLabel.Location = new System.Drawing.Point(24, 79);
            iDProdutoLabel.Name = "iDProdutoLabel";
            iDProdutoLabel.Size = new System.Drawing.Size(61, 16);
            iDProdutoLabel.TabIndex = 3;
            iDProdutoLabel.Text = "IDProduto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(19, 111);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(66, 16);
            quantidadeLabel.TabIndex = 5;
            quantidadeLabel.Text = "quantidade:";
            // 
            // precoUnitarioLabel
            // 
            precoUnitarioLabel.AutoSize = true;
            precoUnitarioLabel.Location = new System.Drawing.Point(6, 137);
            precoUnitarioLabel.Name = "precoUnitarioLabel";
            precoUnitarioLabel.Size = new System.Drawing.Size(82, 16);
            precoUnitarioLabel.TabIndex = 7;
            precoUnitarioLabel.Text = "preco Unitario:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tcc_produtoOrcamentoDataGridView);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(iDAutomovelLabel);
            this.tabPage1.Controls.Add(this.iDAutomovelComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(859, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tcc_produtoOrcamentoDataGridView
            // 
            this.tcc_produtoOrcamentoDataGridView.AllowUserToAddRows = false;
            this.tcc_produtoOrcamentoDataGridView.AllowUserToDeleteRows = false;
            this.tcc_produtoOrcamentoDataGridView.AutoGenerateColumns = false;
            this.tcc_produtoOrcamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_produtoOrcamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.tcc_produtoOrcamentoDataGridView.DataSource = this.tcc_produtoOrcamentoBindingSource;
            this.tcc_produtoOrcamentoDataGridView.Location = new System.Drawing.Point(273, 7);
            this.tcc_produtoOrcamentoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcc_produtoOrcamentoDataGridView.Name = "tcc_produtoOrcamentoDataGridView";
            this.tcc_produtoOrcamentoDataGridView.ReadOnly = true;
            this.tcc_produtoOrcamentoDataGridView.RowHeadersVisible = false;
            this.tcc_produtoOrcamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_produtoOrcamentoDataGridView.Size = new System.Drawing.Size(579, 437);
            this.tcc_produtoOrcamentoDataGridView.TabIndex = 19;
            this.tcc_produtoOrcamentoDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tcc_produtoOrcamentoDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precoUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "preço Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tcc_produtoOrcamentoBindingSource
            // 
            this.tcc_produtoOrcamentoBindingSource.DataMember = "tcc_produtoOrcamento";
            this.tcc_produtoOrcamentoBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 159);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mao de obra";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(105, 416);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 28);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 416);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 7);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 191);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(258, 218);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnGravarProduto
            // 
            this.btnGravarProduto.Location = new System.Drawing.Point(96, 186);
            this.btnGravarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravarProduto.Name = "btnGravarProduto";
            this.btnGravarProduto.Size = new System.Drawing.Size(75, 28);
            this.btnGravarProduto.TabIndex = 10;
            this.btnGravarProduto.Text = "Gravar";
            this.btnGravarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(177, 186);
            this.btnCancelarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(75, 28);
            this.btnCancelarProduto.TabIndex = 9;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(88, 137);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 16);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "R$ 0,00";
            // 
            // iDProdutoComboBox
            // 
            this.iDProdutoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.iDProdutoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.iDProdutoComboBox.DisplayMember = "IDProduto";
            this.iDProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDProdutoComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.iDProdutoComboBox.Location = new System.Drawing.Point(88, 75);
            this.iDProdutoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDProdutoComboBox.Name = "iDProdutoComboBox";
            this.iDProdutoComboBox.Size = new System.Drawing.Size(121, 24);
            this.iDProdutoComboBox.TabIndex = 4;
            this.iDProdutoComboBox.ValueMember = "IDProduto";
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(88, 108);
            this.quantidadeNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.quantidadeNumericUpDown.TabIndex = 6;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(7, 25);
            this.btnNovoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(75, 28);
            this.btnNovoProduto.TabIndex = 0;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tccClienteBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "IDCliente";
            // 
            // tccClienteBindingSource
            // 
            this.tccClienteBindingSource.DataMember = "tcc_Cliente";
            this.tccClienteBindingSource.DataSource = this.banco;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // iDAutomovelComboBox
            // 
            this.iDAutomovelComboBox.DataSource = this.tccAutomovelBindingSource;
            this.iDAutomovelComboBox.DisplayMember = "modelo";
            this.iDAutomovelComboBox.FormattingEnabled = true;
            this.iDAutomovelComboBox.Location = new System.Drawing.Point(9, 110);
            this.iDAutomovelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDAutomovelComboBox.Name = "iDAutomovelComboBox";
            this.iDAutomovelComboBox.Size = new System.Drawing.Size(254, 24);
            this.iDAutomovelComboBox.TabIndex = 10;
            this.iDAutomovelComboBox.ValueMember = "IDAutomovel";
            // 
            // tccAutomovelBindingSource
            // 
            this.tccAutomovelBindingSource.DataMember = "tcc_Automovel";
            this.tccAutomovelBindingSource.DataSource = this.banco;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(859, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(687, 73);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(171, 73);
            this.btnPesquisaCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisaCancelar.TabIndex = 19;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            // 
            // tbnAlterar
            // 
            this.tbnAlterar.Location = new System.Drawing.Point(90, 73);
            this.tbnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnAlterar.Name = "tbnAlterar";
            this.tbnAlterar.Size = new System.Drawing.Size(75, 28);
            this.tbnAlterar.TabIndex = 18;
            this.tbnAlterar.Text = "&Alterar";
            this.tbnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(9, 73);
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
            this.label12.Location = new System.Drawing.Point(638, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pesquisar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbOrdenar.Location = new System.Drawing.Point(641, 39);
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
            this.cmbFiltro.Location = new System.Drawing.Point(514, 39);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(9, 39);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(499, 23);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesquisar:";
            // 
            // tcc_ClienteTableAdapter
            // 
            this.tcc_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_AutomovelTableAdapter
            // 
            this.tcc_AutomovelTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_produtoOrcamentoTableAdapter
            // 
            this.tcc_produtoOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = null;
            this.tableAdapterManager.tcc_ClienteTableAdapter = null;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = this.tcc_produtoOrcamentoTableAdapter;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 534);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrcamento";
            this.Text = "FrmOrcamento";
            this.Load += new System.EventHandler(this.FrmOrcamento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Banco banco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox iDProdutoComboBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox iDAutomovelComboBox;
        private System.Windows.Forms.Button btnGravarProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tcc_produtoOrcamentoBindingSource;
        private BancoTableAdapters.tcc_produtoOrcamentoTableAdapter tcc_produtoOrcamentoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tcc_produtoOrcamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}