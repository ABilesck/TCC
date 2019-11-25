using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    public partial class FrmCliente : Form
    {
        int IdCliente = 0;
        string nomeCliente = "";
        string Tema = ConfigurationManager.AppSettings.Get("tema");
        string Senha = ConfigurationManager.AppSettings.Get("senha");
        string usar = ConfigurationManager.AppSettings.Get("usarSenha");

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            if (Tema.Equals("Claro"))
                Temas.AplicarTema(this, Color.White, Color.Black);
            else
                Temas.AplicarTema(this, Color.Gray, Color.White);

            tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);

            tcc_ClienteTableAdapter.Fill(banco.tcc_Cliente);

        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.RowCount > 0)
                {
                    var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;

                    IdCliente = cliente.IDCliente;
                    nomeCliente = cliente.nome;
                    tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);
                }
            }
            catch (NullReferenceException ex)
            {
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados\n" + ex.Message, "Erro ao selecionar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao selecionar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPesquisa.Text.Equals(""))
                {
                    if (cmbFiltro.Text.Equals("Documento Social"))
                    {
                        tcc_ClienteTableAdapter.FillByDocumentoSocial(banco.tcc_Cliente,
                            "%" + txtPesquisa.Text + "%");
                        btnPesquisaCancelar.Enabled = true;
                        txtPesquisa.Text = "";

                    }
                    else
                    {
                        tcc_ClienteTableAdapter.FillByNome(banco.tcc_Cliente,
                            "%" + txtPesquisa.Text + "%");
                        btnPesquisaCancelar.Enabled = true;
                        txtPesquisa.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("O campo de pesquisa está vazio!", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisaCancelar_Click(object sender, EventArgs e)
        {
            FrmCliente_Load(null, null);
            btnPesquisaCancelar.Enabled = false;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.RowCount > 0)
                {
                    if (MessageBox.Show("Deseja excluir o cliente selecionado e todos seus veiculos cadastrados?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (usar.Equals("1"))
                        {
                            string input = Interaction.InputBox("Informe a senha:", "Excluir", "*", 100, 200);
                            if (input != "")
                            {
                                if (input == Senha)
                                {
                                    IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
                                    tcc_AutomovelTableAdapter.DeleteTodos(IdCliente);
                                    tcc_ClienteTableAdapter.Delete(IdCliente);
                                    FrmCliente_Load(null, null);
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta", "Erro ao excluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
                            tcc_AutomovelTableAdapter.DeleteTodos(IdCliente);
                            tcc_ClienteTableAdapter.Delete(IdCliente);
                            FrmCliente_Load(null, null);
                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ocorreu um erro de objeto\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAutomovel frmCarro = new FrmAutomovel();
                IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
                nomeCliente = ((DataRowView)tcc_ClienteBindingSource.Current).Row["nome"].ToString();
                frmCarro.idCliente = IdCliente;
                frmCarro.nomeCliente = nomeCliente;
                frmCarro.autoNovo = true;
                frmCarro.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Formulário não encontrado\n" + ex.Message, "Erro ao abrir formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao abrir formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterar_Click(null, null);
        }

        public void Reload()
        {
            //IdCliente = Convert.ToInt32(((DataRowView)tcc_ClienteBindingSource.Current).Row["IDCliente"].ToString());
            FrmCliente_Load(null, null);
        }


        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
                cadastroCliente.NovoCadastro = true;
                cadastroCliente.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Formulário não encontrado" + ex.Message, "Erro ao abrir formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao abrir formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usar.Equals("1"))
                {
                    string input = Interaction.InputBox("Informe a senha:", "Alterar", "", 100, 200);
                    if (input != "")
                    {
                        if (input == Senha)
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
                        else
                        {
                            MessageBox.Show("Senha incorreta", "Erro ao alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
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
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente_RowHeaderMouseDoubleClick(null, null);
        }

        private void btnAlterarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (usar.Equals("1"))
                {
                    string input = Interaction.InputBox("Informe a senha:", "Alterar", "", 100, 200);
                    if (input != "")
                    {
                        if (input == Senha)
                        {
                            FrmAutomovel frmCarro = new FrmAutomovel();
                            var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;
                            var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row as Banco.tcc_AutomovelRow;

                            frmCarro.idCliente = cliente.IDCliente;
                            frmCarro.nomeCliente = cliente.nome;
                            frmCarro.Alterar(carro.IDAutomovel, carro.placa, carro.modelo,
                                carro.ano, carro.cor, carro.kmRodado);
                            frmCarro.autoNovo = false;
                            frmCarro.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta", "Erro ao alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    FrmAutomovel frmCarro = new FrmAutomovel();
                    var cliente = (tcc_ClienteBindingSource.Current as DataRowView).Row as Banco.tcc_ClienteRow;
                    var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row as Banco.tcc_AutomovelRow;

                    frmCarro.idCliente = cliente.IDCliente;
                    frmCarro.nomeCliente = cliente.nome;
                    frmCarro.Alterar(carro.IDAutomovel, carro.placa, carro.modelo,
                        carro.ano, carro.cor, carro.kmRodado);
                    frmCarro.autoNovo = false;
                    frmCarro.ShowDialog();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o automovel selecionado?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (usar.Equals("1"))
                    {
                        string input = Interaction.InputBox("Informe a senha:", "Excluir", "", 100, 200);
                        if (input != "")
                        {
                            if (input == Senha)
                            {
                                var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row
                            as Banco.tcc_AutomovelRow;
                                tcc_AutomovelTableAdapter.Delete(carro.IDAutomovel);
                                tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta", "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        var carro = (tcc_AutomovelBindingSource.Current as DataRowView).Row
                            as Banco.tcc_AutomovelRow;
                        tcc_AutomovelTableAdapter.Delete(carro.IDAutomovel);
                        tcc_AutomovelTableAdapter.FillByCliente(banco.tcc_Automovel, IdCliente);
                    }
                    
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Objeto não encontrado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro no banco de dados\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCliente.Columns[e.ColumnIndex].DataPropertyName == "documentoSocial")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        if (stringValue.Length == 11)
                        {
                            stringValue = stringValue.Substring(0, 3) + "." +
                                stringValue.Substring(3, 3) + "."
                            + stringValue.Substring(6, 3) + "-" + stringValue.Substring(9, 2);
                        }
                        else
                        {
                            //76.971.068/0001-80
                            //00.000.000/0000-00
                            //76971068000180
                            stringValue = stringValue.Substring(0, 2) + "." +
                                stringValue.Substring(2, 3) + "." + stringValue.Substring(5, 3) + "/"
                                + stringValue.Substring(8, 4) + "-" + stringValue.Substring(12, 2);
                        }
                        e.Value = stringValue;
                    }
                }
            }
            else if (dgvCliente.Columns[e.ColumnIndex].DataPropertyName == "telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (dgvCliente.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }

        private void tcc_AutomovelDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAuto.Columns[e.ColumnIndex].DataPropertyName == "placa")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 3).ToUpper() + "-" + stringValue.Substring(3, 4);
                        e.Value = stringValue;
                    }
                }
            }
        }
    }
}
