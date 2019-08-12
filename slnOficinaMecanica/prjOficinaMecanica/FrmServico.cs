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
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void tcc_OrcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_OrcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Mecanico' table. You can move, or remove it, as needed.
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            // TODO: This line of code loads data into the 'banco.tcc_Servico' table. You can move, or remove it, as needed.
            this.tcc_ServicoTableAdapter.Fill(this.banco.tcc_Servico);
            // TODO: This line of code loads data into the 'banco.tcc_Orcamento' table. You can move, or remove it, as needed.
            this.tcc_OrcamentoTableAdapter.Fill(this.banco.tcc_Orcamento);

        }
    }
}
