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
    //TODO: design

    public partial class FrmProduto : Form
    {
        Utility utility = new Utility();
        Operacao operacao;
        int idProduto;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto cadastroProduto = new FrmCadastroProduto();
            cadastroProduto.NovoCadastro = true;
            cadastroProduto.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                if(cmbFiltro.SelectedIndex == 0)
                {
                    tcc_ProdutoTableAdapter.FillById(banco.tcc_Produto, Convert.ToInt32(txtPesquisa.Text));
                }
                else if(cmbFiltro.SelectedIndex == 1)
                {
                    tcc_ProdutoTableAdapter.FillByDescricao(banco.tcc_Produto, "%" + txtPesquisa.Text + "%");
                }
            }
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmProduto_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDMecanico"].ToString());
                //tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                tcc_ProdutoTableAdapter.Delete(idProduto);
                FrmProduto_Load(null, null);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var produto = ((DataRowView)tcc_ProdutoBindingSource.Current).Row as Banco.tcc_ProdutoRow;
            FrmCadastroProduto cadastroProduto = new FrmCadastroProduto();
            cadastroProduto.NovoCadastro = false;
            cadastroProduto.Alterar(produto.descricao,
                produto.precoVenda.ToString(), produto.precoCompra.ToString(), produto.quantidade);
            cadastroProduto.IdProduto = produto.IDProduto;
            cadastroProduto.ShowDialog();
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenar.SelectedIndex == 0)
            {
                tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
            }
            else if (cmbOrdenar.SelectedIndex == 1)
            {
                tcc_ProdutoTableAdapter.FillByOrderDescricao(banco.tcc_Produto);
            }
            else if(cmbOrdenar.SelectedIndex == 2)
            {
                tcc_ProdutoTableAdapter.FillByOrderQuantidadeAsc(banco.tcc_Produto);
            }
            else if(cmbOrdenar.SelectedIndex == 3)
            {
                tcc_ProdutoTableAdapter.FillByOrderQuantidadeDesc(banco.tcc_Produto);
            }
        }
        private void tcc_ProdutoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar_Click(null, null);
        }

        public void Reload()
        {
            FrmProduto_Load(null, null);
        }
    }
}
