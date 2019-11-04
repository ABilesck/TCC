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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServico));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisaCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tcc_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
            this.tccMecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_OrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_OrcamentoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.tcc_MecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_MecanicoTableAdapter();
            this.tcc_ServicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ServicoTableAdapter();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1139, 102);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisaCancelar
            // 
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(174, 102);
            this.btnPesquisaCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisaCancelar.Name = "btnPesquisaCancelar";
            this.btnPesquisaCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisaCancelar.TabIndex = 29;
            this.btnPesquisaCancelar.Text = "&Cancelar";
            this.btnPesquisaCancelar.UseVisualStyleBackColor = true;
            this.btnPesquisaCancelar.Click += new System.EventHandler(this.btnPesquisaCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 102);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 28);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 102);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 28);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1090, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(963, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pesquisar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbOrdenar.Location = new System.Drawing.Point(1093, 68);
            this.cmbOrdenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 24);
            this.cmbOrdenar.TabIndex = 24;
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
            this.cmbFiltro.Location = new System.Drawing.Point(966, 68);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 23;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 69);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(948, 23);
            this.txtPesquisa.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pesquisar:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 32;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(423, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 19);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(311, 102);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(106, 28);
            this.btnFinalizar.TabIndex = 34;
            this.btnFinalizar.Text = "&Finalizar serviço";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            this.tableAdapterManager.tcc_AutomovelTableAdapter = null;
            this.tableAdapterManager.tcc_ClienteTableAdapter = null;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = this.tcc_MecanicoTableAdapter;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
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
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.AutoGenerateColumns = false;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9});
            this.dgvServico.DataSource = this.tcc_ServicoBindingSource;
            this.dgvServico.Location = new System.Drawing.Point(12, 137);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.RowHeadersVisible = false;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(1202, 405);
            this.dgvServico.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fantasia";
            this.dataGridViewTextBoxColumn6.HeaderText = "fantasia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaoDeObra";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaoDeObra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dataInicio";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn10.HeaderText = "dataInicio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dataFim";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn11.HeaderText = "dataFim";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 110;
            // 
            // FrmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 554);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisaCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbOrdenar);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmServico";
            this.Text = "FrmServico";
            this.Load += new System.EventHandler(this.FrmServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMecanicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_OrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_OrcamentoBindingSource;
        private BancoTableAdapters.tcc_OrcamentoTableAdapter tcc_OrcamentoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private BancoTableAdapters.tcc_ServicoTableAdapter tcc_ServicoTableAdapter;
        private System.Windows.Forms.BindingSource tcc_ServicoBindingSource;
        private BancoTableAdapters.tcc_MecanicoTableAdapter tcc_MecanicoTableAdapter;
        private System.Windows.Forms.BindingSource tccMecanicoBindingSource;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisaCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}