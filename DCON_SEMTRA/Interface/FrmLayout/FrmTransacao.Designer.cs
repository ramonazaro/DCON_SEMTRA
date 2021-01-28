namespace Interface.FrmLayout
{
    partial class FrmTransacao
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
            this.TableNumeroConta = new System.Windows.Forms.TableLayoutPanel();
            this.MasktextConta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TableTipoOperacao = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDebito = new System.Windows.Forms.Button();
            this.TableValor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnProsseguir = new System.Windows.Forms.Button();
            this.BtnCancelarValor = new System.Windows.Forms.Button();
            this.TableFinalizar = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.TableConfirmar = new System.Windows.Forms.TableLayoutPanel();
            this.LblNomeCLiente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblConta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNumeroConta = new System.Windows.Forms.Label();
            this.LblValorTransa = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancelarTransacao = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TableNumeroConta.SuspendLayout();
            this.TableTipoOperacao.SuspendLayout();
            this.TableValor.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableFinalizar.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TableConfirmar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableNumeroConta
            // 
            this.TableNumeroConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableNumeroConta.ColumnCount = 1;
            this.TableNumeroConta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableNumeroConta.Controls.Add(this.MasktextConta, 0, 1);
            this.TableNumeroConta.Controls.Add(this.label1, 0, 0);
            this.TableNumeroConta.Controls.Add(this.TableTipoOperacao, 0, 2);
            this.TableNumeroConta.Location = new System.Drawing.Point(84, 163);
            this.TableNumeroConta.Name = "TableNumeroConta";
            this.TableNumeroConta.RowCount = 3;
            this.TableNumeroConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableNumeroConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.16901F));
            this.TableNumeroConta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.49765F));
            this.TableNumeroConta.Size = new System.Drawing.Size(477, 187);
            this.TableNumeroConta.TabIndex = 7;
            // 
            // MasktextConta
            // 
            this.MasktextConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MasktextConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasktextConta.Location = new System.Drawing.Point(20, 65);
            this.MasktextConta.Mask = "000,0000,000,000000-0";
            this.MasktextConta.Name = "MasktextConta";
            this.MasktextConta.Size = new System.Drawing.Size(437, 53);
            this.MasktextConta.TabIndex = 0;
            this.MasktextConta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MasktextConta.Click += new System.EventHandler(this.MasktextConta_Click);
            this.MasktextConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MasktextConta_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero da conta";
            // 
            // TableTipoOperacao
            // 
            this.TableTipoOperacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTipoOperacao.ColumnCount = 1;
            this.TableTipoOperacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableTipoOperacao.Controls.Add(this.BtnDebito, 0, 0);
            this.TableTipoOperacao.Location = new System.Drawing.Point(3, 126);
            this.TableTipoOperacao.Name = "TableTipoOperacao";
            this.TableTipoOperacao.RowCount = 1;
            this.TableTipoOperacao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableTipoOperacao.Size = new System.Drawing.Size(471, 49);
            this.TableTipoOperacao.TabIndex = 13;
            // 
            // BtnDebito
            // 
            this.BtnDebito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDebito.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnDebito.FlatAppearance.BorderSize = 0;
            this.BtnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDebito.ForeColor = System.Drawing.Color.White;
            this.BtnDebito.Location = new System.Drawing.Point(17, 4);
            this.BtnDebito.Name = "BtnDebito";
            this.BtnDebito.Size = new System.Drawing.Size(437, 40);
            this.BtnDebito.TabIndex = 0;
            this.BtnDebito.Text = "INICIAR VENDA";
            this.BtnDebito.UseVisualStyleBackColor = false;
            this.BtnDebito.Click += new System.EventHandler(this.BtnDebito_Click);
            // 
            // TableValor
            // 
            this.TableValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableValor.ColumnCount = 1;
            this.TableValor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableValor.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.TableValor.Controls.Add(this.label2, 0, 0);
            this.TableValor.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.TableValor.Location = new System.Drawing.Point(84, 163);
            this.TableValor.Name = "TableValor";
            this.TableValor.RowCount = 3;
            this.TableValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableValor.Size = new System.Drawing.Size(477, 190);
            this.TableValor.TabIndex = 9;
            this.TableValor.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796F));
            this.tableLayoutPanel3.Controls.Add(this.TextValor, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(471, 57);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // TextValor
            // 
            this.TextValor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TextValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextValor.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Underline);
            this.TextValor.HideSelection = false;
            this.TextValor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextValor.Location = new System.Drawing.Point(131, 5);
            this.TextValor.MaxLength = 11;
            this.TextValor.Name = "TextValor";
            this.TextValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextValor.Size = new System.Drawing.Size(209, 46);
            this.TextValor.TabIndex = 13;
            this.TextValor.Text = "R$0,00";
            this.TextValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextValor.Click += new System.EventHandler(this.TextValor_Click);
            this.TextValor.TextChanged += new System.EventHandler(this.TextValor_TextChanged);
            this.TextValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            this.TextValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_valor_KeyUp);
            this.TextValor.Leave += new System.EventHandler(this.txt_valor_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o Valor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnProsseguir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelarValor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 58);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // BtnProsseguir
            // 
            this.BtnProsseguir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnProsseguir.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnProsseguir.FlatAppearance.BorderSize = 0;
            this.BtnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsseguir.ForeColor = System.Drawing.Color.White;
            this.BtnProsseguir.Location = new System.Drawing.Point(48, 9);
            this.BtnProsseguir.Name = "BtnProsseguir";
            this.BtnProsseguir.Size = new System.Drawing.Size(138, 40);
            this.BtnProsseguir.TabIndex = 8;
            this.BtnProsseguir.Text = "PROSSEGUIR";
            this.BtnProsseguir.UseVisualStyleBackColor = false;
            this.BtnProsseguir.Click += new System.EventHandler(this.BtnProsseguir_Click);
            // 
            // BtnCancelarValor
            // 
            this.BtnCancelarValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelarValor.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCancelarValor.FlatAppearance.BorderSize = 0;
            this.BtnCancelarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarValor.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarValor.Location = new System.Drawing.Point(283, 9);
            this.BtnCancelarValor.Name = "BtnCancelarValor";
            this.BtnCancelarValor.Size = new System.Drawing.Size(139, 40);
            this.BtnCancelarValor.TabIndex = 9;
            this.BtnCancelarValor.Text = "CANCELAR";
            this.BtnCancelarValor.UseVisualStyleBackColor = false;
            this.BtnCancelarValor.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableFinalizar
            // 
            this.TableFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableFinalizar.ColumnCount = 1;
            this.TableFinalizar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableFinalizar.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.TableFinalizar.Controls.Add(this.TableConfirmar, 0, 1);
            this.TableFinalizar.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.TableFinalizar.Controls.Add(this.LblConfirmar, 0, 0);
            this.TableFinalizar.Location = new System.Drawing.Point(87, 102);
            this.TableFinalizar.Name = "TableFinalizar";
            this.TableFinalizar.RowCount = 4;
            this.TableFinalizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.TableFinalizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.TableFinalizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.TableFinalizar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableFinalizar.Size = new System.Drawing.Size(473, 316);
            this.TableFinalizar.TabIndex = 12;
            this.TableFinalizar.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxSenha, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 188);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(467, 80);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 49);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha:";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenha.Location = new System.Drawing.Point(257, 13);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(144, 53);
            this.TextBoxSenha.TabIndex = 13;
            this.TextBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSenha_KeyPress);
            // 
            // TableConfirmar
            // 
            this.TableConfirmar.ColumnCount = 2;
            this.TableConfirmar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9743F));
            this.TableConfirmar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0257F));
            this.TableConfirmar.Controls.Add(this.LblNomeCLiente, 1, 0);
            this.TableConfirmar.Controls.Add(this.label3, 0, 0);
            this.TableConfirmar.Controls.Add(this.LblConta, 0, 1);
            this.TableConfirmar.Controls.Add(this.label5, 0, 2);
            this.TableConfirmar.Controls.Add(this.LblNumeroConta, 1, 1);
            this.TableConfirmar.Controls.Add(this.LblValorTransa, 1, 2);
            this.TableConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableConfirmar.Location = new System.Drawing.Point(3, 98);
            this.TableConfirmar.Name = "TableConfirmar";
            this.TableConfirmar.RowCount = 3;
            this.TableConfirmar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableConfirmar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableConfirmar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableConfirmar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableConfirmar.Size = new System.Drawing.Size(467, 84);
            this.TableConfirmar.TabIndex = 11;
            // 
            // LblNomeCLiente
            // 
            this.LblNomeCLiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNomeCLiente.AutoSize = true;
            this.LblNomeCLiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCLiente.Location = new System.Drawing.Point(317, 1);
            this.LblNomeCLiente.Name = "LblNomeCLiente";
            this.LblNomeCLiente.Size = new System.Drawing.Size(0, 25);
            this.LblNomeCLiente.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do cliente:";
            // 
            // LblConta
            // 
            this.LblConta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblConta.AutoSize = true;
            this.LblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConta.Location = new System.Drawing.Point(19, 29);
            this.LblConta.Name = "LblConta";
            this.LblConta.Size = new System.Drawing.Size(145, 25);
            this.LblConta.TabIndex = 6;
            this.LblConta.Text = "Numero Conta:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor da venda:";
            // 
            // LblNumeroConta
            // 
            this.LblNumeroConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNumeroConta.AutoSize = true;
            this.LblNumeroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroConta.Location = new System.Drawing.Point(225, 29);
            this.LblNumeroConta.Name = "LblNumeroConta";
            this.LblNumeroConta.Size = new System.Drawing.Size(183, 25);
            this.LblNumeroConta.TabIndex = 7;
            this.LblNumeroConta.Text = "###.####.######-#";
            // 
            // LblValorTransa
            // 
            this.LblValorTransa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblValorTransa.AutoSize = true;
            this.LblValorTransa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTransa.Location = new System.Drawing.Point(263, 57);
            this.LblValorTransa.Name = "LblValorTransa";
            this.LblValorTransa.Size = new System.Drawing.Size(107, 25);
            this.LblValorTransa.TabIndex = 9;
            this.LblValorTransa.Text = "R$: 000,00";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCancelarTransacao, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnConfirmar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 39);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // BtnCancelarTransacao
            // 
            this.BtnCancelarTransacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelarTransacao.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCancelarTransacao.FlatAppearance.BorderSize = 0;
            this.BtnCancelarTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarTransacao.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarTransacao.Location = new System.Drawing.Point(277, 3);
            this.BtnCancelarTransacao.Name = "BtnCancelarTransacao";
            this.BtnCancelarTransacao.Size = new System.Drawing.Size(145, 33);
            this.BtnCancelarTransacao.TabIndex = 10;
            this.BtnCancelarTransacao.Text = "CANCELAR";
            this.BtnCancelarTransacao.UseVisualStyleBackColor = false;
            this.BtnCancelarTransacao.Click += new System.EventHandler(this.BtnCancelarTransacao_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirmar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnConfirmar.FlatAppearance.BorderSize = 0;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(44, 3);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(145, 33);
            this.BtnConfirmar.TabIndex = 11;
            this.BtnConfirmar.Text = "CONFIRMAR";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.BackColor = System.Drawing.Color.White;
            this.LblConfirmar.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmar.Location = new System.Drawing.Point(57, 23);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(359, 49);
            this.LblConfirmar.TabIndex = 6;
            this.LblConfirmar.Text = "Confirmar Venda";
            // 
            // FrmTransacao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(645, 517);
            this.Controls.Add(this.TableFinalizar);
            this.Controls.Add(this.TableNumeroConta);
            this.Controls.Add(this.TableValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmTransacao";
            this.Load += new System.EventHandler(this.FrmTransacao_Load);
            this.TableNumeroConta.ResumeLayout(false);
            this.TableNumeroConta.PerformLayout();
            this.TableTipoOperacao.ResumeLayout(false);
            this.TableValor.ResumeLayout(false);
            this.TableValor.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TableFinalizar.ResumeLayout(false);
            this.TableFinalizar.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TableConfirmar.ResumeLayout(false);
            this.TableConfirmar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableNumeroConta;
        private System.Windows.Forms.MaskedTextBox MasktextConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TableValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnCancelarValor;
        private System.Windows.Forms.Button BtnProsseguir;
        private System.Windows.Forms.TableLayoutPanel TableFinalizar;
        private System.Windows.Forms.TableLayoutPanel TableConfirmar;
        private System.Windows.Forms.Label LblConta;
        private System.Windows.Forms.Label LblNumeroConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblValorTransa;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnCancelarTransacao;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel TableTipoOperacao;
        private System.Windows.Forms.Button BtnDebito;
        private System.Windows.Forms.TextBox TextValor;
        private System.Windows.Forms.Label LblNomeCLiente;
        private System.Windows.Forms.Label label3;
    }
}