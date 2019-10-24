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
    public partial class FrmServico : Form
    {
        private int idOrcamento;

        public FrmServico()
        {
            InitializeComponent();
        }
        public void FrmServico_Load(object sender, EventArgs e)
        {
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            this.tcc_ServicoTableAdapter.Fill(this.banco.tcc_Servico);
            if (idOrcamento == 0)
                this.tcc_OrcamentoTableAdapter.Fill(this.banco.tcc_Orcamento);

        }
        public void GetOrcamento(int IdO)
        {
            idOrcamento = IdO;
            tcc_OrcamentoTableAdapter.FillById(banco.tcc_Orcamento, idOrcamento);
            //lblOrcamento.Text = idOrcamento.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroServico cadastroServico = new FrmCadastroServico();
            cadastroServico.NovoCadastro = true;
            cadastroServico.ShowDialog();
        }

        public void Reload()
        {
            FrmServico_Load(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
            FrmCadastroServico cadastroServico = new FrmCadastroServico()
            {
                Orcamento = servico.IDOrcamento,
                mecanico = servico.IDMecanico,
                NovoCadastro = false
            };
            cadastroServico.Alterar(servico.razaoSocial, servico.dataInicio);
            cadastroServico.ShowDialog();
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmServico_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvServico.RowCount > 0)
            {
                var servico = (tcc_ServicoBindingSource.Current as DataRowView).Row as Banco.tcc_ServicoRow;
                if (MessageBox.Show("Deseja excluir o serviço selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    tcc_ServicoTableAdapter.DeleteQuery(servico.IDMecanico, servico.IDOrcamento);
                    FrmServico_Load(null, null);

                    MessageBox.Show("Serviço excluido com sucesso!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
