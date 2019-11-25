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
    public partial class FrmCadastroCliente : Form
    {
        public bool NovoCadastro;
        public int Id;
        string Tema = ConfigurationManager.AppSettings.Get("tema");

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

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

        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {

            //76971068000180
            if (rbtPessoaJuridica.Checked)
                txtDocSocial.Mask = "00.000.000/0000-00";
            else
                txtDocSocial.Mask = "000.000.000-00";
        }

        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPessoaJuridica.Checked)
                txtDocSocial.Mask = "00.000.000/0000-00";
            else
                txtDocSocial.Mask = "000.000.000-00";
        }
    }
}
