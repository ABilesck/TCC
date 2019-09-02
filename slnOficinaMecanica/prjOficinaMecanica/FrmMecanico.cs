using System;
using System.Data;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    //TODO: mascaras das text box

    public partial class FrmMecanico : Form
    {
        int idMecanico;
        Utility utility = new Utility();
        Operacao oper = new Operacao();

        public FrmMecanico()
        {
            InitializeComponent();
        }

        private void FrmMecanico_Load(object sender, EventArgs e)
        {
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            utility.HabilitaCampos(tpDados, true);
            utility.HabilitaBotoes(tpDados, true);
            txtRazao.Focus();
            oper = Operacao.incluir;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(oper == Operacao.incluir)
            {
                tcc_MecanicoTableAdapter.Insert(
                    txtRazao.Text,
                    txtCnpj.Text,
                    txtIe.Text,
                    txtTelefone.Text,
                    txtEmail.Text,
                    txtConta.Text,
                    txtAgencia.Text,
                    Convert.ToInt32(txtComissao.Text),
                    txtLogradouro.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtComplemento.Text,
                    cmbUf.Text,
                    txtCep.Text
                    );
            }
            else if(oper == Operacao.alterar)
            {
                tcc_MecanicoTableAdapter.Update(
                    txtRazao.Text,
                    txtCnpj.Text,
                    txtIe.Text,
                    txtTelefone.Text,
                    txtEmail.Text,
                    txtConta.Text,
                    txtAgencia.Text,
                    Convert.ToInt32(txtComissao.Text),
                    txtLogradouro.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtComplemento.Text,
                    cmbUf.Text,
                    txtCep.Text,
                    idMecanico
                    );
            }

            MessageBox.Show("Salvo com sucesso!",
                    "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnCancelar_Click(null, null);
            FrmMecanico_Load(null, null);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(tpDados, false);
            utility.HabilitaCampos(tpDados, false);
            utility.HabilitaCampos(grbConta, false);
            utility.LimpaCampos(tpDados);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                if(cmbFiltro.SelectedIndex == 0)
                {
                    tcc_MecanicoTableAdapter.FillById(banco.tcc_Mecanico,Convert.ToInt32(txtPesquisa.Text));
                }
                else if(cmbFiltro.SelectedIndex == 1)
                {
                    tcc_MecanicoTableAdapter.FillByRazao(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                }
                else if(cmbFiltro.SelectedIndex == 2)
                {
                    tcc_MecanicoTableAdapter.FillByCnpj(banco.tcc_Mecanico, "%" + txtPesquisa.Text + "%");
                }

                if(dgvMecanico.RowCount == 0)
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

        private void tbnAlterar_Click(object sender, EventArgs e)
        {
            idMecanico = Convert.ToInt32(((DataRowView)tcc_MecanicoBindingSource.Current).Row["IDMecanico"].ToString());
            txtRazao.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["razaoSocial"].ToString();
            txtCnpj.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["cnpj"].ToString();
            txtIe.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["ie"].ToString();
            txtTelefone.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["telefone"].ToString();
            txtEmail.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["email"].ToString();
            txtConta.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["contaBancaria"].ToString();
            txtAgencia.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["agenciaBancaria"].ToString();
            txtConta.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["comissao"].ToString();
            txtLogradouro.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["logradouro"].ToString();
            txtBairro.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["bairro"].ToString();
            txtCidade.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["cidade"].ToString();
            txtComplemento.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["complemento"].ToString();
            cmbUf.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["uf"].ToString();
            txtCep.Text = ((DataRowView)tcc_MecanicoBindingSource.Current).Row["cep"].ToString();

            utility.HabilitaCampos(tpDados, true);
            utility.HabilitaBotoes(tpDados, true);

            oper = Operacao.alterar;

            tabControl.SelectedIndex = 0;
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null);
            FrmMecanico_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o mecânico selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                idMecanico = Convert.ToInt32(((DataRowView)tcc_MecanicoBindingSource.Current).Row["IDMecanico"].ToString());
                //tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                tcc_MecanicoTableAdapter.Delete(idMecanico);
                btnCancelar_Click(null, null);
                FrmMecanico_Load(null, null);
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOrdenar.SelectedIndex == 0)
            {
                tcc_MecanicoTableAdapter.Fill(banco.tcc_Mecanico);
            }
            else if(cmbOrdenar.SelectedIndex == 1)
            {
                tcc_MecanicoTableAdapter.FillByOrderRazao(banco.tcc_Mecanico);
            }
        }
    }
}
