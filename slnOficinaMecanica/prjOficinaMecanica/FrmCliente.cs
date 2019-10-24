using System;
using System.Data;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    //TODO: inner join no select do automovel para ver o nome do dono
    //TODO: mudar o design do formulario
    //TODO: fazer as mascaras das text box

    public partial class FrmCliente : Form
    {
        int IdCliente = 0;
        string nomeCliente = "";

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);

            tcc_ClienteTableAdapter.Fill(banco.tcc_Cliente);

        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            //tcPrincipal.TabIndex = 0;
            if (dgvCliente.RowCount > 0)
            {
                var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;

                IdCliente = cliente.IDCliente;
                nomeCliente = cliente.nome;
                tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesquisa.Text.Equals(""))
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    tcc_ClienteTableAdapter.FillById(banco.tcc_Cliente,
                        Convert.ToInt32(txtPesquisa.Text));

                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    tcc_ClienteTableAdapter.FillByDocumentoSocial(banco.tcc_Cliente,
                        "%" + txtPesquisa.Text + "%");

                }
                else if (cmbFiltro.SelectedIndex == 2)
                {
                    tcc_ClienteTableAdapter.FillByNome(banco.tcc_Cliente,
                        "%" + txtPesquisa.Text + "%");

                }
            }
            else
            {
                MessageBox.Show("O campo de pesquisa está vazio!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmCliente_Load(null, null);
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cliente selecionado e todos seus veiculos cadastrados?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
                //tcc_ClienteTableAdapter.Delete(Convert.ToInt32(dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString()));
                tcc_AutomovelTableAdapter.DeleteTodos(IdCliente);
                tcc_ClienteTableAdapter.Delete(IdCliente);
                FrmCliente_Load(null, null);
            }
        }

        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            FrmAutomovel frmCarro = new FrmAutomovel();
            IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
            nomeCliente = ((DataRowView)tcc_ClienteBindingSource.Current).Row["nome"].ToString();
            frmCarro.idCliente = IdCliente;
            frmCarro.nomeCliente = nomeCliente;
            frmCarro.autoNovo = true;
            frmCarro.ShowDialog();
        }

        private void dgvCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;

            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
            cadastroCliente.NovoCadastro = false;
            cadastroCliente.Alterar(cliente.nome, cliente.documentoSocial, cliente.telefone,
                cliente.email, cliente.logradouro, cliente.bairro, cliente.cidade, cliente.complemento,
                cliente.uf, cliente.cep, cliente.registroGeral);
            cadastroCliente.Id = cliente.IDCliente;
            cadastroCliente.ShowDialog();
        }

        public void Reload()
        {
            IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
            FrmCliente_Load(null, null);
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOrdenar_SelectedIndexChanged(null, null);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
            cadastroCliente.NovoCadastro = true;
            cadastroCliente.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;

            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
            cadastroCliente.NovoCadastro = false;
            cadastroCliente.Alterar(cliente.nome, cliente.documentoSocial, cliente.telefone,
                cliente.email, cliente.logradouro, cliente.bairro, cliente.cidade, cliente.complemento,
                cliente.uf, cliente.cep, cliente.registroGeral);
            cadastroCliente.Id = cliente.IDCliente;
            cadastroCliente.ShowDialog();
        }

        private void dgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente_RowHeaderMouseDoubleClick(null, null);
        }

        private void btnAlterarCarro_Click(object sender, EventArgs e)
        {
            FrmAutomovel frmCarro = new FrmAutomovel();
            //IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
            //nomeCliente = ((DataRowView)tcc_ClienteBindingSource.Current).Row["nome"].ToString();

            var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;
            var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row as Banco.tcc_AutomovelRow;

            frmCarro.idCliente = cliente.IDCliente;
            frmCarro.nomeCliente = cliente.nome;
            frmCarro.Alterar(carro.IDAutomovel, carro.placa, carro.modelo, 
                carro.ano, carro.cor, carro.kmRodado);
            frmCarro.autoNovo = false;
            frmCarro.ShowDialog();
        }

        private void btnExcluirCarro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o automovel selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row
                    as Banco.tcc_AutomovelRow;
                tcc_AutomovelTableAdapter.Delete(carro.IDAutomovel);
                tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel,IdCliente);
            }
        }
    }
}
