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
    public partial class FrmRtpProdutos : Form
    {

        string Tema = ConfigurationManager.AppSettings.Get("tema");
        public FrmRtpProdutos()
        {
            InitializeComponent();
        }

        private void FrmRtpProdutos_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);


            this.tcc_ProdutoTableAdapter.Fill(this.Banco.tcc_Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
