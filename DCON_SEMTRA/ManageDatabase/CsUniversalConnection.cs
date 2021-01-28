using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Npgsql;

namespace ManageDatabase
{
    public class CsUniversalConnection
    {
        //  Campo Private
        private NpgsqlConnection npgsqlConnection = ConfigurationConnection();
        // Propriet's internal;
        internal NpgsqlConnection NpgsqlConnection { get => npgsqlConnection; set => npgsqlConnection = value; }

        #region Singleton
        // Instace
        public static CsUniversalConnection instance;
        private CsUniversalConnection()
        {

        }
        // The "GetUniversalConection" is one visible method for all project
        public static CsUniversalConnection GetUniversalConnection()
        {
            if(instance == null)
            {
                instance = new CsUniversalConnection();
            }
            return instance;
        }
        #endregion

        #region DataConnection
        //  Host of connection
        private static NpgsqlConnection ConfigurationConnection()
        {
            return new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = @11qr3p; Database = dcon_semtra;");
        }
        //
        //  OPEN AND CLOSE Conection State 
        //
        public ConnectionState OpenConnection()
        {
            try
            {
                if (!(NpgsqlConnection.State == ConnectionState.Open))
                {
                    NpgsqlConnection = ConfigurationConnection();
                    NpgsqlConnection.Open();
                }
            }
            catch(Exception exception)
            {
                throw new Exception("Não foi possível estabelecer uma conexão, detalhes: " + exception.Message);
            }
            return NpgsqlConnection.State;
        }
        public ConnectionState CloseConnection()
        {
            try
            {
                if (!(NpgsqlConnection.State == ConnectionState.Closed))
                {
                    NpgsqlConnection.Close();
                }
            }
            catch
            {
                return NpgsqlConnection.State;
            }

            return NpgsqlConnection.State;
        }
        //
        //  END STATUS MODIFIES
        //
        #endregion
    }
}
