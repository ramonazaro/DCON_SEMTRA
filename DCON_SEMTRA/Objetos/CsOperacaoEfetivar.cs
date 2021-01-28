using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsOperacaoEfetivar
    {
        public long IdOperacaoEfetivar { get; set; }

        public long NumeroOriginario { get; set; }
        public long NumeroDestino { get; set; }
        public string Senha { get; set; }
        public string AssinaturaDigital { get; set; }

        public decimal SaldoBruto { get; set; }
        public decimal SaldoLiquido { get; set; }
        public decimal Taxa { get; set; }

        public char TipoOperacao { get; set; }

        public DateTime DataTransacao { get; set; }
        public DateTime HoraTransacao { get; set; }
        public DateTime DataEfetivar { get; set; }

        public string Comprovante { get; set; }

        public long FkUsuarioId { get; set; }
        // Auxiliar
        public string Login { get; set; }
        private char cTO;


        public CsOperacaoEfetivar CsOperacaoEfetivarDataGridView_Set(System.Data.DataRow dataRow)
        {
            CsOperacaoEfetivar csOperacaoEfetivar = new CsOperacaoEfetivar
            {
                IdOperacaoEfetivar = Convert.ToInt64(dataRow["id_operacao_efetivar"]),
                NumeroOriginario = Convert.ToInt64(dataRow["numero_originario"]),
                NumeroDestino = Convert.ToInt64(dataRow["numero_destino"]),
                Comprovante = Convert.ToString(dataRow["comprovante"]),
                SaldoBruto = Convert.ToDecimal(dataRow["saldo_bruto"]),
                cTO = Convert.ToChar(dataRow["tipo_operacao"]),
                Login = Convert.ToString(dataRow["login"]),
                SaldoLiquido = Convert.ToDecimal(dataRow["saldo_liquido"]),
                //aux
                DataTransacao = Convert.ToDateTime(dataRow["data_transacao"]),
                HoraTransacao = Convert.ToDateTime((dataRow["hora_transacao"]).ToString()),
                DataEfetivar = Convert.ToDateTime(dataRow["data_efetivar"])
            };
                
            switch (csOperacaoEfetivar.cTO)
            {
                case '1':
                    csOperacaoEfetivar.TipoOperacao = 'D';
                    break;
                case '2':
                    csOperacaoEfetivar.TipoOperacao = 'C';
                    break;
                case '3':
                    csOperacaoEfetivar.TipoOperacao = 'T';
                    break;
                case '4':
                    csOperacaoEfetivar.TipoOperacao = 'E';
                    break;
                case '5':
                    csOperacaoEfetivar.TipoOperacao = 'D';
                    break;
            }

            return csOperacaoEfetivar;
        }
    }
}
