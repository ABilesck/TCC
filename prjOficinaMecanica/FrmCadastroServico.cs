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
    public partial class FrmCadastroServico : Form
    {
        public bool NovoCadastro;
        public int Orcamento;
        public int mecanico;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        public FrmCadastroServico()
        {
            InitializeComponent();
        }
        private void FrmCadastroServico_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);


            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            //tcc_ServicoTableAdapter.Fill(banco.tcc_Servico);
            if (Orcamento == 0)
                tcc_OrcamentoTableAdapter.Fill(banco.tcc_Orcamento);
            else
                tcc_OrcamentoTableAdapter.FillById(banco.tcc_Orcamento, Orcamento);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NovoCadastro)
                {
                    tcc_ServicoTableAdapter.InsertQuery(
                        (int)cmbMecanico.SelectedValue,
                        Orcamento,
                        dtpInicio.Value,
                        txtObs.Text,
                        Convert.ToDouble(txtDesconto.Text)
                        );
                    MessageBox.Show("Salvo com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    tcc_ServicoTableAdapter.UpdateQuery(
                        (int)cmbMecanico.SelectedValue,
                        Orcamento,
                        dtpInicio.Value,
                        Convert.ToDouble(txtDesconto.Text),
                        mecanico,
                        Orcamento
                        );
                    MessageBox.Show("Salvo com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro no banco de dados\n" + ex.Message , "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado\n" + ex.Message, "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcc_OrcamentoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var orcamento = (tcc_OrcamentoBindingSource.Current as DataRowView).Row
                as Banco.tcc_OrcamentoRow;
            Orcamento = orcamento.IDOrcamento;
        }

        private void FrmCadastroServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var form = Application.OpenForms.OfType<Servico>().Single();
                if (form != null)
                    form.Reload();
            }catch(InvalidOperationException ex)
            {
            }
            
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
