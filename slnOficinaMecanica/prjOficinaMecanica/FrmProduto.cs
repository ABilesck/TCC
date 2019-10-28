using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                if (!txtPesquisa.Text.Equals(""))
                {
                    if (cmbFiltro.SelectedIndex == 0)
                    {
                        tcc_ProdutoTableAdapter.FillById(banco.tcc_Produto, Convert.ToInt32(txtPesquisa.Text));
                    }
                    else if (cmbFiltro.SelectedIndex == 1)
                    {
                        tcc_ProdutoTableAdapter.FillByDescricao(banco.tcc_Produto, "%" + txtPesquisa.Text + "%");
                    }
                }
                else
                {
                    MessageBox.Show("Escreva o valor desejado no campo de pesquisa", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Focus();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmProduto_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDMecanico"].ToString());
                    tcc_ProdutoTableAdapter.Delete(idProduto);
                    FrmProduto_Load(null, null);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var produto = ((DataRowView)tcc_ProdutoBindingSource.Current).Row as Banco.tcc_ProdutoRow;
                FrmCadastroProduto cadastroProduto = new FrmCadastroProduto();
                cadastroProduto.NovoCadastro = false;
                cadastroProduto.Alterar(produto.descricao,
                    produto.precoVenda.ToString(), produto.precoCompra.ToString(), produto.quantidade);
                cadastroProduto.IdProduto = produto.IDProduto;
                cadastroProduto.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
