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

namespace Parametros
{
    public class CsParametroOperacaoEfetivada
    {

        private CsBancoDeDados csBancoDeDados;
        private CsOperacaoEfetivada csOperacaoEfetivada;
        private CsListOperacaoEfetivada csListcsOperacaoEfetivada;
        public CsListOperacaoEfetivada CsListOperacaoEfetivada_Selecionar(CommandType commandType, string sqlCommand)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            csOperacaoEfetivada = new CsOperacaoEfetivada();
            csListcsOperacaoEfetivada = new CsListOperacaoEfetivada();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // preenche a data table
            DataTable dataTable = csBancoDeDados.ExecuteCommandConsult(CommandType.Text, sqlCommand);
            // preencher a lista
            foreach(DataRow line in dataTable.Rows)
            {
                csListcsOperacaoEfetivada.Add(csOperacaoEfetivada.CsOperacaoEfetivadaDataGridView_Set(line));
            }
            
            return csListcsOperacaoEfetivada;

        }


    }
}
