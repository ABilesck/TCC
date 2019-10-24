namespace prjOficinaMecanica
{
    partial class FrmCadastroServico
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
            System.Windows.Forms.Label dataInicioLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcc_OrcamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.tcc_produtoOrcamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tcc_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_produtoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_produtoOrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_produtoOrcamentoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.tcc_OrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_OrcamentoTableAdapter();
            this.tcc_ServicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ServicoTableAdapter();
            this.tccMecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.cmbMecanico = new System.Windows.Forms.ComboBox();
            this.tccMecanicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iDMecanicoLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tcc_OrcamentoDataGridView);
            this.groupBox1.Controls.Add(this.tcc_produtoOrcamentoDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produtos";
            // 
            // tcc_OrcamentoDataGridView
            // 
            this.tcc_OrcamentoDataGridView.AllowUserToAddRows = false;
            this.tcc_OrcamentoDataGridView.AllowUserToDeleteRows = false;
            this.tcc_OrcamentoDataGridView.AutoGenerateColumns = false;
            this.tcc_OrcamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_OrcamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tcc_OrcamentoDataGridView.DataSource = this.tcc_OrcamentoBindingSource;
            this.tcc_OrcamentoDataGridView.Location = new System.Drawing.Point(6, 19);
            this.tcc_OrcamentoDataGridView.Name = "tcc_OrcamentoDataGridView";
            this.tcc_OrcamentoDataGridView.ReadOnly = true;
            this.tcc_OrcamentoDataGridView.RowHeadersVisible = false;
            this.tcc_OrcamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_OrcamentoDataGridView.Size = new System.Drawing.Size(763, 187);
            this.tcc_OrcamentoDataGridView.TabIndex = 3;
            this.tcc_OrcamentoDataGridView.SelectionChanged += new System.EventHandler(this.tcc_OrcamentoDataGridView_SelectionChanged);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tcc_produtoOrcamentoDataGridView.DataSource = this.tcc_produtoOrcamentoBindingSource;
            this.tcc_produtoOrcamentoDataGridView.Location = new System.Drawing.Point(6, 243);
            this.tcc_produtoOrcamentoDataGridView.Name = "tcc_produtoOrcamentoDataGridView";
            this.tcc_produtoOrcamentoDataGridView.ReadOnly = true;
            this.tcc_produtoOrcamentoDataGridView.Size = new System.Drawing.Size(763, 198);
            this.tcc_produtoOrcamentoDataGridView.TabIndex = 4;
            // 
            // iDMecanicoLabel
            // 
            iDMecanicoLabel.AutoSize = true;
            iDMecanicoLabel.Location = new System.Drawing.Point(17, 25);
            iDMecanicoLabel.Name = "iDMecanicoLabel";
            iDMecanicoLabel.Size = new System.Drawing.Size(57, 13);
            iDMecanicoLabel.TabIndex = 1;
            iDMecanicoLabel.Text = "Mecânico:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(15, 52);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(59, 13);
            dataInicioLabel.TabIndex = 5;
            dataInicioLabel.Text = "data Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tcc_ServicoBindingSource, "dataInicio", true));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(96, 49);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(596, 22);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(185, 20);
            this.txtDesconto.TabIndex = 8;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(95, 78);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(686, 115);
            this.txtObs.TabIndex = 9;
            this.txtObs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Obs.:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(721, 652);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(640, 652);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IDOrcamento";
            this.dataGridViewTextBoxColumn7.HeaderText = "IDOrcamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dataConsulta";
            this.dataGridViewTextBoxColumn8.HeaderText = "dataConsulta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IDAutomovel";
            this.dataGridViewTextBoxColumn9.HeaderText = "IDAutomovel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn10.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn11.HeaderText = "nome";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaoDeObra";
            this.dataGridViewTextBoxColumn12.HeaderText = "MaoDeObra";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tcc_OrcamentoBindingSource
            // 
            this.tcc_OrcamentoBindingSource.DataMember = "tcc_Orcamento";
            this.tcc_OrcamentoBindingSource.DataSource = this.banco;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = this.tcc_OrcamentoTableAdapter;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = this.tcc_produtoOrcamentoTableAdapter;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_OrcamentoTableAdapter
            // 
            this.tcc_OrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_ServicoTableAdapter
            // 
            this.tcc_ServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tccMecanicoBindingSource
            // 
            this.tccMecanicoBindingSource.DataMember = "tcc_Mecanico";
            this.tccMecanicoBindingSource.DataSource = this.banco;
            // 
            // tcc_MecanicoTableAdapter
            // 
            this.tcc_MecanicoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMecanico
            // 
            this.cmbMecanico.DataSource = this.tccMecanicoBindingSource1;
            this.cmbMecanico.DisplayMember = "razaoSocial";
            this.cmbMecanico.FormattingEnabled = true;
            this.cmbMecanico.Location = new System.Drawing.Point(95, 22);
            this.cmbMecanico.Name = "cmbMecanico";
            this.cmbMecanico.Size = new System.Drawing.Size(436, 21);
            this.cmbMecanico.TabIndex = 13;
            this.cmbMecanico.ValueMember = "IDMecanico";
            // 
            // tccMecanicoBindingSource1
            // 
            this.tccMecanicoBindingSource1.DataMember = "tcc_Mecanico";
            this.tccMecanicoBindingSource1.DataSource = this.banco;
            // 
            // FrmCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 687);
            this.Controls.Add(this.cmbMecanico);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(iDMecanicoLabel);
            this.Controls.Add(dataInicioLabel);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadastroServico";
            this.Text = "FrmCadastroServico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroServico_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_produtoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_produtoOrcamentoBindingSource;
        private BancoTableAdapters.tcc_produtoOrcamentoTableAdapter tcc_produtoOrcamentoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private BancoTableAdapters.tcc_OrcamentoTableAdapter tcc_OrcamentoTableAdapter;
        private System.Windows.Forms.BindingSource tcc_OrcamentoBindingSource;
        private BancoTableAdapters.tcc_ServicoTableAdapter tcc_ServicoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tcc_OrcamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView tcc_produtoOrcamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tcc_ServicoBindingSource;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.BindingSource tccMecanicoBindingSource;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private System.Windows.Forms.ComboBox cmbMecanico;
        private System.Windows.Forms.BindingSource tccMecanicoBindingSource1;
    }
}