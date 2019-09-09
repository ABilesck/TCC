namespace prjOficinaMecanica
{
    partial class FrmMecanico
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
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label ieLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contaBancariaLabel;
            System.Windows.Forms.Label agenciaBancariaLabel;
            System.Windows.Forms.Label comissaoLabel;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.grbConta = new System.Windows.Forms.GroupBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.tcc_MecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMecanico = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            razaoSocialLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contaBancariaLabel = new System.Windows.Forms.Label();
            agenciaBancariaLabel = new System.Windows.Forms.Label();
            comissaoLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.grbConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanico)).BeginInit();
            this.SuspendLayout();
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(13, 39);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(73, 16);
            razaoSocialLabel.TabIndex = 2;
            razaoSocialLabel.Text = "razao Social:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(13, 87);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(32, 16);
            cnpjLabel.TabIndex = 3;
            cnpjLabel.Text = "cnpj:";
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(235, 87);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(20, 16);
            ieLabel.TabIndex = 4;
            ieLabel.Text = "ie:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(13, 183);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 16);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(39, 16);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "email:";
            // 
            // contaBancariaLabel
            // 
            contaBancariaLabel.AutoSize = true;
            contaBancariaLabel.Location = new System.Drawing.Point(6, 37);
            contaBancariaLabel.Name = "contaBancariaLabel";
            contaBancariaLabel.Size = new System.Drawing.Size(86, 16);
            contaBancariaLabel.TabIndex = 0;
            contaBancariaLabel.Text = "conta Bancaria:";
            // 
            // agenciaBancariaLabel
            // 
            agenciaBancariaLabel.AutoSize = true;
            agenciaBancariaLabel.Location = new System.Drawing.Point(175, 37);
            agenciaBancariaLabel.Name = "agenciaBancariaLabel";
            agenciaBancariaLabel.Size = new System.Drawing.Size(97, 16);
            agenciaBancariaLabel.TabIndex = 2;
            agenciaBancariaLabel.Text = "agencia Bancaria:";
            // 
            // comissaoLabel
            // 
            comissaoLabel.AutoSize = true;
            comissaoLabel.Location = new System.Drawing.Point(7, 100);
            comissaoLabel.Name = "comissaoLabel";
            comissaoLabel.Size = new System.Drawing.Size(60, 16);
            comissaoLabel.TabIndex = 4;
            comissaoLabel.Text = "comissão:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpDados);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(633, 703);
            this.tabControl.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.AutoScroll = true;
            this.tpDados.Controls.Add(this.txtCep);
            this.tpDados.Controls.Add(this.grbConta);
            this.tpDados.Controls.Add(this.txtComplemento);
            this.tpDados.Controls.Add(this.btnNovo);
            this.tpDados.Controls.Add(this.txtBairro);
            this.tpDados.Controls.Add(emailLabel);
            this.tpDados.Controls.Add(this.cmbUf);
            this.tpDados.Controls.Add(this.btnSalvar);
            this.tpDados.Controls.Add(this.txtCidade);
            this.tpDados.Controls.Add(this.txtEmail);
            this.tpDados.Controls.Add(this.txtLogradouro);
            this.tpDados.Controls.Add(this.btnCancelar);
            this.tpDados.Controls.Add(this.label9);
            this.tpDados.Controls.Add(telefoneLabel);
            this.tpDados.Controls.Add(this.label8);
            this.tpDados.Controls.Add(this.label7);
            this.tpDados.Controls.Add(this.txtTelefone);
            this.tpDados.Controls.Add(this.label6);
            this.tpDados.Controls.Add(razaoSocialLabel);
            this.tpDados.Controls.Add(this.label5);
            this.tpDados.Controls.Add(ieLabel);
            this.tpDados.Controls.Add(this.label4);
            this.tpDados.Controls.Add(this.txtRazao);
            this.tpDados.Controls.Add(this.txtIe);
            this.tpDados.Controls.Add(this.txtCnpj);
            this.tpDados.Controls.Add(cnpjLabel);
            this.tpDados.Location = new System.Drawing.Point(4, 25);
            this.tpDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDados.Size = new System.Drawing.Size(625, 674);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Cadastro";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(16, 576);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 23);
            this.txtCep.TabIndex = 23;
            // 
            // grbConta
            // 
            this.grbConta.Controls.Add(comissaoLabel);
            this.grbConta.Controls.Add(this.txtComissao);
            this.grbConta.Controls.Add(agenciaBancariaLabel);
            this.grbConta.Controls.Add(this.txtAgencia);
            this.grbConta.Controls.Add(contaBancariaLabel);
            this.grbConta.Controls.Add(this.txtConta);
            this.grbConta.Location = new System.Drawing.Point(6, 235);
            this.grbConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbConta.Name = "grbConta";
            this.grbConta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbConta.Size = new System.Drawing.Size(461, 172);
            this.grbConta.TabIndex = 10;
            this.grbConta.TabStop = false;
            this.grbConta.Text = "Conta para depósito";
            // 
            // txtComissao
            // 
            this.txtComissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "comissao", true));
            this.txtComissao.Location = new System.Drawing.Point(10, 119);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(105, 23);
            this.txtComissao.TabIndex = 5;
            // 
            // tcc_MecanicoBindingSource
            // 
            this.tcc_MecanicoBindingSource.DataMember = "tcc_Mecanico";
            this.tcc_MecanicoBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAgencia
            // 
            this.txtAgencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "agenciaBancaria", true));
            this.txtAgencia.Location = new System.Drawing.Point(178, 57);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(149, 23);
            this.txtAgencia.TabIndex = 3;
            // 
            // txtConta
            // 
            this.txtConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "contaBancaria", true));
            this.txtConta.Location = new System.Drawing.Point(9, 57);
            this.txtConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(163, 23);
            this.txtConta.TabIndex = 1;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(316, 480);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(251, 23);
            this.txtComplemento.TabIndex = 22;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 7);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(16, 480);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 23);
            this.txtBairro.TabIndex = 21;
            // 
            // cmbUf
            // 
            this.cmbUf.Enabled = false;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(402, 528);
            this.cmbUf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(121, 24);
            this.cmbUf.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(411, 626);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(16, 528);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(377, 23);
            this.txtCidade.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(16, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(16, 432);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(551, 23);
            this.txtLogradouro.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(492, 626);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cidade";
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(16, 203);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(216, 23);
            this.txtTelefone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Complemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Logradouro";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(16, 59);
            this.txtRazao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(551, 23);
            this.txtRazao.TabIndex = 3;
            // 
            // txtIe
            // 
            this.txtIe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "ie", true));
            this.txtIe.Location = new System.Drawing.Point(238, 107);
            this.txtIe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(229, 23);
            this.txtIe.TabIndex = 5;
            // 
            // txtCnpj
            // 
            this.txtCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "cnpj", true));
            this.txtCnpj.Location = new System.Drawing.Point(16, 107);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(216, 23);
            this.txtCnpj.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgvMecanico);
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
            this.tabPage2.Size = new System.Drawing.Size(625, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMecanico
            // 
            this.dgvMecanico.AllowUserToAddRows = false;
            this.dgvMecanico.AllowUserToDeleteRows = false;
            this.dgvMecanico.AutoGenerateColumns = false;
            this.dgvMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMecanico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvMecanico.DataSource = this.tcc_MecanicoBindingSource;
            this.dgvMecanico.Location = new System.Drawing.Point(6, 108);
            this.dgvMecanico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMecanico.Name = "dgvMecanico";
            this.dgvMecanico.ReadOnly = true;
            this.dgvMecanico.RowHeadersVisible = false;
            this.dgvMecanico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMecanico.Size = new System.Drawing.Size(605, 555);
            this.dgvMecanico.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "razaoSocial";
            this.dataGridViewTextBoxColumn2.HeaderText = "razaoSocial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn3.HeaderText = "cnpj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ie";
            this.dataGridViewTextBoxColumn4.HeaderText = "ie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "contaBancaria";
            this.dataGridViewTextBoxColumn7.HeaderText = "contaBancaria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "agenciaBancaria";
            this.dataGridViewTextBoxColumn8.HeaderText = "agenciaBancaria";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "comissao";
            this.dataGridViewTextBoxColumn9.HeaderText = "comissao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "logradouro";
            this.dataGridViewTextBoxColumn10.HeaderText = "logradouro";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn11.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn12.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn13.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn14.HeaderText = "uf";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn15.HeaderText = "cep";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(536, 73);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(168, 73);
            this.btnPesquisaCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisaCancelar.TabIndex = 19;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            this.btnPesquisaCancelar.Click += new System.EventHandler(this.btnPesquisaCancelar_Click);
            // 
            // tbnAlterar
            // 
            this.tbnAlterar.Location = new System.Drawing.Point(87, 73);
            this.tbnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnAlterar.Name = "tbnAlterar";
            this.tbnAlterar.Size = new System.Drawing.Size(75, 28);
            this.tbnAlterar.TabIndex = 18;
            this.tbnAlterar.Text = "&Alterar";
            this.tbnAlterar.UseVisualStyleBackColor = true;
            this.tbnAlterar.Click += new System.EventHandler(this.tbnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(6, 73);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 18);
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
            this.cmbOrdenar.Location = new System.Drawing.Point(490, 39);
            this.cmbOrdenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 24);
            this.cmbOrdenar.TabIndex = 14;
            this.cmbOrdenar.Text = "Código";
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Razão Social",
            "CNPJ"});
            this.cmbFiltro.Location = new System.Drawing.Point(363, 39);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 39);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(349, 23);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesquisar:";
            // 
            // tcc_MecanicoTableAdapter
            // 
            this.tcc_MecanicoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 732);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMecanico";
            this.Text = "Mecânico";
            this.Load += new System.EventHandler(this.FrmMecanico_Load);
            this.tabControl.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.grbConta.ResumeLayout(false);
            this.grbConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMecanico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.TabPage tabPage2;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_MecanicoBindingSource;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbConta;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
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
        private System.Windows.Forms.DataGridView dgvMecanico;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}