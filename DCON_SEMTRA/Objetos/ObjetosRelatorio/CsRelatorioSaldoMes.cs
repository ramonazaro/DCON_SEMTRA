using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.ObjetosRelatorio
{
    public class CsRelatorioSaldoMes
    {
        public long Registro { get; set; }
        public double Saldo { get; set; }
        public double Media { get; set; }

        public CsRelatorioSaldoMes DataGridView_Set(System.Data.DataRow dataRow)
        {
            long array = Convert.ToInt64(dataRow.ItemArray[0]);
            CsRelatorioSaldoMes csRelatorioSaldoMes;
            if (array > 0 )
            {
                csRelatorioSaldoMes = new CsRelatorioSaldoMes
                {
                    Registro = Convert.ToInt64(dataRow["registros"]),
                    Saldo = Convert.ToDouble(dataRow["saldo"]),
                    Media = Convert.ToDouble(dataRow["media"])
                     
                };
                return csRelatorioSaldoMes;
            }
            else
            {
                csRelatorioSaldoMes = new CsRelatorioSaldoMes();
                return csRelatorioSaldoMes;
            }


        }
    }
}
