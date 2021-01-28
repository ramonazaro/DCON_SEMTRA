using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsUsuarioFisico
    {
        public int IdUsuarioFisico { get; set; }
        public string NomeCompleto { get; set; }
        public char Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public string TipoContrato { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }

        public int FkIdClienteContatante { get; set; }

        public CsUsuarioFisico CsUsuarioFisicoDataGriDView_SET(System.Data.DataRow dataRow)
        {
            CsUsuarioFisico csUsuarioFisico = new CsUsuarioFisico
            {
                IdUsuarioFisico = Convert.ToInt32(dataRow["id_usuario_fisico"]),
                NomeCompleto = Convert.ToString(dataRow["nome_completo"]),
                Cpf = Convert.ToChar(dataRow["cpf"]),
                Telefone = Convert.ToString(dataRow["telefone"]),
                Email = Convert.ToString(dataRow["email"]),
                Funcao = Convert.ToString(dataRow["funcao"]),
                TipoContrato = Convert.ToString(dataRow["tipo_contrato"]),
                DataDeNascimento = Convert.ToDateTime(dataRow["data_nascimento"]),
                DataAdmissao = Convert.ToDateTime(dataRow["data_admissao"]),
                Logradouro = Convert.ToString(dataRow["logradouro"]),
                Bairro = Convert.ToString(dataRow["bairro"]),
                FkIdClienteContatante = Convert.ToInt32(dataRow["fk_cliente_contratante_id"])
            };

            return csUsuarioFisico;
        }
    }
}
