namespace Refaccionaria
{
    partial class Form_Trabajadores
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomTra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApeMaTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRfcTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApePaTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHorarioTra = new System.Windows.Forms.TextBox();
            this.TxtEstadoTra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNssTra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtIdTra = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxtNomTra
            // 
            this.TxtNomTra.Location = new System.Drawing.Point(40, 39);
            this.TxtNomTra.Name = "TxtNomTra";
            this.TxtNomTra.Size = new System.Drawing.Size(100, 20);
            this.TxtNomTra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Materno";
            // 
            // TxtApeMaTra
            // 
            this.TxtApeMaTra.Location = new System.Drawing.Point(40, 80);
            this.TxtApeMaTra.Name = "TxtApeMaTra";
            this.TxtApeMaTra.Size = new System.Drawing.Size(100, 20);
            this.TxtApeMaTra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "RFC";
            // 
            // TxtRfcTra
            // 
            this.TxtRfcTra.Location = new System.Drawing.Point(40, 119);
            this.TxtRfcTra.Name = "TxtRfcTra";
            this.TxtRfcTra.Size = new System.Drawing.Size(100, 20);
            this.TxtRfcTra.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefono";
            // 
            // TxtTelTra
            // 
            this.TxtTelTra.Location = new System.Drawing.Point(40, 158);
            this.TxtTelTra.Name = "TxtTelTra";
            this.TxtTelTra.Size = new System.Drawing.Size(100, 20);
            this.TxtTelTra.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido Paterno";
            // 
            // TxtApePaTra
            // 
            this.TxtApePaTra.Location = new System.Drawing.Point(146, 39);
            this.TxtApePaTra.Name = "TxtApePaTra";
            this.TxtApePaTra.Size = new System.Drawing.Size(100, 20);
            this.TxtApePaTra.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Horario ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Estado";
            // 
            // TxtHorarioTra
            // 
            this.TxtHorarioTra.Location = new System.Drawing.Point(146, 119);
            this.TxtHorarioTra.Name = "TxtHorarioTra";
            this.TxtHorarioTra.Size = new System.Drawing.Size(100, 20);
            this.TxtHorarioTra.TabIndex = 2;
            // 
            // TxtEstadoTra
            // 
            this.TxtEstadoTra.Location = new System.Drawing.Point(146, 158);
            this.TxtEstadoTra.Name = "TxtEstadoTra";
            this.TxtEstadoTra.Size = new System.Drawing.Size(100, 20);
            this.TxtEstadoTra.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Numero de Seguro Social";
            // 
            // TxtNssTra
            // 
            this.TxtNssTra.Location = new System.Drawing.Point(146, 80);
            this.TxtNssTra.Name = "TxtNssTra";
            this.TxtNssTra.Size = new System.Drawing.Size(100, 20);
            this.TxtNssTra.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtIdTra
            // 
            this.TxtIdTra.Location = new System.Drawing.Point(269, 158);
            this.TxtIdTra.Name = "TxtIdTra";
            this.TxtIdTra.ReadOnly = true;
            this.TxtIdTra.Size = new System.Drawing.Size(111, 20);
            this.TxtIdTra.TabIndex = 4;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(240, 184);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(269, 132);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar Busqueda";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(334, 184);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtIdTra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtEstadoTra);
            this.Controls.Add(this.TxtNssTra);
            this.Controls.Add(this.TxtTelTra);
            this.Controls.Add(this.TxtHorarioTra);
            this.Controls.Add(this.TxtRfcTra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtApeMaTra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApePaTra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNomTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form_Trabajadores";
            this.Text = "Form_Trabajadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApeMaTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRfcTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtApePaTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtHorarioTra;
        private System.Windows.Forms.TextBox TxtEstadoTra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNssTra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtIdTra;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}