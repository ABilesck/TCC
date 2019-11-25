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
    public partial class FrmCadastroMecanico : Form
    {
        public bool NovoCadastro;
        public int id;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        public FrmCadastroMecanico()
        {
            InitializeComponent();
            txtComissao.Text = "0";
        }
        private void FrmCadastroMecanico_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);


            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NovoCadastro)
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
                        txtCep.Text,
                        txtFantasia.Text
                        );
                }
                else
                {
                    tcc_MecanicoTableAdapter.UpdateQuery(
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
                        txtFantasia.Text,
                        id
                        );
                }

                MessageBox.Show("Salvo com sucesso!",
                        "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCadastroMecanico_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMecanico>().Single();
            form.Reload();
        }

        public void Alterar(int idMecanico, string razao,string fantasia, string cnpj, string ie, string tel,
            string email, string conta, string agencia, string comissao, string logradouro,
            string bairro, string cidade, string complemento, string uf, string cep)
        {
            txtRazao.Text = razao;
            txtFantasia.Text = fantasia;
            txtCnpj.Text = cnpj;
            txtIe.Text = ie;
            txtTelefone.Text = tel;
            txtEmail.Text = email;
            txtConta.Text = conta;
            txtAgencia.Text = agencia;
            txtComissao.Text = comissao;
            txtLogradouro.Text = logradouro;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtComplemento.Text = complemento;
            cmbUf.Text = uf;
            txtCep.Text = cep;
            id = idMecanico;
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
