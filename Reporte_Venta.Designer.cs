namespace Refaccionaria
{
    partial class Reporte_Venta
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
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.refaccionriaDataSet1 = new Refaccionaria.REFACCIONRIADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.DtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.refaccionriaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(448, 27);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerar.TabIndex = 0;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(12, 30);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(200, 20);
            this.DtFecha.TabIndex = 1;
            // 
            // refaccionriaDataSet1
            // 
            this.refaccionriaDataSet1.DataSetName = "REFACCIONRIADataSet";
            this.refaccionriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Refaccionaria.ReportVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 393);
            this.reportViewer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial";
            // 
            // DtFechaFinal
            // 
            this.DtFechaFinal.Location = new System.Drawing.Point(231, 30);
            this.DtFechaFinal.Name = "DtFechaFinal";
            this.DtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtFechaFinal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final";
            // 
            // Reporte_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.BtnGenerar);
            this.Name = "Reporte_Venta";
            this.Text = "Reporte_Venta";
            this.Load += new System.EventHandler(this.Reporte_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refaccionriaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private REFACCIONRIADataSet refaccionriaDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtFechaFinal;
        private System.Windows.Forms.Label label2;
    }
}