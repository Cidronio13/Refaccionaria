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
    public partial class Form_Proveedores : Form
    {
        List<int> ArregloIdRegimen = new List<int>();
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(Convert.ToString(c.conexion()));
        SqlCommand cmd = new SqlCommand();
        public Form_Proveedores(int Id)
        {
            InitializeComponent();
            LlenarComboBox();
            cmd.Connection = con;
            if (Id > -1)
            {
                Llenar(Id);
            }
            else if (Id == -1)
            {
                TxtEliminar.Enabled = false;
                TxtIdProv.Visible = false;
                BtnCancelar.Visible = false;
            }
        }
        private void LlenarComboBox()
        {
            string query = "SELECT Id_Regimen, Descripcion_Regimen FROM Regime_Fiscal";

            using (SqlConnection connection = new SqlConnection(Convert.ToString(c.conexion())))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    CmbRegimen.Items.Clear();

                    while (reader.Read())
                    {
                        ArregloIdRegimen.Add(Convert.ToInt16(reader["Id_Regimen"]));
                        CmbRegimen.Items.Add(reader["Descripcion_Regimen"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void Llenar(int Id)
        {
            try
            {
                TxtIdProv.Visible = true;
                TxtEliminar.Enabled = true;
                BtnCancelar.Visible = true;
                TxtIdProv.Text = Id.ToString();


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Proveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 1);
                cmd.Parameters.AddWithValue("@Id_Proveedor", Convert.ToInt32(TxtIdProv.Text));
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtCoProv.Text = reader["Correo_Proveedor"].ToString();
                            TxtCPProv.Text = reader["Cp_Proveedor"].ToString();
                            TxtDiProv.Text = reader["Direccion_Proveedor"].ToString();
                            CmbRegimen.SelectedIndex = ArregloIdRegimen.IndexOf(Convert.ToInt32(reader["Id_Regimen"]));
                            TxtNomProv.Text = reader["Nombre_Proveedor"].ToString();
                            TxtRfcProv.Text = reader["Rfc_Proveedor"].ToString();
                            TxtTelProv.Text = reader["Telefono_Proveedor"].ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con ID " + TxtIdProv.Text);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Proveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 2);
                cmd.Parameters.AddWithValue("@Id_Proveedor", TxtIdProv.Text);
                cmd.Parameters.AddWithValue("@Nombre_Proveedor", TxtNomProv.Text);
                cmd.Parameters.AddWithValue("@Telefono_Proveedor", TxtTelProv.Text);
                cmd.Parameters.AddWithValue("@Correo_Proveedor", TxtCoProv.Text);
                cmd.Parameters.AddWithValue("@Direccion_Proveedor", TxtDiProv.Text);
                cmd.Parameters.AddWithValue("@Rfc_Proveedor", TxtRfcProv.Text);
                cmd.Parameters.AddWithValue("@Cp_Proveedor", TxtCPProv.Text);
                cmd.Parameters.AddWithValue("@Id_Regimen", ArregloIdRegimen[CmbRegimen.SelectedIndex]);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                Limpiar();
                TxtEliminar.Enabled = false;
                TxtIdProv.Visible = false;
                BtnCancelar.Visible = false;
                TxtIdProv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Buscar_Proveedores form_Buscar_Producto = new Form_Buscar_Proveedores();
            form_Buscar_Producto.Show();
            this.Close();
        }

        private void TxtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Proveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 3);
                cmd.Parameters.AddWithValue("@Id_Proveedor", Convert.ToInt32(TxtIdProv.Text));


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Eliminado");
                Limpiar();
                TxtEliminar.Enabled = false;
                TxtIdProv.Visible = false;
                BtnCancelar.Visible = false;
                TxtIdProv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtEliminar.Enabled = false;
            TxtIdProv.Visible = false;
            BtnCancelar.Visible = false;
            TxtIdProv.Clear();
        }
        void Limpiar()
        {
            TxtCoProv.Clear();
            TxtCPProv.Clear();
            TxtDiProv.Clear();
            TxtNomProv.Clear();
            TxtRfcProv.Clear();
            TxtTelProv.Clear();
            CmbRegimen.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
