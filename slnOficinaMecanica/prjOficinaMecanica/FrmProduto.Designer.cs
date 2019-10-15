namespace prjOficinaMecanica
{
    partial class FrmProduto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label precoVendaLabel;
            System.Windows.Forms.Label precoCompraLabel;
            System.Windows.Forms.Label quantidadeLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.txtPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcc_ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco = new prjOficinaMecanica.Banco();
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
            this.tcc_ProdutoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ProdutoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            descricaoLabel = new System.Windows.Forms.Label();
            precoVendaLabel = new System.Windows.Forms.Label();
            precoCompraLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(6, 39);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(61, 16);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "descricao:";
            // 
            // precoVendaLabel
            // 
            precoVendaLabel.AutoSize = true;
            precoVendaLabel.Location = new System.Drawing.Point(267, 39);
            precoVendaLabel.Name = "precoVendaLabel";
            precoVendaLabel.Size = new System.Drawing.Size(72, 16);
            precoVendaLabel.TabIndex = 6;
            precoVendaLabel.Text = "preco Venda:";
            // 
            // precoCompraLabel
            // 
            precoCompraLabel.AutoSize = true;
            precoCompraLabel.Location = new System.Drawing.Point(267, 87);
            precoCompraLabel.Name = "precoCompraLabel";
            precoCompraLabel.Size = new System.Drawing.Size(83, 16);
            precoCompraLabel.TabIndex = 8;
            precoCompraLabel.Text = "preco Compra:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 87);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(66, 16);
            quantidadeLabel.TabIndex = 9;
            quantidadeLabel.Text = "quantidade:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDados);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.txtPrecoCompra);
            this.tpDados.Controls.Add(this.txtPrecoVenda);
            this.tpDados.Controls.Add(this.btnGravar);
            this.tpDados.Controls.Add(this.btnCancelar);
            this.tpDados.Controls.Add(this.btnNovo);
            this.tpDados.Controls.Add(quantidadeLabel);
            this.tpDados.Controls.Add(this.nudQuantidade);
            this.tpDados.Controls.Add(descricaoLabel);
            this.tpDados.Controls.Add(this.txtDescricao);
            this.tpDados.Controls.Add(precoVendaLabel);
            this.tpDados.Controls.Add(precoCompraLabel);
            this.tpDados.Location = new System.Drawing.Point(4, 25);
            this.tpDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpDados.Size = new System.Drawing.Size(576, 413);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Cadastro";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(270, 107);
            this.txtPrecoCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(152, 23);
            this.txtPrecoCompra.TabIndex = 15;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(270, 59);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(152, 23);
            this.txtPrecoVenda.TabIndex = 14;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(263, 185);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 28);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(347, 185);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 7);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(9, 107);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(118, 23);
            this.nudQuantidade.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(9, 59);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(239, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tcc_ProdutoDataGridView);
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
            this.tabPage2.Size = new System.Drawing.Size(576, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcc_ProdutoDataGridView
            // 
            this.tcc_ProdutoDataGridView.AllowUserToAddRows = false;
            this.tcc_ProdutoDataGridView.AllowUserToDeleteRows = false;
            this.tcc_ProdutoDataGridView.AutoGenerateColumns = false;
            this.tcc_ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tcc_ProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tcc_ProdutoDataGridView.DataSource = this.tcc_ProdutoBindingSource;
            this.tcc_ProdutoDataGridView.Location = new System.Drawing.Point(6, 105);
            this.tcc_ProdutoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcc_ProdutoDataGridView.Name = "tcc_ProdutoDataGridView";
            this.tcc_ProdutoDataGridView.ReadOnly = true;
            this.tcc_ProdutoDataGridView.RowHeadersVisible = false;
            this.tcc_ProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tcc_ProdutoDataGridView.Size = new System.Drawing.Size(554, 271);
            this.tcc_ProdutoDataGridView.TabIndex = 20;
            this.tcc_ProdutoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tcc_ProdutoDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precoVenda";
            this.dataGridViewTextBoxColumn4.HeaderText = "precoVenda";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precoCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "precoCompra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tcc_ProdutoBindingSource
            // 
            this.tcc_ProdutoBindingSource.DataMember = "tcc_Produto";
            this.tcc_ProdutoBindingSource.DataSource = this.banco;
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(485, 69);
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
            this.btnPesquisaCancelar.Location = new System.Drawing.Point(168, 69);
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
            this.tbnAlterar.Location = new System.Drawing.Point(87, 69);
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
            this.btnPesquisar.Location = new System.Drawing.Point(6, 69);
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
            this.label12.Location = new System.Drawing.Point(439, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Organizar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 15);
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
            this.cmbOrdenar.Location = new System.Drawing.Point(439, 36);
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
            "Descrição"});
            this.cmbFiltro.Location = new System.Drawing.Point(312, 36);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 13;
            this.cmbFiltro.Text = "Código";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 36);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(300, 23);
            this.txtPesquisa.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesquisar:";
            // 
            // tcc_ProdutoTableAdapter
            // 
            this.tcc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = null;
            this.tableAdapterManager.tcc_ClienteTableAdapter = null;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = this.tcc_ProdutoTableAdapter;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 470);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_ProdutoBindingSource;
        private BancoTableAdapters.tcc_ProdutoTableAdapter tcc_ProdutoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView tcc_ProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
        private System.Windows.Forms.MaskedTextBox txtPrecoCompra;
        private System.Windows.Forms.MaskedTextBox txtPrecoVenda;
    }
}