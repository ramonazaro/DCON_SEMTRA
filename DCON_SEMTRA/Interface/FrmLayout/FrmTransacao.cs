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

namespace Interface.FrmLayout
{
    public partial class FrmTransacao : Form
    {
        private CsConta csConta;
        private CsUsuario csUsuario;
        private CsTrabalhoConta csTrabalhoConta;
        private CsOperacaoEfetivar csOperacaoEfetivar;
        private CsTrabalhoOperacaoEfetivar csTrabalhoOperacaoEfetivar;
        private CsListOperacaoEfetivar csListCsOperacaoEfetivar;

        // Operação
        private long numeroOriginario;
        private long numeroDestino;
        private long fkUsuarioId;
        private decimal valor_operacao;
        private string senha;
        private char tipoOperacao;
        private string nomeCliente;
        // Comprovante
        private long Comprovate;


        public FrmTransacao()
        {
            InitializeComponent();
        }

        #region Buttons        
        private void BtnProsseguir_Click(object sender, EventArgs e)
        {
            LblValorTransa.Text = TextValor.Text;

            valor_operacao = Convert.ToDecimal(TextValor.Text.Substring(2));

            TableValor.Visible = false;
            TableFinalizar.Visible = true;

            TextBoxSenha.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableNumeroConta.Visible = true;
            TableValor.Visible = false;
            
        }

        private void BtnCancelarTransacao_Click(object sender, EventArgs e)
        {
            TableFinalizar.Visible = false;
            TableNumeroConta.Visible = true;

            LimparCampos();
        }
        
        private void BtnDebito_Click(object sender, EventArgs e)
        {
            VerificarDadosConta('1');
            LblNomeCLiente.Text = nomeCliente;
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            senha = TextBoxSenha.Text;

            ExecutarOperacao();

            TableFinalizar.Visible = false;
            TableNumeroConta.Visible = true;

            LimparCampos();
        }
        #endregion



        private bool Autentica_Conta()
        {
            csConta = new CsConta();
            csUsuario = new CsUsuario();
            csTrabalhoConta = new CsTrabalhoConta();
            
            // Verifica se a conta do cliente é valida
            csConta.Numero = Convert.ToInt64(MasktextConta.Text);
            long idContaOriginaria = csTrabalhoConta.Conta_Autentica(csConta);

            if (idContaOriginaria > 0 )
            {
                csConta.IdConta = idContaOriginaria;
                csConta = csTrabalhoConta.Conta_Select_Numero(csConta);
                nomeCliente = csTrabalhoConta.Conta_Select_Nome(csConta);
                MessageBox.Show("Cliente: " + nomeCliente, "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Busca o numero da conta empresa e preenche destino
                csConta.IdConta = csUsuario.S_FkContaId;
                csConta = csTrabalhoConta.Conta_Select_Numero(csConta);
                numeroDestino = csConta.Numero;

                fkUsuarioId = csUsuario.S_IdUsuario;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void VerificarDadosConta(char tipo_operacao)
        {
            if (!(String.IsNullOrWhiteSpace(MasktextConta.Text)) && MasktextConta.Text.Count() == 17)
            {
                if (Autentica_Conta())
                {
                    LblNumeroConta.Text = MasktextConta.Text;
                    numeroOriginario = Convert.ToInt64(MasktextConta.Text);
                    tipoOperacao = tipo_operacao;

                    TableNumeroConta.Visible = false;
                    TableValor.Visible = true;

                    TextValor.Focus();
                    TextValor.SelectionStart = TextValor.TextLength;
                }
                else
                {
                    MessageBox.Show("Informe um número válido.", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                MasktextConta.Clear();
            }
            else
            {
                MessageBox.Show("Verifique a quantidade de digitos da conta informada.", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void PreparaComprovante()
        {
            csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
            csListCsOperacaoEfetivar = new CsListOperacaoEfetivar();

            csListCsOperacaoEfetivar = csTrabalhoOperacaoEfetivar.ProcurarOperacoeEfetivar("  WHERE fk_usuario_id = "  + fkUsuarioId + " order by id_operacao_efetivar desc limit 1");
            
            Comprovate = Convert.ToInt64(csListCsOperacaoEfetivar[0].Comprovante);
            numeroOriginario = csListCsOperacaoEfetivar[0].NumeroOriginario;
            valor_operacao = csListCsOperacaoEfetivar[0].SaldoBruto;
        }

        private void ExecutarOperacao()
        {
            csOperacaoEfetivar = new CsOperacaoEfetivar
            {
                NumeroOriginario = numeroOriginario,
                NumeroDestino = numeroDestino,
                Senha = senha,
                AssinaturaDigital = "000000",
                SaldoBruto = valor_operacao,
                DataTransacao = DateTime.Now.Date,
                TipoOperacao = tipoOperacao,
                FkUsuarioId = fkUsuarioId
            };

             csTrabalhoOperacaoEfetivar = new CsTrabalhoOperacaoEfetivar();
            try
            {
                csTrabalhoOperacaoEfetivar.InsertOperacaoEfetivar(csOperacaoEfetivar);

                PreparaComprovante();

                DialogResult dialogResult = MessageBox.Show(" Compra realizada com sucesso! " +
                    "\n Conta Nª:  " + numeroOriginario +
                    "\n Valor: " + valor_operacao +
                    "\n Comprovante Nº: " + Comprovate +
                    "\n \n Deseja emitir comprovante ? ", "Administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if(dialogResult == DialogResult.Yes)
                {

                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LimparCampos()
        {
            LblNumeroConta.Text = "R$0,00";
            LblValorTransa.Text = String.Empty;
            TextBoxSenha.Clear();
            TextValor.Text = "R$0,00";
        }
        
        #region ValorMonetarioParaTextValor
        string valor;
        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                BtnProsseguir.PerformClick();
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Delete)
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                    {
                        if (e.KeyChar == ',')
                        {
                            e.Handled = (TextValor.Text.Contains(","));
                        }
                        else
                            e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            valor = TextValor.Text.Replace("R$", "");
            TextValor.Text = string.Format("{0:C}", Convert.ToDecimal(valor));
        }

        private void txt_valor_KeyUp(object sender, KeyEventArgs e)
        {
            valor = TextValor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                TextValor.Text = "0,0" + valor;
            }
            if (valor.Length == 1)
            {
                TextValor.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                TextValor.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (TextValor.Text.StartsWith("0,"))
                {
                    TextValor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (TextValor.Text.Contains("00,"))
                {
                    TextValor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    TextValor.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = TextValor.Text;
            TextValor.Text = string.Format("{0:C}", Convert.ToDecimal(valor));
            TextValor.Select(TextValor.Text.Length, 0);
        }
        #endregion

        private void MasktextConta_Click(object sender, EventArgs e)
        {
            MasktextConta.SelectionStart = 0;
        }

        private void TextValor_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextValor_Click(object sender, EventArgs e)
        {
            TextValor.SelectionStart = MasktextConta.TextLength;
        }

        private void FrmTransacao_Load(object sender, EventArgs e)
        {
            MasktextConta.Focus();
        }

        private void MasktextConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                BtnDebito.PerformClick();
            }
        }

        private void TextBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                BtnConfirmar.PerformClick();
            }
            else
            {
                if (TextBoxSenha.Text.Length > 4)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
