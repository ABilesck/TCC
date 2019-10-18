﻿using System;
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
    //TODO: o Formulario todo
    public partial class FrmServico : Form
    {
        private int idOrcamento;

        public FrmServico()
        {
            InitializeComponent();
        }

        private void tcc_OrcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_OrcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco);

        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            this.tcc_MecanicoTableAdapter.Fill(this.banco.tcc_Mecanico);
            this.tcc_ServicoTableAdapter.Fill(this.banco.tcc_Servico);
            if(idOrcamento == 0)
                this.tcc_OrcamentoTableAdapter.Fill(this.banco.tcc_Orcamento);

        }
        public void GetOrcamento(int IdO)
        {
            idOrcamento = IdO;
            tcc_OrcamentoTableAdapter.FillById(banco.tcc_Orcamento, idOrcamento);
            lblOrcamento.Text = idOrcamento.ToString();
        }
    }
}
