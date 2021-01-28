using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using Objetos;
using Parametros;

namespace Trabalho.TrabalhoRelatorio
{
    public class CsTrabalhoRelatorioVendaHoraDia
    {
        private string sqlcommand;
        private Parametros.ParametrosRelatório.CsParametroRelatorioVendaHoraDia csParametroRelatorioVendaHoraDia;

        public Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia Classe_Selecionar(DateTime periodoInicial, DateTime periodoFinal)
        {
            csParametroRelatorioVendaHoraDia = new Parametros.ParametrosRelatório.CsParametroRelatorioVendaHoraDia();

            sqlcommand = "SELECT data_venda, hora_venda, total_venda FROM relatorio_venda_hora_dia(@PeriodoInicial, @PeriodoFinal);";

            return csParametroRelatorioVendaHoraDia.CsListtRelatorioVendaHoraDia_Selecionar(CommandType.Text, sqlcommand, periodoInicial, periodoFinal);

        }
    }
}
