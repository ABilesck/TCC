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
                    if (cmbFiltro.SelectedIndex == 0)
                    {
                        tcc_MecanicoTableAdapter.FillById(banco.tcc_Mecanico, Convert.ToInt32(txtPesquisa.Text));
                    }
                    else if (cmbFiltro.SelectedIndex == 1)
                    {
                        tcc_MecanicoTableAdapter.FillByRazao(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                    }
                    else if (cmbFiltro.SelectedIndex == 2)
                    {
                        tcc_MecanicoTableAdapter.FillByCnpj(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                    }

                    if (dgvMecanico.RowCount == 0)
                    {
                        MessageBox.Show("Não foram encontrados registros com esses parâmetros!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O campo de pesquisa está vazio!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var Mecanico = (tcc_MecanicoBindingSource.Current as DataRowView).Row
                as Banco.tcc_MecanicoRow;
                FrmCadastroMecanico cadastroMecanico = new FrmCadastroMecanico();
                cadastroMecanico.NovoCadastro = false;
                cadastroMecanico.Alterar(Mecanico.IDMecanico, Mecanico.razaoSocial, Mecanico.cnpj,
                    Mecanico.ie, Mecanico.telefone, Mecanico.email, Mecanico.contaBancaria, Mecanico.agenciaBancaria,
                    Mecanico.comissao.ToString(), Mecanico.logradouro, Mecanico.bairro, Mecanico.cidade,
                    Mecanico.complemento, Mecanico.uf, Mecanico.cep);
                cadastroMecanico.ShowDialog();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Erro ao abrir o formulário\n"+ ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmMecanico_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o mecânico selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    idMecanico = Convert.ToInt32(((DataRowView)tcc_MecanicoBindingSource.Current).Row["IDMecanico"].ToString());
                    tcc_MecanicoTableAdapter.Delete(idMecanico);
                    FrmMecanico_Load(null, null);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenar.SelectedIndex == 0)
            {
                tcc_MecanicoTableAdapter.Fill(banco.tcc_Mecanico);
            }
            else if (cmbOrdenar.SelectedIndex == 1)
            {
                tcc_MecanicoTableAdapter.FillByOrderRazao(banco.tcc_Mecanico);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroMecanico cadastroMecanico = new FrmCadastroMecanico() { NovoCadastro = true };
                cadastroMecanico.ShowDialog();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Formulário não encontrado\n" + ex.Message, "Erro ao abrir o formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao abrir o formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
