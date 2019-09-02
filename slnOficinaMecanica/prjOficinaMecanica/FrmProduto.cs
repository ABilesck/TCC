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
    //TODO: design

    public partial class FrmProduto : Form
    {
        Utility utility = new Utility();
        Operacao operacao;
        int idProduto;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            this.tcc_ProdutoTableAdapter.Fill(this.banco.tcc_Produto);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(tpDados, true);
            utility.HabilitaCampos(tpDados, true);
            txtDescricao.Focus();
            operacao = Operacao.incluir;
        }

        private void btnGravar_click(object sender, EventArgs e)
        {
            if(operacao == Operacao.incluir)
            {
                tcc_ProdutoTableAdapter.Insert(
                    txtDescricao.Text,
                    Convert.ToInt32(nudQuantidade.Value),
                    Convert.ToDouble(txtPrecoVenda.Text),
                    Convert.ToDouble(txtPrecoCompra.Text)
                    );
            }
            else if(operacao == Operacao.alterar)
            {
                tcc_ProdutoTableAdapter.Update(
                    txtDescricao.Text,
                    Convert.ToInt32(nudQuantidade.Value),
                    Convert.ToDouble(txtPrecoVenda.Text),
                    Convert.ToDouble(txtPrecoCompra.Text),
                    idProduto
                    );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(tpDados, false);
            utility.HabilitaCampos(tpDados, false);
            utility.LimpaCampos(tpDados);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                if(cmbFiltro.SelectedIndex == 0)
                {
                    tcc_ProdutoTableAdapter.FillById(banco.tcc_Produto, Convert.ToInt32(txtPesquisa.Text));
                }
                else if(cmbFiltro.SelectedIndex == 1)
                {
                    tcc_ProdutoTableAdapter.FillByDescricao(banco.tcc_Produto, "%" + txtPesquisa.Text + "%");
                }
            }
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null);
            FrmProduto_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDMecanico"].ToString());
                //tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                tcc_ProdutoTableAdapter.Delete(idProduto);
                btnCancelar_Click(null, null);
                FrmProduto_Load(null, null);
            }
        }

        private void tbnAlterar_Click(object sender, EventArgs e)
        {
            idProduto = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["IDProduto"].ToString());
            txtDescricao.Text = ((DataRowView)tcc_ProdutoBindingSource.Current).Row["descricao"].ToString();
            txtPrecoCompra.Text = ((DataRowView)tcc_ProdutoBindingSource.Current).Row["precoCompra"].ToString();
            txtPrecoVenda.Text = ((DataRowView)tcc_ProdutoBindingSource.Current).Row["precoVenda"].ToString();
            nudQuantidade.Value = Convert.ToInt32(((DataRowView)tcc_ProdutoBindingSource.Current).Row["quantidade"].ToString());

            utility.HabilitaCampos(tpDados, true);
            utility.HabilitaBotoes(tpDados, true);

            operacao = Operacao.alterar;

            tabControl1.SelectedIndex = 0;
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenar.SelectedIndex == 0)
            {
                tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
            }
            else if (cmbOrdenar.SelectedIndex == 1)
            {
                tcc_ProdutoTableAdapter.FillByOrderDescricao(banco.tcc_Produto);
            }
            else if(cmbOrdenar.SelectedIndex == 2)
            {
                tcc_ProdutoTableAdapter.FillByOrderQuantidadeAsc(banco.tcc_Produto);
            }
            else if(cmbOrdenar.SelectedIndex == 3)
            {
                tcc_ProdutoTableAdapter.FillByOrderQuantidadeDesc(banco.tcc_Produto);
            }
        }
        public void Alterar(int id, string desc, string precoCompra, string precoVenda, int qtde)
        {
            idProduto = id;
            txtDescricao.Text = desc;
            txtPrecoCompra.Text = precoCompra;
            txtPrecoVenda.Text = precoVenda;
            nudQuantidade.Value = qtde;

            utility.HabilitaCampos(tpDados, true);
            utility.HabilitaBotoes(tpDados, true);

            operacao = Operacao.alterar;

            tabControl1.SelectedIndex = 0;
        }
        private void tcc_ProdutoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbnAlterar_Click(null, null);
        }
    }
}
