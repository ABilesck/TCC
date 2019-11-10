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
    public partial class FrmCadastroOrcamento : Form
    {
        public bool novoCadastro;
        public int IdOrcamento;

        private string NomeCliente;
        private string Modelo;

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        public FrmCadastroOrcamento()
        {
            InitializeComponent();
        }

        private void FrmCadastroOrcamento_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
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

        public void PreencherCampos(string Cliente, string Auto, double MaoDeObra, string desc)
        {
            NomeCliente = Cliente;
            Modelo = Auto;
            txtMaoDeObra.Text = MaoDeObra.ToString();
            txtDescricao.Text = desc;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue != null)
                {
                    tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, (int)cmbCliente.SelectedValue);
                    var auto = (tccAutomovelBindingSource.Current as DataRowView).Row as Banco.tcc_AutomovelRow;
                    txtPlaca.Text = auto.placa;
                }
                    
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
                        Convert.ToDouble(txtMaoDeObra.Text),
                        txtDescricao.Text
                        );
                }
                else
                {
                    tcc_OrcamentoTableAdapter.UpdateQuery(
                        Convert.ToDouble(txtMaoDeObra.Text),
                        (int)cmbCarro.SelectedValue,
                        txtDescricao.Text,
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
            var form = Application.OpenForms.OfType<Orcamento>().Single();
            form.Reload();
        }

        private void cmbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCarro.SelectedValue != null)
            {
                var auto = (tccAutomovelBindingSource.Current as DataRowView).Row as Banco.tcc_AutomovelRow;
                txtPlaca.Text = auto.placa;
            }
        }
    }
}
