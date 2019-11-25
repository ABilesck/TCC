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
    public partial class FrmOrdemDeServico : Form
    {
        public int mecanico;
        public int Orcamento;
        public FrmOrdemDeServico()
        {
            InitializeComponent();
        }

        private void FrmOrdemDeServico_Load(object sender, EventArgs e)
        {
            OrdemServicoTableAdapter.Fill(Banco.OrdemServico, mecanico, Orcamento);

            reportViewer1.RefreshReport();
        }
    }
}
