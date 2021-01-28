using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using Objetos;
using Parametros;

namespace Trabalho
{
    public class CsTrabalhoConta
    {
        private string sqlcommand;
        private CsParametroConta csParametroConta;

        public long Conta_Autentica(CsConta csConta)
        {
            csParametroConta = new CsParametroConta();

            sqlcommand = "SELECT id_conta FROM conta WHERE numero = @Numero ";

            return csParametroConta.ContaParametro_Autentica(CommandType.Text, sqlcommand, csConta);
        }
        public CsConta Conta_Select_Numero(CsConta csConta)
        {
            csParametroConta = new CsParametroConta();

            sqlcommand = "SELECT numero, tipo_usuario, fk_usuario_tipo_id, saldo_bloqueado, saldo FROM conta WHERE id_conta = @IdConta ";

            return csParametroConta.ContaParametro_SelecionaNumero(CommandType.Text, sqlcommand, csConta);
        }

        public String Conta_Select_Nome(CsConta csConta)
        {
            csParametroConta = new CsParametroConta();

            sqlcommand = "SELECT select_nome_usuario(@TipoUsuario, @FkUsuarioTipoId)";

            return csParametroConta.ContaParametro_SelectionaNomeCliente(CommandType.Text, sqlcommand, csConta);
        }
    }
}
