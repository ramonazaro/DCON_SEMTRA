using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Objetos;
using Trabalho;

namespace Interface.FrmLayout
{
    public partial class FrmRequisitar : Form
    {
        private Trabalho.TrabalhoRelatorio.CsTrabalhoRelatorioDia csTrabalhoRelatorioDia;
        private Trabalho.TrabalhoRelatorio.CsTabalhoRelatorioSaldoMes csTrabalhoRelatorioSaldoMes;
        private Objetos.ObjetosRelatorio.CsListRelatorioDia csListRelatorioDia;
        private Objetos.ObjetosRelatorio.CsRelatorioDia csRelatorioDia;
        private Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes csListRelatorioSaldoMes;
        private Objetos.ObjetosRelatorio.CsRelatorioSaldoMes csRelatorioSaldoMes;


        public FrmRequisitar()
        {
            InitializeComponent();
        }

        #region DataGridView
        private void PreencherDataGrid_View()
        {
            csTrabalhoRelatorioDia = new Trabalho.TrabalhoRelatorio.CsTrabalhoRelatorioDia();
            csListRelatorioDia = new Objetos.ObjetosRelatorio.CsListRelatorioDia();

            csListRelatorioDia = csTrabalhoRelatorioDia.CsRelatorioDia_Select();

            if (csListRelatorioDia.Count > 0)
            {
                DataGridResumoDiario.DataSource = csListRelatorioDia;
                AjustarDataGridView();
            }
            else
            {
                DataGridResumoDiario.DataSource = null;
                MessageBox.Show("Nenhum registro encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarDataGrid();
        }
        

        private void AtualizarDataGrid()
        {
            DataGridResumoDiario.Refresh();
            DataGridResumoDiario.Update();
        }

        private void AjustarDataGridView()
        {
            DataGridResumoDiario.Columns["DataVenda"].DisplayIndex = 0;
            DataGridResumoDiario.Columns["Media"].DisplayIndex = 1;
            DataGridResumoDiario.Columns["Minimo"].DisplayIndex = 2;
            DataGridResumoDiario.Columns["Maximo"].DisplayIndex = 3;
            DataGridResumoDiario.Columns["Total"].DisplayIndex = 4;
        }
        #endregion


        #region PreencherLabelMesAtual/Anterior

        private void PreencherMesAnteriorLbl()
        {
            PreencherLbl(false, LblMesAnteriorRegistro, LblMesAnteriorSaldo, LblMesAnteriorMedia);
        }

        private void PreencherMesAtualLbl()
        {
            PreencherLbl(true, LblMesAtualRegistro, LblMesAtualSaldo, LblMesAtualMedia);
        }

        private void PreencherLbl(bool mesAtual, Label registro, Label saldo, Label media)
        {
            string mes = "anterior";

            csListRelatorioSaldoMes = CsRelatorioSaldoMesPreencher(mesAtual);

            if (csListRelatorioSaldoMes.Count > 0)
            {
                registro.Text = csListRelatorioSaldoMes[0].Registro.ToString();
                saldo.Text = String.Format("{0:C}", csListRelatorioSaldoMes[0].Saldo);
                media.Text = String.Format("{0:C}", csListRelatorioSaldoMes[0].Media);
            }
            else
            {
                if (mesAtual)
                {
                    mes = "atual";
                }
                MessageBox.Show("Não há dados inseridos no mês " + mes);
            }
        }
        private Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes CsRelatorioSaldoMesPreencher(bool mesAtual)
        {
            csTrabalhoRelatorioSaldoMes = new Trabalho.TrabalhoRelatorio.CsTabalhoRelatorioSaldoMes();
            csListRelatorioSaldoMes = new Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes();

            csListRelatorioSaldoMes = csTrabalhoRelatorioSaldoMes.Classe_Selecionar(mesAtual);

            return csListRelatorioSaldoMes;
        }


        #endregion
        private void TableBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridResumoDiario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRequisitar_Shown(object sender, EventArgs e)
        {
            PreencherDataGrid_View();
            PreencherMesAnteriorLbl();
            PreencherMesAtualLbl();
        }

        private void DataGridResumoDiario_DoubleClick(object sender, EventArgs e)
        {
            FrmSubLayout.FrmConfirmarRequisicao frmConfirmarRequisicao = new FrmSubLayout.FrmConfirmarRequisicao(PreencherDateTime());
            DialogResult dialogResult = frmConfirmarRequisicao.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                PreencherDataGrid_View();
            }
        }

        private DateTime PreencherDateTime()
        {
            return Convert.ToDateTime(DataGridResumoDiario.SelectedCells[0].Value);
        }

        private void LblMesAtualMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
