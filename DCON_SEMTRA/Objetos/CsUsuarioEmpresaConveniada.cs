using System;

namespace Objetos
{
    public class CsUsuarioEmpresaConveniada
    {
        public int IdUsuarioEmpresaConveniada { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public char Cnpj { get; set; }
        public char InscricaoEstadual { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }

        public int FkIdClienteContratante { get; set; }

        public CsUsuarioEmpresaConveniada CsUsuarioEmpresaConveniadaDataGridiView_SET(System.Data.DataRow dataRow)
        {
            CsUsuarioEmpresaConveniada csUsuarioEmpresaConveniada = new CsUsuarioEmpresaConveniada
            {
                IdUsuarioEmpresaConveniada = Convert.ToInt32(dataRow["id_usuario_empresa_conveniada"]),
                NomeFantasia = Convert.ToString(dataRow["nome_fantasia"]),
                RazaoSocial = Convert.ToString(dataRow["razao_social"]),
                Cnpj = Convert.ToChar(dataRow["cnpj"]),
                InscricaoEstadual = Convert.ToChar(dataRow["inscricao_estadual"]),
                Telefone = Convert.ToString(dataRow["telefone"]),
                Email = Convert.ToString(dataRow["email"]),
                Logradouro = Convert.ToString(dataRow["logradouro"]),
                FkIdClienteContratante = Convert.ToInt32(dataRow["fk_cliente_contratante_id"])
            };
            return csUsuarioEmpresaConveniada;
        }
    }
}
