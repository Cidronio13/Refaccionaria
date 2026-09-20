namespace Refaccionaria
{
    partial class Reporte_Pedido
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.DtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Refaccionaria.ReportVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 394);
            this.reportViewer1.TabIndex = 5;
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(7, 25);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(200, 20);
            this.DtFecha.TabIndex = 4;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(451, 22);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerar.TabIndex = 3;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // DtFechaFinal
            // 
            this.DtFechaFinal.Location = new System.Drawing.Point(224, 25);
            this.DtFechaFinal.Name = "DtFechaFinal";
            this.DtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtFechaFinal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Inicial";
            // 
            // Reporte_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.BtnGenerar);
            this.Name = "Reporte_Pedido";
            this.Text = "Reporte_Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.DateTimePicker DtFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}