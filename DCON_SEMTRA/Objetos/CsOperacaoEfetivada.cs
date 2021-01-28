using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsOperacaoEfetivada
    {
        public long IdOperacaoEfetivada { get; set; }

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

        public bool Finalizada { get; set; }
        // Auxiliar
        public string Login { get; set; }
        private char cTO;


        public CsOperacaoEfetivada CsOperacaoEfetivadaDataGridView_Set(System.Data.DataRow dataRow)
        {
            CsOperacaoEfetivada csOperacaoEfetivada = new CsOperacaoEfetivada
            {
                IdOperacaoEfetivada = Convert.ToInt64(dataRow["id_operacao_efetivada"]),
                NumeroOriginario = Convert.ToInt64(dataRow["numero_originario"]),
                NumeroDestino = Convert.ToInt64(dataRow["numero_destino"]),
                Comprovante = Convert.ToString(dataRow["comprovante"]),
                SaldoBruto = Convert.ToDecimal(dataRow["saldo_bruto"]),
                cTO = Convert.ToChar(dataRow["tipo_operacao"]),
                Login = Convert.ToString(dataRow["login"]),
                SaldoLiquido = Convert.ToDecimal(dataRow["saldo_liquido"]),
                HoraTransacao = Convert.ToDateTime((dataRow["hora_transacao"]).ToString()),
                DataEfetivar = Convert.ToDateTime(dataRow["data_efetivar"])
            };

            switch (csOperacaoEfetivada.cTO)
            {
                case '1':
                    csOperacaoEfetivada.TipoOperacao = 'D';
                    break;
                case '2':
                    csOperacaoEfetivada.TipoOperacao = 'C';
                    break;
                case '3':
                    csOperacaoEfetivada.TipoOperacao = 'T';
                    break;
                case '4':
                    csOperacaoEfetivada.TipoOperacao = 'E';
                    break;
                case '5':
                    csOperacaoEfetivada.TipoOperacao = 'D';
                    break;
            }

            return csOperacaoEfetivada;
        }
    }
}
