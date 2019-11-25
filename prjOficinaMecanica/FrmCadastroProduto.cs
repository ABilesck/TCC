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
    public partial class FrmCadastroProduto : Form
    {
        public bool NovoCadastro;
        public int IdProduto;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NovoCadastro)
                {
                    tcc_ProdutoTableAdapter.Insert(
                        txtDescricao.Text,
                        Convert.ToInt32(nudQuantidade.Value),
                        Convert.ToDouble(txtPreco.Text)
                        );
                }
                else
                {
                    tcc_ProdutoTableAdapter.UpdateQuery(
                        txtDescricao.Text,
                        Convert.ToInt32(nudQuantidade.Value),
                        Convert.ToDouble(txtPreco.Text),
                        IdProduto
                        );
                }

                MessageBox.Show("Salvo com sucesso!", "Atenção",
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
        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            if (NovoCadastro)
                btnEstoque.Enabled = false;
            else
                btnEstoque.Enabled = true;


            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
        }

        public void Alterar(string desc, string preco, int qtde)
        {
            txtDescricao.Text = desc;
            txtPreco.Text = preco;
            nudQuantidade.Value = qtde;
        }

        private void FrmCadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmProduto>().Single();
            form.Reload();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            string NovaQtde = Interaction.InputBox("Digite a quantidade de produtos para adicionar:", "Atualizar estoque", "0", 300, 200);

            int velhaQtde = Convert.ToInt32(nudQuantidade.Value);

            int qtde = Convert.ToInt32(NovaQtde) + velhaQtde;

            tcc_ProdutoTableAdapter.UpdateQuery(
                txtDescricao.Text,
                qtde,
                Convert.ToDouble(txtPreco.Text),
                IdProduto
                );

            MessageBox.Show("Estoque atalizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
