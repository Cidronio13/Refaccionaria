using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria
{
    public partial class Form_Pr_Menu : Form
    {
        public Form_Pr_Menu()
        {
            InitializeComponent();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = -1;
            Form_Clientes form_Clientes = new Form_Clientes(id);
            form_Clientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = -1;
            Form_Producto producto = new Form_Producto(id);
            producto.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = -1;
            Form_Categoria form_Categoria = new Form_Categoria(id);
            form_Categoria.Show();
        }

        private void administrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = -1;
            Form_Proveedores form_Proveedores = new Form_Proveedores(id);
            form_Proveedores.Show();
        }

        private void administrarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = -1;
            Form_Trabajadores form_Tra = new Form_Trabajadores(id);
            form_Tra.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            Form_Venta form_Venta = new Form_Venta(id);
            form_Venta.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            Form_Pedido form_Pedido = new Form_Pedido(id);
            form_Pedido.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            Compra compra = new Compra(id);
            compra.Show();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_Compra reporte_Compra = new Reporte_Compra();
            reporte_Compra.Show();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_Venta reporte_venta = new Reporte_Venta();
            reporte_venta.Show();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_Pedido reporte_pedido = new Reporte_Pedido();
            reporte_pedido.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Proveedor reporte = new Reporte_Proveedor();
            reporte.Show();
        }

        private void productoFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_ProdFaltante reporte_ = new Reporte_ProdFaltante();
            reporte_.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Producto reporte_ = new Reporte_Producto();
            reporte_.Show();
        }
    }
}
