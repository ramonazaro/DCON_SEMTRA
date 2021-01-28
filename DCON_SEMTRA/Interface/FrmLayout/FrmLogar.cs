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
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
        }
        #region Botões
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            BtnLogar.BackColor = Color.FromArgb(12, 30, 67);
            BtnRegistrar.BackColor = Color.Transparent;
            pnRecuperar.Visible = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            BtnLogar.BackColor = Color.Transparent;
            BtnRegistrar.BackColor = Color.FromArgb(12, 30, 67);
            pnRecuperar.Visible = true;
        }
        
        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();

            if (Autenticar_Usuario())
            {
                frmHome.Show();
                this.Visible = false;
            }
        }

        #endregion

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void PnRecuperar_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool Autenticar_Usuario()
        {
            // Objetos
            CsTrabalhoUsuario csTrabalhoUsuario = new CsTrabalhoUsuario();
            CsListUsuario csListUsuario = new CsListUsuario();
            CsUsuario csUsuario = new CsUsuario();
            
            csUsuario.Login = TxtNome.Text;

            if (!(TxtSenha.Text.Length > 4))
            { 
                csUsuario.Senha = TxtSenha.Text;
                // Preenche a lista de usuário
                if( csTrabalhoUsuario.Usuario_Autentica(csUsuario))
                {
                    if (csUsuario.S_TipoUsuario == 'c')
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Somente usuários conveniados podem ter acesso.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretas");
                    return false;
                }
            }
            return false;

        }
        
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #region TxtEnter/TxtLeave
        private void TxtOperations_enter(TextBox u_textBox, string u_text)
        {
            if (u_textBox.Equals(u_textBox))
            {
                u_textBox.Text = "";
                u_textBox.ForeColor = Color.Silver;
            }
        }
        private void TxtOperations_leave(TextBox u_textBox, string u_text)
        {
            if (String.IsNullOrEmpty(u_textBox.Text))
            {
                u_textBox.Text = u_text;
                u_textBox.ForeColor = Color.Gray;
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                BtnAcessar.PerformClick();
            }
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            TxtOperations_enter(TxtNome, "Nome");
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            TxtOperations_leave(TxtNome, "Nome");
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtOperations_enter(TxtSenha, "Senha");
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            TxtOperations_leave(TxtSenha, "Senha");
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            TxtOperations_enter(TxtEmail, "Digite o seu email.");
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            TxtOperations_leave(TxtEmail, "Digite o seu email.");
        }
        #endregion
    }
}
