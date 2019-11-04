using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    public partial class FrmConfigurar : Form
    {
        string form = ConfigurationManager.AppSettings.Get("abrirForm");
        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        public FrmConfigurar()
        {
            InitializeComponent();
            if (form.Equals("Nenhum"))
            {
                rbtNao.Checked = true;
                rbtSim.Checked = false;
                HabilitarBox();
            }
            else
            {
                rbtNao.Checked = false;
                rbtSim.Checked = true;
                HabilitarBox();
            }
            cmbTema.Text = Tema;
            cmbForm.Text = form;
            txtSenha.Text = Senha;
            txtRepetirSenha.Text = Senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtRepetirSenha.Text)
            {
                string SenhaFinal = txtRepetirSenha.Text;

                Config.UpdateAppSettings("tema", cmbTema.Text);
                Config.UpdateAppSettings("abrirForm", cmbForm.Text);
                Config.UpdateAppSettings("senha", SenhaFinal);
                var menu = Application.OpenForms.OfType<FrmMenu>().Single();
                menu.Tema = cmbTema.Text;
                menu.FrmMenu_Load(null, null);
                MessageBox.Show("Configurações alteradas com sucesso!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Senhas não coincidem!", "Erro ao salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtSim_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBox();
        }

        private void rbtNao_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBox();
        }

        private void HabilitarBox()
        {
            if (rbtSim.Checked)
                cmbForm.Enabled = true;
            else
            {
                cmbForm.Enabled = false;
                cmbForm.Text = "Nenhum";
            }

        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);
        }
    }
}
