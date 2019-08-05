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
    public partial class FrmCliente : Form
    {
        int IdCliente = 0;
        Operacao oper;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Nome";
            lblDocSocial.Text = "CPF";
            lblRegistro.Text = "RG";
        }

        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Razão Social";
            lblDocSocial.Text = "CNPJ";
            lblRegistro.Text = "Inscrição Estadual";
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Automovel' table. You can move, or remove it, as needed.
            this.tcc_AutomovelTableAdapter.FillByIdCliente(this.banco.tcc_Automovel, IdCliente);
            // TODO: This line of code loads data into the 'banco.tcc_Cliente' table. You can move, or remove it, as needed.
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);

        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            tcPrincipal.TabIndex = 0;
            FrmCliente_Load(null, null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaBotoes(tpCadastrar, true);
            HabilitaCampos(tpDados, true);
            HabilitaCampos(tpEndereco, true);
            oper = Operacao.incluir;
        }

        private void HabilitaCampos(Control control, bool hab)
        {
            foreach (Control c in control.Controls)
            {
                if(c is TextBox)
                {
                    c.Enabled = hab;
                }
                if(c is ComboBox)
                {
                    c.Enabled = hab;
                }
                if(c is MaskedTextBox)
                {
                    c.Enabled = hab;
                }
            }
        }
        private void LimpaCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }
        private void HabilitaBotoes(Control control, bool hab)
        {
            foreach (Control c in control.Controls)
            {
                if(c is Button)
                {
                    if (c.Name.Equals("btnNovo"))
                    {
                        c.Enabled = !hab;
                    }
                    else
                    {
                        c.Enabled = hab;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaBotoes(tpCadastrar, false);
            HabilitaCampos(tpDados, false);
            HabilitaCampos(tpEndereco, false);
            LimpaCampos(tpDados);
            LimpaCampos(tpEndereco);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(oper == Operacao.incluir)
            {
                tcc_ClienteTableAdapter.Insert(
                txtNome.Text,
                txtDocSocial.Text,
                txtTelefone.Text,
                txtEmail.Text,
                txtLogradouro.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtCidade.Text,
                cmbUf.Text,
                txtCep.Text,
                txtRegistro.Text
                );
                
            }
            if(oper == Operacao.alterar)
            {
                tcc_ClienteTableAdapter.UpdateQuery(
                txtNome.Text,
                txtDocSocial.Text,
                txtTelefone.Text,
                txtEmail.Text,
                txtLogradouro.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtCidade.Text,
                cmbUf.Text,
                txtCep.Text,
                txtRegistro.Text,
                IdCliente
                );
            }

            MessageBox.Show("Salvo com sucesso!",
                    "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnCancelar_Click(null, null);
            FrmCliente_Load(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                if(cmbFiltro.SelectedIndex == 0)
                {
                    tcc_ClienteTableAdapter.FillById(banco.tcc_Cliente,
                        Convert.ToInt32(txtPesquisa.Text));

                }else if(cmbFiltro.SelectedIndex == 1)
                {
                    tcc_ClienteTableAdapter.FillByDocumentoSocial(banco.tcc_Cliente,
                        "%" + txtPesquisa.Text + "%");

                }else if(cmbFiltro.SelectedIndex == 2)
                {
                    tcc_ClienteTableAdapter.FillByNome(banco.tcc_Cliente,
                        "%" + txtPesquisa.Text + "%");

                }
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null);
            FrmCliente_Load(null, null);
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOrdenar.SelectedIndex == 0)
            {

                tcc_ClienteTableAdapter.FillByOrderID(banco.tcc_Cliente);

            }else if(cmbOrdenar.SelectedIndex == 1)
            {
                tcc_ClienteTableAdapter.FillByOrderNome(banco.tcc_Cliente);
            }
        }

        private void tbnAlterar_Click(object sender, EventArgs e)
        {
            IdCliente = Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString());
            txtNome.Text = dgvCliente[1, dgvCliente.CurrentRow.Index].Value.ToString();
            txtDocSocial.Text = dgvCliente[2, dgvCliente.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvCliente[3, dgvCliente.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvCliente[4, dgvCliente.CurrentRow.Index].Value.ToString();
            txtLogradouro.Text = dgvCliente[5, dgvCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvCliente[6, dgvCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvCliente[7, dgvCliente.CurrentRow.Index].Value.ToString();
            txtComplemento.Text = dgvCliente[8, dgvCliente.CurrentRow.Index].Value.ToString();
            cmbUf.Text = dgvCliente[9, dgvCliente.CurrentRow.Index].Value.ToString();
            txtCep.Text = dgvCliente[10, dgvCliente.CurrentRow.Index].Value.ToString();
            txtRegistro.Text = dgvCliente[11, dgvCliente.CurrentRow.Index].Value.ToString();

            HabilitaBotoes(tpCadastrar, true);
            HabilitaCampos(tpDados, true);
            HabilitaCampos(tpEndereco, true);

            oper = Operacao.alterar;

            tcPrincipal.SelectedIndex = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o cliente selecionado?","Atenção",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                btnCancelar_Click(null, null);
                FrmCliente_Load(null, null);
            }
        }
    }
    enum Operacao
    {
        incluir,
        alterar
    }
}
