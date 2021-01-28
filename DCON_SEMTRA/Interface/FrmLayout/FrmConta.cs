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

namespace Interface.FrmLayout
{
    public partial class FrmConta : Form
    {
        private CsTrabalhoOperacaoEfetivar csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
        private CsListOperacaoEfetivar csListCsOperacaoEfetivar = new CsListOperacaoEfetivar();
        private CsUsuario csUsuario = new CsUsuario();
        public FrmHome frmHome;
        private CsConta csConta;
        private CsTrabalhoConta csTrabalhoConta;

        

        public FrmConta(object form)
        {
            InitializeComponent();
            frmHome = (form as FrmHome);
        }


        private void PreencherSaldo()
        {
            csTrabalhoConta = new CsTrabalhoConta();

            csConta = new CsConta
            {
                IdConta = csUsuario.S_FkContaId
            };

            csConta = csTrabalhoConta.Conta_Select_Numero(csConta);

            LblSaldoBloqueado.Text = String.Format("{0:C}", csConta.SaldoBloqueado);
            LblSaldoDisponivel.Text = String.Format("{0:C}", csConta.Saldo);
            LblSaldoGeral.Text = String.Format("{0:C}", (csConta.Saldo + csConta.SaldoBloqueado));


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConta_Shown(object sender, EventArgs e)
        {
            PreencherDataGrid_View();
            PreencherSaldo();
        }

        private void FrmConta_Load(object sender, EventArgs e)
        {

        }

        #region DataGridView
        private void PreencherDataGrid_View()
        {

            csListCsOperacaoEfetivar = csTrabalhoOperacaoEfetivar.ProcurarOperacoeEfetivar(" WHERE tipo_operacao = '1' or tipo_operacao = '2'");

            if (csListCsOperacaoEfetivar.Count > 0)
            {
                DataGridOperacaoEfetivar.DataSource = csListCsOperacaoEfetivar;
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
            DataGridOperacaoEfetivar.Columns["TipoOperacao"].DisplayIndex = 3;
            DataGridOperacaoEfetivar.Columns["Login"].DisplayIndex = 4;
            DataGridOperacaoEfetivar.Columns["DataTransacao"].DisplayIndex = 5;
        }
        #endregion

        private void TxtGerenciar_Click(object sender, EventArgs e)
        {
            frmHome.AcessoRapidoExtorno();
        }

        private void TxtRegistrarTransacao_Click(object sender, EventArgs e)
        {
            frmHome.AcessoRapidoTransacao();
        }

        private void TxtRegistrarFuncionario_Click(object sender, EventArgs e)
        {
            frmHome.AcessoRapidoFuncionario();
        }

        private void DataGridOperacaoEfetivar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
