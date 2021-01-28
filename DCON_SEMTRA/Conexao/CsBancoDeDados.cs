using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ADD
using System.Data;
using System.IO;
using Npgsql;
using NpgsqlTypes;


namespace Conexao
{
    public class CsBancoDeDados
    {
        #region Instacia
        public static CsBancoDeDados instancia;

        private static NpgsqlConnection npgsqlConnection = ConexaoBanco();

        private CsBancoDeDados(){}

        public static CsBancoDeDados GetCsBancoDeDados()
        {
            if (instancia is null)
            {
                instancia = new CsBancoDeDados();

            }
            return instancia;
        }
        #endregion

        #region objetos
        private NpgsqlParameterCollection npgsqlParameterCollection = new NpgsqlCommand().Parameters;
        private NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
        private NpgsqlDataReader npgsqlDataReader;
        private DataTable dataTable = new DataTable();
        #endregion

        #region Abrir/Fechar Conexao
        private static NpgsqlConnection ConexaoBanco()
        {
            return new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = @11qr3p; Database = postgres;");
        }
        public bool OpenConection()
        {
            if (!(npgsqlConnection.State == ConnectionState.Open))
            {
                try
                {
                    npgsqlConnection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool CloseConection()
        {
            if (!(npgsqlConnection.State == ConnectionState.Closed))
            {
                try
                {
                    npgsqlConnection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        public void ParametroColecao_Clear()
        {
            npgsqlParameterCollection.Clear();
        }

        public void ParametroColecao_Add(string nameParameter, NpgsqlDbType npgsqlDbType ,object valueParameter)
        {
            npgsqlParameterCollection.Add(new NpgsqlParameter
            {
                ParameterName = nameParameter,
                NpgsqlDbType = npgsqlDbType,
                Value = valueParameter
            });
            
       }

        #region Funcionamento e execução
        public object ExecuteCommandNonQuery(CommandType commandType, string command)
        {
            try
            {
                OpenConection();
                // Cria e define o tipo do commando sql
                NpgsqlCommand npgsqlCommand = npgsqlConnection.CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Adiciona os parametros na coleção
                foreach (NpgsqlParameter npgsqlParameter in npgsqlParameterCollection)
                {
                    npgsqlCommand.Parameters.Add(new NpgsqlParameter(npgsqlParameter.ParameterName, npgsqlParameter.Value));
                }
                
                return npgsqlCommand.ExecuteNonQuery();
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                CloseConection();
            }
        }

        public DataTable ExecuteCommandConsult(CommandType commandType, string command)
        {
            try
            {
                OpenConection();
                // Cria e define o tipo do commando sql
                NpgsqlCommand npgsqlCommand = npgsqlConnection.CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Adiciona os parametros na coleção
                foreach (NpgsqlParameter npgsqlParameter in npgsqlParameterCollection)
                {
                    npgsqlCommand.Parameters.Add(new NpgsqlParameter(npgsqlParameter.ParameterName, npgsqlParameter.Value));
                }
                // Cria os objetos
                npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
                dataTable = new DataTable();

                // Preenche com os dados coletados e retorna
                npgsqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                CloseConection();
            }
        }
        //
        //
        //
        public NpgsqlDataReader ExecuteReader(CommandType commandType, string command)
        {
            try
            {
                OpenConection();
                // Cria e define o tipo do commando sql
                NpgsqlCommand npgsqlCommand = npgsqlConnection.CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Adiciona os parametros na coleção
                foreach (NpgsqlParameter npgsqlParameter in npgsqlParameterCollection)
                {
                    npgsqlCommand.Parameters.Add(new NpgsqlParameter(npgsqlParameter.ParameterName, npgsqlParameter.Value));
                }
                // Cria os objetos
                npgsqlDataReader = npgsqlCommand.ExecuteReader();
                return npgsqlDataReader;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
            }
        }
        #endregion

    }
}
