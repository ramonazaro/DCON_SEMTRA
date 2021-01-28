using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.ObjetosRelatorio
{
    public class CsRelatorioDia
    {
        public DateTime DataVenda { get; set; }
        public double Media { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }
        public double Total { get; set; }

        public CsRelatorioDia CsRelatorioDiaDataGridView(System.Data.DataRow dataRow)
        {
            CsRelatorioDia csRelatorioDia = new CsRelatorioDia
            {
                DataVenda = Convert.ToDateTime(dataRow["data_venda"]),
                Media = Convert.ToDouble(dataRow["media"]),
                Minimo = Convert.ToDouble(dataRow["minimo"]),
                Maximo = Convert.ToDouble(dataRow["maximo"]),
                Total = Convert.ToDouble(dataRow["total"])
            };
            return csRelatorioDia;
        }
    }
}
