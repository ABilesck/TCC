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
    public partial class FrmRtpMecanico : Form
    {
        public FrmRtpMecanico()
        {
            InitializeComponent();
        }

        private void FrmRtpMecanico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Banco.tcc_Mecanico' table. You can move, or remove it, as needed.
            this.tcc_MecanicoTableAdapter.Fill(this.Banco.tcc_Mecanico);

            this.reportViewer1.RefreshReport();
        }
    }
}
