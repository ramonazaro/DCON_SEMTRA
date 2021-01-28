using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objetos;
using Trabalho;

namespace Interface.FrmLayout.FrmSubLayout
{
    public partial class CsGerenciarOperacaoBloqueada : Form
    {
        private CsTrabalhoOperacaoEfetivar csTrabalhoOperacaoEfetivar;
        private CsOperacaoEfetivar csOperacaoEfetivar = new CsOperacaoEfetivar();

        private CsUsuario csUsuario = new CsUsuario();
        private CsListOperacaoEfetivar csListOperacaoEfetivar;
        

        public CsGerenciarOperacaoBloqueada(CsOperacaoEfetivar csOperacaoEfetivar)
        {
            InitializeComponent();
            Preencher(csOperacaoEfetivar);
        }

        #region Buttons


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(TextBoxAssinatura.Text)))
            {
                csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
                PreencherObjetoCsOperacaoEfetivar();
                try
                {
                    csTrabalhoOperacaoEfetivar.InsertOperacaoExtorno(csOperacaoEfetivar);
                    PreparaComprovante();

                    DialogResult dialogResult = MessageBox.Show(" Compra realizada com sucesso! " +
                        "\n Conta Nª:  " + csOperacaoEfetivar.NumeroOriginario +
                        "\n Valor: " + csOperacaoEfetivar.SaldoLiquido +
                        "\n Comprovante Nº: " + csOperacaoEfetivar.Comprovante +
                        "\n \n Deseja emitir comprovante ? ", "Administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                catch (Exception e404)
                {
                    MessageBox.Show(e404.Message);
                }
            }
            else
            {
                PanelAssinatura.Visible = true;
            }
            PanelAssinatura.Visible = false;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void BtnExtornar_Click(object sender, EventArgs e)
        {
            PanelSenha.Visible = true;
            TextSenha.Clear();
            TextSenha.Focus();
            TextBoxAssinatura.Clear();
        }


        private void BtnSeguir_Click(object sender, EventArgs e)
        {
            PanelSenha.Visible = false;
            PanelAssinatura.Visible = true;
            TextBoxAssinatura.Focus();

        }
        #endregion
        private void CsGerenciarOperacaoBloqueada_Load(object sender, EventArgs e)
        {

        }

        private void Preencher(CsOperacaoEfetivar csOperacaoEfetivar)
        {
            this.csOperacaoEfetivar = csOperacaoEfetivar;
            MaskedTextContaCliente.Text = csOperacaoEfetivar.NumeroOriginario.ToString();
            MaskedTextComprovante.Text = csOperacaoEfetivar.Comprovante.ToString();
            MaskedTextValor.Text = "R$ " + csOperacaoEfetivar.SaldoBruto.ToString();
        }
        public void PreparaComprovante()
        {
            /*
            csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
            csListOperacaoEfetivar = new CsListOperacaoEfetivar();
            
            csListOperacaoEfetivar = csTrabalhoOperacaoEfetivar.ProcurarOperacoeEfetivar("  WHERE fk_usuario_id = " + csUsuario.S_IdUsuario + " order by id_operacao_efetivar desc limit 1");

            csOperacaoEfetivar.Comprovante = csListOperacaoEfetivar[0].Comprovante;
            csOperacaoEfetivar.NumeroOriginario = csListOperacaoEfetivar[0].NumeroOriginario;
            csOperacaoEfetivar.SaldoBruto = csListOperacaoEfetivar[0].SaldoBruto;
            */
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PreencherObjetoCsOperacaoEfetivar()
        {
            csOperacaoEfetivar.AssinaturaDigital = TextBoxAssinatura.Text;
            csOperacaoEfetivar.FkUsuarioId = csUsuario.S_IdUsuario;
            csOperacaoEfetivar.Senha = TextSenha.Text;
            csOperacaoEfetivar.TipoOperacao = '4';
        }

        private void TextSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (Char)Keys.Enter)
            {
                BtnSeguir.PerformClick();
            }
        }

        private void TextBoxAssinatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                BtnConfirmar.PerformClick();
            }
        }
    }
}
