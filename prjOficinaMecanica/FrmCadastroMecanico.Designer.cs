namespace prjOficinaMecanica
{
    partial class FrmCadastroMecanico
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
            System.Windows.Forms.Label comissaoLabel;
            System.Windows.Forms.Label agenciaBancariaLabel;
            System.Windows.Forms.Label contaBancariaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label ieLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMecanico));
            this.banco = new prjOficinaMecanica.Banco();
            this.tcc_MecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.grbConta = new System.Windows.Forms.GroupBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            comissaoLabel = new System.Windows.Forms.Label();
            agenciaBancariaLabel = new System.Windows.Forms.Label();
            contaBancariaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            razaoSocialLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).BeginInit();
            this.grbConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // comissaoLabel
            // 
            comissaoLabel.AutoSize = true;
            comissaoLabel.Location = new System.Drawing.Point(7, 100);
            comissaoLabel.Name = "comissaoLabel";
            comissaoLabel.Size = new System.Drawing.Size(55, 13);
            comissaoLabel.TabIndex = 4;
            comissaoLabel.Text = "Comissão:";
            // 
            // agenciaBancariaLabel
            // 
            agenciaBancariaLabel.AutoSize = true;
            agenciaBancariaLabel.Location = new System.Drawing.Point(175, 37);
            agenciaBancariaLabel.Name = "agenciaBancariaLabel";
            agenciaBancariaLabel.Size = new System.Drawing.Size(94, 13);
            agenciaBancariaLabel.TabIndex = 2;
            agenciaBancariaLabel.Text = "Agencia Bancária:";
            // 
            // contaBancariaLabel
            // 
            contaBancariaLabel.AutoSize = true;
            contaBancariaLabel.Location = new System.Drawing.Point(6, 37);
            contaBancariaLabel.Name = "contaBancariaLabel";
            contaBancariaLabel.Size = new System.Drawing.Size(83, 13);
            contaBancariaLabel.TabIndex = 0;
            contaBancariaLabel.Text = "Conta Bancária:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 109);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "E-mail:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(9, 157);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 30;
            telefoneLabel.Text = "Telefone:";
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(9, 13);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(73, 13);
            razaoSocialLabel.TabIndex = 24;
            razaoSocialLabel.Text = "Razão Social:";
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(231, 61);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(20, 13);
            ieLabel.TabIndex = 27;
            ieLabel.Text = "IE:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(9, 61);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 26;
            cnpjLabel.Text = "CNPJ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(273, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 51;
            label1.Text = "Nome Fantasia:";
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_MecanicoBindingSource
            // 
            this.tcc_MecanicoBindingSource.DataMember = "tcc_Mecanico";
            this.tcc_MecanicoBindingSource.DataSource = this.banco;
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
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grbConta
            // 
            this.grbConta.Controls.Add(comissaoLabel);
            this.grbConta.Controls.Add(this.txtComissao);
            this.grbConta.Controls.Add(agenciaBancariaLabel);
            this.grbConta.Controls.Add(this.txtAgencia);
            this.grbConta.Controls.Add(contaBancariaLabel);
            this.grbConta.Controls.Add(this.txtConta);
            this.grbConta.Location = new System.Drawing.Point(2, 209);
            this.grbConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbConta.Name = "grbConta";
            this.grbConta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbConta.Size = new System.Drawing.Size(461, 172);
            this.grbConta.TabIndex = 37;
            this.grbConta.TabStop = false;
            this.grbConta.Text = "Conta para depósito";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(10, 119);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(105, 20);
            this.txtComissao.TabIndex = 8;
            this.txtComissao.Text = "0";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(178, 57);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(149, 20);
            this.txtAgencia.TabIndex = 7;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(9, 57);
            this.txtConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(163, 20);
            this.txtConta.TabIndex = 6;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(312, 454);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(251, 20);
            this.txtComplemento.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 454);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(398, 502);
            this.cmbUf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(121, 21);
            this.cmbUf.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(407, 600);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 502);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(377, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(12, 406);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(551, 20);
            this.txtLogradouro.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 600);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Complemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Logradouro";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(12, 33);
            this.txtRazao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(258, 20);
            this.txtRazao.TabIndex = 0;
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(234, 81);
            this.txtIe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(229, 20);
            this.txtIe.TabIndex = 3;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(276, 33);
            this.txtFantasia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(258, 20);
            this.txtFantasia.TabIndex = 1;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(11, 81);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(215, 20);
            this.txtCnpj.TabIndex = 2;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 174);
            this.txtTelefone.Mask = "(00)#0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(187, 20);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 547);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(147, 20);
            this.txtCep.TabIndex = 14;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmCadastroMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 647);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.grbConta);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(razaoSocialLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(ieLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(cnpjLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroMecanico";
            this.Text = "Cadastro de Mecânico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroMecanico_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroMecanico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).EndInit();
            this.grbConta.ResumeLayout(false);
            this.grbConta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_MecanicoBindingSource;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox grbConta;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCep;
    }
}