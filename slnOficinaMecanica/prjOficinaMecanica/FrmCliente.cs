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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Nome";
            lblDocSocial.Text = "CPF";
            lblRegistro.Text = "RG";
        }

        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Razão Social";
            lblDocSocial.Text = "CNPJ";
            lblRegistro.Text = "Inscrição Estadual";
        }

        private void tcc_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Cliente' table. You can move, or remove it, as needed.
            this.tcc_ClienteTableAdapter.Fill(this.banco.tcc_Cliente);

        }
    }
}
