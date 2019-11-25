using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace prjOficinaMecanica
{

    public partial class FrmMecanico : Form
    {
        int idMecanico;
        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");

        public FrmMecanico()
        {
            InitializeComponent();
        }

        public void FrmMecanico_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
        }

        public void Reload()
        {
            FrmMecanico_Load(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPesquisa.Text.Equals(""))
                {
                    if (cmbFiltro.Text.Equals("Razão Social"))
                    {
                        tcc_MecanicoTableAdapter.FillByRazao(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                    }
                    else if (cmbFiltro.Text.Equals("Apelido"))
                    {
                        tcc_MecanicoTableAdapter.FillByApelido(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                    }
                    else
                    {
                        tcc_MecanicoTableAdapter.FillByCnpj(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                    }

                    if (dgvMecanico.RowCount == 0)
                    {
                        MessageBox.Show("Não foram encontrados registros com esses parâmetros!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    btnPesquisaCancelar.Enabled = true;
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("O campo de pesquisa está vazio!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbnAlterar_Click(object sender, EventArgs e)
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
                            var Mecanico = (tcc_MecanicoBindingSource.Current as DataRowView).Row
                                as Banco.tcc_MecanicoRow;
                            FrmCadastroMecanico cadastroMecanico = new FrmCadastroMecanico();
                            cadastroMecanico.Alterar(Mecanico.IDMecanico, Mecanico.razaoSocial, Mecanico.fantasia, Mecanico.cnpj,
                                Mecanico.ie, Mecanico.telefone, Mecanico.email, Mecanico.contaBancaria, Mecanico.agenciaBancaria,
                                Mecanico.comissao.ToString(), Mecanico.logradouro, Mecanico.bairro, Mecanico.cidade,
                                Mecanico.complemento, Mecanico.uf, Mecanico.cep);
                            cadastroMecanico.ShowDialog();
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
                    var Mecanico = (tcc_MecanicoBindingSource.Current as DataRowView).Row
                                as Banco.tcc_MecanicoRow;
                    FrmCadastroMecanico cadastroMecanico = new FrmCadastroMecanico();
                    cadastroMecanico.Alterar(Mecanico.IDMecanico, Mecanico.razaoSocial, Mecanico.fantasia, Mecanico.cnpj,
                        Mecanico.ie, Mecanico.telefone, Mecanico.email, Mecanico.contaBancaria, Mecanico.agenciaBancaria,
                        Mecanico.comissao.ToString(), Mecanico.logradouro, Mecanico.bairro, Mecanico.cidade,
                        Mecanico.complemento, Mecanico.uf, Mecanico.cep);
                    cadastroMecanico.ShowDialog();
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

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmMecanico_Load(null, null);
            btnPesquisaCancelar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o mecânico selecionado?", "Atenção",
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
                                idMecanico = Convert.ToInt32(((DataRowView)tcc_MecanicoBindingSource.Current).Row["IDMecanico"].ToString());
                                tcc_MecanicoTableAdapter.Delete(idMecanico);
                                FrmMecanico_Load(null, null);
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
                        idMecanico = Convert.ToInt32(((DataRowView)tcc_MecanicoBindingSource.Current).Row["IDMecanico"].ToString());
                        tcc_MecanicoTableAdapter.Delete(idMecanico);
                        FrmMecanico_Load(null, null);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroMecanico cadastroMecanico = new FrmCadastroMecanico() { NovoCadastro = true };
                cadastroMecanico.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Formulário não encontrado\n" + ex.Message, "Erro ao abrir o formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao abrir o formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMecanico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMecanico.Columns[e.ColumnIndex].DataPropertyName == "cnpj")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        //76.971.068/0001-80
                        //00.000.000/0000-00
                        //76971068000180
                        stringValue = stringValue.Substring(0, 2) + "." +
                            stringValue.Substring(2, 3) + "." + stringValue.Substring(5, 3) + "/"
                            + stringValue.Substring(8, 4) + "-" + stringValue.Substring(12, 2);
                        e.Value = stringValue;
                    }
                }
            }
            else if (dgvMecanico.Columns[e.ColumnIndex].DataPropertyName == "telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (dgvMecanico.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }
    }
}
