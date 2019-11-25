using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOficinaMecanica
{

    public partial class FrmProduto : Form
    {
        int idProduto;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);


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
                    if (cmbFiltro.Text.Equals("Descrição"))
                    {
                        tcc_ProdutoTableAdapter.FillByDescricao(banco.tcc_Produto, "%" + txtPesquisa.Text + "%");
                    }
                }
                else
                {
                    MessageBox.Show("O campo de pesquisa está vazio!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPesquisa.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
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
                    if (usar.Equals("1"))
                    {
                        string input = Interaction.InputBox("Informe a senha:", "Excluir", "*", 100, 200);
                        if (input != "")
                        {
                            if (input == Senha)
                            {
                                idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDProduto"].ToString());
                                tcc_ProdutoTableAdapter.Delete(idProduto);
                                FrmProduto_Load(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta", "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDProduto"].ToString());
                        tcc_ProdutoTableAdapter.Delete(idProduto);
                        FrmProduto_Load(null, null);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usar.Equals("1"))
                {
                    string input = Interaction.InputBox("Informe a senha:", "Alterar", "*", 100, 200);
                    if (input != "")
                    {
                        if (input == Senha)
                        {
                            var produto = ((DataRowView)tcc_ProdutoBindingSource.Current).Row as Banco.tcc_ProdutoRow;
                            FrmCadastroProduto cadastroProduto = new FrmCadastroProduto();
                            cadastroProduto.NovoCadastro = false;
                            cadastroProduto.Alterar(produto.descricao,
                                produto.precoUnit.ToString(), produto.quantidade);
                            cadastroProduto.IdProduto = produto.IDProduto;
                            cadastroProduto.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta", "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    var produto = ((DataRowView)tcc_ProdutoBindingSource.Current).Row as Banco.tcc_ProdutoRow;
                    FrmCadastroProduto cadastroProduto = new FrmCadastroProduto();
                    cadastroProduto.NovoCadastro = false;
                    cadastroProduto.Alterar(produto.descricao,
                        produto.precoUnit.ToString(), produto.quantidade);
                    cadastroProduto.IdProduto = produto.IDProduto;
                    cadastroProduto.ShowDialog();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
