using System;

namespace Objetos
{
    public class CsClienteContratante
    {
        public int IdClienteContratante { get; set; }
        public string RazaoSocial { get; set; }
        public string LoginClienteContrante { get; set; }
        public char Senha { get; set; }

        public int FkMunicipioId { get; set; }
        public int FkEstadoId { get; set; }

        public CsClienteContratante CsClienteContratanteDataGridView_SET(System.Data.DataRow dataRow)
        {
            CsClienteContratante csClienteContratante = new CsClienteContratante
            {
                IdClienteContratante = Convert.ToInt32(dataRow["id_cliente_contratante"]),
                RazaoSocial = Convert.ToString(dataRow["razao_social"]),
                LoginClienteContrante = Convert.ToString(dataRow["login_cliente_contratante"]),
                Senha = Convert.ToChar(dataRow["senha"]),
                FkMunicipioId = Convert.ToInt32(dataRow["fk_municipio_id"]),
                FkEstadoId = Convert.ToInt32(dataRow["fk_estado_id"])
            };

            return csClienteContratante;
        }
    }
}
