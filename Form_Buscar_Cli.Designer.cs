namespace Refaccionaria
{
    partial class Form_Buscar_Cli
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
            this.nomClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFACCIONRIADataSet = new Refaccionaria.REFACCIONRIADataSet();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new Refaccionaria.REFACCIONRIADataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LblCliID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomClienteDataGridViewTextBoxColumn,
            this.apellidoPaternoClienteDataGridViewTextBoxColumn,
            this.apellidoMaternoClienteDataGridViewTextBoxColumn,
            this.direccionClienteDataGridViewTextBoxColumn,
            this.rfcClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.idRegimenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Cliente";
            this.ID.HeaderText = "Id_Cliente";
            this.ID.Name = "ID";
            // 
            // nomClienteDataGridViewTextBoxColumn
            // 
            this.nomClienteDataGridViewTextBoxColumn.DataPropertyName = "Nom_Cliente";
            this.nomClienteDataGridViewTextBoxColumn.HeaderText = "Nom_Cliente";
            this.nomClienteDataGridViewTextBoxColumn.Name = "nomClienteDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoClienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paterno_Cliente";
            this.apellidoPaternoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido_Paterno_Cliente";
            this.apellidoPaternoClienteDataGridViewTextBoxColumn.Name = "apellidoPaternoClienteDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoClienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Materno_Cliente";
            this.apellidoMaternoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido_Materno_Cliente";
            this.apellidoMaternoClienteDataGridViewTextBoxColumn.Name = "apellidoMaternoClienteDataGridViewTextBoxColumn";
            // 
            // direccionClienteDataGridViewTextBoxColumn
            // 
            this.direccionClienteDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.HeaderText = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.Name = "direccionClienteDataGridViewTextBoxColumn";
            // 
            // rfcClienteDataGridViewTextBoxColumn
            // 
            this.rfcClienteDataGridViewTextBoxColumn.DataPropertyName = "Rfc_Cliente";
            this.rfcClienteDataGridViewTextBoxColumn.HeaderText = "Rfc_Cliente";
            this.rfcClienteDataGridViewTextBoxColumn.Name = "rfcClienteDataGridViewTextBoxColumn";
            // 
            // correoClienteDataGridViewTextBoxColumn
            // 
            this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "Correo_Cliente";
            this.correoClienteDataGridViewTextBoxColumn.HeaderText = "Correo_Cliente";
            this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
            // 
            // telefonoClienteDataGridViewTextBoxColumn
            // 
            this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "Telefono_Cliente";
            this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
            // 
            // idRegimenDataGridViewTextBoxColumn
            // 
            this.idRegimenDataGridViewTextBoxColumn.DataPropertyName = "Id_Regimen";
            this.idRegimenDataGridViewTextBoxColumn.HeaderText = "Id_Regimen";
            this.idRegimenDataGridViewTextBoxColumn.Name = "idRegimenDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.rEFACCIONRIADataSet;
            // 
            // rEFACCIONRIADataSet
            // 
            this.rEFACCIONRIADataSet.DataSetName = "REFACCIONRIADataSet";
            this.rEFACCIONRIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(12, 184);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(336, 20);
            this.TxtFiltro.TabIndex = 1;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.rEFACCIONRIADataSet;
            // 
            // LblCliID
            // 
            this.LblCliID.AutoSize = true;
            this.LblCliID.Location = new System.Drawing.Point(13, 13);
            this.LblCliID.Name = "LblCliID";
            this.LblCliID.Size = new System.Drawing.Size(16, 13);
            this.LblCliID.TabIndex = 3;
            this.LblCliID.Text = "-1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Buscar_Cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblCliID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Buscar_Cli";
            this.Text = "Form_Buscar_Cli";
            this.Load += new System.EventHandler(this.Form_Buscar_Cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private REFACCIONRIADataSet rEFACCIONRIADataSet;
        private REFACCIONRIADataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label LblCliID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}