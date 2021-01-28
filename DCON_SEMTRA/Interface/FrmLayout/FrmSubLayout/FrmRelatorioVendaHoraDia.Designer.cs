namespace Interface.FrmLayout.FrmSubLayout
{
    partial class FrmRelatorioVendaHoraDia
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.DateInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Periodo Inicial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.05166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.94834F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateInicio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateFinal, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 96);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Periodo Final:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateInicio
            // 
            this.DateInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicio.CustomFormat = "dd/M/";
            this.DateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicio.Location = new System.Drawing.Point(181, 14);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(87, 20);
            this.DateInicio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Periodo Inicial:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateFinal
            // 
            this.DateFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.CustomFormat = "dd/M/";
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(181, 62);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(87, 20);
            this.DateFinal.TabIndex = 6;
            // 
            // BtnGerar
            // 
            this.BtnGerar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.Location = new System.Drawing.Point(11, 138);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(271, 37);
            this.BtnGerar.TabIndex = 8;
            this.BtnGerar.Text = "Gerar Relatório";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // FrmRelatorioVendaHoraDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRelatorioVendaHoraDia";
            this.ShowIcon = false;
            this.Text = "IMARKET";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Button BtnGerar;
    }
}