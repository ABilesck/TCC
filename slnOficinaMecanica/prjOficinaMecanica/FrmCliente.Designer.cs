namespace prjOficinaMecanica
{
    partial class FrmCliente
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
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpCadastrar = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tcc_AutomovelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_AutomovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.btnAddCarro = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtDocSocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblDocSocial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.rbtPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbtPessoaFisica = new System.Windows.Forms.RadioButton();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisaCancelar = new System.Windows.Forms.Button();
            this.tbnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tcc_ClienteTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ClienteTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.tcc_AutomovelTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_AutomovelTableAdapter();
            this.tcPrincipal.SuspendLayout();
            this.tpCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            this.tcDados.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpCadastrar);
            this.tcPrincipal.Controls.Add(this.tbPesquisa);
            this.tcPrincipal.Location = new System.Drawing.Point(12, 13);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(607, 552);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpCadastrar
            // 
            this.tpCadastrar.AutoScroll = true;
            this.tpCadastrar.Controls.Add(this.btnNovo);
            this.tpCadastrar.Controls.Add(this.tcc_AutomovelDataGridView);
            this.tpCadastrar.Controls.Add(this.btnAddCarro);
            this.tpCadastrar.Controls.Add(this.btnSalvar);
            this.tpCadastrar.Controls.Add(this.btnCancelar);
            this.tpCadastrar.Controls.Add(this.label1);
            this.tpCadastrar.Controls.Add(this.tcDados);
            this.tpCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tpCadastrar.Name = "tpCadastrar";
            this.tpCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastrar.Size = new System.Drawing.Size(599, 526);
            this.tpCadastrar.TabIndex = 0;
            this.tpCadastrar.Text = "Cadastrar";
            this.tpCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(11, 239);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tcc_AutomovelDataGridView
            // 
            this.tcc_AutomovelDataGridView.AllowUserToAddRows = false;
            this.tcc_AutomovelDataGridView.AllowUserToDeleteRows = false;
            this.tcc_AutomovelDataGridView.AutoGenerateColumns = false;
            this.tcc_AutomovelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_AutomovelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.tcc_AutomovelDataGridView.DataSource = this.tcc_AutomovelBindingSource;
            this.tcc_AutomovelDataGridView.Location = new System.Drawing.Point(11, 338);
            this.tcc_AutomovelDataGridView.Name = "tcc_AutomovelDataGridView";
            this.tcc_AutomovelDataGridView.ReadOnly = true;
            this.tcc_AutomovelDataGridView.RowHeadersVisible = false;
            this.tcc_AutomovelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_AutomovelDataGridView.Size = new System.Drawing.Size(574, 185);
            this.tcc_AutomovelDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IDAutomovel";
            this.dataGridViewTextBoxColumn13.HeaderText = "IDAutomovel";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn15.HeaderText = "placa";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn16.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ano";
            this.dataGridViewTextBoxColumn17.HeaderText = "ano";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "cor";
            this.dataGridViewTextBoxColumn18.HeaderText = "cor";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "kmRodado";
            this.dataGridViewTextBoxColumn19.HeaderText = "kmRodado";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // tcc_AutomovelBindingSource
            // 
            this.tcc_AutomovelBindingSource.DataMember = "tcc_Automovel";
            this.tcc_AutomovelBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddCarro
            // 
            this.btnAddCarro.Enabled = false;
            this.btnAddCarro.Location = new System.Drawing.Point(510, 309);
            this.btnAddCarro.Name = "btnAddCarro";
            this.btnAddCarro.Size = new System.Drawing.Size(75, 23);
            this.btnAddCarro.TabIndex = 5;
            this.btnAddCarro.Text = "Novo carro";
            this.btnAddCarro.UseVisualStyleBackColor = true;
            this.btnAddCarro.Click += new System.EventHandler(this.btnAddCarro_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(429, 239);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(510, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carros";
            // 
            // tcDados
            // 
            this.tcDados.Controls.Add(this.tpDados);
            this.tcDados.Controls.Add(this.tpEndereco);
            this.tcDados.Location = new System.Drawing.Point(7, 7);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(583, 225);
            this.tcDados.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.txtTelefone);
            this.tpDados.Controls.Add(this.txtEmail);
            this.tpDados.Controls.Add(this.txtRegistro);
            this.tpDados.Controls.Add(this.txtDocSocial);
            this.tpDados.Controls.Add(this.txtNome);
            this.tpDados.Controls.Add(this.label3);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.lblRegistro);
            this.tpDados.Controls.Add(this.lblDocSocial);
            this.tpDados.Controls.Add(this.lblNome);
            this.tpDados.Controls.Add(this.rbtPessoaJuridica);
            this.tpDados.Controls.Add(this.rbtPessoaFisica);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(575, 199);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(10, 166);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(189, 20);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(10, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Location = new System.Drawing.Point(208, 86);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(182, 20);
            this.txtRegistro.TabIndex = 11;
            // 
            // txtDocSocial
            // 
            this.txtDocSocial.Enabled = false;
            this.txtDocSocial.Location = new System.Drawing.Point(10, 86);
            this.txtDocSocial.Name = "txtDocSocial";
            this.txtDocSocial.Size = new System.Drawing.Size(189, 20);
            this.txtDocSocial.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(10, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(545, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-Mail";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(205, 69);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(23, 13);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.Text = "RG";
            // 
            // lblDocSocial
            // 
            this.lblDocSocial.AutoSize = true;
            this.lblDocSocial.Location = new System.Drawing.Point(7, 69);
            this.lblDocSocial.Name = "lblDocSocial";
            this.lblDocSocial.Size = new System.Drawing.Size(27, 13);
            this.lblDocSocial.TabIndex = 5;
            this.lblDocSocial.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // rbtPessoaJuridica
            // 
            this.rbtPessoaJuridica.AutoSize = true;
            this.rbtPessoaJuridica.Location = new System.Drawing.Point(98, 6);
            this.rbtPessoaJuridica.Name = "rbtPessoaJuridica";
            this.rbtPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbtPessoaJuridica.TabIndex = 3;
            this.rbtPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbtPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbtPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbtPessoaJuridica_CheckedChanged);
            // 
            // rbtPessoaFisica
            // 
            this.rbtPessoaFisica.AutoSize = true;
            this.rbtPessoaFisica.Checked = true;
            this.rbtPessoaFisica.Location = new System.Drawing.Point(6, 6);
            this.rbtPessoaFisica.Name = "rbtPessoaFisica";
            this.rbtPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbtPessoaFisica.TabIndex = 2;
            this.rbtPessoaFisica.TabStop = true;
            this.rbtPessoaFisica.Text = "Pessoa Física";
            this.rbtPessoaFisica.UseVisualStyleBackColor = true;
            this.rbtPessoaFisica.CheckedChanged += new System.EventHandler(this.rbtPessoaFisica_CheckedChanged);
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.txtCep);
            this.tpEndereco.Controls.Add(this.txtComplemento);
            this.tpEndereco.Controls.Add(this.txtBairro);
            this.tpEndereco.Controls.Add(this.cmbUf);
            this.tpEndereco.Controls.Add(this.txtCidade);
            this.tpEndereco.Controls.Add(this.txtLogradouro);
            this.tpEndereco.Controls.Add(this.label9);
            this.tpEndereco.Controls.Add(this.label8);
            this.tpEndereco.Controls.Add(this.label7);
            this.tpEndereco.Controls.Add(this.label6);
            this.tpEndereco.Controls.Add(this.label5);
            this.tpEndereco.Controls.Add(this.label4);
            this.tpEndereco.Location = new System.Drawing.Point(4, 22);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(575, 199);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(10, 141);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 20);
            this.txtCep.TabIndex = 11;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(310, 63);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(251, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(10, 63);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // cmbUf
            // 
            this.cmbUf.Enabled = false;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(396, 102);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(121, 21);
            this.cmbUf.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(10, 102);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(377, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(10, 24);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(551, 20);
            this.txtLogradouro.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Complemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logradouro";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.AutoScroll = true;
            this.tbPesquisa.Controls.Add(this.btnExcluir);
            this.tbPesquisa.Controls.Add(this.btnPesquisaCancelar);
            this.tbPesquisa.Controls.Add(this.tbnAlterar);
            this.tbPesquisa.Controls.Add(this.btnPesquisar);
            this.tbPesquisa.Controls.Add(this.dgvCliente);
            this.tbPesquisa.Controls.Add(this.label12);
            this.tbPesquisa.Controls.Add(this.label11);
            this.tbPesquisa.Controls.Add(this.cmbOrdenar);
            this.tbPesquisa.Controls.Add(this.cmbFiltro);
            this.tbPesquisa.Controls.Add(this.txtPesquisa);
            this.tbPesquisa.Controls.Add(this.label10);
            this.tbPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tbPesquisa.Size = new System.Drawing.Size(599, 526);
            this.tbPesquisa.TabIndex = 1;
            this.tbPesquisa.Text = "Pesquisar";
            this.tbPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(515, 51);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(172, 51);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCancelar.TabIndex = 9;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            this.btnPesquisaCancelar.Click += new System.EventHandler(this.btnPesquisaCancelar_Click);
            // 
            // tbnAlterar
            // 
            this.tbnAlterar.Location = new System.Drawing.Point(91, 51);
            this.tbnAlterar.Name = "tbnAlterar";
            this.tbnAlterar.Size = new System.Drawing.Size(75, 23);
            this.tbnAlterar.TabIndex = 8;
            this.tbnAlterar.Text = "&Alterar";
            this.tbnAlterar.UseVisualStyleBackColor = true;
            this.tbnAlterar.Click += new System.EventHandler(this.tbnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(10, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoGenerateColumns = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvCliente.DataSource = this.tcc_ClienteBindingSource;
            this.dgvCliente.Location = new System.Drawing.Point(10, 80);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(580, 440);
            this.dgvCliente.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "documentoSocial";
            this.dataGridViewTextBoxColumn3.HeaderText = "documentoSocial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "logradouro";
            this.dataGridViewTextBoxColumn6.HeaderText = "logradouro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn7.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn9.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn10.HeaderText = "uf";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn11.HeaderText = "cep";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "registroGeral";
            this.dataGridViewTextBoxColumn12.HeaderText = "registroGeral";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tcc_ClienteBindingSource
            // 
            this.tcc_ClienteBindingSource.DataMember = "tcc_Cliente";
            this.tcc_ClienteBindingSource.DataSource = this.banco;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Pesquisar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbOrdenar.Location = new System.Drawing.Point(469, 24);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 3;
            this.cmbOrdenar.Text = "Código";
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Documento Social",
            "Nome"});
            this.cmbFiltro.Location = new System.Drawing.Point(342, 24);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 2;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(10, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(326, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisar:";
            // 
            // tcc_ClienteTableAdapter
            // 
            this.tcc_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = null;
            this.tableAdapterManager.tcc_ClienteTableAdapter = this.tcc_ClienteTableAdapter;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_AutomovelTableAdapter
            // 
            this.tcc_AutomovelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 577);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpCadastrar.ResumeLayout(false);
            this.tpCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            this.tcDados.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            this.tbPesquisa.ResumeLayout(false);
            this.tbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.TabPage tbPesquisa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtDocSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblDocSocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rbtPessoaJuridica;
        private System.Windows.Forms.RadioButton rbtPessoaFisica;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddCarro;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_ClienteBindingSource;
        private BancoTableAdapters.tcc_ClienteTableAdapter tcc_ClienteTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tcc_AutomovelBindingSource;
        private BancoTableAdapters.tcc_AutomovelTableAdapter tcc_AutomovelTableAdapter;
        private System.Windows.Forms.DataGridView tcc_AutomovelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisaCancelar;
        private System.Windows.Forms.Button tbnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}