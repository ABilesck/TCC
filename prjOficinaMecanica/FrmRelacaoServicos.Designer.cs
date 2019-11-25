namespace prjOficinaMecanica
{
    partial class FrmRelacaoServicos
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
            this.OrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Banco = new prjOficinaMecanica.Banco();
            this.RptServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RptServicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.RptServicoTableAdapter();
            this.OrdemServicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.OrdemServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdemServicoBindingSource
            // 
            this.OrdemServicoBindingSource.DataMember = "OrdemServico";
            this.OrdemServicoBindingSource.DataSource = this.Banco;
            // 
            // Banco
            // 
            this.Banco.DataSetName = "Banco";
            this.Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptServicoBindingSource
            // 
            this.RptServicoBindingSource.DataMember = "RptServico";
            this.RptServicoBindingSource.DataSource = this.Banco;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdemServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjOficinaMecanica.OrdemDeServico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // RptServicoTableAdapter
            // 
            this.RptServicoTableAdapter.ClearBeforeFill = true;
            // 
            // OrdemServicoTableAdapter
            // 
            this.OrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelacaoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelacaoServicos";
            this.Text = "Relação de Serviços";
            this.Load += new System.EventHandler(this.FrmRelacaoServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RptServicoBindingSource;
        private Banco Banco;
        private BancoTableAdapters.RptServicoTableAdapter RptServicoTableAdapter;
        private System.Windows.Forms.BindingSource OrdemServicoBindingSource;
        private BancoTableAdapters.OrdemServicoTableAdapter OrdemServicoTableAdapter;
    }
}