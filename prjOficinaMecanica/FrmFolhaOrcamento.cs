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
        public int id;
        public FrmFolhaOrcamento()
        {
            InitializeComponent();
        }

        private void FrmFolhaOrcamento_Load(object sender, EventArgs e)
        {
            if(id == 0)
                this.RelOrcamentoTableAdapter.Fill(this.Banco.RelOrcamento);
            else
                this.RelOrcamentoTableAdapter.FillbyId(this.Banco.RelOrcamento, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
