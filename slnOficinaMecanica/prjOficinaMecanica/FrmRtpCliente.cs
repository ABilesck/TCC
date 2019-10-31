using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    public partial class FrmRtpCliente : Form
    {
        public FrmRtpCliente()
        {
            InitializeComponent();
        }

        private void FrmRtpCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.ReportCliente' table. You can move, or remove it, as needed.
            this.ReportClienteTableAdapter.Fill(this.Banco.ReportCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
