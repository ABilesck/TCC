namespace prjOficinaMecanica
{
    partial class FrmRelMecanico
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
            this.RelMecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Banco = new prjOficinaMecanica.Banco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelMecanicoTableAdapter = new prjOficinaMecanica.BancoTableAdapters.RelMecanicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelMecanicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // RelMecanicoBindingSource
            // 
            this.RelMecanicoBindingSource.DataMember = "RelMecanico";
            this.RelMecanicoBindingSource.DataSource = this.Banco;
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
            reportDataSource1.Value = this.RelMecanicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prjOficinaMecanica.RelMecanico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // RelMecanicoTableAdapter
            // 
            this.RelMecanicoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelMecanico";
            this.Text = "Relatório de Mecânico";
            this.Load += new System.EventHandler(this.FrmRelMecanico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelMecanicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RelMecanicoBindingSource;
        private Banco Banco;
        private BancoTableAdapters.RelMecanicoTableAdapter RelMecanicoTableAdapter;
    }
}