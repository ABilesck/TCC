using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    public partial class FrmCadastroOrcamento : Form
    {
        public bool novoCadastro;
        public int IdOrcamento;

        private string NomeCliente;
        private string Modelo;
        public FrmCadastroOrcamento()
        {
            InitializeComponent();
        }

        private void FrmCadastroOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco.tcc_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);
            // TODO: esta linha de código carrega dados na tabela 'banco.tcc_Automovel'. Você pode movê-la ou removê-la conforme necessário.
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
            // TODO: esta linha de código carrega dados na tabela 'banco.tcc_Orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tcc_OrcamentoTableAdapter.Fill(this.banco.tcc_Orcamento);
            if (novoCadastro)
            {
                cmbCliente_SelectedIndexChanged(null, null);
                txtMaoDeObra.Text = "0,00";
            }
            else
            {
                cmbCliente.Text = NomeCliente;
                cmbCarro.Text = Modelo;
            }
                

        }

        public void PreencherCampos(string Cliente, string Auto, double MaoDeObra)
        {
            NomeCliente = Cliente;
            Modelo = Auto;
            txtMaoDeObra.Text = MaoDeObra.ToString();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue != null)
                    tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, (int)cmbCliente.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (novoCadastro)
                {
                    tcc_OrcamentoTableAdapter.InsertQuery(
                        DateTime.Now,
                        (int)cmbCarro.SelectedValue,
                        Convert.ToDouble(txtMaoDeObra.Text)
                        );
                }
                else
                {
                    tcc_OrcamentoTableAdapter.UpdateQuery(
                        Convert.ToDouble(txtMaoDeObra.Text),
                        (int)cmbCarro.SelectedValue,
                        IdOrcamento
                        );
                }

                MessageBox.Show("Salvo com sucesso!",
                        "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCadastroOrcamento_Load(null, null);
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

        private void FrmCadastroOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmOrcamento>().Single();
            form.Reload();
        }
    }
}
