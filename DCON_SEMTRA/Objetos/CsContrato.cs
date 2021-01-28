using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsContrato
    {
        public int IdContrato { get; set; }
        public int NumeroContrato { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public bool Vigente { get; set; }
        public int DiasSaque { get; set; }
        public decimal ValorServico { get; set; }
        public string CopiaDigitalContrato { get; set; }
        public string Descricao { get; set; }

        public CsContrato CsContratoDataGridView_SET(System.Data.DataRow dataRow)
        {
            CsContrato csContrato = new CsContrato
            {
                IdContrato = Convert.ToInt32(dataRow["id_contrato"]),
                NumeroContrato = Convert.ToInt32(dataRow["numero_contrato"]),
                DataInicio = Convert.ToDateTime(dataRow["data_inicio"]),
                DataTermino = Convert.ToDateTime(dataRow["data_termino"]),
                Vigente = Convert.ToBoolean(dataRow["vigente"]),
                DiasSaque = Convert.ToInt32(dataRow["dias_saque"]),
                ValorServico = Convert.ToDecimal(dataRow["valor_servico"]),
                CopiaDigitalContrato = Convert.ToString(dataRow["copia_digital_contrato"]),
                Descricao = Convert.ToString(dataRow["descricao"]),
            };
            return csContrato;
        }
    }
}
