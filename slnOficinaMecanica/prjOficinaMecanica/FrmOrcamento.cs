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
    //TODO: fazer tudo, esse nao tem nada

    public partial class FrmOrcamento : Form
    {
        Utility utility = new Utility();
        Operacao operacao;
        Operacao produto;
        int idCliente;
        int IdOrcamento;

        double precotemporario;

        public FrmOrcamento()
        {
            InitializeComponent();
        }
        
        private void FrmOrcamento_Load(object sender, EventArgs e)
        {
            tcc_OrcamentoTableAdapter.Fill(banco.tcc_Orcamento);
            if(dgvOrcamento.Rows.Count > 0)
            {
                IdOrcamento = Convert.ToInt32(tcc_OrcamentoTableAdapter.GetFirstId().ToString());
                tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, IdOrcamento);
            }
            tcc_ProdutoTableAdapter.Fill(banco.tcc_Produto);
            tcc_AutomovelTableAdapter.Fill(banco.tcc_Automovel);
            tcc_ClienteTableAdapter.Fill(banco.tcc_Cliente);

        }

        private void tcc_produtoOrcamentoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.Alterar(
                Convert.ToInt32(((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["IDProduto"].ToString()),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["descricao"].ToString(),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["IDProduto"].ToString(),
                ((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["precoUnitario"].ToString(),
                Convert.ToInt32(((DataRowView)tcc_produtoOrcamentoBindingSource.Current).Row["quantidade"].ToString())
                );
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbCliente.SelectedValue != null)
                    tcc_AutomovelTableAdapter.FillByIdCliente(banco.tcc_Automovel, (int)cmbCliente.SelectedValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(tbpCadastro, true);
            utility.HabilitaCampos(tbpCadastro, true);
            grbProduto.Enabled = true;
            operacao = Operacao.incluir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(tbpCadastro, false);
            utility.HabilitaCampos(tbpCadastro, false);
            grbProduto.Enabled = false;
            tcc_OrcamentoTableAdapter.Fill(banco.tcc_Orcamento);
            tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, IdOrcamento);
            //FrmOrcamento_Load(null, null);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            utility.HabilitaBotoes(grbProduto, true);
            utility.HabilitaCampos(grbProduto, true);
            nudQuantidade.Value = 1;
            cmbProduto_SelectedIndexChanged(null, null);
            produto = Operacao.incluir;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (operacao == Operacao.incluir)
            {
                tcc_OrcamentoTableAdapter.InsertQuery(
                    DateTime.Now, 
                    Convert.ToInt32(cmbAuto.SelectedValue),
                    Convert.ToDouble(txtMaoDeObra.Text));
                MessageBox.Show("Orçamento criado com sucesso!", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdOrcamento = Convert.ToInt32(tcc_OrcamentoTableAdapter.GetLastId());
                btnCancelar_Click(null, null);
                grbProduto.Enabled = true;
                label6.Text = IdOrcamento.ToString();
            }
            else if (operacao == Operacao.alterar)
            {

            }

        }

        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            if (operacao == Operacao.incluir)
            {
                tcc_produtoOrcamentoTableAdapter.Insert(IdOrcamento, (int)cmbProduto.SelectedValue,
                    (int)nudQuantidade.Value, precotemporario);
                MessageBox.Show("Produto adicionado com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar_Click(null, null);
            }
            else if (operacao == Operacao.alterar)
            {

            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = tcc_ProdutoTableAdapter.GetDataByDescricao(cmbProduto.Text);

            foreach (DataRow row in produto.Rows)
            {
                precotemporario = Convert.ToDouble(row["precoVenda"].ToString());
            }
            nudQuantidade.Value = 1;
            txtPrecoUnit.Text = precotemporario.ToString("R$##,##0.00");
            txtSubtotal.Text = precotemporario.ToString("R$##,##0.00");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (int)nudQuantidade.Value * precotemporario;
            txtSubtotal.Text = subTotal.ToString("R$##,##0.00");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o orçamento selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                IdOrcamento = Convert.ToInt32(((DataRowView)tcc_OrcamentoBindingSource.Current).Row["IDOrcamento"].ToString());
                //tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                tcc_produtoOrcamentoTableAdapter.DeleteTodos(IdOrcamento);
                tcc_OrcamentoTableAdapter.DeleteQuery(IdOrcamento);
                btnCancelar_Click(null, null);
                FrmOrcamento_Load(null, null);
            }
        }

        private void dgvOrcamento_SelectionChanged(object sender, EventArgs e)
        {
            IdOrcamento = Convert.ToInt32(dgvOrcamento[0, dgvOrcamento.CurrentRow.Index].Value.ToString());

            label6.Text = IdOrcamento.ToString();

            tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento,
                Convert.ToInt32(dgvOrcamento[0, dgvOrcamento.CurrentRow.Index].Value.ToString()));
            if (tcc_produtoOrcamentoDataGridView.Rows.Count != 0)
            {
                double Total = Convert.ToDouble(tcc_produtoOrcamentoTableAdapter.
                TotalOrcamento(IdOrcamento).ToString());
                txtTotal1.Text = Total.ToString("R$##,##0.00");
                txtTotal2.Text = Total.ToString("R$##,##0.00");
            }
            else
            {
                txtTotal1.Text = "R$0,00";
                txtTotal2.Text = "R$0,00";
            }
        }

        private void dgvOrcamento_SelectionChanged_1(object sender, EventArgs e)
        {
            IdOrcamento = Convert.ToInt32(dgvOrcamento[0, dgvOrcamento.CurrentRow.Index].Value.ToString());

            label6.Text = IdOrcamento.ToString();

            tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento,
                Convert.ToInt32(dgvOrcamento[0, dgvOrcamento.CurrentRow.Index].Value.ToString()));
            if (tcc_produtoOrcamentoDataGridView.Rows.Count != 0)
            {
                double Total = Convert.ToDouble(tcc_produtoOrcamentoTableAdapter.
                TotalOrcamento(IdOrcamento).ToString());
                txtTotal1.Text = Total.ToString("R$##,##0.00");
                txtTotal2.Text = Total.ToString("R$##,##0.00");
            }
            else
            {
                txtTotal1.Text = "R$0,00";
                txtTotal2.Text = "R$0,00";
            }
        }
    }
}
