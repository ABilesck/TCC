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
    public partial class Servico : Form
    {
        private int idOrcamento;
        private bool Finalizado;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");

        public Servico()
        {
            InitializeComponent();
        }
        public void FrmServico_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);


            tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            tcc_ServicoTableAdapter.Fill(banco.tcc_Servico);

            if (dgvServico.Rows.Count > 0)
            {
                dgvServico_SelectionChanged(null, null);
            }

        }
        public void GetOrcamento(int IdO)
        {
            idOrcamento = IdO;
            tcc_OrcamentoTableAdapter.FillById(banco.tcc_Orcamento, idOrcamento);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroServico cadastroServico = new FrmCadastroServico();
            cadastroServico.NovoCadastro = true;
            cadastroServico.ShowDialog();
        }

        public void Reload()
        {
            FrmServico_Load(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (usar.Equals("1"))
            {
                string input = Interaction.InputBox("Informe a senha:", "Alterar", "*", 100, 200);
                if (input != "")
                {
                    if (input == Senha)
                    {
                        var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
                        FrmCadastroServico cadastroServico = new FrmCadastroServico()
                        {
                            Orcamento = servico.IDOrcamento,
                            mecanico = servico.IDMecanico,
                            NovoCadastro = false
                        };
                        cadastroServico.Alterar(servico.razaoSocial, servico.dataInicio);
                        cadastroServico.ShowDialog();
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
                var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
                FrmCadastroServico cadastroServico = new FrmCadastroServico()
                {
                    Orcamento = servico.IDOrcamento,
                    mecanico = servico.IDMecanico,
                    NovoCadastro = false
                };
                cadastroServico.Alterar(servico.razaoSocial, servico.dataInicio);
                cadastroServico.ShowDialog();
            }
            
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmServico_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServico.RowCount > 0)
                {
                    var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
                    if (MessageBox.Show("Deseja excluir o serviço selecionado?\nEsta ação não " +
                        "pode ser desfeita", "Atenção",
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
                                    tcc_ServicoTableAdapter.DeleteQuery(servico.IDMecanico, servico.IDOrcamento);
                                    FrmServico_Load(null, null);

                                    MessageBox.Show("Serviço excluido com sucesso!", "Atenção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            tcc_ServicoTableAdapter.DeleteQuery(servico.IDMecanico, servico.IDOrcamento);
                            FrmServico_Load(null, null);

                            MessageBox.Show("Serviço excluido com sucesso!", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados" +
                    "\n" + ex.Message, "Erro no Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServico_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvServico.Rows.Count > 0)
                {
                    if (dgvServico[4, dgvServico.CurrentRow.Index].Value.ToString() == "")
                    {
                        //nao finalizado
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Staus: Não finalizado";
                        Finalizado = false;
                    }
                    else
                    {
                        //finalizado
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = "Staus: Finalizado";
                        Finalizado = true;
                    }
                }
                else
                {
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.Text = "Nenhum serviço selecionado!";
                }

            }
            catch (NullReferenceException ex)
            {
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado!\n" +
                    ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Finalizado)
                {
                    var servico = ((DataRowView)tcc_ServicoBindingSource.Current).Row as Banco.tcc_ServicoRow;
                    tcc_ServicoTableAdapter.Finalizar(DateTime.Now, servico.IDMecanico, servico.IDOrcamento);
                    MessageBox.Show("Serviço Finalizado com sucesso!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Serviço já finalizado!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvServico_SelectionChanged(null, null);
                tcc_ServicoTableAdapter.Fill(banco.tcc_Servico);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ocorreu um erro na referencia de objeto" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
            FrmOrdemDeServico ordemDeServico = new FrmOrdemDeServico()
            {
                mecanico = servico.IDMecanico,
                Orcamento = servico.IDOrcamento
            };
            ordemDeServico.ShowDialog();
        }
        public void CriarServicoPeloOrcamento(int orc)
        {
            FrmCadastroServico cadastroServico = new FrmCadastroServico()
            { Orcamento = orc, NovoCadastro = true };
            cadastroServico.ShowDialog();
        }
    }
}
