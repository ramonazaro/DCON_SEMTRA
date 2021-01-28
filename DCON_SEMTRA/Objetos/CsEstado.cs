using System;

namespace Objetos
{
    public class CsEstado
    {
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public char Sigla { get; set; }

        public CsEstado CsEstadoDataGridView_SET(System.Data.DataRow dataRow)
        {
            CsEstado csEstado = new CsEstado
            {
                IdEstado = Convert.ToInt32(dataRow["id_estado"]),
                Nome = Convert.ToString(dataRow["nome"]),
                Sigla = Convert.ToChar(dataRow["sigla"])
            };
            return csEstado;
        }
    }
}
