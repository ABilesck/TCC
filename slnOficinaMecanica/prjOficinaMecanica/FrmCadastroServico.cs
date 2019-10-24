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
    public partial class FrmCadastroServico : Form
    {
        public bool NovoCadastro;
        public int Orcamento;
        public int mecanico;
        public FrmCadastroServico()
        {
            InitializeComponent();
        }
        private void FrmCadastroServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Mecanico' table. You can move, or remove it, as needed.
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            tcc_ServicoTableAdapter.Fill(banco.tcc_Servico);
            if (NovoCadastro)
                tcc_OrcamentoTableAdapter.Fill(banco.tcc_Orcamento);
            else
                tcc_OrcamentoTableAdapter.FillById(banco.tcc_Orcamento, Orcamento);

            if (NovoCadastro)
                tcc_produtoOrcamentoTableAdapter.Fill(banco.tcc_produtoOrcamento);
            else
                tcc_produtoOrcamentoTableAdapter.FillByOrcamento(banco.tcc_produtoOrcamento, Orcamento);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (NovoCadastro)
            {
                tcc_ServicoTableAdapter.InsertQuery(
                    (int)cmbMecanico.SelectedValue,
                    Orcamento,
                    dtpInicio.Value
                    );
            }
            else
            {
                tcc_ServicoTableAdapter.UpdateQuery(
                    (int)cmbMecanico.SelectedValue,
                    Orcamento,
                    dtpInicio.Value,
                    mecanico,
                    Orcamento
                    );
            }
            MessageBox.Show("Salvo com sucesso!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void tcc_OrcamentoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row
                as Banco.tcc_OrcamentoRow;
            Orcamento = orcamento.IDOrcamento;
        }

        private void FrmCadastroServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmServico>().Single();
            form.Reload();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Alterar(string mecanico, DateTime inicio)
        {
            cmbMecanico.Text = mecanico;
            dtpInicio.Value = inicio;
        }
    }
}
