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
    public partial class FrmAutomovel : Form
    {
        public int idCliente;
        public string nomeCliente;
        public FrmAutomovel()
        {
            InitializeComponent();
        }

        private void FrmCarro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Automovel' table. You can move, or remove it, as needed.
            this.tcc_AutomovelTableAdapter.Fill(this.banco.tcc_Automovel);
            lblCliente.Text = "Cliente: " + nomeCliente;
        }

        private void tcc_AutomovelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_AutomovelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }
    }
}
