namespace Refaccionaria
{
    partial class Form_Venta
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
            this.components = new System.ComponentModel.Container();
            this.dtDetalle = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spVentaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVentaDet1 = new Refaccionaria.dsVentaDet();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cbTrabajador = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVentaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaDet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetalle
            // 
            this.dtDetalle.AllowUserToAddRows = false;
            this.dtDetalle.AutoGenerateColumns = false;
            this.dtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadVentaDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.totalVentaDataGridViewTextBoxColumn,
            this.idVentaDataGridViewTextBoxColumn});
            this.dtDetalle.DataSource = this.spVentaDetBindingSource;
            this.dtDetalle.Location = new System.Drawing.Point(33, 23);
            this.dtDetalle.Name = "dtDetalle";
            this.dtDetalle.Size = new System.Drawing.Size(529, 150);
            this.dtDetalle.TabIndex = 18;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // cantidadVentaDataGridViewTextBoxColumn
            // 
            this.cantidadVentaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Venta";
            this.cantidadVentaDataGridViewTextBoxColumn.HeaderText = "Cantidad_Venta";
            this.cantidadVentaDataGridViewTextBoxColumn.Name = "cantidadVentaDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio_Venta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // totalVentaDataGridViewTextBoxColumn
            // 
            this.totalVentaDataGridViewTextBoxColumn.DataPropertyName = "Total_Venta";
            this.totalVentaDataGridViewTextBoxColumn.HeaderText = "Total_Venta";
            this.totalVentaDataGridViewTextBoxColumn.Name = "totalVentaDataGridViewTextBoxColumn";
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "Id_Venta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "Id_Venta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            // 
            // spVentaDetBindingSource
            // 
            this.spVentaDetBindingSource.DataMember = "spVentaDet";
            this.spVentaDetBindingSource.DataSource = this.dsVentaDet1;
            // 
            // dsVentaDet1
            // 
            this.dsVentaDet1.DataSetName = "dsVentaDet";
            this.dsVentaDet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(568, 38);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 17;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(388, 401);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cbMetodoPago.TabIndex = 13;
            // 
            // cbTrabajador
            // 
            this.cbTrabajador.FormattingEnabled = true;
            this.cbTrabajador.Location = new System.Drawing.Point(388, 307);
            this.cbTrabajador.Name = "cbTrabajador";
            this.cbTrabajador.Size = new System.Drawing.Size(121, 21);
            this.cbTrabajador.TabIndex = 14;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(388, 357);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 15;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(388, 262);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 16;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(549, 308);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(549, 402);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 9;
            this.txtImporte.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(549, 357);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(549, 214);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(549, 263);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(130, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(33, 231);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Metodo de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID";
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.Location = new System.Drawing.Point(307, 357);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProd.TabIndex = 22;
            this.BtnBuscarProd.Text = "Buscar";
            this.BtnBuscarProd.UseVisualStyleBackColor = true;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(671, 401);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 23;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(33, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimir Ticket?";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(33, 385);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(121, 64);
            this.reportViewer1.TabIndex = 25;
            this.reportViewer1.Visible = false;
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscarProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtDetalle);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.cbTrabajador);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Form_Venta";
            this.Text = "Form_Venta";
            this.Load += new System.EventHandler(this.Form_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVentaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentaDet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.ComboBox cbTrabajador;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spVentaDetBindingSource;
        private dsVentaDet dsVentaDet1;
        private System.Windows.Forms.Button BtnBuscarProd;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}