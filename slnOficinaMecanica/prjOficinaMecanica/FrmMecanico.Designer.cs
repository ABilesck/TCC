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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.banco = new prjOficinaMecanica.Banco();
            this.tcc_MecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.ieTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contaBancariaTextBox = new System.Windows.Forms.TextBox();
            this.agenciaBancariaTextBox = new System.Windows.Forms.TextBox();
            this.comissaoTextBox = new System.Windows.Forms.TextBox();
            razaoSocialLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contaBancariaLabel = new System.Windows.Forms.Label();
            agenciaBancariaLabel = new System.Windows.Forms.Label();
            comissaoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(599, 559);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(razaoSocialLabel);
            this.tabPage3.Controls.Add(this.razaoSocialTextBox);
            this.tabPage3.Controls.Add(cnpjLabel);
            this.tabPage3.Controls.Add(this.cnpjTextBox);
            this.tabPage3.Controls.Add(ieLabel);
            this.tabPage3.Controls.Add(this.ieTextBox);
            this.tabPage3.Controls.Add(telefoneLabel);
            this.tabPage3.Controls.Add(this.telefoneTextBox);
            this.tabPage3.Controls.Add(emailLabel);
            this.tabPage3.Controls.Add(this.emailTextBox);
            this.tabPage3.Controls.Add(contaBancariaLabel);
            this.tabPage3.Controls.Add(this.contaBancariaTextBox);
            this.tabPage3.Controls.Add(agenciaBancariaLabel);
            this.tabPage3.Controls.Add(this.agenciaBancariaTextBox);
            this.tabPage3.Controls.Add(comissaoLabel);
            this.tabPage3.Controls.Add(this.comissaoTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(591, 533);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(13, 9);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(68, 13);
            razaoSocialLabel.TabIndex = 2;
            razaoSocialLabel.Text = "razao Social:";
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "razaoSocial", true));
            this.razaoSocialTextBox.Location = new System.Drawing.Point(112, 6);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razaoSocialTextBox.TabIndex = 3;
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(13, 35);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 4;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(112, 32);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 5;
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(13, 61);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(18, 13);
            ieLabel.TabIndex = 6;
            ieLabel.Text = "ie:";
            // 
            // ieTextBox
            // 
            this.ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "ie", true));
            this.ieTextBox.Location = new System.Drawing.Point(112, 58);
            this.ieTextBox.Name = "ieTextBox";
            this.ieTextBox.Size = new System.Drawing.Size(100, 20);
            this.ieTextBox.TabIndex = 7;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(13, 87);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(112, 84);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 113);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(112, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // contaBancariaLabel
            // 
            contaBancariaLabel.AutoSize = true;
            contaBancariaLabel.Location = new System.Drawing.Point(13, 139);
            contaBancariaLabel.Name = "contaBancariaLabel";
            contaBancariaLabel.Size = new System.Drawing.Size(82, 13);
            contaBancariaLabel.TabIndex = 12;
            contaBancariaLabel.Text = "conta Bancaria:";
            // 
            // contaBancariaTextBox
            // 
            this.contaBancariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "contaBancaria", true));
            this.contaBancariaTextBox.Location = new System.Drawing.Point(112, 136);
            this.contaBancariaTextBox.Name = "contaBancariaTextBox";
            this.contaBancariaTextBox.Size = new System.Drawing.Size(100, 20);
            this.contaBancariaTextBox.TabIndex = 13;
            // 
            // agenciaBancariaLabel
            // 
            agenciaBancariaLabel.AutoSize = true;
            agenciaBancariaLabel.Location = new System.Drawing.Point(13, 165);
            agenciaBancariaLabel.Name = "agenciaBancariaLabel";
            agenciaBancariaLabel.Size = new System.Drawing.Size(93, 13);
            agenciaBancariaLabel.TabIndex = 14;
            agenciaBancariaLabel.Text = "agencia Bancaria:";
            // 
            // agenciaBancariaTextBox
            // 
            this.agenciaBancariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "agenciaBancaria", true));
            this.agenciaBancariaTextBox.Location = new System.Drawing.Point(112, 162);
            this.agenciaBancariaTextBox.Name = "agenciaBancariaTextBox";
            this.agenciaBancariaTextBox.Size = new System.Drawing.Size(100, 20);
            this.agenciaBancariaTextBox.TabIndex = 15;
            // 
            // comissaoLabel
            // 
            comissaoLabel.AutoSize = true;
            comissaoLabel.Location = new System.Drawing.Point(13, 191);
            comissaoLabel.Name = "comissaoLabel";
            comissaoLabel.Size = new System.Drawing.Size(54, 13);
            comissaoLabel.TabIndex = 16;
            comissaoLabel.Text = "comissao:";
            // 
            // comissaoTextBox
            // 
            this.comissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_MecanicoBindingSource, "comissao", true));
            this.comissaoTextBox.Location = new System.Drawing.Point(112, 188);
            this.comissaoTextBox.Name = "comissaoTextBox";
            this.comissaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.comissaoTextBox.TabIndex = 17;
            // 
            // FrmMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMecanico";
            this.Text = "FrmMecanico";
            this.Load += new System.EventHandler(this.FrmMecanico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_MecanicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_MecanicoBindingSource;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox ieTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contaBancariaTextBox;
        private System.Windows.Forms.TextBox agenciaBancariaTextBox;
        private System.Windows.Forms.TextBox comissaoTextBox;
    }
}