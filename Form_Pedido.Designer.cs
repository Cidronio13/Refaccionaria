namespace Refaccionaria
{
    partial class Form_Pedido
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
            this.CmbIdCliente = new System.Windows.Forms.ComboBox();
            this.CmbIdProducto = new System.Windows.Forms.ComboBox();
            this.CmbIdTrabajador = new System.Windows.Forms.ComboBox();
            this.dtDetallePedido = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spPedidoDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPedidoDet = new Refaccionaria.dsPedidoDet();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoDet)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbIdCliente
            // 
            this.CmbIdCliente.FormattingEnabled = true;
            this.CmbIdCliente.Location = new System.Drawing.Point(237, 335);
            this.CmbIdCliente.Name = "CmbIdCliente";
            this.CmbIdCliente.Size = new System.Drawing.Size(121, 21);
            this.CmbIdCliente.TabIndex = 0;
            // 
            // CmbIdProducto
            // 
            this.CmbIdProducto.FormattingEnabled = true;
            this.CmbIdProducto.Location = new System.Drawing.Point(237, 380);
            this.CmbIdProducto.Name = "CmbIdProducto";
            this.CmbIdProducto.Size = new System.Drawing.Size(121, 21);
            this.CmbIdProducto.TabIndex = 0;
            this.CmbIdProducto.SelectedIndexChanged += new System.EventHandler(this.CmbIdProducto_SelectedIndexChanged);
            // 
            // CmbIdTrabajador
            // 
            this.CmbIdTrabajador.FormattingEnabled = true;
            this.CmbIdTrabajador.Location = new System.Drawing.Point(237, 424);
            this.CmbIdTrabajador.Name = "CmbIdTrabajador";
            this.CmbIdTrabajador.Size = new System.Drawing.Size(121, 21);
            this.CmbIdTrabajador.TabIndex = 0;
            // 
            // dtDetallePedido
            // 
            this.dtDetallePedido.AutoGenerateColumns = false;
            this.dtDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadPedidoDataGridViewTextBoxColumn,
            this.precioPedidoDataGridViewTextBoxColumn,
            this.totalPedidoDataGridViewTextBoxColumn});
            this.dtDetallePedido.DataSource = this.spPedidoDetBindingSource;
            this.dtDetallePedido.Location = new System.Drawing.Point(12, 22);
            this.dtDetallePedido.Name = "dtDetallePedido";
            this.dtDetallePedido.Size = new System.Drawing.Size(541, 215);
            this.dtDetallePedido.TabIndex = 1;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "Id_Pedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // cantidadPedidoDataGridViewTextBoxColumn
            // 
            this.cantidadPedidoDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Pedido";
            this.cantidadPedidoDataGridViewTextBoxColumn.HeaderText = "Cantidad_Pedido";
            this.cantidadPedidoDataGridViewTextBoxColumn.Name = "cantidadPedidoDataGridViewTextBoxColumn";
            // 
            // precioPedidoDataGridViewTextBoxColumn
            // 
            this.precioPedidoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Pedido";
            this.precioPedidoDataGridViewTextBoxColumn.HeaderText = "Precio_Pedido";
            this.precioPedidoDataGridViewTextBoxColumn.Name = "precioPedidoDataGridViewTextBoxColumn";
            // 
            // totalPedidoDataGridViewTextBoxColumn
            // 
            this.totalPedidoDataGridViewTextBoxColumn.DataPropertyName = "Total_Pedido";
            this.totalPedidoDataGridViewTextBoxColumn.HeaderText = "Total_Pedido";
            this.totalPedidoDataGridViewTextBoxColumn.Name = "totalPedidoDataGridViewTextBoxColumn";
            // 
            // spPedidoDetBindingSource
            // 
            this.spPedidoDetBindingSource.DataMember = "spPedidoDet";
            this.spPedidoDetBindingSource.DataSource = this.dsPedidoDet;
            // 
            // dsPedidoDet
            // 
            this.dsPedidoDet.DataSetName = "dsPedidoDet";
            this.dsPedidoDet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Importe";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(469, 337);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(469, 431);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 23;
            this.txtImporte.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(469, 386);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.Text = "0";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(584, 431);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 25;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(469, 292);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 26;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Trabajador";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(237, 285);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 35;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(130, 289);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 36;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(40, 288);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 37;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.Location = new System.Drawing.Point(376, 378);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProd.TabIndex = 38;
            this.BtnBuscarProd.Text = "Buscar";
            this.BtnBuscarProd.UseVisualStyleBackColor = true;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(584, 384);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 39;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscarProd);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.dtDetallePedido);
            this.Controls.Add(this.CmbIdTrabajador);
            this.Controls.Add(this.CmbIdProducto);
            this.Controls.Add(this.CmbIdCliente);
            this.Name = "Form_Pedido";
            this.Text = "Form_Pedido";
            this.Load += new System.EventHandler(this.Form_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPedidoDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbIdCliente;
        private System.Windows.Forms.ComboBox CmbIdProducto;
        private System.Windows.Forms.ComboBox CmbIdTrabajador;
        private System.Windows.Forms.DataGridView dtDetallePedido;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spPedidoDetBindingSource;
        private dsPedidoDet dsPedidoDet;
        private System.Windows.Forms.Button BtnBuscarProd;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}