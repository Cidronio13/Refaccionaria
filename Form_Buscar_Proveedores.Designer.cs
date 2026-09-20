namespace Refaccionaria
{
    partial class Form_Buscar_Proveedores
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
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFACCIONRIADataSet3 = new Refaccionaria.REFACCIONRIADataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtIdProv = new System.Windows.Forms.TextBox();
            this.proveedoresTableAdapter = new Refaccionaria.REFACCIONRIADataSet3TableAdapters.ProveedoresTableAdapter();
            this.LblIdProv = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.telefonoProveedorDataGridViewTextBoxColumn,
            this.correoProveedorDataGridViewTextBoxColumn,
            this.direccionProveedorDataGridViewTextBoxColumn,
            this.rfcProveedorDataGridViewTextBoxColumn,
            this.cpProveedorDataGridViewTextBoxColumn,
            this.idRegimenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Proveedor";
            this.ID.HeaderText = "Id_Proveedor";
            this.ID.Name = "ID";
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre_Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            // 
            // telefonoProveedorDataGridViewTextBoxColumn
            // 
            this.telefonoProveedorDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Proveedor";
            this.telefonoProveedorDataGridViewTextBoxColumn.HeaderText = "Telefono_Proveedor";
            this.telefonoProveedorDataGridViewTextBoxColumn.Name = "telefonoProveedorDataGridViewTextBoxColumn";
            // 
            // correoProveedorDataGridViewTextBoxColumn
            // 
            this.correoProveedorDataGridViewTextBoxColumn.DataPropertyName = "Correo_Proveedor";
            this.correoProveedorDataGridViewTextBoxColumn.HeaderText = "Correo_Proveedor";
            this.correoProveedorDataGridViewTextBoxColumn.Name = "correoProveedorDataGridViewTextBoxColumn";
            // 
            // direccionProveedorDataGridViewTextBoxColumn
            // 
            this.direccionProveedorDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Proveedor";
            this.direccionProveedorDataGridViewTextBoxColumn.HeaderText = "Direccion_Proveedor";
            this.direccionProveedorDataGridViewTextBoxColumn.Name = "direccionProveedorDataGridViewTextBoxColumn";
            // 
            // rfcProveedorDataGridViewTextBoxColumn
            // 
            this.rfcProveedorDataGridViewTextBoxColumn.DataPropertyName = "Rfc_Proveedor";
            this.rfcProveedorDataGridViewTextBoxColumn.HeaderText = "Rfc_Proveedor";
            this.rfcProveedorDataGridViewTextBoxColumn.Name = "rfcProveedorDataGridViewTextBoxColumn";
            // 
            // cpProveedorDataGridViewTextBoxColumn
            // 
            this.cpProveedorDataGridViewTextBoxColumn.DataPropertyName = "Cp_Proveedor";
            this.cpProveedorDataGridViewTextBoxColumn.HeaderText = "Cp_Proveedor";
            this.cpProveedorDataGridViewTextBoxColumn.Name = "cpProveedorDataGridViewTextBoxColumn";
            // 
            // idRegimenDataGridViewTextBoxColumn
            // 
            this.idRegimenDataGridViewTextBoxColumn.DataPropertyName = "Id_Regimen";
            this.idRegimenDataGridViewTextBoxColumn.HeaderText = "Id_Regimen";
            this.idRegimenDataGridViewTextBoxColumn.Name = "idRegimenDataGridViewTextBoxColumn";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.rEFACCIONRIADataSet3;
            // 
            // rEFACCIONRIADataSet3
            // 
            this.rEFACCIONRIADataSet3.DataSetName = "REFACCIONRIADataSet3";
            this.rEFACCIONRIADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtIdProv
            // 
            this.TxtIdProv.Location = new System.Drawing.Point(12, 187);
            this.TxtIdProv.Name = "TxtIdProv";
            this.TxtIdProv.Size = new System.Drawing.Size(172, 20);
            this.TxtIdProv.TabIndex = 2;
            this.TxtIdProv.TextChanged += new System.EventHandler(this.TxtIdProv_TextChanged);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // LblIdProv
            // 
            this.LblIdProv.AutoSize = true;
            this.LblIdProv.Location = new System.Drawing.Point(12, 9);
            this.LblIdProv.Name = "LblIdProv";
            this.LblIdProv.Size = new System.Drawing.Size(0, 13);
            this.LblIdProv.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Buscar_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblIdProv);
            this.Controls.Add(this.TxtIdProv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Buscar_Proveedores";
            this.Text = "Form_Buscar_Proveedores";
            this.Load += new System.EventHandler(this.Form_Buscar_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private REFACCIONRIADataSet3 rEFACCIONRIADataSet3;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private REFACCIONRIADataSet3TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtIdProv;
        private System.Windows.Forms.Label LblIdProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}