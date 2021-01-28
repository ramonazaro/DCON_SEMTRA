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
    public class CsParametroConta
    {
        private CsBancoDeDados csBancoDeDados;
        private NpgsqlDataReader npgsqlDataReader;
        public long ContaParametro_Autentica(CommandType commandType, string sqlcommand, CsConta csConta)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@Numero", NpgsqlDbType.Bigint, csConta.Numero);
            // Preenche o leitor de dados
            npgsqlDataReader = csBancoDeDados.ExecuteReader(CommandType.Text, sqlcommand);
            // Atribui o valor a variavel boll          
            try
            {
                if (npgsqlDataReader.Read())
                {
                    return Convert.ToInt64(npgsqlDataReader["id_conta"].ToString());
                }
                else
                {
                    throw new Exception("Numero da conta inexistente.");
                }

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                CsBancoDeDados.GetCsBancoDeDados().CloseConection();
            }
        }

        public CsConta ContaParametro_SelecionaNumero(CommandType commandType, string sqlcommand, CsConta csConta)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@IdConta", NpgsqlDbType.Bigint, csConta.IdConta);
            // Preenche o leitor de dados
            npgsqlDataReader = csBancoDeDados.ExecuteReader(CommandType.Text, sqlcommand);

            try
            {
                if (npgsqlDataReader.Read())
                {

                    csConta.Numero = Convert.ToInt64(npgsqlDataReader["numero"].ToString());
                    csConta.TipoUsuario = Convert.ToChar(npgsqlDataReader["tipo_usuario"].ToString());
                    csConta.FkUsuarioTipoId = Convert.ToInt64(npgsqlDataReader["fk_usuario_tipo_id"].ToString());

                    csConta.Saldo = Convert.ToDecimal(npgsqlDataReader["saldo"].ToString());
                    csConta.SaldoBloqueado = Convert.ToDecimal(npgsqlDataReader["saldo_bloqueado"].ToString());
                    return csConta;
                }
                else
                {
                    throw new Exception("Conta da empresa conveniada não encontrada. ");
                }

            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                CsBancoDeDados.GetCsBancoDeDados().CloseConection();
            }
        }

        public String ContaParametro_SelectionaNomeCliente(CommandType commandType, string sqlcommand, CsConta csConta)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@TipoUsuario", NpgsqlDbType.Varchar, csConta.TipoUsuario);
            csBancoDeDados.ParametroColecao_Add("@FkUsuarioTipoId", NpgsqlDbType.Bigint, csConta.FkUsuarioTipoId);
            // Preenche o leitor de dados
            npgsqlDataReader = csBancoDeDados.ExecuteReader(CommandType.Text, sqlcommand);

            try
            {
                if (npgsqlDataReader.Read())
                {
                   return npgsqlDataReader[0].ToString();
                }
                else
                {
                    throw new Exception("Conta da empresa conveniada não encontrada. ");
                }

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                CsBancoDeDados.GetCsBancoDeDados().CloseConection();
            }
        }


    }
}
