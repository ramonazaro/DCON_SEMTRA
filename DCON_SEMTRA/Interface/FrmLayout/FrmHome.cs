using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Objetos;


namespace Interface.FrmLayout
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();

            AbrirForm(new FrmConta(this));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsgm, int wParam, int Iparm);

        private void Minimize_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            TxtVisibleFalse();
            TxtRegistrarTransacao.Visible = true;
            TxtRegistrarFuncionario.Visible = true;

            TxtRegistrarTransacao.PerformClick();

            MouseClick(Register.Location.Y);
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            TxtVisibleFalse();
            MouseClick(Manage.Location.Y);

            TxtGerenciarTransacoes.Visible = true;
            TxtGerenciarExtorno.Visible = true;
            TxtSolicitarDesbloqueioSaldo.Visible = true;

            TxtGerenciarTransacoes.PerformClick();
        }

        public void Service_Click(object sender, EventArgs e)
        {
            TxtVisibleFalse();
            MouseClick(Service.Location.Y);
            TxtControle.Visible = true;

            AbrirForm(new FrmConta(this));
        }

        private void Report_Click(object sender, EventArgs e)
        {
            TxtVisibleFalse();
            MouseClick(Report.Location.Y);
            FrmSubLayout.FrmRelatorioVendaHoraDia frmRelatorioVendaHoraDia = new FrmSubLayout.FrmRelatorioVendaHoraDia();
            frmRelatorioVendaHoraDia.Show();
        }

        public void TxtVisibleFalse()
        {
            TxtRegistrarFuncionario.Visible = false;
            TxtRegistrarTransacao.Visible = false;
            TxtGerenciarExtorno.Visible = false;
            TxtGerenciarTransacoes.Visible = false;
            TxtControle.Visible = false;
            TxtSolicitarDesbloqueioSaldo.Visible = false;
        }


        #region Methods Operations
        private void MouseEnter(int location)
        {
            Point point = new Point(5, location);
            PanelMouseEnter.Location = point;
            PanelMouseEnter.Visible = true;
        }
        private void MouseLeave()
        {
            PanelMouseEnter.Visible = false;
        }
        private void MouseClick(int location)
        {

            Point point = new Point(5, location);
            PanelMouseClick.Location = point;
            PanelMouseClick.Visible = true;
        }
        #endregion

        private void PictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PictureMinimize.Visible = true;
        }

        private void PictureHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PictureMinimize.Visible = false;
        }

        private void TimerActualHour_Tick(object sender, EventArgs e)
        {
            LblActualHour.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirForm(object Formulario)
        {
            if (PnConteiner.Controls.Count > 0)
            {
                PnConteiner.Controls.RemoveAt(0);
            }
            Form form = Formulario as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PnConteiner.Controls.Add(form);
            this.PnConteiner.Tag = form;
            form.Show();
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerMenuHide_Tick(object sender, EventArgs e)
        {
            bool hide = false;

            if (hide == true)
            {
                MessageBox.Show("true");
            }
            else
            {
                for (int i = 155; i <= 64; i--)
                {
                    Menu.Width--;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTitleDCON_Click(object sender, EventArgs e)
        {
        }



        #region Visual Buttons

     
        private void TxtRegistrarTransacao_Click(object sender, EventArgs e)
        {
            TxtRegistrarTransacao.BackColor = Color.White;
            TxtRegistrarFuncionario.BackColor = Color.Silver;

            AbrirForm(new FrmTransacao());
        }

        private void TxtRegistrarFuncionario_Click(object sender, EventArgs e)
        {
            TxtRegistrarTransacao.BackColor = Color.Silver;
            TxtRegistrarFuncionario.BackColor = Color.White;

            AbrirForm(new FrmFuncionario());
        }


        private void TxtGerenciarTransações_Click(object sender, EventArgs e)
        {
            TxtGerenciarTransacoes.BackColor = Color.White;
            TxtGerenciarExtorno.BackColor = Color.Silver;
            TxtSolicitarDesbloqueioSaldo.BackColor = Color.Silver;

            AbrirForm(new FrmGerenciar());
        }

        private void TxtGerenciarExtorno_Click(object sender, EventArgs e)
        {
            TxtGerenciarExtorno.BackColor = Color.White;
            TxtGerenciarTransacoes.BackColor = Color.Silver;
            TxtSolicitarDesbloqueioSaldo.BackColor = Color.Silver;

            AbrirForm(new FrmGerenciarEfetivada());
        }

        private void BtnSolicitarDesbloqueioSaldo_Click(object sender, EventArgs e)
        {
            TxtSolicitarDesbloqueioSaldo.BackColor = Color.White;
            TxtGerenciarExtorno.BackColor = Color.Silver;
            TxtGerenciarTransacoes.BackColor = Color.Silver;

            AbrirForm(new FrmRequisitar());
        }


        private void Manage_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(Manage.Location.Y);
        }

        private void Manage_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave();
        }
        private void Service_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(Service.Location.Y);
        }

        private void Service_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave();
        }

        private void Report_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(Report.Location.Y);
        }

        private void Report_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave();
        }

        private void Register_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(Register.Location.Y);
        }

        private void Register_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave();
        }
        #endregion

        #region AcessoRapidoConta
        public void AcessoRapidoExtorno()
        {
            Manage.PerformClick();
        }
        public void AcessoRapidoTransacao()
        {
            Register.PerformClick();
        }
        public void AcessoRapidoFuncionario()
        {
            Register.PerformClick();
            TxtRegistrarFuncionario.PerformClick();
        }
        public void AcessoRapidoRequisitar()
        {
            Manage.PerformClick();
            TxtSolicitarDesbloqueioSaldo.PerformClick();
        }
        #endregion

        private void PnControleBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnControleBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
