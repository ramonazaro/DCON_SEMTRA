namespace Interface.FrmLayout.FrmSubLayout
{
    partial class FrmConfirmarRequisicao
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridOperacaoEfetivar = new System.Windows.Forms.DataGridView();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TextBoxAssinatura = new System.Windows.Forms.TextBox();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataGridOperacaoEfetivar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.19847F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.80153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirmar dados";
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
            this.DataGridOperacaoEfetivar.Location = new System.Drawing.Point(3, 147);
            this.DataGridOperacaoEfetivar.MultiSelect = false;
            this.DataGridOperacaoEfetivar.Name = "DataGridOperacaoEfetivar";
            this.DataGridOperacaoEfetivar.ReadOnly = true;
            this.DataGridOperacaoEfetivar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridOperacaoEfetivar.RowHeadersVisible = false;
            this.DataGridOperacaoEfetivar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridOperacaoEfetivar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOperacaoEfetivar.Size = new System.Drawing.Size(664, 419);
            this.DataGridOperacaoEfetivar.TabIndex = 3;
            this.DataGridOperacaoEfetivar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOperacaoEfetivar_CellContentClick);
            this.DataGridOperacaoEfetivar.DoubleClick += new System.EventHandler(this.DataGridOperacaoEfetivar_DoubleClick);
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(193, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contas referentes a 00/00/0000";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.94175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.05825F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnConfirmar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxAssinatura, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextSenha, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 43);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assinatura digital:";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(535, 6);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(107, 31);
            this.BtnConfirmar.TabIndex = 15;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TextBoxAssinatura
            // 
            this.TextBoxAssinatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxAssinatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TextBoxAssinatura.Location = new System.Drawing.Point(415, 6);
            this.TextBoxAssinatura.Name = "TextBoxAssinatura";
            this.TextBoxAssinatura.PasswordChar = '*';
            this.TextBoxAssinatura.Size = new System.Drawing.Size(83, 31);
            this.TextBoxAssinatura.TabIndex = 16;
            this.TextBoxAssinatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextSenha
            // 
            this.TextSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TextSenha.Location = new System.Drawing.Point(114, 6);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(84, 31);
            this.TextSenha.TabIndex = 17;
            this.TextSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmConfirmarRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConfirmarRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmarRequisicao";
            this.Load += new System.EventHandler(this.FrmConfirmarRequisicao_Load);
            this.Shown += new System.EventHandler(this.FrmConfirmarRequisicao_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TextBoxAssinatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextSenha;
    }
}