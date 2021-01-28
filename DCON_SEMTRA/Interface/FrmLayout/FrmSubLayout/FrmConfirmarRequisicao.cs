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

namespace Interface.FrmLayout.FrmSubLayout
{
    public partial class FrmConfirmarRequisicao : Form
    {
        private CsTrabalhoOperacaoEfetivar csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
        private CsListOperacaoEfetivar csListCsOperacaoEfetivar = new CsListOperacaoEfetivar();
        private CsOperacaoEfetivar csOperacaoEfetivar;
        private DateTime dateTime;

        public FrmConfirmarRequisicao(DateTime dateTime)
        {
            InitializeComponent();
            this.dateTime = dateTime;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConfirmarRequisicao_Load(object sender, EventArgs e)
        {

        }



        #region DataGridView
        private void PreencherDataGrid_View()
        {

            csListCsOperacaoEfetivar = csTrabalhoOperacaoEfetivar.ProcurarOperacoeEfetivar(" WHERE tipo_operacao = '1' or tipo_operacao = '2'  AND data_transacao =  '" + dateTime.ToShortDateString() + "'");

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

        private void FrmConfirmarRequisicao_Shown(object sender, EventArgs e)
        {
            PreencherDataGrid_View();
        }

        private void DataGridOperacaoEfetivar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Executar_LiberacaoImediata();
        }

        private void DataGridOperacaoEfetivar_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Executar_LiberacaoImediata()
        {
            csOperacaoEfetivar = new CsOperacaoEfetivar();
            int row = DataGridOperacaoEfetivar.Rows.Count;
            int i = 0;
            string senha = String.Empty;
            string assinatura = String.Empty;
            senha = TextSenha.Text;
            assinatura = TextBoxAssinatura.Text;

            for (i = 0; i < row; i++)
            {
                csOperacaoEfetivar = (DataGridOperacaoEfetivar.Rows[i].DataBoundItem as CsOperacaoEfetivar);

                csOperacaoEfetivar.Senha = senha;
                csOperacaoEfetivar.AssinaturaDigital = assinatura;
                
                csTrabalhoOperacaoEfetivar.InserirOperacaoImediata(csOperacaoEfetivar);
            }

            MessageBox.Show(" Transações liberadas, para solicitar deposito fisico.");
            this.DialogResult = DialogResult.Yes;
        }
    }
}
