using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria
{
    public partial class Form_Pedido : Form
    {
        int Cont = 0;
        List<int> ArregloIdCliente = new List<int>();
        List<int> ArregloIdProducto = new List<int>();
        List<int> ArregloIdTrabajador = new List<int>();
        private dsPedidoDet dsPedDet = new dsPedidoDet();
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        string sConexion = Convert.ToString(c.conexion());
        int idDetalle = 0, Id_Prod;
        public Form_Pedido(int id_Prod)
        {
            InitializeComponent();
            Id_Prod = id_Prod;
            this.sConexion = sConexion;
            consecutivo();
            idDetalle = consecutivoDetalle();
        }

        private void Form_Pedido_Load(object sender, EventArgs e)
        {
            Cont = 0;
            cargarComboBox("Nom_Cliente", "Nombre", "Cliente", CmbIdCliente, "Id_Cliente");
            cargarComboBox("Descripcion_Producto", "Nombre", "Productos", CmbIdProducto, "Id_Producto");
            cargarComboBox("Nom_Trabajador", "Nombre", "Trabajador", CmbIdTrabajador, "Id_Trabajador");
            CmbIdProducto.Text = Convert.ToString(Id_Prod);
            CmbIdProducto.SelectedIndex = ArregloIdProducto.IndexOf(Id_Prod);
            dtDetallePedido.DataSource = dsPedDet.spPedidoDet;
        }
        void cargarComboBox(string value, string display, string tabla, ComboBox combo, string Coso)
        {
            string consulta = $"SELECT * FROM {tabla}";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(sConexion))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(consulta, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    combo.Items.Clear();
                    if (Cont == 0)
                    {
                        while (reader.Read())
                        {
                            ArregloIdCliente.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 1)
                    {
                        while (reader.Read())
                        {
                            ArregloIdProducto.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 2)
                    {
                        while (reader.Read())
                        {
                            ArregloIdTrabajador.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            Cont++;
        }
        void consecutivo()
        {
            try
            {
                string consulta = "SELECT ISNULL(MAX(Id_Pedido) + 1, 1) AS maxid FROM Pedido";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtID.Text = lector["maxid"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                dsPedidoDet.spPedidoDetRow row = dsPedDet.spPedidoDet.NewspPedidoDetRow();
                row.Id_Pedido = int.Parse(txtID.Text);
                row.Id_Producto = int.Parse(ArregloIdProducto[CmbIdProducto.SelectedIndex].ToString());
                row.Cantidad_Pedido = int.Parse(txtCantidad.Text);
                row.Precio_Pedido = decimal.Parse(txtPrecio.Text);
                row.Total_Pedido = row.Cantidad_Pedido * row.Precio_Pedido;
                dsPedDet.spPedidoDet.AddspPedidoDetRow(row);
                dtDetallePedido.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido x = new Pedido(sConexion);
                x.Detalles = dsPedDet.spPedidoDet;
                x.Id_Pedido = int.Parse(txtID.Text);
                x.Fecha_Pedido = dtpFechaPedido.Value;
                x.Importe_Pedido = decimal.Parse(txtImporte.Text);
                x.Total_Pedido = decimal.Parse(txtTotal.Text);
                x.Id_Cliente = int.Parse(ArregloIdCliente[CmbIdCliente.SelectedIndex].ToString());
                x.Id_Trabajador = int.Parse(ArregloIdTrabajador[CmbIdTrabajador.SelectedIndex].ToString());
                MessageBox.Show(x.Guardar());
                dtDetallePedido.ClearSelection();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            int Coso = 3;
            Form_Buscar_Producto form_Buscar_Producto = new Form_Buscar_Producto(Coso);
            form_Buscar_Producto.Show();
            this.Close();
        }

        int consecutivoDetalle()
        {
            try
            {
                string consulta = "SELECT ISNULL(MAX(Id_Pedido), 0) AS maxid FROM Pedido_Detalle";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                SqlDataReader lector = cmd.ExecuteReader();
                int id = 0;
                if (lector.Read())
                {
                    id = int.Parse(lector["maxid"].ToString());
                }
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return 0;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtTotal.Text = (Double.Parse(txtPrecio.Text) * Double.Parse(txtCantidad.Text)).ToString();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtTotal.Text = (Double.Parse(txtPrecio.Text) * Double.Parse(txtCantidad.Text)).ToString();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CmbIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT Precio_Producto AS Precio FROM Productos WHERE Id_Producto = " + int.Parse(ArregloIdProducto[CmbIdProducto.SelectedIndex].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtPrecio.Text = lector["Precio"].ToString();
            }
            con.Close();
        }

        private void Limpiar()
        {
            dsPedDet.spPedidoDet.Rows.Clear();
            txtPrecio.Text = "0";
            txtImporte.Text = "0";
            txtCantidad.Clear();
            txtID.Clear();
            txtTotal.Text = "0";
            CmbIdCliente.Text = "";
            CmbIdProducto.Text = "";
            CmbIdTrabajador.Text = "";
            consecutivo();
        }
    }
}
