namespace prjOficinaMecanica
{
    partial class FrmCadastroProduto
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
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label precoVendaLabel;
            System.Windows.Forms.Label precoCompraLabel;
            this.txtPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.banco = new prjOficinaMecanica.Banco();
            this.tcc_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ProdutoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_ProdutoTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            quantidadeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            precoVendaLabel = new System.Windows.Forms.Label();
            precoCompraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(269, 77);
            this.txtPrecoCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(152, 20);
            this.txtPrecoCompra.TabIndex = 26;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(269, 29);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(152, 20);
            this.txtPrecoVenda.TabIndex = 25;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(262, 155);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 28);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(346, 155);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(5, 57);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 20;
            quantidadeLabel.Text = "quantidade:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(8, 77);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(118, 20);
            this.nudQuantidade.TabIndex = 21;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(5, 9);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 16;
            descricaoLabel.Text = "descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(8, 29);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(239, 20);
            this.txtDescricao.TabIndex = 17;
            // 
            // precoVendaLabel
            // 
            precoVendaLabel.AutoSize = true;
            precoVendaLabel.Location = new System.Drawing.Point(266, 9);
            precoVendaLabel.Name = "precoVendaLabel";
            precoVendaLabel.Size = new System.Drawing.Size(71, 13);
            precoVendaLabel.TabIndex = 18;
            precoVendaLabel.Text = "preco Venda:";
            // 
            // precoCompraLabel
            // 
            precoCompraLabel.AutoSize = true;
            precoCompraLabel.Location = new System.Drawing.Point(266, 57);
            precoCompraLabel.Name = "precoCompraLabel";
            precoCompraLabel.Size = new System.Drawing.Size(76, 13);
            precoCompraLabel.TabIndex = 19;
            precoCompraLabel.Text = "preco Compra:";
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_ProdutoBindingSource
            // 
            this.tcc_ProdutoBindingSource.DataMember = "tcc_Produto";
            this.tcc_ProdutoBindingSource.DataSource = this.banco;
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
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = this.tcc_ProdutoTableAdapter;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 194);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(precoVendaLabel);
            this.Controls.Add(precoCompraLabel);
            this.Name = "FrmCadastroProduto";
            this.Text = "FrmCadastroProduto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroProduto_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPrecoCompra;
        private System.Windows.Forms.MaskedTextBox txtPrecoVenda;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_ProdutoBindingSource;
        private BancoTableAdapters.tcc_ProdutoTableAdapter tcc_ProdutoTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
    }
}