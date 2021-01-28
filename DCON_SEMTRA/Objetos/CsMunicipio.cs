using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsMunicipio
    {
        public int IdMunicipio { get; set; }
        public string Nome { get; set; }
        public char Sigla { get; set; }

        public CsMunicipio CsMunicipioDataGridView_SET(System.Data.DataRow dataRow)
        {
            CsMunicipio csMunicipio = new CsMunicipio
            {
                IdMunicipio = Convert.ToInt32(dataRow["id_municipio"]),
                Nome = Convert.ToString(dataRow["nome"]),
                Sigla = Convert.ToChar(dataRow["sigla"])
            };
            return csMunicipio;
        }
    }
}
