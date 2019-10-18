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

            Close();
        }

        private void FrmAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
           var form = Application.OpenForms.OfType<FrmCliente>().Single();
           form.Reload();
        }

        public void Alterar(int idCarro, string placa, string modelo, string ano, string cor, string km)
        {
            txtPlaca.Text = placa;
            txtModelo.Text = modelo;
            txtAno.Text = ano;
            txtCor.Text = cor;
            txtKm.Text = km;
            idAutomovel = idCarro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
