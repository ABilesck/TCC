namespace prjOficinaMecanica
{
    partial class FrmRtpCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRtpCliente));
            this.ReportClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Banco = new prjOficinaMecanica.Banco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportClienteTableAdapter = new prjOficinaMecanica.BancoTableAdapters.ReportClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportClienteBindingSource
            // 
            this.ReportClienteBindingSource.DataMember = "ReportCliente";
            this.ReportClienteBindingSource.DataSource = this.Banco;
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
            reportDataSource1.Value = this.ReportClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjOficinaMecanica.rptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportClienteTableAdapter
            // 
            this.ReportClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRtpCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRtpCliente";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.FrmRtpCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportClienteBindingSource;
        private Banco Banco;
        private BancoTableAdapters.ReportClienteTableAdapter ReportClienteTableAdapter;
    }
}