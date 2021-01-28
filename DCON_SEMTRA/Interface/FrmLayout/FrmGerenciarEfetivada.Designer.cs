namespace Interface
{
    partial class FrmGerenciarEfetivada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.DataGridOperacaoEfetivar = new System.Windows.Forms.DataGridView();
            this.IdOperacaoEfetivada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPesquisar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnPesquisar.FlatAppearance.BorderSize = 0;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Location = new System.Drawing.Point(518, 4);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(102, 29);
            this.BtnPesquisar.TabIndex = 12;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // DataGridOperacaoEfetivar
            // 
            this.DataGridOperacaoEfetivar.AllowUserToAddRows = false;
            this.DataGridOperacaoEfetivar.AllowUserToDeleteRows = false;
            this.DataGridOperacaoEfetivar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridOperacaoEfetivar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridOperacaoEfetivar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridOperacaoEfetivar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOperacaoEfetivar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOperacaoEfetivar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridOperacaoEfetivar.ColumnHeadersHeight = 43;
            this.DataGridOperacaoEfetivar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridOperacaoEfetivar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOperacaoEfetivada,
            this.finalizada,
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
            this.DataEfetivar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridOperacaoEfetivar.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridOperacaoEfetivar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridOperacaoEfetivar.Location = new System.Drawing.Point(3, 47);
            this.DataGridOperacaoEfetivar.MultiSelect = false;
            this.DataGridOperacaoEfetivar.Name = "DataGridOperacaoEfetivar";
            this.DataGridOperacaoEfetivar.ReadOnly = true;
            this.DataGridOperacaoEfetivar.RowHeadersVisible = false;
            this.DataGridOperacaoEfetivar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridOperacaoEfetivar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOperacaoEfetivar.Size = new System.Drawing.Size(623, 403);
            this.DataGridOperacaoEfetivar.TabIndex = 0;
            // 
            // IdOperacaoEfetivada
            // 
            this.IdOperacaoEfetivada.DataPropertyName = "IdOperacaoEfetivada";
            this.IdOperacaoEfetivada.HeaderText = "IdOperacaoEfetivada";
            this.IdOperacaoEfetivada.Name = "IdOperacaoEfetivada";
            this.IdOperacaoEfetivada.ReadOnly = true;
            this.IdOperacaoEfetivada.Visible = false;
            // 
            // finalizada
            // 
            this.finalizada.DataPropertyName = "Finalizada";
            this.finalizada.HeaderText = "finalizada";
            this.finalizada.Name = "finalizada";
            this.finalizada.ReadOnly = true;
            this.finalizada.Visible = false;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.DataTransacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataTransacao.FillWeight = 44.26049F;
            this.DataTransacao.HeaderText = "Data Transação";
            this.DataTransacao.Name = "DataTransacao";
            this.DataTransacao.ReadOnly = true;
            this.DataTransacao.Visible = false;
            // 
            // DataEfetivar
            // 
            this.DataEfetivar.DataPropertyName = "DataEfetivar";
            this.DataEfetivar.FillWeight = 52.80193F;
            this.DataEfetivar.HeaderText = "Data Execução";
            this.DataEfetivar.Name = "DataEfetivar";
            this.DataEfetivar.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.TxtBoxPesquisa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnPesquisar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TxtBoxPesquisa
            // 
            this.TxtBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisa.Location = new System.Drawing.Point(3, 4);
            this.TxtBoxPesquisa.Name = "TxtBoxPesquisa";
            this.TxtBoxPesquisa.Size = new System.Drawing.Size(509, 30);
            this.TxtBoxPesquisa.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridOperacaoEfetivar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.205021F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.56485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.125456F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 478);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FrmGerenciarEfetivada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarEfetivada";
            this.Text = "FrmGerenciarEfetivada";
            this.Shown += new System.EventHandler(this.FrmGerenciarEfetivada_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOperacaoEfetivar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView DataGridOperacaoEfetivar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtBoxPesquisa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacaoEfetivada;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalizada;
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
    }
}