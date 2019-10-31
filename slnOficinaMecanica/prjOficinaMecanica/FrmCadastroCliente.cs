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
    public partial class FrmCadastroCliente : Form
    {
        public bool NovoCadastro;
        public int Id;
        private Utility Utility = new Utility();

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            tcc_ClienteTableAdapter.Fill(banco.tcc_Cliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NovoCadastro)
                {
                    tcc_ClienteTableAdapter.Insert(
                        txtNome.Text,
                        txtDocSocial.Text,
                        txtTelefone.Text,
                        txtEmail.Text,
                        txtLogradouro.Text,
                        txtBairro.Text,
                        txtCidade.Text,
                        txtComplemento.Text,
                        cmbUf.Text,
                        txtCep.Text,
                        txtRegistro.Text);
                }
                else
                {
                    tcc_ClienteTableAdapter.UpdateQuery(
                        txtNome.Text,
                        txtDocSocial.Text,
                        txtTelefone.Text,
                        txtEmail.Text,
                        txtLogradouro.Text,
                        txtBairro.Text,
                        txtCidade.Text,
                        txtComplemento.Text,
                        cmbUf.Text,
                        txtCep.Text,
                        txtRegistro.Text,
                        Id);
                }
                MessageBox.Show("Cliente salvo com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmCliente>().Single();
            form.Reload();
        }

        public void Alterar(string nome, string docSocial, string tel, string email,
            string logradouro, string bairro, string cidade, string complemento, string uf,
            string cep, string registro)
        {
            txtNome.Text = nome;
            txtDocSocial.Text = docSocial;
            txtTelefone.Text = tel;
            txtEmail.Text = email;
            txtLogradouro.Text = logradouro;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtComplemento.Text = complemento;
            cmbUf.Text = uf;
            txtCep.Text = cep;
            txtRegistro.Text = registro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
