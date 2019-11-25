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
    public partial class FrmRelMecanico : Form
    {
        public FrmRelMecanico()
        {
            InitializeComponent();
        }

        private void FrmRelMecanico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.RelMecanico' table. You can move, or remove it, as needed.
            this.RelMecanicoTableAdapter.Fill(this.Banco.RelMecanico);

            this.reportViewer1.RefreshReport();
        }
    }
}
