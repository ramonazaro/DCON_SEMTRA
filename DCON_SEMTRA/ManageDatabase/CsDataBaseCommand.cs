using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Npgsql; 

namespace ManageDatabase
{
    public class CsDataBaseCommand
    {
        CsUniversalConnection csUniversalConnection = CsUniversalConnection.GetUniversalConnection();
        
        private NpgsqlParameterCollection npgsqlParameterCollection = new NpgsqlCommand().Parameters;
        private NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
        private NpgsqlDataReader npgsqlDataReader;
        private DataTable dataTable = new DataTable();

        #region Operations CsDataBase
        public object ExecuteCommandNonQuery(CommandType commandType, string command)
        {
            try
            {
               csUniversalConnection.OpenConnection();

                // Creates and defines NpgsqlCommad
                NpgsqlCommand npgsqlCommand = csUniversalConnection.GetNpgsqlConnection().CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Add parameter in parameter Collection
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
                csUniversalConnection.CloseConnection();

            }
        }

        public DataTable ExecuteCommandConsult(CommandType commandType, string command)
        {
            try
            {
                csUniversalConnection.OpenConnection();
                // Creates and defines NpgsqlCommad
                NpgsqlCommand npgsqlCommand = csUniversalConnection.GetNpgsqlConnection().CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Add parameter in parameter Collection
                foreach (NpgsqlParameter npgsqlParameter in npgsqlParameterCollection)
                {
                    npgsqlCommand.Parameters.Add(new NpgsqlParameter(npgsqlParameter.ParameterName, npgsqlParameter.Value));
                }
                //Create objetc's
                npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
                dataTable = new DataTable();
                //
                npgsqlDataAdapter.Fill(dataTable);
                //
                return dataTable;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
               csUniversalConnection.CloseConnection();
            }
        }
        //
        //
        //
        public NpgsqlDataReader ExecuteReader(CommandType commandType, string command)
        {
            try
            {
                csUniversalConnection.OpenConnection();
                // Creates and defines NpgsqlCommad
                NpgsqlCommand npgsqlCommand = csUniversalConnection.GetNpgsqlConnection().CreateCommand();
                npgsqlCommand.CommandType = commandType;
                npgsqlCommand.CommandText = command;
                // Add parameter in parameter Collection
                foreach (NpgsqlParameter npgsqlParameter in npgsqlParameterCollection)
                {
                    npgsqlCommand.Parameters.Add(new NpgsqlParameter(npgsqlParameter.ParameterName, npgsqlParameter.Value));
                }
                //Create objetc's
                npgsqlDataReader = npgsqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                //
                return npgsqlDataReader;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                csUniversalConnection.CloseConnection();
            }
        }
        #endregion
    }
}
