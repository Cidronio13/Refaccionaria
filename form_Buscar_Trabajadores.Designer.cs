namespace Refaccionaria
{
    partial class form_Buscar_Trabajadores
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
            this.DgvBuTra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoTrabajadorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nssTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEFACCIONRIADataSet4 = new Refaccionaria.REFACCIONRIADataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.trabajadorTableAdapter = new Refaccionaria.REFACCIONRIADataSet4TableAdapters.TrabajadorTableAdapter();
            this.LblIdTra = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBuTra
            // 
            this.DgvBuTra.AutoGenerateColumns = false;
            this.DgvBuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomTrabajadorDataGridViewTextBoxColumn,
            this.apellidoPaternoTrabajadorDataGridViewTextBoxColumn,
            this.apellidoMaternoTrabajadorDataGridViewTextBoxColumn,
            this.rfcTrabajadorDataGridViewTextBoxColumn,
            this.horarioTrabajadorDataGridViewTextBoxColumn,
            this.telefonoTrabajadorDataGridViewTextBoxColumn,
            this.estadoTrabajadorDataGridViewCheckBoxColumn,
            this.nssTrabajadorDataGridViewTextBoxColumn});
            this.DgvBuTra.DataSource = this.trabajadorBindingSource;
            this.DgvBuTra.Location = new System.Drawing.Point(12, 27);
            this.DgvBuTra.Name = "DgvBuTra";
            this.DgvBuTra.Size = new System.Drawing.Size(941, 150);
            this.DgvBuTra.TabIndex = 0;
            this.DgvBuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuTra_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Trabajador";
            this.ID.HeaderText = "Id_Trabajador";
            this.ID.Name = "ID";
            // 
            // nomTrabajadorDataGridViewTextBoxColumn
            // 
            this.nomTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Nom_Trabajador";
            this.nomTrabajadorDataGridViewTextBoxColumn.HeaderText = "Nom_Trabajador";
            this.nomTrabajadorDataGridViewTextBoxColumn.Name = "nomTrabajadorDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoTrabajadorDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paterno_Trabajador";
            this.apellidoPaternoTrabajadorDataGridViewTextBoxColumn.HeaderText = "Apellido_Paterno_Trabajador";
            this.apellidoPaternoTrabajadorDataGridViewTextBoxColumn.Name = "apellidoPaternoTrabajadorDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoTrabajadorDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Materno_Trabajador";
            this.apellidoMaternoTrabajadorDataGridViewTextBoxColumn.HeaderText = "Apellido_Materno_Trabajador";
            this.apellidoMaternoTrabajadorDataGridViewTextBoxColumn.Name = "apellidoMaternoTrabajadorDataGridViewTextBoxColumn";
            // 
            // rfcTrabajadorDataGridViewTextBoxColumn
            // 
            this.rfcTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Rfc_Trabajador";
            this.rfcTrabajadorDataGridViewTextBoxColumn.HeaderText = "Rfc_Trabajador";
            this.rfcTrabajadorDataGridViewTextBoxColumn.Name = "rfcTrabajadorDataGridViewTextBoxColumn";
            // 
            // horarioTrabajadorDataGridViewTextBoxColumn
            // 
            this.horarioTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Horario_Trabajador";
            this.horarioTrabajadorDataGridViewTextBoxColumn.HeaderText = "Horario_Trabajador";
            this.horarioTrabajadorDataGridViewTextBoxColumn.Name = "horarioTrabajadorDataGridViewTextBoxColumn";
            // 
            // telefonoTrabajadorDataGridViewTextBoxColumn
            // 
            this.telefonoTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Trabajador";
            this.telefonoTrabajadorDataGridViewTextBoxColumn.HeaderText = "Telefono_Trabajador";
            this.telefonoTrabajadorDataGridViewTextBoxColumn.Name = "telefonoTrabajadorDataGridViewTextBoxColumn";
            // 
            // estadoTrabajadorDataGridViewCheckBoxColumn
            // 
            this.estadoTrabajadorDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Trabajador";
            this.estadoTrabajadorDataGridViewCheckBoxColumn.HeaderText = "Estado_Trabajador";
            this.estadoTrabajadorDataGridViewCheckBoxColumn.Name = "estadoTrabajadorDataGridViewCheckBoxColumn";
            // 
            // nssTrabajadorDataGridViewTextBoxColumn
            // 
            this.nssTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "Nss_Trabajador";
            this.nssTrabajadorDataGridViewTextBoxColumn.HeaderText = "Nss_Trabajador";
            this.nssTrabajadorDataGridViewTextBoxColumn.Name = "nssTrabajadorDataGridViewTextBoxColumn";
            // 
            // trabajadorBindingSource
            // 
            this.trabajadorBindingSource.DataMember = "Trabajador";
            this.trabajadorBindingSource.DataSource = this.rEFACCIONRIADataSet4;
            // 
            // rEFACCIONRIADataSet4
            // 
            this.rEFACCIONRIADataSet4.DataSetName = "REFACCIONRIADataSet4";
            this.rEFACCIONRIADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(12, 183);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(170, 20);
            this.TxtFiltro.TabIndex = 2;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // trabajadorTableAdapter
            // 
            this.trabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // LblIdTra
            // 
            this.LblIdTra.AutoSize = true;
            this.LblIdTra.Location = new System.Drawing.Point(12, 11);
            this.LblIdTra.Name = "LblIdTra";
            this.LblIdTra.Size = new System.Drawing.Size(0, 13);
            this.LblIdTra.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_Buscar_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblIdTra);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvBuTra);
            this.Name = "form_Buscar_Trabajadores";
            this.Text = "form_Buscar_Trabajadores";
            this.Load += new System.EventHandler(this.form_Buscar_Trabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFACCIONRIADataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBuTra;
        private REFACCIONRIADataSet4 rEFACCIONRIADataSet4;
        private System.Windows.Forms.BindingSource trabajadorBindingSource;
        private REFACCIONRIADataSet4TableAdapters.TrabajadorTableAdapter trabajadorTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblIdTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoTrabajadorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nssTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}