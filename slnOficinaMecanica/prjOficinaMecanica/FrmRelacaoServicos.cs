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
    public partial class FrmRelacaoServicos : Form
    {
        public FrmRelacaoServicos()
        {
            InitializeComponent();
        }

        private void FrmRelacaoServicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.RptServico' table. You can move, or remove it, as needed.
            this.RptServicoTableAdapter.Fill(this.Banco.RptServico);

            this.reportViewer1.RefreshReport();
        }
    }
}
