namespace Interface.FrmLayout.FrmSubLayout
{
    partial class CsGerenciarOperacaoBloqueada
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
            this.BtnExtornar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.LblContaOriginaria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskedTextContaCliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskedTextComprovante = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextValor = new System.Windows.Forms.MaskedTextBox();
            this.PanelAssinatura = new System.Windows.Forms.TableLayoutPanel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TextBoxAssinatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelSenha = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSeguir = new System.Windows.Forms.Button();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelAssinatura.SuspendLayout();
            this.PanelSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExtornar
            // 
            this.BtnExtornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtornar.Location = new System.Drawing.Point(338, 121);
            this.BtnExtornar.Name = "BtnExtornar";
            this.BtnExtornar.Size = new System.Drawing.Size(75, 38);
            this.BtnExtornar.TabIndex = 0;
            this.BtnExtornar.Text = "Extornar";
            this.BtnExtornar.UseVisualStyleBackColor = true;
            this.BtnExtornar.Click += new System.EventHandler(this.BtnExtornar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(23, 121);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 38);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LblContaOriginaria
            // 
            this.LblContaOriginaria.AutoSize = true;
            this.LblContaOriginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContaOriginaria.Location = new System.Drawing.Point(13, 15);
            this.LblContaOriginaria.Name = "LblContaOriginaria";
            this.LblContaOriginaria.Size = new System.Drawing.Size(148, 25);
            this.LblContaOriginaria.TabIndex = 4;
            this.LblContaOriginaria.Text = "Conta Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Compra:";
            // 
            // MaskedTextContaCliente
            // 
            this.MaskedTextContaCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskedTextContaCliente.Enabled = false;
            this.MaskedTextContaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextContaCliente.Location = new System.Drawing.Point(167, 9);
            this.MaskedTextContaCliente.Mask = "000,0000,000,000000-0";
            this.MaskedTextContaCliente.Name = "MaskedTextContaCliente";
            this.MaskedTextContaCliente.Size = new System.Drawing.Size(246, 31);
            this.MaskedTextContaCliente.TabIndex = 9;
            this.MaskedTextContaCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comprovante:";
            // 
            // MaskedTextComprovante
            // 
            this.MaskedTextComprovante.Enabled = false;
            this.MaskedTextComprovante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextComprovante.Location = new System.Drawing.Point(167, 46);
            this.MaskedTextComprovante.Name = "MaskedTextComprovante";
            this.MaskedTextComprovante.Size = new System.Drawing.Size(246, 31);
            this.MaskedTextComprovante.TabIndex = 11;
            // 
            // MaskedTextValor
            // 
            this.MaskedTextValor.Enabled = false;
            this.MaskedTextValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextValor.Location = new System.Drawing.Point(167, 83);
            this.MaskedTextValor.Name = "MaskedTextValor";
            this.MaskedTextValor.Size = new System.Drawing.Size(121, 31);
            this.MaskedTextValor.TabIndex = 12;
            // 
            // PanelAssinatura
            // 
            this.PanelAssinatura.ColumnCount = 3;
            this.PanelAssinatura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.13184F));
            this.PanelAssinatura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.86817F));
            this.PanelAssinatura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.PanelAssinatura.Controls.Add(this.BtnConfirmar, 2, 0);
            this.PanelAssinatura.Controls.Add(this.TextBoxAssinatura, 1, 0);
            this.PanelAssinatura.Controls.Add(this.label2, 0, 0);
            this.PanelAssinatura.Location = new System.Drawing.Point(7, 9);
            this.PanelAssinatura.Name = "PanelAssinatura";
            this.PanelAssinatura.RowCount = 1;
            this.PanelAssinatura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelAssinatura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.PanelAssinatura.Size = new System.Drawing.Size(418, 161);
            this.PanelAssinatura.TabIndex = 13;
            this.PanelAssinatura.Visible = false;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(312, 65);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(83, 31);
            this.BtnConfirmar.TabIndex = 14;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TextBoxAssinatura
            // 
            this.TextBoxAssinatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxAssinatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TextBoxAssinatura.Location = new System.Drawing.Point(203, 65);
            this.TextBoxAssinatura.MaxLength = 6;
            this.TextBoxAssinatura.Name = "TextBoxAssinatura";
            this.TextBoxAssinatura.PasswordChar = '*';
            this.TextBoxAssinatura.Size = new System.Drawing.Size(83, 31);
            this.TextBoxAssinatura.TabIndex = 0;
            this.TextBoxAssinatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxAssinatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAssinatura_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Assinatura digital:";
            // 
            // PanelSenha
            // 
            this.PanelSenha.ColumnCount = 3;
            this.PanelSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.09524F));
            this.PanelSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.90476F));
            this.PanelSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.PanelSenha.Controls.Add(this.BtnSeguir, 2, 0);
            this.PanelSenha.Controls.Add(this.TextSenha, 1, 0);
            this.PanelSenha.Controls.Add(this.label4, 0, 0);
            this.PanelSenha.Location = new System.Drawing.Point(7, 9);
            this.PanelSenha.Name = "PanelSenha";
            this.PanelSenha.RowCount = 1;
            this.PanelSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelSenha.Size = new System.Drawing.Size(417, 150);
            this.PanelSenha.TabIndex = 14;
            this.PanelSenha.Visible = false;
            // 
            // BtnSeguir
            // 
            this.BtnSeguir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSeguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeguir.Location = new System.Drawing.Point(291, 59);
            this.BtnSeguir.Name = "BtnSeguir";
            this.BtnSeguir.Size = new System.Drawing.Size(83, 31);
            this.BtnSeguir.TabIndex = 14;
            this.BtnSeguir.Text = ">";
            this.BtnSeguir.UseVisualStyleBackColor = true;
            this.BtnSeguir.Click += new System.EventHandler(this.BtnSeguir_Click);
            // 
            // TextSenha
            // 
            this.TextSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TextSenha.Location = new System.Drawing.Point(160, 59);
            this.TextSenha.MaxLength = 4;
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(84, 31);
            this.TextSenha.TabIndex = 0;
            this.TextSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextSenha.TextChanged += new System.EventHandler(this.TextSenha_TextChanged);
            this.TextSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSenha_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            // 
            // CsGerenciarOperacaoBloqueada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 175);
            this.Controls.Add(this.PanelAssinatura);
            this.Controls.Add(this.PanelSenha);
            this.Controls.Add(this.MaskedTextValor);
            this.Controls.Add(this.MaskedTextComprovante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskedTextContaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblContaOriginaria);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExtornar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CsGerenciarOperacaoBloqueada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMARKET - INFORMAÇÕES";
            this.Load += new System.EventHandler(this.CsGerenciarOperacaoBloqueada_Load);
            this.PanelAssinatura.ResumeLayout(false);
            this.PanelAssinatura.PerformLayout();
            this.PanelSenha.ResumeLayout(false);
            this.PanelSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExtornar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label LblContaOriginaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MaskedTextContaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskedTextComprovante;
        private System.Windows.Forms.MaskedTextBox MaskedTextValor;
        private System.Windows.Forms.TableLayoutPanel PanelAssinatura;
        private System.Windows.Forms.TextBox TextBoxAssinatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TableLayoutPanel PanelSenha;
        private System.Windows.Forms.Button BtnSeguir;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.Label label4;
    }
}