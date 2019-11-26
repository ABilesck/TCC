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
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadbar.PerformStep();
            if (loadbar.Value == 40)
                mainLabel.Text = "Criando arquivo de backup";
            if(loadbar.Value == 100)
            {
                timer1.Enabled = false;
                Visible = false;

                Close();
            }
        }
    }
}
