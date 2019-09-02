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
    //TODO: fazer tudo, esse nao tem nada

    public partial class FrmOrcamento : Form
    {
        public FrmOrcamento()
        {
            InitializeComponent();
        }

        private void FrmOrcamento_Load(object sender, EventArgs e)
        {
            this.tcc_produtoOrcamentoTableAdapter.Fill(this.banco.tcc_produtoOrcamento);
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);

        }

        private void tcc_produtoOrcamentoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.Alterar(
                Convert.ToInt32(((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["IDProduto"].ToString()),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["descricao"].ToString(),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["IDProduto"].ToString(),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["precoUnitario"].ToString(),
                Convert.ToInt32(((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["quantidade"].ToString())
                );
            
        }
    }
}
