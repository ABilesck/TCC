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
    //TODO: botoes de cancelar e sair

    public partial class FrmAutomovel : Form
    {
        public int idCliente;
        public int idAutomovel;
        public string nomeCliente;
        public bool autoNovo;
        public FrmAutomovel()
        {
            InitializeComponent();
        }

        private void FrmCarro_Load(object sender, EventArgs e)
        {
            tcc_AutomovelTableAdapter.Fill(banco.tcc_Automovel);
            lblCliente.Text = "Cliente: " + nomeCliente;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //TODO: possibilitar alterar um carro

            if (autoNovo)
            {
                tcc_AutomovelTableAdapter.Insert(
                    idCliente,
                   txtPlaca.Text,
                   txtModelo.Text,
                   txtAno.Text,
                   txtCor.Text, 
                   txtKm.Text);
            }
            else
            {
                tcc_AutomovelTableAdapter.Update(
                    idCliente,
                    txtPlaca.Text,
                    txtModelo.Text,
                    txtAno.Text,
                    txtCor.Text,
                    txtKm.Text,
                    idAutomovel);
            }

            MessageBox.Show("Salvo com sucesso!",
                    "Atencão", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //btnCancelar;
            FrmCarro_Load(null, null);
            Close();
        }

        private void FrmAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
           var form = Application.OpenForms.OfType<FrmCliente>().Single();
           form.Reload();
        }
    }
}
