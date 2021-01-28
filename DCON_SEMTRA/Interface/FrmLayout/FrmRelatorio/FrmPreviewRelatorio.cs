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
using Microsoft.Reporting.WinForms;

namespace Interface.FrmLayout.FrmRelatorio
{
    public partial class FrmPreviewRelatorio : Form
    {
        public FrmPreviewRelatorio(Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia csListtRelatorioVendaHora)
        {
            InitializeComponent();
            CarregarReport(csListtRelatorioVendaHora);
        }

        private void FrmPreviewRelatorio_Load(object sender, EventArgs e)
        {

            this.ReportHoraDia.RefreshReport();
        }

        private void ReportHoraDia_Load(object sender, EventArgs e)
        {

        }


        private void CarregarReport(Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia csListtRelatorioVendaHora)
        {
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "DataSetVendaHoraDia",
                Value = csListtRelatorioVendaHora
            };

            this.ReportHoraDia.LocalReport.DataSources.Add(reportDataSource);
            this.ReportHoraDia.SetDisplayMode(DisplayMode.PrintLayout);
            this.ReportHoraDia.ZoomMode = ZoomMode.Percent;
            this.ReportHoraDia.ZoomPercent = 100;
            this.ReportHoraDia.Update();
            this.ReportHoraDia.RefreshReport();
        }
    }
}
