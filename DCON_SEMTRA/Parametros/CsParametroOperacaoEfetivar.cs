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
    public class CsParametroOperacaoEfetivar
    {

        private CsBancoDeDados csBancoDeDados;
        CsOperacaoEfetivar csOperacaoEfetivar;
        CsListOperacaoEfetivar csListCsOperacaoEfetivar;
        private CsUsuario csUsuario;

        public void RegistrarOperacaoEfetivar_EfetuarOperacao(CommandType commandType, string sqlCommand, CsOperacaoEfetivar csOperacaoEfetivar)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@NumeroOriginario", NpgsqlDbType.Bigint, csOperacaoEfetivar.NumeroOriginario);
            csBancoDeDados.ParametroColecao_Add("@NumeroDestino", NpgsqlDbType.Bigint, csOperacaoEfetivar.NumeroDestino);
            csBancoDeDados.ParametroColecao_Add("@AssinaturaDigital", NpgsqlDbType.Varchar, csOperacaoEfetivar.AssinaturaDigital);
            csBancoDeDados.ParametroColecao_Add("@Senha", NpgsqlDbType.Varchar, csOperacaoEfetivar.Senha);
            csBancoDeDados.ParametroColecao_Add("@SaldoBruto", NpgsqlDbType.Numeric, csOperacaoEfetivar.SaldoBruto);
            csBancoDeDados.ParametroColecao_Add("@TipoOperacao", NpgsqlDbType.Char, csOperacaoEfetivar.TipoOperacao);
            csBancoDeDados.ParametroColecao_Add("@FkUsuarioId", NpgsqlDbType.Bigint, csOperacaoEfetivar.FkUsuarioId);

            // Executar Comando 
            csBancoDeDados.ExecuteCommandNonQuery(commandType, sqlCommand);
        }


        public void RegistrarOperacaoEfetivar_EfetuarExtorno(CommandType commandType, string sqlCommand, CsOperacaoEfetivar csOperacaoEfetivar)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@FkUsuarioId", NpgsqlDbType.Bigint, csOperacaoEfetivar.FkUsuarioId);
            csBancoDeDados.ParametroColecao_Add("@IdOperacaoEfetivar", NpgsqlDbType.Bigint, csOperacaoEfetivar.IdOperacaoEfetivar);
            csBancoDeDados.ParametroColecao_Add("@Senha", NpgsqlDbType.Varchar, csOperacaoEfetivar.Senha);
            csBancoDeDados.ParametroColecao_Add("@AssinaturaDigital", NpgsqlDbType.Varchar, csOperacaoEfetivar.AssinaturaDigital);
            // Executar Comando 
            csBancoDeDados.ExecuteCommandNonQuery(commandType, sqlCommand);
        }

        public CsListOperacaoEfetivar CsListOperacaoEfetivar_Selecionar(CommandType commandType, string sqlCommand)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            csOperacaoEfetivar = new CsOperacaoEfetivar();
            csListCsOperacaoEfetivar = new CsListOperacaoEfetivar();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // preenche a data table
            DataTable dataTable = csBancoDeDados.ExecuteCommandConsult(CommandType.Text, sqlCommand);
            // preencher a lista
            foreach(DataRow line in dataTable.Rows)
            {
                csListCsOperacaoEfetivar.Add(csOperacaoEfetivar.CsOperacaoEfetivarDataGridView_Set(line));
            }
            return csListCsOperacaoEfetivar;
        }


        public void RegistrarOperacaoEfetivar_EfetuarLiberacaoImediato(CommandType commandType, string sqlCommand, CsOperacaoEfetivar csOperacaoEfetivar)
        {
            csUsuario = new CsUsuario();
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@IdOperacaoEfetivar", NpgsqlDbType.Bigint, csOperacaoEfetivar.IdOperacaoEfetivar);
            csBancoDeDados.ParametroColecao_Add("@IdConta", NpgsqlDbType.Bigint, csUsuario.S_FkContaId);
            csBancoDeDados.ParametroColecao_Add("@Senha", NpgsqlDbType.Varchar, csOperacaoEfetivar.Senha);
            csBancoDeDados.ParametroColecao_Add("@AssinaturaDigital", NpgsqlDbType.Varchar, csOperacaoEfetivar.AssinaturaDigital);
            // Executar Comando 
            csBancoDeDados.ExecuteCommandNonQuery(commandType, sqlCommand);
        }

    }
}
