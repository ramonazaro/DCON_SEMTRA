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
    public class CsTrabalhoOperacaoEfetivada
    {
        private string sqlcommand;
        private CsParametroOperacaoEfetivada csParametroOperacaoEfetivada = new CsParametroOperacaoEfetivada();

        public CsListOperacaoEfetivada ProcurarOperacoeEfetivada(string where)
        {
            sqlcommand = "SELECT id_operacao_efetivada, numero_originario, numero_destino, comprovante, saldo_bruto, saldo_liquido, tipo_operacao, login, data_transacao, hora_transacao, data_efetivar FROM operacao_efetivada INNER JOIN usuario ON id_usuario = fk_usuario_id " + where;
            return csParametroOperacaoEfetivada.CsListOperacaoEfetivada_Selecionar(CommandType.Text, sqlcommand);
        }
    }
}
