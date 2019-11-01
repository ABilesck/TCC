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
    public partial class FrmConfigurar : Form
    {
        public FrmConfigurar()
        {
            InitializeComponent();
            cmbTema.Text = ConfigurationManager.AppSettings.Get("tema");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Config.UpdateAppSettings("tema", cmbTema.Text);
            var menu = Application.OpenForms.OfType<FrmMenu>().Single();
            menu.Tema = cmbTema.Text;
            menu.FrmMenu_Load(null, null);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
