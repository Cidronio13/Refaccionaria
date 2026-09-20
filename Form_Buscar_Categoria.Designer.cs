namespace Refaccionaria
{
    partial class Form_Buscar_Categoria
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
            this.DgvBuCat = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFACCIONRIADataSet1 = new Refaccionaria.REFACCIONRIADataSet1();
            this.rEFACCIONRIADataSet = new Refaccionaria.REFACCIONRIADataSet();
            this.rEFACCIONRIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.categoria_ProductoTableAdapter = new Refaccionaria.REFACCIONRIADataSet1TableAdapters.Categoria_ProductoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblProdId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBuCat
            // 
            this.DgvBuCat.AutoGenerateColumns = false;
            this.DgvBuCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBuCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descripcionCategoriaDataGridViewTextBoxColumn});
            this.DgvBuCat.DataSource = this.categoriaProductoBindingSource;
            this.DgvBuCat.Location = new System.Drawing.Point(12, 40);
            this.DgvBuCat.Name = "DgvBuCat";
            this.DgvBuCat.Size = new System.Drawing.Size(242, 150);
            this.DgvBuCat.TabIndex = 0;
            this.DgvBuCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuCat_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Categoria";
            this.ID.HeaderText = "Id_Categoria";
            this.ID.Name = "ID";
            // 
            // descripcionCategoriaDataGridViewTextBoxColumn
            // 
            this.descripcionCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Categoria";
            this.descripcionCategoriaDataGridViewTextBoxColumn.HeaderText = "Descripcion_Categoria";
            this.descripcionCategoriaDataGridViewTextBoxColumn.Name = "descripcionCategoriaDataGridViewTextBoxColumn";
            // 
            // categoriaProductoBindingSource
            // 
            this.categoriaProductoBindingSource.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource.DataSource = this.rEFACCIONRIADataSet1;
            // 
            // rEFACCIONRIADataSet1
            // 
            this.rEFACCIONRIADataSet1.DataSetName = "REFACCIONRIADataSet1";
            this.rEFACCIONRIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEFACCIONRIADataSet
            // 
            this.rEFACCIONRIADataSet.DataSetName = "REFACCIONRIADataSet";
            this.rEFACCIONRIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEFACCIONRIADataSetBindingSource
            // 
            this.rEFACCIONRIADataSetBindingSource.DataSource = this.rEFACCIONRIADataSet;
            this.rEFACCIONRIADataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoria_ProductoTableAdapter
            // 
            this.categoria_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblProdId
            // 
            this.LblProdId.AutoSize = true;
            this.LblProdId.Location = new System.Drawing.Point(12, 24);
            this.LblProdId.Name = "LblProdId";
            this.LblProdId.Size = new System.Drawing.Size(0, 13);
            this.LblProdId.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Buscar_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblProdId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvBuCat);
            this.Name = "Form_Buscar_Categoria";
            this.Text = "Form_Buscar_Categoria";
            this.Load += new System.EventHandler(this.Form_Buscar_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBuCat;
        private System.Windows.Forms.BindingSource rEFACCIONRIADataSetBindingSource;
        private REFACCIONRIADataSet rEFACCIONRIADataSet;
        private REFACCIONRIADataSet1 rEFACCIONRIADataSet1;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource;
        private REFACCIONRIADataSet1TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}