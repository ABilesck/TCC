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
    public partial class FrmMecanico : Form
    {
        public FrmMecanico()
        {
            InitializeComponent();
        }

        private void tcc_MecanicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_MecanicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmMecanico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco.tcc_Mecanico' table. You can move, or remove it, as needed.
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);

        }
    }
}
