using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objetos;
using Trabalho;

namespace Interface
{
    public partial class FrmGerenciarEfetivada : Form
    {
        private CsTrabalhoOperacaoEfetivada csTrabalhoOperacaoEfetivada = new CsTrabalhoOperacaoEfetivada();
        private CsListOperacaoEfetivada csListCsOperacaoEfetivada = new CsListOperacaoEfetivada();
        private CsOperacaoEfetivada CsOperacaoEfetivada;

        public FrmGerenciarEfetivada()
        {
            InitializeComponent();
        }

        private void FrmGerenciarEfetivada_Shown(object sender, EventArgs e)
        {
            PreencherDataGrid_View();
        }


        private void PreencherDataGrid_View()
        {
            csListCsOperacaoEfetivada = csTrabalhoOperacaoEfetivada.ProcurarOperacoeEfetivada("  WHERE tipo_operacao = '5' or tipo_operacao = '4' ");

            if (csListCsOperacaoEfetivada.Count > 0)
            {
                DataGridOperacaoEfetivar.DataSource = csListCsOperacaoEfetivada;
                AjustarDataGridView();
            }
            else
            {
                DataGridOperacaoEfetivar.DataSource = null;
                MessageBox.Show("Nenhum registro encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            DataGridOperacaoEfetivar.Refresh();
            DataGridOperacaoEfetivar.Update();
        }


        private void AjustarDataGridView()
        {
            DataGridOperacaoEfetivar.Columns["NumeroOriginario"].DisplayIndex = 0;
            DataGridOperacaoEfetivar.Columns["Comprovante"].DisplayIndex = 1;
            DataGridOperacaoEfetivar.Columns["SaldoLiquido"].DisplayIndex = 2;
            DataGridOperacaoEfetivar.Columns["Login"].DisplayIndex = 3;
            DataGridOperacaoEfetivar.Columns["TipoOperacao"].DisplayIndex = 4;
            DataGridOperacaoEfetivar.Columns["DataTransacao"].DisplayIndex = 5;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
