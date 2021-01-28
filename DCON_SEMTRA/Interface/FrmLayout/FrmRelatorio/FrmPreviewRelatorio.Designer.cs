namespace Interface.FrmLayout.FrmRelatorio
{
    partial class FrmPreviewRelatorio
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
            this.ReportHoraDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportHoraDia
            // 
            this.ReportHoraDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHoraDia.Location = new System.Drawing.Point(0, 0);
            this.ReportHoraDia.Name = "ReportHoraDia";
            this.ReportHoraDia.ServerReport.BearerToken = null;
            this.ReportHoraDia.Size = new System.Drawing.Size(633, 360);
            this.ReportHoraDia.TabIndex = 0;
            this.ReportHoraDia.Load += new System.EventHandler(this.ReportHoraDia_Load);
            // 
            // FrmPreviewRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 360);
            this.Controls.Add(this.ReportHoraDia);
            this.Name = "FrmPreviewRelatorio";
            this.Text = "FrmPreviewRelatorio";
            this.Load += new System.EventHandler(this.FrmPreviewRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportHoraDia;
    }
}