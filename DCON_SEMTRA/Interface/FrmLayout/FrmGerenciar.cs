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
    public partial class FrmGerenciar : Form
    {
        private CsTrabalhoOperacaoEfetivar csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
        private CsListOperacaoEfetivar csListCsOperacaoEfetivar = new CsListOperacaoEfetivar();
        private CsOperacaoEfetivar csOperacaoEfetivar;

        private FrmSubLayout.CsGerenciarOperacaoBloqueada csGerenciarOperacaoBloqueada;

        public FrmGerenciar()
        {
            InitializeComponent();
        }

        private void FrmGerenciar_Load(object sender, EventArgs e)
        {
        }

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
            DataGridOperacaoEfetivar.Columns["Login"].DisplayIndex = 3;
            DataGridOperacaoEfetivar.Columns["TipoOperacao"].DisplayIndex = 4;
            DataGridOperacaoEfetivar.Columns["DataTransacao"].DisplayIndex = 5;
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {


        }

        private void DataGridOperacaoEfetivar_doubleClick(object sender, EventArgs e)
        {
            csGerenciarOperacaoBloqueada = new FrmSubLayout.CsGerenciarOperacaoBloqueada(PreencherObjeto());
            csGerenciarOperacaoBloqueada.ShowDialog();

            DialogResult dialogResult = csGerenciarOperacaoBloqueada.DialogResult;

            if (dialogResult == DialogResult.Yes)
            {
                PreencherDataGrid_View();
            }
        }

        private CsOperacaoEfetivar PreencherObjeto()
        {
            csOperacaoEfetivar = new CsOperacaoEfetivar();
            csOperacaoEfetivar = (DataGridOperacaoEfetivar.SelectedRows[0].DataBoundItem as CsOperacaoEfetivar);

            return csOperacaoEfetivar;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmGerenciar_Shown(object sender, EventArgs e)
        {
            PreencherDataGrid_View();
        }

        private void DataGridOperacaoEfetivar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
