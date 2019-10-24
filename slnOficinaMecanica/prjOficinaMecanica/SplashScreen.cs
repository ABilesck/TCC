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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
            pgbLoad.PerformStep();
            if(pgbLoad.Value == 100)
            {
                tmrProgresso.Enabled = false;
                Visible = false;

                Close();
            }
        }
    }
}
