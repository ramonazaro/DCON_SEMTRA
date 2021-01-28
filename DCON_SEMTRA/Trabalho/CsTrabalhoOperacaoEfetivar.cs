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
    public class CsTrabalhoOperacaoEfetivar
    {
        private string sqlcommand;
        private CsParametroOperacaoEfetivar csParametroOperacaoEfetivar = new CsParametroOperacaoEfetivar();

        public CsListOperacaoEfetivar ProcurarOperacoeEfetivar(string where)
        {
            sqlcommand = "SELECT id_operacao_efetivar, numero_originario, numero_destino, comprovante, saldo_bruto, saldo_liquido, tipo_operacao, login, data_transacao, hora_transacao, data_efetivar  FROM operacao_efetivar INNER JOIN usuario ON id_usuario = fk_usuario_id " + where;
            return csParametroOperacaoEfetivar.CsListOperacaoEfetivar_Selecionar(CommandType.Text,sqlcommand);
        }

        public void InsertOperacaoEfetivar(CsOperacaoEfetivar csOperacaoEfetivar)
        {
            csParametroOperacaoEfetivar = new CsParametroOperacaoEfetivar();

            sqlcommand = "SELECT insert_operacao(@NumeroOriginario, @NumeroDestino, @Senha, @AssinaturaDigital, @SaldoBruto, @TipoOperacao, @FkUsuarioId); ";

            csParametroOperacaoEfetivar.RegistrarOperacaoEfetivar_EfetuarOperacao(CommandType.Text, sqlcommand, csOperacaoEfetivar);
        }

        public void InsertOperacaoExtorno(CsOperacaoEfetivar csOperacaoEfetivar)
        {
            csParametroOperacaoEfetivar = new CsParametroOperacaoEfetivar();

            sqlcommand = "SELECT insert_extorno(@FkUsuarioId , @IdOperacaoEfetivar , @Senha, @AssinaturaDigital);";

            csParametroOperacaoEfetivar.RegistrarOperacaoEfetivar_EfetuarExtorno(CommandType.Text, sqlcommand, csOperacaoEfetivar);
        }
        
        public void InserirOperacaoImediata(CsOperacaoEfetivar csOperacaoEfetivar)
        {
            sqlcommand = "SELECT inserir_liberacao_imediata(@IdOperacaoEfetivar, @IdConta, @Senha, @AssinaturaDigital) ";
            csParametroOperacaoEfetivar.RegistrarOperacaoEfetivar_EfetuarLiberacaoImediato(CommandType.Text, sqlcommand, csOperacaoEfetivar);
        }


    }
}
