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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Refaccionaria
{
    public partial class Form_Clientes : Form
    {
        List<int> ArregloIdRegimen = new List<int>();
        static Conexion c = new Conexion();
        static string Connection = Convert.ToString(c.conexion());
        SqlConnection con = new SqlConnection(Connection);
        SqlCommand cmd = new SqlCommand();

        public Form_Clientes(int Id)
        {   
            InitializeComponent();
            BtnLlenar.Visible = false;
            cmd.Connection = con;
            LlenarComboBox();
            if (Id > -1) 
            { 
                TxtCliId.Visible = true;
                BtnEliminar.Enabled = true;
                BtnCancelar.Visible = true;
                TxtCliId.Text = Id.ToString();
                Llenar();
                
            }
            else if (Id == -1)
            {
                BtnLlenar.Visible = false;
                TxtCliId.Visible = false;
                BtnCancelar.Visible= false;
                BtnEliminar.Enabled= false;
            }
            
        }
        void Limpiar()
        {
            TxtApellidoMaCli.Clear();
            TxtApellPaCli.Clear();
            TxtCorreoCli.Clear();
            TxtDireccinCli.Clear();
            TxtNombreCli.Clear();
            TxtRfcCli.Clear();
            NudCodigoP.Value = 0;
            NudTelefono.Value = 0;
        }
        private void LlenarComboBox()
        {
            string query = "SELECT Id_Regimen, Descripcion_Regimen FROM Regime_Fiscal";

            using (SqlConnection connection = new SqlConnection(Connection))
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Cliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 2); 
                cmd.Parameters.AddWithValue("@Id_Cliente", TxtCliId.Text);
                cmd.Parameters.AddWithValue("@Nom_Cliente", TxtNombreCli.Text); 
                cmd.Parameters.AddWithValue("@Direccion_Cliente", TxtDireccinCli.Text); 
                cmd.Parameters.AddWithValue("@Telefono_Cliente", NudTelefono.Value);
                cmd.Parameters.AddWithValue("@Correo_Cliente", TxtCorreoCli.Text);
                cmd.Parameters.AddWithValue("@Apellido_Paterno_Cliente", TxtApellPaCli.Text);
                cmd.Parameters.AddWithValue("@Rfc_Cliente", TxtRfcCli.Text);
                cmd.Parameters.AddWithValue("@Apellido_Materno_Cliente", TxtApellidoMaCli.Text);
                cmd.Parameters.AddWithValue("@Codigo_Postal_Cliente", NudCodigoP.Value);
                cmd.Parameters.AddWithValue("@Id_Regimen", ArregloIdRegimen[CmbRegimen.SelectedIndex]);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Buscar_Cli form_Buscar_Cli = new Form_Buscar_Cli();
            form_Buscar_Cli.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Cliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 3);
                cmd.Parameters.AddWithValue("@Id_Cliente", Convert.ToInt32(TxtCliId.Text));


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Eliminado");
                BtnEliminar.Enabled = false;
                TxtCliId.Visible = false;
                BtnCancelar.Visible = false;
                BtnLlenar.Visible = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            TxtCliId.Visible = false;
            BtnCancelar.Visible = false;
            BtnLlenar.Visible = false;
            TxtCliId.Clear();
        }

        private void BtnLlenar_Click(object sender, EventArgs e)
        {
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SP_Cliente";
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@OP", 1);
            //cmd.Parameters.AddWithValue("@Id_Cliente", Convert.ToInt32(TxtCliId.Text));
            //con.Open();
            //using (SqlDataReader reader = cmd.ExecuteReader())
            //{
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            TxtNombreCli.Text = reader["Nom_Cliente"].ToString();
            //            TxtApellPaCli.Text = reader["Apellido_Paterno_Cliente"].ToString();
            //            TxtApellidoMaCli.Text = reader["Apellido_Materno_Cliente"].ToString();
            //            TxtDireccinCli.Text = reader["Direccion_Cliente"].ToString();
            //            TxtRfcCli.Text = reader["Rfc_Cliente"].ToString();
            //            TxtCorreoCli.Text = reader["Correo_Cliente"].ToString();
            //            NudTelefono.Value = Convert.ToInt64(reader["Telefono_Cliente"]);
            //            NudCodigoP.Value = Convert.ToInt32(reader["Codigo_Postal_Cliente"]);
            //            //TxtIdReCli.Text = reader["Id_Regimen"].ToString();
            //            //int idRegimen = Convert.ToInt32(reader["Id_Regimen"]);
            //            //int index = ArregloIdRegimen.IndexOf(idRegimen);
            //            CmbRegimen.SelectedIndex = ArregloIdRegimen.IndexOf(Convert.ToInt32(reader["Id_Regimen"]));

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontró el cliente con ID " + TxtCliId.Text);
            //    }
            //}

            //con.Close();
        }
        void Llenar()
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Cliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 1);
                cmd.Parameters.AddWithValue("@Id_Cliente", Convert.ToInt32(TxtCliId.Text));
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtNombreCli.Text = reader["Nom_Cliente"].ToString();
                            TxtApellPaCli.Text = reader["Apellido_Paterno_Cliente"].ToString();
                            TxtApellidoMaCli.Text = reader["Apellido_Materno_Cliente"].ToString();
                            TxtDireccinCli.Text = reader["Direccion_Cliente"].ToString();
                            TxtRfcCli.Text = reader["Rfc_Cliente"].ToString();
                            TxtCorreoCli.Text = reader["Correo_Cliente"].ToString();
                            NudTelefono.Value = Convert.ToInt64(reader["Telefono_Cliente"]);
                            NudCodigoP.Value = Convert.ToInt32(reader["Codigo_Postal_Cliente"]);
                            //TxtIdReCli.Text = reader["Id_Regimen"].ToString();
                            //int idRegimen = Convert.ToInt32(reader["Id_Regimen"]);
                            //int index = ArregloIdRegimen.IndexOf(idRegimen);
                            CmbRegimen.SelectedIndex = ArregloIdRegimen.IndexOf(Convert.ToInt32(reader["Id_Regimen"]));

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con ID " + TxtCliId.Text);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
