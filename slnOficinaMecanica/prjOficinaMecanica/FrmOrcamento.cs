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
        public FrmOrcamento()
        {
            InitializeComponent();
        }

        int idCliente;

        private void FrmOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Produto' table. You can move, or remove it, as needed.
            this.tcc_ProdutoTableAdapter.Fill(this.banco.tcc_Produto);
            this.tcc_produtoOrcamentoTableAdapter.Fill(this.banco.tcc_produtoOrcamento);
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);

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
                idCliente = (int)cmbCliente.SelectedValue;
                if(cmbAuto.Items.Count == 0)
                {
                    MessageBox.Show("O cliente não possui nenhum automóvel cadastrado!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tcc_AutomovelTableAdapter.FillByIdCliente(banco.tcc_Automovel, idCliente);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao selecionar um cliente:\n" + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            idCliente = 0;
        }
    }
}
