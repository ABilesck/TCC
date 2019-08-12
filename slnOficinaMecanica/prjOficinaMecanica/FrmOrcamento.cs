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
    public partial class FrmOrcamento : Form
    {
        public FrmOrcamento()
        {
            InitializeComponent();
        }

        private void tcc_OrcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_OrcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Automovel' table. You can move, or remove it, as needed.
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
            // TODO: This line of code loads data into the 'banco.tcc_Cliente' table. You can move, or remove it, as needed.
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);
            // TODO: This line of code loads data into the 'banco.tcc_Produto' table. You can move, or remove it, as needed.
            this.tcc_ProdutoTableAdapter.Fill(this.banco.tcc_Produto);
            // TODO: This line of code loads data into the 'banco.tcc_produtoOrcamento' table. You can move, or remove it, as needed.
            this.tcc_produtoOrcamentoTableAdapter.Fill(this.banco.tcc_produtoOrcamento);
            // TODO: This line of code loads data into the 'banco.tcc_Orcamento' table. You can move, or remove it, as needed.
            this.tcc_OrcamentoTableAdapter.Fill(this.banco.tcc_Orcamento);

        }
    }
}
