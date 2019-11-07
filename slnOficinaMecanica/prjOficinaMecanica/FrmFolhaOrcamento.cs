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
    public partial class FrmFolhaOrcamento : Form
    {
        public FrmFolhaOrcamento()
        {
            InitializeComponent();
        }

        private void FrmFolhaOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.OrdemServico' table. You can move, or remove it, as needed.
            this.RelOrcamentoTableAdapter.Fill(this.Banco.RelOrcamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
