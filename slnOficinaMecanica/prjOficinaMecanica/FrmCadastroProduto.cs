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
    public partial class FrmCadastroProduto : Form
    {
        public bool NovoCadastro;
        public int IdProduto;
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (NovoCadastro)
            {
                tcc_ProdutoTableAdapter.Insert(
                    txtDescricao.Text,
                    Convert.ToInt32(nudQuantidade.Value),
                    Convert.ToDouble(txtPrecoVenda.Text),
                    Convert.ToDouble(txtPrecoCompra.Text)
                    );
            }
            else
            {
                tcc_ProdutoTableAdapter.Update(
                    txtDescricao.Text,
                    Convert.ToInt32(nudQuantidade.Value),
                    Convert.ToDouble(txtPrecoVenda.Text),
                    Convert.ToDouble(txtPrecoCompra.Text),
                    IdProduto
                    );
            }

            MessageBox.Show("Salvo com sucesso!", "Atenção", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
        }

        public void Alterar(string desc, string pVenda, string pCompra, int qtde)
        {
            txtDescricao.Text = desc;
            txtPrecoVenda.Text = pVenda;
            txtPrecoCompra.Text = pCompra;
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
    }
}
