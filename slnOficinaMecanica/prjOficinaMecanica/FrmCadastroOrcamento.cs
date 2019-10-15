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
    public partial class FrmCadastroOrcamento : Form
    {
        public bool novoCadastro;
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
                

        }

        public void PreencherCampos(int IdCliente, int IdAuto, double MaoDeObra)
        {
            cmbCliente.SelectedValue = IdCliente;
            cmbCarro.SelectedValue = IdAuto;
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
            if (novoCadastro)
            {
                tcc_OrcamentoTableAdapter.InsertQuery(
                    DateTime.Now,
                    (int)cmbCarro.SelectedValue,
                    Convert.ToDouble(txtMaoDeObra.Text)
                    );
            }

            MessageBox.Show("Salvo com sucesso!",
                    "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmCadastroOrcamento_Load(null, null);
            Close();
        }

        private void FrmCadastroOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmOrcamento>().Single();
            form.Reload();
        }
    }
}
