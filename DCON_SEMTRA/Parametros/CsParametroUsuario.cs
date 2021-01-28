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
    public class CsParametroUsuario
    {
        CsUsuario csUsuario;
        private CsBancoDeDados csBancoDeDados;
        private NpgsqlDataReader npgsqlDataReader;
        private bool result_npgsqlDataReader;

        public bool UsuarioParametro_Autentica(CommandType commandType, string sqlcommand, CsUsuario csUsuario)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            // Limpa
            csBancoDeDados.ParametroColecao_Clear();
            // Adiciona parametros
            csBancoDeDados.ParametroColecao_Add("@Senha", NpgsqlDbType.Varchar, csUsuario.Senha);
            csBancoDeDados.ParametroColecao_Add("@Login", NpgsqlDbType.Varchar, csUsuario.Login);
            // Preenche o leitor de dados
            npgsqlDataReader = csBancoDeDados.ExecuteReader(CommandType.Text, sqlcommand);
            // Atribui o valor a variavel boll
            result_npgsqlDataReader = npgsqlDataReader.HasRows;
            // Preenche as váriaveis estaticas.
            PreencherVariavelStatica_Usuario();
            CsBancoDeDados.GetCsBancoDeDados().CloseConection();
           

            return result_npgsqlDataReader;
        }


        public void PreencherVariavelStatica_Usuario()
        {
            csUsuario = new CsUsuario();
            if (npgsqlDataReader.Read())
            {
                csUsuario.PreencherUsuario(Convert.ToChar(npgsqlDataReader["nivel_acesso"].ToString()), Convert.ToChar(npgsqlDataReader["tipo_usuario"].ToString()), Convert.ToInt64(npgsqlDataReader["fk_conta_id"].ToString()), Convert.ToInt64(npgsqlDataReader["id_usuario"].ToString()));
            }

        }
    }
}
