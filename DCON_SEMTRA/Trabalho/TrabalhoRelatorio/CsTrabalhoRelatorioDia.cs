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
    public class CsTrabalhoRelatorioDia
    {
        private string sqlcommand;
        private Parametros.ParametrosRelatório.CsParametroRelatorioDia csParametroRelatorioDia;

        public Objetos.ObjetosRelatorio.CsListRelatorioDia CsRelatorioDia_Select()
        {
            csParametroRelatorioDia = new Parametros.ParametrosRelatório.CsParametroRelatorioDia();

            sqlcommand = "SELECT data_venda, media, minimo, maximo, total FROM relatorio_dia(@FkIdConta)";

            return csParametroRelatorioDia.CsRelatorioDia_Selecionar(CommandType.Text, sqlcommand);

        }

    }
}
