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
    public partial class FrmRtpProdutos : Form
    {
        public FrmRtpProdutos()
        {
            InitializeComponent();
        }

        private void FrmRtpProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.tcc_Produto' table. You can move, or remove it, as needed.
            this.tcc_ProdutoTableAdapter.Fill(this.Banco.tcc_Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
