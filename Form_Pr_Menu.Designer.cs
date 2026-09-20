namespace Refaccionaria
{
    partial class Form_Pr_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTrabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoFaltanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarClientesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.administrarProveedoresToolStripMenuItem,
            this.administrarTrabajadoresToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // administrarClientesToolStripMenuItem
            // 
            this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.administrarClientesToolStripMenuItem.Text = "Administrar Clientes";
            this.administrarClientesToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // administrarProveedoresToolStripMenuItem
            // 
            this.administrarProveedoresToolStripMenuItem.Name = "administrarProveedoresToolStripMenuItem";
            this.administrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.administrarProveedoresToolStripMenuItem.Text = "Administrar Proveedores";
            this.administrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.administrarProveedoresToolStripMenuItem_Click);
            // 
            // administrarTrabajadoresToolStripMenuItem
            // 
            this.administrarTrabajadoresToolStripMenuItem.Name = "administrarTrabajadoresToolStripMenuItem";
            this.administrarTrabajadoresToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.administrarTrabajadoresToolStripMenuItem.Text = "Administrar Trabajadores";
            this.administrarTrabajadoresToolStripMenuItem.Click += new System.EventHandler(this.administrarTrabajadoresToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem1,
            this.ventaToolStripMenuItem1,
            this.pedidoToolStripMenuItem1,
            this.proveedoresToolStripMenuItem,
            this.productoFaltanteToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.compraToolStripMenuItem1.Text = "Compra";
            this.compraToolStripMenuItem1.Click += new System.EventHandler(this.compraToolStripMenuItem1_Click);
            // 
            // ventaToolStripMenuItem1
            // 
            this.ventaToolStripMenuItem1.Name = "ventaToolStripMenuItem1";
            this.ventaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ventaToolStripMenuItem1.Text = "Venta";
            this.ventaToolStripMenuItem1.Click += new System.EventHandler(this.ventaToolStripMenuItem1_Click);
            // 
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pedidoToolStripMenuItem1.Text = "Pedido";
            this.pedidoToolStripMenuItem1.Click += new System.EventHandler(this.pedidoToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // productoFaltanteToolStripMenuItem
            // 
            this.productoFaltanteToolStripMenuItem.Name = "productoFaltanteToolStripMenuItem";
            this.productoFaltanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoFaltanteToolStripMenuItem.Text = "Producto Faltante";
            this.productoFaltanteToolStripMenuItem.Click += new System.EventHandler(this.productoFaltanteToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // Form_Pr_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Pr_Menu";
            this.Text = "Form_Pr_Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarTrabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoFaltanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
    }
}