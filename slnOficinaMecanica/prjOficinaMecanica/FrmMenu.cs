using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
