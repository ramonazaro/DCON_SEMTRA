using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.ObjetosRelatorio
{
    public class CsRelatorioVendaHoraDia
    {
        public DateTime DataVenda { get; set; }
        public DateTime HoraVenda { get; set; }
        public decimal TotalVenda { get; set; }

        public CsRelatorioVendaHoraDia DataGridView_Set(System.Data.DataRow dataRow)
        {
            CsRelatorioVendaHoraDia csRelatorioVendaHoraDia = new CsRelatorioVendaHoraDia
            {
                DataVenda = Convert.ToDateTime(dataRow["data_venda"]),
                HoraVenda = Convert.ToDateTime(dataRow["hora_venda"]),
                TotalVenda = Convert.ToDecimal(dataRow["total_venda"])
            };
            return csRelatorioVendaHoraDia;
        }
    }
}
