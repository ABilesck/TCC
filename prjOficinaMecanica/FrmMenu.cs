using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;

namespace prjOficinaMecanica
{
    public partial class FrmMenu : Form
    {
        public string Tema = ConfigurationManager.AppSettings.Get("tema");
        public string form = ConfigurationManager.AppSettings.Get("abrirForm");

        #region banco
        string nomeDb = "tcc_OficinaMecanica";
        string sql;
        string Conn = "Provider=SQLOLEDB;" + Properties.Settings.Default.tcc_OficinaMecanicaConnectionString;
        OleDbConnection conexao;
        OleDbCommand comando;
        #endregion

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmCliente)
                {
                    item.Focus();
                    return;
                }
            }
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void drawCircleForm()
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, 850, 850, 0, 360);
            Region = new Region(path);
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.circulo;
            IsMdiContainer = true;

        }

        private void MnuMecanico_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmMecanico)
                {
                    item.Focus();
                    return;
                }
            }
            FrmMecanico frmMecanico = new FrmMecanico();
            frmMecanico.MdiParent = this;
            frmMecanico.Show();
        }

        private void orcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is Orcamento)
                {
                    item.Focus();
                    return;
                }
            }
            Orcamento frmOrcamento = new Orcamento();
            frmOrcamento.MdiParent = this;
            frmOrcamento.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmProduto)
                {
                    item.Focus();
                    return;
                }
            }
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is Servico)
                {
                    item.Focus();
                    return;
                }
            }
            Servico frmServico = new Servico();
            frmServico.MdiParent = this;
            frmServico.Show();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                item.Close();
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                AutoBackupDB();
                FrmLoad frmLoad = new FrmLoad();
                frmLoad.ShowDialog();
            }

        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            RestaurarDb();

            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            AbrirFormulario(form);
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clienteToolStripMenuItem_Click(null, null);
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            MnuMecanico_Click(null, null);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            produtoToolStripMenuItem_Click(null, null);
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            orcamentoToolStripMenuItem_Click(null, null);
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            servicoToolStripMenuItem_Click(null, null);
        }

        private void mnuRelProduto_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRtpProdutos)
                {
                    item.Focus();
                    return;
                }
            }
            FrmRtpProdutos rtpProdutos = new FrmRtpProdutos() { MdiParent = this };
            rtpProdutos.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRtpCliente)
                {
                    item.Focus();
                    return;
                }
            }

            FrmRtpCliente rtpCliente = new FrmRtpCliente() { MdiParent = this };
            rtpCliente.Show();
        }

        private void mecânicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRtpMecanico)
                {
                    item.Focus();
                    return;
                }
            }

            FrmRtpMecanico rtpMecanico = new FrmRtpMecanico() { MdiParent = this };
            rtpMecanico.Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmConfigurar)
                {
                    item.Focus();
                    return;
                }
            }
            FrmConfigurar configurar = new FrmConfigurar() { MdiParent = this };
            configurar.Show();
        }

        public void AbrirFormulario(string f)
        {
            if (!f.Equals("Nenhum"))
            {
                switch (f)
                {
                    case "Cliente":

                        clienteToolStripMenuItem_Click(null, null);

                        break;

                    case "Mecânico":

                        MnuMecanico_Click(null, null);

                        break;

                    case "Produto":

                        produtoToolStripMenuItem_Click(null, null);

                        break;

                    case "Orçamento":

                        orcamentoToolStripMenuItem_Click(null, null);

                        break;

                    case "Serviço":

                        servicoToolStripMenuItem_Click(null, null);

                        break;
                }
            }
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmRelacaoServicos)
                {
                    item.Focus();
                    return;
                }
            }
            FrmRelacaoServicos frmRelacaoServicos = new FrmRelacaoServicos() { MdiParent = this };
            frmRelacaoServicos.Show();
        }

        private void orçamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmFolhaOrcamento)
                {
                    item.Focus();
                    return;
                }
            }
            FrmFolhaOrcamento folhaOrcamento = new FrmFolhaOrcamento() { MdiParent = this };
            folhaOrcamento.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item is FrmAbout)
                {
                    item.Focus();
                    return;
                }
            }
            FrmAbout frmAbout = new FrmAbout() { MdiParent = this };
            frmAbout.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Finally Show the Created PDF from resources 
            Process.Start("Manual.pdf");
        }

        private void AutoBackupDB()
        {
            conexao = new OleDbConnection(Conn);

            string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
            //string AppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            sql = $"BACKUP DATABASE {nomeDb} TO DISK =  '{AppPath}\\Medicaro_arquivo_backup.bak' with DIFFERENTIAL";
            comando = new OleDbCommand(sql, conexao);
            comando.CommandText = sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("Backup realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel criar o arquivo de backup.\n" +
                    "erro: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestaurarDb()
        {
            conexao = new OleDbConnection(Conn);

            string AppPath = Path.GetDirectoryName(Application.ExecutablePath);
            sql = $"RESTORE DATABASE {nomeDb} FROM DISK '{AppPath}\\Medicaro_arquivo_backup.bak' with NORECOVERY\n go";
        }
    }
}