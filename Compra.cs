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
    public partial class Compra : Form
    {
        int Cont = 0;
        List<int> ArregloIdCliente = new List<int>();
        List<int> ArregloIdProducto = new List<int>();
        List<int> ArregloIdProveedor = new List<int>();
        List<int> ArregloIdTrabajador = new List<int>();
        private dsCompraDet dsComDet = new dsCompraDet();
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        string sConexion = c.conexion();
        int idDetalle = 0, Id_Prod;
        public Compra(int id_Prod)
        {
            InitializeComponent();
            Id_Prod = id_Prod;
            this.sConexion = sConexion;
            consecutivo();
            idDetalle = consecutivoDetalle();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            Cont = 0;
            cargarComboBox("Nom_Cliente", "Nombre", "Cliente", CmbIdCliente, "Id_Cliente");
            cargarComboBox("Descripcion_Producto", "Nombre", "Productos", CmbIdProducto, "Id_Producto");
            cargarComboBox("Nombre_Proveedor", "Nombre", "Proveedores", CmbIdProveedor, "Id_Proveedor");
            cargarComboBox("Nom_Trabajador", "Nombre", "Trabajador", CmbIdTrabajador, "Id_Trabajador");
            //cbProducto.Text = Convert.ToString(Id_Prod);
            CmbIdProducto.SelectedIndex = ArregloIdProducto.IndexOf(Id_Prod);
            dtDetalleCompra.DataSource = dsComDet.spCompraDet;

            
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
                            ArregloIdProveedor.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 3)
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
                string consulta = "SELECT ISNULL(MAX(Id_Compra) + 1, 1) AS maxid FROM Compra";
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Clase_Compra x = new Clase_Compra(sConexion);
                x.Detalles = dsComDet.spCompraDet;
                x.Id_Compra = int.Parse(txtID.Text);
                x.Fecha_Compra = dtpFechaCompra.Value;
                x.Importe_Compra = decimal.Parse(txtImporte.Text);
                x.Total_Compra = decimal.Parse(txtTotal.Text);
                x.Id_Cliente = int.Parse(ArregloIdCliente[CmbIdCliente.SelectedIndex].ToString());
                x.Id_Proveedor = int.Parse(ArregloIdProveedor[CmbIdProveedor.SelectedIndex].ToString());
                x.Id_Trabajador = int.Parse(ArregloIdTrabajador[CmbIdTrabajador.SelectedIndex].ToString());
                x.Id_Producto = int.Parse(ArregloIdProducto[CmbIdProducto.SelectedIndex].ToString());
                x.Cantidad_Compra = int.Parse(txtCantidad.Text);
                x.Precio_Compra = decimal.Parse(txtPrecio.Text);
                MessageBox.Show(x.Guardar());
                dtDetalleCompra.ClearSelection();
                
                Limpiar();
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
                dsCompraDet.spCompraDetRow row = dsComDet.spCompraDet.NewspCompraDetRow();
                row.Id_Compra = int.Parse(txtID.Text);
                row.Id_Producto = int.Parse(ArregloIdProducto[CmbIdProducto.SelectedIndex].ToString());
                row.Cantidad_Compra = int.Parse(txtCantidad.Text);
                row.Precio_Compra = decimal.Parse(txtPrecio.Text);
                row.Total_Compra = row.Cantidad_Compra * row.Precio_Compra;
                dsComDet.spCompraDet.AddspCompraDetRow(row);
                dtDetalleCompra.Refresh();
                txtImporte.Text = (Double.Parse(txtTotal.Text) + Double.Parse(txtImporte.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            int Coso = 4;
            Form_Buscar_Producto form_Buscar_Producto = new Form_Buscar_Producto(Coso);
            form_Buscar_Producto.Show();
            this.Close();
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        int consecutivoDetalle()
        {
            try
            {
                string consulta = "SELECT ISNULL(MAX(Id_Venta), 0) AS maxid FROM Venta_Detallle";
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            
            dsComDet.spCompraDet.Rows.Clear();
            txtPrecio.Text = "0";
            txtImporte.Text = "0";
            txtCantidad.Clear();
            txtID.Clear();
            txtTotal.Text = "0";
            CmbIdCliente.Text = "";
            CmbIdProveedor.Text = "";
            CmbIdProducto.Text = "";
            CmbIdTrabajador.Text = "";
            consecutivo();
        }
    }
}
