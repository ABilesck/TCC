using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");

        string nomeDb = "tcc_OficinaMecanica";
        string sql;
        string Conn = "Provider=SQLOLEDB;" + Properties.Settings.Default.tcc_OficinaMecanicaConnectionString;
        OleDbConnection conexao;
        OleDbCommand comando;
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
            string usarSenha = "1";
            if (chbUsarSenha.Checked)
                usarSenha = "1";
            else
                usarSenha = "0";

            if (txtSenha.Text == txtRepetirSenha.Text)
            {
                string SenhaFinal = txtRepetirSenha.Text;

                Config.UpdateAppSettings("tema", cmbTema.Text);
                Config.UpdateAppSettings("abrirForm", cmbForm.Text);
                Config.UpdateAppSettings("senha", SenhaFinal);
                Config.UpdateAppSettings("usarSenha", usarSenha);
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

            if (usar.Equals("1"))
                chbUsarSenha.Checked = true;
            else
                chbUsarSenha.Checked = false;
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Informe a senha:", "Alterar", "*", 100, 200);
            if(input != "")
            {
                if(Senha == input)
                {
                    grpSenha.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            conexao = new OleDbConnection(Conn);

            string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
            //string AppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            sql = $"BACKUP DATABASE {nomeDb} TO DISK =  '{AppPath}\\Medicaro_arquivo_backup.bak'";
            comando = new OleDbCommand(sql, conexao);
            comando.CommandText = sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Backup realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel criar o arquivo de backup.\n" +
                    "erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
