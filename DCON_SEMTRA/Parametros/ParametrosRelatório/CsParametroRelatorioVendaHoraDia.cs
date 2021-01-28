using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Objetos;
using Conexao;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Parametros.ParametrosRelatório
{
    public class CsParametroRelatorioVendaHoraDia
    {
        Objetos.ObjetosRelatorio.CsRelatorioVendaHoraDia csRelatorioVendaHoraDia = new Objetos.ObjetosRelatorio.CsRelatorioVendaHoraDia();
        Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia CsListtRelatorioVendaHoraDia = new Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia();
        private CsBancoDeDados csBancoDeDados;

        public Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia CsListtRelatorioVendaHoraDia_Selecionar(CommandType commandType, string sqlCommand, DateTime periodoInicial, DateTime periodoFinal)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            csRelatorioVendaHoraDia = new Objetos.ObjetosRelatorio.CsRelatorioVendaHoraDia();
            CsListtRelatorioVendaHoraDia = new Objetos.ObjetosRelatorio.CsListtRelatorioVendaHoraDia();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adicionar paramentro
            csBancoDeDados.ParametroColecao_Add("@PeriodoInicial", NpgsqlDbType.Date, periodoInicial.Date);
            csBancoDeDados.ParametroColecao_Add("@PeriodoFinal", NpgsqlDbType.Date, periodoFinal.Date);
            // preenche a data table
            DataTable dataTable = csBancoDeDados.ExecuteCommandConsult(CommandType.Text, sqlCommand);
            // preencher a lista
            foreach (DataRow line in dataTable.Rows)
            {
                CsListtRelatorioVendaHoraDia.Add(csRelatorioVendaHoraDia.DataGridView_Set(line));
            }

            return CsListtRelatorioVendaHoraDia;

        }

    }
}
