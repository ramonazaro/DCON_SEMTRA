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
    public class CsTabalhoRelatorioSaldoMes
    {
        private string sqlcommand;
        private Parametros.ParametrosRelatório.CsParametroRelatorioSaldoMes csParametroRelatorioSaldoMes;

        public Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes Classe_Selecionar(bool mesAtual)
        {
            csParametroRelatorioSaldoMes = new Parametros.ParametrosRelatório.CsParametroRelatorioSaldoMes();

            sqlcommand = "SELECT registros, saldo, media FROM relatorio_saldo_mes(@MesAtual, @FkIdConta);";

            return csParametroRelatorioSaldoMes.Classe_Selecionar(CommandType.Text, sqlcommand, mesAtual);

        }
    }
}
