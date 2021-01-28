using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Objetos;
using Conexao;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Parametros.ParametrosRelatório
{
    public class CsParametroRelatorioSaldoMes
    {
        private CsBancoDeDados csBancoDeDados;
        private Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes  csListRelatorioSaldoMes;
        private Objetos.ObjetosRelatorio.CsRelatorioSaldoMes csRelatorioSaldoMes;
        private CsUsuario csUsuario;


        public Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes Classe_Selecionar(CommandType commandType, string sqlcommand, bool mesAtual)
        {
            // Objetos
            csBancoDeDados = CsBancoDeDados.GetCsBancoDeDados();
            csRelatorioSaldoMes = new Objetos.ObjetosRelatorio.CsRelatorioSaldoMes();
            csListRelatorioSaldoMes = new Objetos.ObjetosRelatorio.CsListRelatorioSaldoMes();
            csUsuario = new CsUsuario();
            // Limpa e adiciona parametros;
            csBancoDeDados.ParametroColecao_Clear();
            csBancoDeDados.ParametroColecao_Add("@MesAtual", NpgsqlDbType.Boolean, mesAtual);
            csBancoDeDados.ParametroColecao_Add("@FkIdConta", NpgsqlDbType.Bigint, csUsuario.S_FkContaId);
            // Preenche o objeto DataTable
            DataTable dataTable = csBancoDeDados.ExecuteCommandConsult(CommandType.Text, sqlcommand);
            // Preenche a lista
            foreach (DataRow line in dataTable.Rows)
            {
                csListRelatorioSaldoMes.Add(csRelatorioSaldoMes.DataGridView_Set(line));
            }
            return csListRelatorioSaldoMes;
        }

    }
}
