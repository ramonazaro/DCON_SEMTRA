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
    public partial class FrmRelatorioVendaHoraDia : Form
    {
        private Objetos.ObjetosRelatorio.CsRelatorioVendaHoraDia csRelatorioVendaHoraDia;
        private Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia csListtRelatorioVendaHora;
        private Trabalho.TrabalhoRelatorio.CsTrabalhoRelatorioVendaHoraDia csTrabalhoRelatorioVendaHoraDia;

        public FrmRelatorioVendaHoraDia()
        {
            InitializeComponent();
        }

        private void Preencher()
        {
            FrmRelatorio.FrmPreviewRelatorio frmPreviewRelatorio;
            csTrabalhoRelatorioVendaHoraDia = new Trabalho.TrabalhoRelatorio.CsTrabalhoRelatorioVendaHoraDia();
            csListtRelatorioVendaHora = csTrabalhoRelatorioVendaHoraDia.Classe_Selecionar(DateInicio.Value.Date, DateFinal.Value.Date);
            frmPreviewRelatorio = new FrmRelatorio.FrmPreviewRelatorio(csListtRelatorioVendaHora);
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            Preencher();
        }
    }
}
