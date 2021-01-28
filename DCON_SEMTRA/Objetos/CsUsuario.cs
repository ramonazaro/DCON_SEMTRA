using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class CsUsuario
    {

        public long IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public DateTime DataCriado { get; set; }

        public char NivelAcesso { get; set; }
        public bool Status { get; set; }
        public char TipoUsuario { get; set; }

        public long FkUsuarioTipoId { get; set; }
        public long FkContaId { get; set; }

        // staticas
        private static char _NivelAcesso;
        private static char _TipoUsuario;
        private static long _FkContaId;
        private static long _IdUsuario;

        public char S_TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        public char S_NivelAcesso { get => _NivelAcesso; set => _NivelAcesso = value; }
        public long S_FkContaId { get => _FkContaId; set => _FkContaId = value; }

        public long S_IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        public CsUsuario CsUsuarioDataGridView(System.Data.DataRow dataRow)
        {
            CsUsuario csUsuario = new CsUsuario
            {
                IdUsuario = Convert.ToInt64(dataRow["id_usuario"]),
                Login = Convert.ToString(dataRow["login"]),
                Senha = Convert.ToString(dataRow["senha"]),
                DataCriado = Convert.ToDateTime(dataRow["data_criado"]),
                NivelAcesso = Convert.ToChar(dataRow["nivel_acesso"]),
                Status = Convert.ToBoolean(dataRow["status"]),
                TipoUsuario = Convert.ToChar(dataRow["tipo_usuario"]),
                FkUsuarioTipoId = Convert.ToInt64(dataRow["fk_usuario_tipo_id"]),
                FkContaId = Convert.ToInt64(dataRow["fk_conta_id"])
            };
            return csUsuario;
        }

        public void PreencherUsuario(char u_NivelAcesso, char u_TipoUsuario, long u_FkContaId, long u_IdUsuario)
        {
            _NivelAcesso = u_NivelAcesso;
            _TipoUsuario = u_TipoUsuario;
            _FkContaId = u_FkContaId;
            _IdUsuario = u_IdUsuario;
        }

    }
}
