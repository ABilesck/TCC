﻿namespace prjOficinaMecanica
{
    partial class FrmCadastroOrcamento
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
            System.Windows.Forms.Label maoDeObraLabel;
            this.banco = new prjOficinaMecanica.Banco();
            this.tcc_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_OrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_OrcamentoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.tcc_AutomovelTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_AutomovelTableAdapter();
            this.tcc_ClienteTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ClienteTableAdapter();
            this.tccAutomovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaoDeObra = new System.Windows.Forms.MaskedTextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.tccClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbCarro = new System.Windows.Forms.ComboBox();
            this.tccAutomovelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iDAutomovelLabel = new System.Windows.Forms.Label();
            maoDeObraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDAutomovelLabel
            // 
            iDAutomovelLabel.AutoSize = true;
            iDAutomovelLabel.Location = new System.Drawing.Point(12, 52);
            iDAutomovelLabel.Name = "iDAutomovelLabel";
            iDAutomovelLabel.Size = new System.Drawing.Size(71, 13);
            iDAutomovelLabel.TabIndex = 4;
            iDAutomovelLabel.Text = "IDAutomovel:";
            // 
            // maoDeObraLabel
            // 
            maoDeObraLabel.AutoSize = true;
            maoDeObraLabel.Location = new System.Drawing.Point(9, 102);
            maoDeObraLabel.Name = "maoDeObraLabel";
            maoDeObraLabel.Size = new System.Drawing.Size(74, 13);
            maoDeObraLabel.TabIndex = 10;
            maoDeObraLabel.Text = "Mao De Obra:";
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_OrcamentoBindingSource
            // 
            this.tcc_OrcamentoBindingSource.DataMember = "tcc_Orcamento";
            this.tcc_OrcamentoBindingSource.DataSource = this.banco;
            // 
            // tcc_OrcamentoTableAdapter
            // 
            this.tcc_OrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = this.tcc_AutomovelTableAdapter;
            this.tableAdapterManager.tcc_ClienteTableAdapter = this.tcc_ClienteTableAdapter;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_AutomovelTableAdapter
            // 
            this.tcc_AutomovelTableAdapter.ClearBeforeFill = true;
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
            // txtMaoDeObra
            // 
            this.txtMaoDeObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tcc_OrcamentoBindingSource, "MaoDeObra", true));
            this.txtMaoDeObra.Location = new System.Drawing.Point(89, 99);
            this.txtMaoDeObra.Name = "txtMaoDeObra";
            this.txtMaoDeObra.Size = new System.Drawing.Size(200, 20);
            this.txtMaoDeObra.TabIndex = 3;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.tccClienteBindingSource;
            this.cmbCliente.DisplayMember = "nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(89, 12);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(386, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.ValueMember = "IDCliente";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // tccClienteBindingSource
            // 
            this.tccClienteBindingSource.DataMember = "tcc_Cliente";
            this.tccClienteBindingSource.DataSource = this.banco;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(375, 50);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(319, 148);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCarro
            // 
            this.cmbCarro.DataSource = this.tccAutomovelBindingSource1;
            this.cmbCarro.DisplayMember = "modelo";
            this.cmbCarro.FormattingEnabled = true;
            this.cmbCarro.Location = new System.Drawing.Point(89, 50);
            this.cmbCarro.Name = "cmbCarro";
            this.cmbCarro.Size = new System.Drawing.Size(280, 21);
            this.cmbCarro.TabIndex = 15;
            this.cmbCarro.ValueMember = "IDAutomovel";
            // 
            // tccAutomovelBindingSource1
            // 
            this.tccAutomovelBindingSource1.DataMember = "tcc_Automovel";
            this.tccAutomovelBindingSource1.DataSource = this.banco;
            // 
            // FrmCadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 182);
            this.Controls.Add(this.cmbCarro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(iDAutomovelLabel);
            this.Controls.Add(maoDeObraLabel);
            this.Controls.Add(this.txtMaoDeObra);
            this.Name = "FrmCadastroOrcamento";
            this.Text = "FrmCadastroOrcamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroOrcamento_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccAutomovelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_OrcamentoBindingSource;
        private BancoTableAdapters.tcc_OrcamentoTableAdapter tcc_OrcamentoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private BancoTableAdapters.tcc_AutomovelTableAdapter tcc_AutomovelTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtMaoDeObra;
        private System.Windows.Forms.BindingSource tccAutomovelBindingSource;
        private BancoTableAdapters.tcc_ClienteTableAdapter tcc_ClienteTableAdapter;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tccClienteBindingSource;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbCarro;
        private System.Windows.Forms.BindingSource tccAutomovelBindingSource1;
    }
}