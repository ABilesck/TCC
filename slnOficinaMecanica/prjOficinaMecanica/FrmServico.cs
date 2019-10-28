﻿using System;
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
    public partial class FrmServico : Form
    {
        private int idOrcamento;
        private bool Finalizado;

        public FrmServico()
        {
            InitializeComponent();
        }
        public void FrmServico_Load(object sender, EventArgs e)
        {
            tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            tcc_ServicoTableAdapter.Fill(this.banco.tcc_Servico);

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
                        tcc_ServicoTableAdapter.DeleteQuery(servico.IDMecanico, servico.IDOrcamento);
                        FrmServico_Load(null, null);

                        MessageBox.Show("Serviço excluido com sucesso!", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados" +
                    "\n" + ex.Message, "Erro no Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
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
                if(dgvServico.Rows.Count > 0)
                {
                    if (dgvServico[5, dgvServico.CurrentRow.Index].Value.ToString() == "")
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
            catch(SqlException ex)
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
            catch(NullReferenceException ex)
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
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado" +
                    "\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
