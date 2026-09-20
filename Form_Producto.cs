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
    public partial class Form_Producto : Form
    {
        int Cont = 0, Id_Cat = 0;
        List<int> ArregloIdCategoria = new List<int>();
        List<int> ArregloIdProveedor = new List<int>();
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(Convert.ToString(c.conexion()));
        SqlCommand cmd = new SqlCommand();
        public Form_Producto(int Id)
        {
            InitializeComponent();
            cmd.Connection = con;
            cargarComboBox("Descripcion_Categoria", "Descripcion", "Categoria_Producto", CmbCategoria, "Id_Categoria");
            cargarComboBox("Nombre_Proveedor", "Nombre", "Proveedores", CmbProveedor, "Id_Proveedor");
            if (Id > -1)
            {
                llenar(Id);
            }
            else if (Id == -1)
            {
                TxtIdPro.Visible = false;
                BtnCancelar.Visible = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Producto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 2);
                cmd.Parameters.AddWithValue("@Id_Producto", TxtIdPro.Text);
                cmd.Parameters.AddWithValue("@Descripcion_Producto", TxtDescripcionPro.Text);
                cmd.Parameters.AddWithValue("@Precio_Producto", TxtPrePro.Text);
                cmd.Parameters.AddWithValue("@Id_Categoria", ArregloIdCategoria[CmbCategoria.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Id_Proveedor", ArregloIdProveedor[CmbProveedor.SelectedIndex].ToString());
                cmd.Parameters.AddWithValue("@Stock_Minimo_Producto", 1);
                cmd.Parameters.AddWithValue("@Stock_Maximo_Producto", 9999);
                cmd.Parameters.AddWithValue("@Stock_Producto", TxtStock.Text);
                cmd.Parameters.AddWithValue("@Tipo_Producto", TxtTipoPro.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                Limpiar();
                TxtIdPro.Visible = false;
                TxtIdPro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Coso = 1;
            Form_Buscar_Producto form_Buscar_Producto = new Form_Buscar_Producto(Coso);
            form_Buscar_Producto.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Producto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 3);
                cmd.Parameters.AddWithValue("@Id_Producto", Convert.ToInt32(TxtIdPro.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Eliminado");
                BtnEliminar.Enabled = false;
                TxtIdPro.Visible = false;
                BtnCancelar.Visible = false;
                TxtIdPro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            TxtIdPro.Visible = false;
            BtnCancelar.Visible = false;
            TxtIdPro.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void llenar(int Id)
        {
            try
            {
                TxtIdPro.Visible = true;
                BtnEliminar.Enabled = true;
                BtnCancelar.Visible = true;
                TxtIdPro.Text = Id.ToString();



                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Producto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 1);
                cmd.Parameters.AddWithValue("@Id_Producto", Convert.ToInt32(TxtIdPro.Text));
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtDescripcionPro.Text = reader["Descripcion_Producto"].ToString();
                            TxtPrePro.Text = reader["Precio_Producto"].ToString();
                            TxtStock.Text = reader["Stock_Producto"].ToString();
                            TxtTipoPro.Text = reader["Tipo_Producto"].ToString();
                            CmbProveedor.SelectedIndex = ArregloIdProveedor.IndexOf(Convert.ToInt32(reader["Id_Proveedor"]));
                            CmbCategoria.SelectedIndex = ArregloIdCategoria.IndexOf(Convert.ToInt32(reader["Id_Categoria"]));

                        }

                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con ID " + TxtIdPro.Text);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void cargarComboBox(string value, string display, string tabla, ComboBox combo, string Coso)
        {
            string consulta = $"SELECT * FROM {tabla}";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Convert.ToString(c.conexion())))
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
                            ArregloIdCategoria.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 1)
                    {
                        while (reader.Read())
                        {
                            ArregloIdProveedor.Add(Convert.ToInt16(reader[Coso]));
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
        void Limpiar()
        {
            TxtDescripcionPro.Clear();
            TxtPrePro.Clear();
            TxtStock.Clear();
            TxtTipoPro.Clear();
            CmbCategoria.Text = "";
            CmbProveedor.Text = "";
        }

    }
}
