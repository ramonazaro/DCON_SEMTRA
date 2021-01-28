namespace Interface.FrmLayout
{
    partial class FrmLogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRecuperar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnRecuperar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.pnRecuperar);
            this.panel1.Controls.Add(this.BtnAcessar);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.TxtSenha);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(360, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 294);
            this.panel1.TabIndex = 0;
            // 
            // pnRecuperar
            // 
            this.pnRecuperar.Controls.Add(this.button2);
            this.pnRecuperar.Controls.Add(this.panel4);
            this.pnRecuperar.Controls.Add(this.TxtEmail);
            this.pnRecuperar.Location = new System.Drawing.Point(0, 87);
            this.pnRecuperar.Name = "pnRecuperar";
            this.pnRecuperar.Size = new System.Drawing.Size(333, 207);
            this.pnRecuperar.TabIndex = 31;
            this.pnRecuperar.Visible = false;
            this.pnRecuperar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnRecuperar_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(24, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "RECUPERAR SENHA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(24, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 1);
            this.panel4.TabIndex = 30;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Gray;
            this.TxtEmail.Location = new System.Drawing.Point(24, 60);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(284, 20);
            this.TxtEmail.TabIndex = 29;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.Text = "Digite o seu email.";
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.BtnAcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcessar.FlatAppearance.BorderSize = 0;
            this.BtnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcessar.ForeColor = System.Drawing.Color.Silver;
            this.BtnAcessar.Location = new System.Drawing.Point(24, 210);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(284, 30);
            this.BtnAcessar.TabIndex = 2;
            this.BtnAcessar.Text = "ACESSAR";
            this.BtnAcessar.UseVisualStyleBackColor = false;
            this.BtnAcessar.Click += new System.EventHandler(this.BtnAcessar_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(24, 186);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 1);
            this.panel9.TabIndex = 29;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(24, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 1);
            this.panel8.TabIndex = 28;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.Color.Gray;
            this.TxtSenha.Location = new System.Drawing.Point(24, 161);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(284, 20);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.Text = "Senha";
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            this.TxtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 87);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.Gray;
            this.TxtNome.Location = new System.Drawing.Point(24, 118);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(284, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.Text = "Nome";
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.TxtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(235, 250);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(125, 35);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.Text = "Recuperar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.BtnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogar.FlatAppearance.BorderSize = 0;
            this.BtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogar.ForeColor = System.Drawing.Color.White;
            this.BtnLogar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogar.Image")));
            this.BtnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogar.Location = new System.Drawing.Point(235, 215);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(125, 35);
            this.BtnLogar.TabIndex = 0;
            this.BtnLogar.Text = "Acessar";
            this.BtnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FrmLogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 294);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogar";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnRecuperar.ResumeLayout(false);
            this.pnRecuperar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.Panel pnRecuperar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnAcessar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtNome;
    }
}