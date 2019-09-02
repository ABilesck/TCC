using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace prjOficinaMecanica
{
    public partial class FrmMenu : Form
    {
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
                if(item is FrmCliente)
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
                if(item is FrmMecanico)
                {
                    item.Focus();
                    return;
                }
            }
            FrmMecanico frmMecanico = new FrmMecanico();
            frmMecanico.MdiParent = this;
            frmMecanico.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if(item is FrmOrcamento)
                {
                    item.Focus();
                    return;
                }
            }
            FrmOrcamento frmOrcamento = new FrmOrcamento();
            frmOrcamento.MdiParent = this;
            frmOrcamento.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if(item is FrmProduto)
                {
                    item.Focus();
                    return;
                }
            }
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if(item is FrmServico)
                {
                    item.Focus();
                    return;
                }
            }
            FrmServico frmServico = new FrmServico();
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
            if(MessageBox.Show("Deseja fechar o programa?",
                "Atenção",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            /*
            FrmOrcamento frmOrcamento = new FrmOrcamento();
            frmOrcamento.MdiParent = this;
            
            FrmServico frmServico = new FrmServico();
            frmServico.MdiParent = this;
            
            frmOrcamento.Show();
            frmServico.Show();

            LayoutMdi(MdiLayout.TileVertical);
            */
        }
    }
}
