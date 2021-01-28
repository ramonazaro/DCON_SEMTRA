using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsConta
    {
        public long IdConta { get; set; }

        public long Numero { get; set; }
        public string Senha { get; set; }
        public string AssinaturaDigital { get; set; }
        // Montate
        public decimal Saldo { get; set; }
        public decimal SaldoBloqueado { get; set; }
        public decimal SaldoCredito { get; set; }
        public decimal LimiteCredito{ get; set; }
        // Situação
        public DateTime DataCriado { get; set; }
        public DateTime DataValidade { get; set; }
        public bool Status { get; set; }
        // Apenas dois possiveis F ou  C
        public char TipoUsuario { get; set; }
        public long FkUsuarioTipoId { get; set; }
        public long FkContratoId { get; set; }

        public CsConta CsUsuarioDataGridVBiew(System.Data.DataRow dataRow)
        {
            CsConta csConta = new CsConta
            {
                IdConta = Convert.ToInt64(dataRow["id_conta"]),
                Numero = Convert.ToInt64(dataRow["numero"]),
                Senha = Convert.ToString(dataRow["senha"]),
                AssinaturaDigital = Convert.ToString(dataRow["assinatura_digital"]),
                Saldo = Convert.ToDecimal(dataRow["saldo"]),
                SaldoBloqueado = Convert.ToDecimal(dataRow["saldo_bloqueado"]),
                SaldoCredito = Convert.ToDecimal(dataRow["saldo_credito"]),
                LimiteCredito = Convert.ToDecimal(dataRow["limite_credito"]),
                DataCriado = Convert.ToDateTime(dataRow["data_criado"]),
                DataValidade = Convert.ToDateTime(dataRow["data_validade"]),
                Status = Convert.ToBoolean(dataRow["status"]),
                TipoUsuario = Convert.ToChar(dataRow["tipo_usuario"]),
                FkUsuarioTipoId = Convert.ToInt64(dataRow["fk_usuario_tipo_id"]),
                FkContratoId = Convert.ToInt64(dataRow["fk_contrato_id"])
            };
            return csConta;
        }


    }
}
