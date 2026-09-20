namespace Refaccionaria
{
    partial class Compra
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
            this.dtDetalleCompra = new System.Windows.Forms.DataGridView();
            this.idCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spCompraDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompraDet = new Refaccionaria.dsCompraDet();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.CmbIdTrabajador = new System.Windows.Forms.ComboBox();
            this.CmbIdProducto = new System.Windows.Forms.ComboBox();
            this.CmbIdCliente = new System.Windows.Forms.ComboBox();
            this.CmbIdProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCompraDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompraDet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetalleCompra
            // 
            this.dtDetalleCompra.AutoGenerateColumns = false;
            this.dtDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompraDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadCompraDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.totalCompraDataGridViewTextBoxColumn});
            this.dtDetalleCompra.DataSource = this.spCompraDetBindingSource;
            this.dtDetalleCompra.Location = new System.Drawing.Point(12, 12);
            this.dtDetalleCompra.Name = "dtDetalleCompra";
            this.dtDetalleCompra.Size = new System.Drawing.Size(628, 231);
            this.dtDetalleCompra.TabIndex = 0;
            // 
            // idCompraDataGridViewTextBoxColumn
            // 
            this.idCompraDataGridViewTextBoxColumn.DataPropertyName = "Id_Compra";
            this.idCompraDataGridViewTextBoxColumn.HeaderText = "Id_Compra";
            this.idCompraDataGridViewTextBoxColumn.Name = "idCompraDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // cantidadCompraDataGridViewTextBoxColumn
            // 
            this.cantidadCompraDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Compra";
            this.cantidadCompraDataGridViewTextBoxColumn.HeaderText = "Cantidad_Compra";
            this.cantidadCompraDataGridViewTextBoxColumn.Name = "cantidadCompraDataGridViewTextBoxColumn";
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_Compra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio_Compra";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            // 
            // totalCompraDataGridViewTextBoxColumn
            // 
            this.totalCompraDataGridViewTextBoxColumn.DataPropertyName = "Total_Compra";
            this.totalCompraDataGridViewTextBoxColumn.HeaderText = "Total_Compra";
            this.totalCompraDataGridViewTextBoxColumn.Name = "totalCompraDataGridViewTextBoxColumn";
            // 
            // spCompraDetBindingSource
            // 
            this.spCompraDetBindingSource.DataMember = "spCompraDet";
            this.spCompraDetBindingSource.DataSource = this.dsCompraDet;
            // 
            // dsCompraDet
            // 
            this.dsCompraDet.DataSetName = "dsCompraDet";
            this.dsCompraDet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(103, 249);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 249);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.Location = new System.Drawing.Point(394, 365);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProd.TabIndex = 56;
            this.BtnBuscarProd.Text = "Buscar";
            this.BtnBuscarProd.UseVisualStyleBackColor = true;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(37, 411);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCompra.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Importe";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(487, 324);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 42;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(487, 418);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 43;
            this.txtImporte.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(487, 373);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.Text = "0";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(602, 418);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 45;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(487, 279);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 46;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // CmbIdTrabajador
            // 
            this.CmbIdTrabajador.FormattingEnabled = true;
            this.CmbIdTrabajador.Location = new System.Drawing.Point(255, 411);
            this.CmbIdTrabajador.Name = "CmbIdTrabajador";
            this.CmbIdTrabajador.Size = new System.Drawing.Size(121, 21);
            this.CmbIdTrabajador.TabIndex = 40;
            // 
            // CmbIdProducto
            // 
            this.CmbIdProducto.FormattingEnabled = true;
            this.CmbIdProducto.Location = new System.Drawing.Point(255, 367);
            this.CmbIdProducto.Name = "CmbIdProducto";
            this.CmbIdProducto.Size = new System.Drawing.Size(121, 21);
            this.CmbIdProducto.TabIndex = 41;
            this.CmbIdProducto.SelectedIndexChanged += new System.EventHandler(this.CmbIdProducto_SelectedIndexChanged);
            // 
            // CmbIdCliente
            // 
            this.CmbIdCliente.FormattingEnabled = true;
            this.CmbIdCliente.Location = new System.Drawing.Point(255, 322);
            this.CmbIdCliente.Name = "CmbIdCliente";
            this.CmbIdCliente.Size = new System.Drawing.Size(121, 21);
            this.CmbIdCliente.TabIndex = 39;
            // 
            // CmbIdProveedor
            // 
            this.CmbIdProveedor.FormattingEnabled = true;
            this.CmbIdProveedor.Location = new System.Drawing.Point(255, 282);
            this.CmbIdProveedor.Name = "CmbIdProveedor";
            this.CmbIdProveedor.Size = new System.Drawing.Size(121, 21);
            this.CmbIdProveedor.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Proveedor";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(627, 373);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 57;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscarProd);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.CmbIdTrabajador);
            this.Controls.Add(this.CmbIdProducto);
            this.Controls.Add(this.CmbIdProveedor);
            this.Controls.Add(this.CmbIdCliente);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.dtDetalleCompra);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCompraDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompraDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetalleCompra;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscarProd;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox CmbIdTrabajador;
        private System.Windows.Forms.ComboBox CmbIdProducto;
        private System.Windows.Forms.ComboBox CmbIdCliente;
        private System.Windows.Forms.ComboBox CmbIdProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spCompraDetBindingSource;
        private dsCompraDet dsCompraDet;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}