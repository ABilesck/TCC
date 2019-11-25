namespace prjOficinaMecanica
{
    partial class FrmFolhaOrcamento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Banco = new prjOficinaMecanica.Banco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelOrcamentoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.RelOrcamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // RelOrcamentoBindingSource
            // 
            this.RelOrcamentoBindingSource.DataMember = "RelOrcamento";
            this.RelOrcamentoBindingSource.DataSource = this.Banco;
            // 
            // Banco
            // 
            this.Banco.DataSetName = "Banco";
            this.Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RelOrcamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjOficinaMecanica.FolhaOrcamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(929, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // RelOrcamentoTableAdapter
            // 
            this.RelOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFolhaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 605);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFolhaOrcamento";
            this.Text = "Folha de Orçamento";
            this.Load += new System.EventHandler(this.FrmFolhaOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Banco Banco;
        private System.Windows.Forms.BindingSource RelOrcamentoBindingSource;
        private BancoTableAdapters.RelOrcamentoTableAdapter RelOrcamentoTableAdapter;
    }
}