namespace Refaccionaria
{
    partial class Form_Buscar_Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMaximoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFACCIONRIADataSet2 = new Refaccionaria.REFACCIONRIADataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.productosTableAdapter = new Refaccionaria.REFACCIONRIADataSet2TableAdapters.ProductosTableAdapter();
            this.LblProId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.precioProductoDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.stockMinimoProductoDataGridViewTextBoxColumn,
            this.stockMaximoProductoDataGridViewTextBoxColumn,
            this.stockProductoDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Producto";
            this.ID.HeaderText = "Id_Producto";
            this.ID.Name = "ID";
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            this.precioProductoDataGridViewTextBoxColumn.DataPropertyName = "Precio_Producto";
            this.precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio_Producto";
            this.precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Id_Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "Id_Proveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            // 
            // stockMinimoProductoDataGridViewTextBoxColumn
            // 
            this.stockMinimoProductoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Minimo_Producto";
            this.stockMinimoProductoDataGridViewTextBoxColumn.HeaderText = "Stock_Minimo_Producto";
            this.stockMinimoProductoDataGridViewTextBoxColumn.Name = "stockMinimoProductoDataGridViewTextBoxColumn";
            // 
            // stockMaximoProductoDataGridViewTextBoxColumn
            // 
            this.stockMaximoProductoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Maximo_Producto";
            this.stockMaximoProductoDataGridViewTextBoxColumn.HeaderText = "Stock_Maximo_Producto";
            this.stockMaximoProductoDataGridViewTextBoxColumn.Name = "stockMaximoProductoDataGridViewTextBoxColumn";
            // 
            // stockProductoDataGridViewTextBoxColumn
            // 
            this.stockProductoDataGridViewTextBoxColumn.DataPropertyName = "Stock_Producto";
            this.stockProductoDataGridViewTextBoxColumn.HeaderText = "Stock_Producto";
            this.stockProductoDataGridViewTextBoxColumn.Name = "stockProductoDataGridViewTextBoxColumn";
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo_Producto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.rEFACCIONRIADataSet2;
            // 
            // rEFACCIONRIADataSet2
            // 
            this.rEFACCIONRIADataSet2.DataSetName = "REFACCIONRIADataSet2";
            this.rEFACCIONRIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(44, 217);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(175, 20);
            this.TxtFiltro.TabIndex = 2;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // LblProId
            // 
            this.LblProId.AutoSize = true;
            this.LblProId.Location = new System.Drawing.Point(41, 19);
            this.LblProId.Name = "LblProId";
            this.LblProId.Size = new System.Drawing.Size(0, 13);
            this.LblProId.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Buscar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblProId);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Buscar_Producto";
            this.Text = "Form_Buscar_Producto";
            this.Load += new System.EventHandler(this.Form_Buscar_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private REFACCIONRIADataSet2 rEFACCIONRIADataSet2;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private REFACCIONRIADataSet2TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMaximoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}