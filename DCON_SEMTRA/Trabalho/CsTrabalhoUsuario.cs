using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using Objetos;
using Parametros;
using Conexao;

namespace Trabalho
{
    public class CsTrabalhoUsuario 
    {
        private CsUsuario csUsuario = new CsUsuario();
        private string sqlcommand;
        private CsParametroUsuario csParametroConta;

            
        public bool Usuario_Autentica(CsUsuario csUsuario)
        {
            csParametroConta = new CsParametroUsuario();

            sqlcommand = "SELECT * FROM usuario WHERE login = @Login AND senha = @Senha";

            return csParametroConta.UsuarioParametro_Autentica(CommandType.Text, sqlcommand, csUsuario);
        }
    }
}
