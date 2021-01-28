namespace Interface.FrmLayout
{
    partial class FrmConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSaldoBloqueado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSaldoGeral = new System.Windows.Forms.Label();
            this.LblSaldoDisponivel = new System.Windows.Forms.Label();
            this.TableBase = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridOperacaoEfetivar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdOperacaoEfetivar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssinaturaDigital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroOriginario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprovante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEfetivar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtGerenciar = new System.Windows.Forms.Button();
            this.TxtRegistrarFuncionario = new System.Windows.Forms.Button();
            this.TxtRegistrarTransacao = new System.Windows.Forms.Button();
            this.BtnAdiantar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableBase.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.96117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.78641F));
            this.tableLayoutPanel1.Controls.Add(this.LblSaldoBloqueado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblSaldoGeral, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblSaldoDisponivel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblSaldoBloqueado
            // 
            this.LblSaldoBloqueado.AutoSize = true;
            this.LblSaldoBloqueado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaldoBloqueado.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.LblSaldoBloqueado.ForeColor = System.Drawing.Color.Firebrick;
            this.LblSaldoBloqueado.Location = new System.Drawing.Point(177, 30);
            this.LblSaldoBloqueado.Name = "LblSaldoBloqueado";
            this.LblSaldoBloqueado.Size = new System.Drawing.Size(214, 27);
            this.LblSaldoBloqueado.TabIndex = 3;
            this.LblSaldoBloqueado.Text = "R$0,00";
            this.LblSaldoBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo disponivel:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(177, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo bloqueado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(399, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Geral";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSaldoGeral
            // 
            this.LblSaldoGeral.AutoSize = true;
            this.LblSaldoGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaldoGeral.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.LblSaldoGeral.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblSaldoGeral.Location = new System.Drawing.Point(399, 30);
            this.LblSaldoGeral.Name = "LblSaldoGeral";
            this.LblSaldoGeral.Size = new System.Drawing.Size(117, 27);
            this.LblSaldoGeral.TabIndex = 5;
            this.LblSaldoGeral.Text = "R$0,00";
            this.LblSaldoGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSaldoDisponivel
            // 
            this.LblSaldoDisponivel.AutoSize = true;
            this.LblSaldoDisponivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaldoDisponivel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.LblSaldoDisponivel.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblSaldoDisponivel.Location = new System.Drawing.Point(5, 30);
            this.LblSaldoDisponivel.Name = "LblSaldoDisponivel";
            this.LblSaldoDisponivel.Size = new System.Drawing.Size(164, 27);
            this.LblSaldoDisponivel.TabIndex = 2;
            this.LblSaldoDisponivel.Text = "R$0,00";
            this.LblSaldoDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableBase
            // 
            this.TableBase.BackColor = System.Drawing.Color.White;
            this.TableBase.ColumnCount = 1;
            this.TableBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBase.Controls.Add(this.label5, 0, 0);
            this.TableBase.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.TableBase.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.TableBase.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TableBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBase.Location = new System.Drawing.Point(0, 0);
            this.TableBase.Name = "TableBase";
            this.TableBase.RowCount = 5;
            this.TableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TableBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TableBase.Size = new System.Drawing.Size(629, 478);
            this.TableBase.TabIndex = 1;
            this.TableBase.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(222, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Controle Financeiro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DataGridOperacaoEfetivar, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(623, 212);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Resumo financeiro diário:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridOperacaoEfetivar
            // 
            this.DataGridOperacaoEfetivar.AllowUserToAddRows = false;
            this.DataGridOperacaoEfetivar.AllowUserToDeleteRows = false;
            this.DataGridOperacaoEfetivar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridOperacaoEfetivar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridOperacaoEfetivar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridOperacaoEfetivar.BackgroundColor = System.Drawing.Color.White;
            this.DataGridOperacaoEfetivar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOperacaoEfetivar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DataGridOperacaoEfetivar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOperacaoEfetivar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridOperacaoEfetivar.ColumnHeadersHeight = 43;
            this.DataGridOperacaoEfetivar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridOperacaoEfetivar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOperacaoEfetivar,
            this.NumeroDestino,
            this.Senha,
            this.AssinaturaDigital,
            this.SaldoBruto,
            this.Taxa,
            this.FkUsuarioId,
            this.NumeroOriginario,
            this.Comprovante,
            this.SaldoLiquido,
            this.TipoOperacao,
            this.Login,
            this.DataTransacao,
            this.DataEfetivar,
            this.HoraTransacao});
            this.DataGridOperacaoEfetivar.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridOperacaoEfetivar.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridOperacaoEfetivar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridOperacaoEfetivar.EnableHeadersVisualStyles = false;
            this.DataGridOperacaoEfetivar.GridColor = System.Drawing.Color.White;
            this.DataGridOperacaoEfetivar.Location = new System.Drawing.Point(3, 28);
            this.DataGridOperacaoEfetivar.MultiSelect = false;
            this.DataGridOperacaoEfetivar.Name = "DataGridOperacaoEfetivar";
            this.DataGridOperacaoEfetivar.ReadOnly = true;
            this.DataGridOperacaoEfetivar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridOperacaoEfetivar.RowHeadersVisible = false;
            this.DataGridOperacaoEfetivar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridOperacaoEfetivar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOperacaoEfetivar.Size = new System.Drawing.Size(617, 181);
            this.DataGridOperacaoEfetivar.TabIndex = 2;
            this.DataGridOperacaoEfetivar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOperacaoEfetivar_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19101F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.80899F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.3871F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.6129F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(623, 124);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(77, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Acessibilidade";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(387, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Acesso Rapido";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.TxtGerenciar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.TxtRegistrarFuncionario, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TxtRegistrarTransacao, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.BtnAdiantar, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(296, 32);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(324, 89);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(287, 89);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Solicitação de Atendimento";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Configurações da tabela";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IdOperacaoEfetivar
            // 
            this.IdOperacaoEfetivar.DataPropertyName = "IdOperacaoEfetivar";
            this.IdOperacaoEfetivar.HeaderText = "IdOperacaoEfetivar";
            this.IdOperacaoEfetivar.Name = "IdOperacaoEfetivar";
            this.IdOperacaoEfetivar.ReadOnly = true;
            this.IdOperacaoEfetivar.Visible = false;
            // 
            // NumeroDestino
            // 
            this.NumeroDestino.DataPropertyName = "NumeroDestino";
            this.NumeroDestino.HeaderText = "NumeroDestino";
            this.NumeroDestino.Name = "NumeroDestino";
            this.NumeroDestino.ReadOnly = true;
            this.NumeroDestino.Visible = false;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // AssinaturaDigital
            // 
            this.AssinaturaDigital.DataPropertyName = "AssinaturaDigital";
            this.AssinaturaDigital.HeaderText = "AssinaturaDigital";
            this.AssinaturaDigital.Name = "AssinaturaDigital";
            this.AssinaturaDigital.ReadOnly = true;
            this.AssinaturaDigital.Visible = false;
            // 
            // SaldoBruto
            // 
            this.SaldoBruto.DataPropertyName = "SaldoBruto";
            this.SaldoBruto.HeaderText = "SaldoBruto";
            this.SaldoBruto.Name = "SaldoBruto";
            this.SaldoBruto.ReadOnly = true;
            this.SaldoBruto.Visible = false;
            // 
            // Taxa
            // 
            this.Taxa.DataPropertyName = "Taxa";
            this.Taxa.HeaderText = "Taxa";
            this.Taxa.Name = "Taxa";
            this.Taxa.ReadOnly = true;
            this.Taxa.Visible = false;
            // 
            // FkUsuarioId
            // 
            this.FkUsuarioId.DataPropertyName = "FkUsuarioId";
            this.FkUsuarioId.HeaderText = "FkUsuarioId";
            this.FkUsuarioId.Name = "FkUsuarioId";
            this.FkUsuarioId.ReadOnly = true;
            this.FkUsuarioId.Visible = false;
            // 
            // NumeroOriginario
            // 
            this.NumeroOriginario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumeroOriginario.DataPropertyName = "NumeroOriginario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "000,0000,000,000000-0";
            dataGridViewCellStyle3.NullValue = null;
            this.NumeroOriginario.DefaultCellStyle = dataGridViewCellStyle3;
            this.NumeroOriginario.FillWeight = 1F;
            this.NumeroOriginario.HeaderText = "Conta Cliente";
            this.NumeroOriginario.Name = "NumeroOriginario";
            this.NumeroOriginario.ReadOnly = true;
            this.NumeroOriginario.Width = 189;
            // 
            // Comprovante
            // 
            this.Comprovante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Comprovante.DataPropertyName = "Comprovante";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Comprovante.DefaultCellStyle = dataGridViewCellStyle4;
            this.Comprovante.FillWeight = 1F;
            this.Comprovante.HeaderText = "Comprovante";
            this.Comprovante.Name = "Comprovante";
            this.Comprovante.ReadOnly = true;
            this.Comprovante.Width = 149;
            // 
            // SaldoLiquido
            // 
            this.SaldoLiquido.DataPropertyName = "SaldoLiquido";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.SaldoLiquido.DefaultCellStyle = dataGridViewCellStyle5;
            this.SaldoLiquido.FillWeight = 49.37282F;
            this.SaldoLiquido.HeaderText = "Valor";
            this.SaldoLiquido.Name = "SaldoLiquido";
            this.SaldoLiquido.ReadOnly = true;
            // 
            // TipoOperacao
            // 
            this.TipoOperacao.DataPropertyName = "TipoOperacao";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoOperacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.TipoOperacao.FillWeight = 27.41862F;
            this.TipoOperacao.HeaderText = "Tipo";
            this.TipoOperacao.Name = "TipoOperacao";
            this.TipoOperacao.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Login.DefaultCellStyle = dataGridViewCellStyle7;
            this.Login.FillWeight = 55.39514F;
            this.Login.HeaderText = "Funcionário";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // DataTransacao
            // 
            this.DataTransacao.DataPropertyName = "DataTransacao";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = null;
            this.DataTransacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataTransacao.FillWeight = 44.26049F;
            this.DataTransacao.HeaderText = "Data Compra";
            this.DataTransacao.Name = "DataTransacao";
            this.DataTransacao.ReadOnly = true;
            this.DataTransacao.Visible = false;
            // 
            // DataEfetivar
            // 
            this.DataEfetivar.DataPropertyName = "DataEfetivar";
            this.DataEfetivar.FillWeight = 52.80193F;
            this.DataEfetivar.HeaderText = "Data Libera";
            this.DataEfetivar.Name = "DataEfetivar";
            this.DataEfetivar.ReadOnly = true;
            this.DataEfetivar.Visible = false;
            // 
            // HoraTransacao
            // 
            this.HoraTransacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HoraTransacao.DataPropertyName = "HoraTransacao";
            dataGridViewCellStyle9.Format = "t";
            this.HoraTransacao.DefaultCellStyle = dataGridViewCellStyle9;
            this.HoraTransacao.HeaderText = "Hora Compra";
            this.HoraTransacao.MinimumWidth = 60;
            this.HoraTransacao.Name = "HoraTransacao";
            this.HoraTransacao.ReadOnly = true;
            this.HoraTransacao.Width = 60;
            // 
            // TxtGerenciar
            // 
            this.TxtGerenciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TxtGerenciar.BackColor = System.Drawing.Color.White;
            this.TxtGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtGerenciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGerenciar.FlatAppearance.BorderSize = 0;
            this.TxtGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtGerenciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGerenciar.ForeColor = System.Drawing.Color.Black;
            this.TxtGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("TxtGerenciar.Image")));
            this.TxtGerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtGerenciar.Location = new System.Drawing.Point(4, 4);
            this.TxtGerenciar.Name = "TxtGerenciar";
            this.TxtGerenciar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtGerenciar.Size = new System.Drawing.Size(154, 37);
            this.TxtGerenciar.TabIndex = 20;
            this.TxtGerenciar.Text = "Extorno";
            this.TxtGerenciar.UseVisualStyleBackColor = false;
            this.TxtGerenciar.Click += new System.EventHandler(this.TxtGerenciar_Click);
            // 
            // TxtRegistrarFuncionario
            // 
            this.TxtRegistrarFuncionario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TxtRegistrarFuncionario.BackColor = System.Drawing.Color.White;
            this.TxtRegistrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtRegistrarFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegistrarFuncionario.FlatAppearance.BorderSize = 0;
            this.TxtRegistrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRegistrarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistrarFuncionario.ForeColor = System.Drawing.Color.Black;
            this.TxtRegistrarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("TxtRegistrarFuncionario.Image")));
            this.TxtRegistrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtRegistrarFuncionario.Location = new System.Drawing.Point(165, 48);
            this.TxtRegistrarFuncionario.Name = "TxtRegistrarFuncionario";
            this.TxtRegistrarFuncionario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRegistrarFuncionario.Size = new System.Drawing.Size(155, 37);
            this.TxtRegistrarFuncionario.TabIndex = 22;
            this.TxtRegistrarFuncionario.Text = "Funcionario";
            this.TxtRegistrarFuncionario.UseVisualStyleBackColor = false;
            this.TxtRegistrarFuncionario.Click += new System.EventHandler(this.TxtRegistrarFuncionario_Click);
            // 
            // TxtRegistrarTransacao
            // 
            this.TxtRegistrarTransacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TxtRegistrarTransacao.BackColor = System.Drawing.Color.White;
            this.TxtRegistrarTransacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtRegistrarTransacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegistrarTransacao.FlatAppearance.BorderSize = 0;
            this.TxtRegistrarTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRegistrarTransacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistrarTransacao.ForeColor = System.Drawing.Color.Black;
            this.TxtRegistrarTransacao.Image = ((System.Drawing.Image)(resources.GetObject("TxtRegistrarTransacao.Image")));
            this.TxtRegistrarTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtRegistrarTransacao.Location = new System.Drawing.Point(4, 48);
            this.TxtRegistrarTransacao.Name = "TxtRegistrarTransacao";
            this.TxtRegistrarTransacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRegistrarTransacao.Size = new System.Drawing.Size(154, 37);
            this.TxtRegistrarTransacao.TabIndex = 21;
            this.TxtRegistrarTransacao.Text = "Compra";
            this.TxtRegistrarTransacao.UseVisualStyleBackColor = false;
            this.TxtRegistrarTransacao.Click += new System.EventHandler(this.TxtRegistrarTransacao_Click);
            // 
            // BtnAdiantar
            // 
            this.BtnAdiantar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdiantar.BackColor = System.Drawing.Color.White;
            this.BtnAdiantar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdiantar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdiantar.FlatAppearance.BorderSize = 0;
            this.BtnAdiantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdiantar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdiantar.ForeColor = System.Drawing.Color.Black;
            this.BtnAdiantar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdiantar.Image")));
            this.BtnAdiantar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdiantar.Location = new System.Drawing.Point(165, 4);
            this.BtnAdiantar.Name = "BtnAdiantar";
            this.BtnAdiantar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdiantar.Size = new System.Drawing.Size(155, 37);
            this.BtnAdiantar.TabIndex = 23;
            this.BtnAdiantar.Text = "Requisitar";
            this.BtnAdiantar.UseVisualStyleBackColor = false;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 478);
            this.Controls.Add(this.TableBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConta";
            this.Text = "FrmConta";
            this.Load += new System.EventHandler(this.FrmConta_Load);
            this.Shown += new System.EventHandler(this.FrmConta_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TableBase.ResumeLayout(false);
            this.TableBase.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSaldoBloqueado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSaldoDisponivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSaldoGeral;
        private System.Windows.Forms.TableLayoutPanel TableBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button TxtGerenciar;
        private System.Windows.Forms.Button TxtRegistrarTransacao;
        private System.Windows.Forms.Button TxtRegistrarFuncionario;
        private System.Windows.Forms.Button BtnAdiantar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridOperacaoEfetivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacaoEfetivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssinaturaDigital;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUsuarioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroOriginario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprovante;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTransacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEfetivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraTransacao;
    }
}