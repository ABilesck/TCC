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

    public partial class Orcamento : Form
    {
        private int IdOrcamento;
        private int IdProduto;
        private int IdAuto;
        private double MaoDeObra;
        private double PrecoTemporario;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");
        public Orcamento()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            FrmOrcamento_Load(null, null);
            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
            iDProdutoComboBox_SelectedIndexChanged(null, null);
        }

        private void FrmOrcamento_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
            tcc_OrcamentoTableAdapter.Fill(banco.tcc_Orcamento);
            tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, IdOrcamento);

            iDProdutoComboBox_SelectedIndexChanged(null, null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroOrcamento cadastroOrcamento = new FrmCadastroOrcamento()
                {
                    novoCadastro = true
                };
                cadastroOrcamento.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro no cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro no cadastro",
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
                            var Orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row
                                as Banco.tcc_OrcamentoRow;
                            FrmCadastroOrcamento cadastroOrcamento = new FrmCadastroOrcamento();
                            cadastroOrcamento.novoCadastro = false;
                            cadastroOrcamento.IdOrcamento = Orcamento.IDOrcamento;
                            cadastroOrcamento.PreencherCampos(Orcamento.nome, Orcamento.modelo,
                                MaoDeObra, Orcamento.descricao);
                            cadastroOrcamento.ShowDialog();
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
                    var Orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row
                                as Banco.tcc_OrcamentoRow;
                    FrmCadastroOrcamento cadastroOrcamento = new FrmCadastroOrcamento();
                    cadastroOrcamento.novoCadastro = false;
                    cadastroOrcamento.IdOrcamento = Orcamento.IDOrcamento;
                    cadastroOrcamento.PreencherCampos(Orcamento.nome, Orcamento.modelo,
                        MaoDeObra, Orcamento.descricao);
                    cadastroOrcamento.ShowDialog();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcc_OrcamentoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var Orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row
                as Banco.tcc_OrcamentoRow;
                IdOrcamento = Orcamento.IDOrcamento;
                IdAuto = Orcamento.IDAutomovel;
                MaoDeObra = Orcamento.MaoDeObra;
                if (IdOrcamento != 0)
                {
                    tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, IdOrcamento);
                }

                if (dgvOrcamentos.RowCount > 0)
                {
                    if (dgvProdutos.RowCount > 0)
                    {
                        double Total = Convert.ToDouble(tcc_produtoOrcamentoTableAdapter.Total(IdOrcamento).ToString());
                        Total += MaoDeObra;
                        txtTotal.Text = Total.ToString("R$ #,###,##0.00");
                    }
                    else
                    {
                        txtTotal.Text = MaoDeObra.ToString("R$ #,###,##0.00");
                    }

                }
                else
                {
                    txtTotal.Text = "R$ 0,00";
                }
                iDProdutoComboBox_SelectedIndexChanged(null, null);
            }
            catch (NullReferenceException ex)
            {
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao preecher as tabelas\n" + ex.Message, "Erro nas tabelas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro nas tabelas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrcamentos.RowCount > 0)
                {

                    if (MessageBox.Show("Deseja excluir o orçamento selecionado?", "Atenção",
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
                                    tcc_produtoOrcamentoTableAdapter.DeleteTodos(IdOrcamento);
                                    tcc_OrcamentoTableAdapter.DeleteQuery(IdOrcamento);
                                    FrmOrcamento_Load(null, null);
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
                            tcc_produtoOrcamentoTableAdapter.DeleteTodos(IdOrcamento);
                            tcc_OrcamentoTableAdapter.DeleteQuery(IdOrcamento);
                            FrmOrcamento_Load(null, null);
                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao selecionar item para excluir\n" + ex.Message, "Erro ao excluir",
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPesquisa.Text.Equals(""))
                {
                    if (cmbFiltro.Text.Equals("Cliente"))
                    {
                        tcc_OrcamentoTableAdapter.FillByCliente(banco.tcc_Orcamento,
                            "%" + txtPesquisa.Text + "%");
                    }
                    else if (cmbFiltro.Text.Equals("Veiculo"))
                    {
                        tcc_OrcamentoTableAdapter.FillByVeiculo(banco.tcc_Orcamento,
                            "%" + txtPesquisa.Text + "%");
                    }
                    else
                    {
                        tcc_OrcamentoTableAdapter.FillByDescricao(banco.tcc_Orcamento,
                            "%" + txtPesquisa.Text + "%");
                    }
                    btnCancelar.Enabled = true;
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Campo de pesquisa vazio!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void iDProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = tcc_ProdutoTableAdapter.GetDataByDescricao(iDProdutoComboBox.Text);
            PrecoTemporario = 0;
            foreach (DataRow item in produto.Rows)
            {
                PrecoTemporario = Convert.ToDouble(item["precoUnit"].ToString());
            }
            quantidadeNumericUpDown.Value = 1;
            precoUnitarioTextBox.Text = PrecoTemporario.ToString("R$ #,###,##0.00");
            subtotalTextBox.Text = PrecoTemporario.ToString("R$ #,###,##0.00");
        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double Subtotal = (int)quantidadeNumericUpDown.Value * PrecoTemporario;
            subtotalTextBox.Text = Subtotal.ToString("R$ #,###,##0.00");
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                tcc_produtoOrcamentoTableAdapter.InsertQuery(
                IdOrcamento,
                (int)iDProdutoComboBox.SelectedValue,
                (int)quantidadeNumericUpDown.Value,
                PrecoTemporario);
                MessageBox.Show("Produto inserido com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcc_OrcamentoDataGridView_SelectionChanged(null, null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao inserir produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao inserir produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProdutoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.RowCount > 0)
                {
                    if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        tcc_produtoOrcamentoTableAdapter.DeleteQuery(IdOrcamento, IdProduto);
                        tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, IdOrcamento);
                        tcc_OrcamentoDataGridView_SelectionChanged(null, null);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nenhum objeto selecionado\n" + ex.Message, "Erro ao excluir",
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


        private void btnCriarServico_Click(object sender, EventArgs e)
        {
            try
            {
                var orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row as Banco.tcc_OrcamentoRow;
                Servico frmServico = new Servico();
                frmServico.CriarServicoPeloOrcamento(orcamento.IDOrcamento);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erro ao criar o serviço\n" + ex.Message, "Erro ao abrir formulário",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao abrir formulário",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrcamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmOrcamento_Load(null, null);
            btnCancelar.Enabled = false;
        }

        private void btnFolha_Click(object sender, EventArgs e)
        {
            var orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row as Banco.tcc_OrcamentoRow;
            FrmFolhaOrcamento folhaOrcamento = new FrmFolhaOrcamento() { id = orcamento.IDOrcamento };
            folhaOrcamento.ShowDialog();
        }
    }
}
