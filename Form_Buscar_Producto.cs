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
    public partial class Form_Buscar_Producto : Form
    {
        static Conexion c = new Conexion();
        string sConexion = Convert.ToString(c.conexion());
        int Coso;
        public Form_Buscar_Producto(int coso)
        {
            InitializeComponent();
            Coso = coso;
            this.productosTableAdapter.Connection.ConnectionString = sConexion;
            button1.Enabled = false;
        }

        private void Form_Buscar_Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEFACCIONRIADataSet2.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.rEFACCIONRIADataSet2.Productos);

        }
        void rellenar()
        {
            try
            {
                this.productosTableAdapter.FillBy(this.rEFACCIONRIADataSet2.Productos, TxtFiltro.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Coso == 1)
            {
                Form_Producto form_Producto = new Form_Producto(Convert.ToInt32(LblProId.Text));
                form_Producto.Show();
                this.Close();
            }
            else if(Coso == 2)
            {
                Form_Venta form_Venta = new Form_Venta(Convert.ToInt32(LblProId.Text));
                form_Venta.Show();
                this.Close();
            }
            else if (Coso == 3)
            {
                Form_Pedido form_Pedido = new Form_Pedido(Convert.ToInt32(LblProId.Text));
                form_Pedido.Show();
                this.Close();
            }
            else if (Coso == 4)
            {
                Compra compra = new Compra(Convert.ToInt32(LblProId.Text));
                compra.Show();
                this.Close();
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LblProId.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                LblProId.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                LblProId.Visible = false;
                button1.Enabled = false;
                LblProId.Text = "-1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Producto form_Producto = new Form_Producto(-1);
            form_Producto.Show();
            this.Close();
        }
    }
}
