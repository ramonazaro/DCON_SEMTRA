using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Objetos;
using Conexao;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Parametros.ParametrosRelatório
{
    public class CsParametroRelatorioDia
    {
        private CsBancoDeDados csBancoDeDados;
        private Objetos.ObjetosRelatorio.CsRelatorioDia csRelatorioDia;
        private Objetos.ObjetosRelatorio.CsListRelatorioDia csListRelatorioDia;
        private CsUsuario csUsuario;

        public Objetos.ObjetosRelatorio.CsListRelatorioDia CsRelatorioDia_Selecionar(CommandType commandType, string sqlcommand)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            csRelatorioDia = new Objetos.ObjetosRelatorio.CsRelatorioDia();
            csListRelatorioDia = new Objetos.ObjetosRelatorio.CsListRelatorioDia();
            csUsuario = new CsUsuario();
            // Limpa e adiciona parametros;
            csBancoDeDados.ParametroColecao_Clear();
            csBancoDeDados.ParametroColecao_Add("@FkIdConta", NpgsqlDbType.Bigint, csUsuario.S_FkContaId);
            // Preenche o objeto DataTable
            DataTable dataTable = csBancoDeDados.ExecuteCommandConsult(CommandType.Text, sqlcommand);
            // Preenche a lista
            foreach (DataRow line in dataTable.Rows)
            {
                csListRelatorioDia.Add(csRelatorioDia.CsRelatorioDiaDataGridView(line));
            }
            return csListRelatorioDia;
        }

    }
}
