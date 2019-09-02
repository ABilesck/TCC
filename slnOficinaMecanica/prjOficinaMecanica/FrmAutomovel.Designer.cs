namespace prjOficinaMecanica
{
    partial class FrmAutomovel
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
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label kmRodadoLabel;
            this.lblCliente = new System.Windows.Forms.Label();
            this.banco = new prjOficinaMecanica.Banco();
            this.tcc_AutomovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_AutomovelTableAdapter = new prjOficinaMecanica.BancoTableAdapters.tcc_AutomovelTableAdapter();
            this.tableAdapterManager = new prjOficinaMecanica.BancoTableAdapters.TableAdapterManager();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            placaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            kmRodadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new System.Drawing.Point(12, 78);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(36, 13);
            placaLabel.TabIndex = 6;
            placaLabel.Text = "placa:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(4, 52);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(44, 13);
            modeloLabel.TabIndex = 8;
            modeloLabel.Text = "modelo:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(21, 104);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(28, 13);
            anoLabel.TabIndex = 10;
            anoLabel.Text = "ano:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(217, 52);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(25, 13);
            corLabel.TabIndex = 12;
            corLabel.Text = "cor:";
            // 
            // kmRodadoLabel
            // 
            kmRodadoLabel.AutoSize = true;
            kmRodadoLabel.Location = new System.Drawing.Point(177, 82);
            kmRodadoLabel.Name = "kmRodadoLabel";
            kmRodadoLabel.Size = new System.Drawing.Size(65, 13);
            kmRodadoLabel.TabIndex = 14;
            kmRodadoLabel.Text = "km Rodado:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // banco
            // 
            this.banco.DataSetName = "Banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_AutomovelBindingSource
            // 
            this.tcc_AutomovelBindingSource.DataMember = "tcc_Automovel";
            this.tcc_AutomovelBindingSource.DataSource = this.banco;
            // 
            // tcc_AutomovelTableAdapter
            // 
            this.tcc_AutomovelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_AutomovelTableAdapter = this.tcc_AutomovelTableAdapter;
            this.tableAdapterManager.tcc_ClienteTableAdapter = null;
            this.tableAdapterManager.tcc_MecanicoTableAdapter = null;
            this.tableAdapterManager.tcc_OrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_produtoOrcamentoTableAdapter = null;
            this.tableAdapterManager.tcc_ProdutoTableAdapter = null;
            this.tableAdapterManager.tcc_ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjOficinaMecanica.BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(55, 75);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(75, 20);
            this.txtPlaca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(55, 49);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(55, 101);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(75, 20);
            this.txtAno.TabIndex = 11;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(248, 49);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(138, 20);
            this.txtCor.TabIndex = 13;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(248, 75);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(366, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(285, 144);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(204, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 185);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(placaLabel);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(kmRodadoLabel);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmAutomovel";
            this.Text = "Automovel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutomovel_FormClosing);
            this.Load += new System.EventHandler(this.FrmCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_AutomovelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private Banco banco;
        private System.Windows.Forms.BindingSource tcc_AutomovelBindingSource;
        private BancoTableAdapters.tcc_AutomovelTableAdapter tcc_AutomovelTableAdapter;
        private BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}