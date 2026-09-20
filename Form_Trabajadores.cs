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
    public partial class Form_Trabajadores : Form
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(Convert.ToString(c.conexion()));
        SqlCommand cmd = new SqlCommand();
        public Form_Trabajadores(int Id)
        {
            InitializeComponent();
            cmd.Connection = con;
            if (Id > -1)
            {
                try
                {
                    TxtIdTra.Visible = true;
                    BtnEliminar.Enabled = true;
                    BtnCancelar.Visible = true;
                    TxtIdTra.Text = Id.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Datos_Trabajador";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@OP", 1);
                    cmd.Parameters.AddWithValue("@Id_Trabajador", Convert.ToInt32(TxtIdTra.Text));
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TxtApeMaTra.Text = reader["Apellido_Materno_Trabajador"].ToString();
                                TxtApePaTra.Text = reader["Apellido_Paterno_Trabajador"].ToString();
                                TxtEstadoTra.Text = reader["Estado_Trabajador"].ToString();
                                TxtTelTra.Text = reader["Telefono_Trabajador"].ToString();
                                TxtHorarioTra.Text = reader["Horario_Trabajador"].ToString();
                                TxtNomTra.Text = reader["Nom_Trabajador"].ToString();
                                TxtNssTra.Text = reader["Nss_Trabajador"].ToString();
                                TxtRfcTra.Text = reader["Rfc_Trabajador"].ToString();


                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con ID " + TxtIdTra.Text);
                        }
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (Id == -1)
            {
                TxtIdTra.Visible = false;
                BtnEliminar.Enabled = false;
                BtnCancelar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Trabajador";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 2);
                cmd.Parameters.AddWithValue("@Id_Trabajador", TxtIdTra.Text);
                cmd.Parameters.AddWithValue("@Nom_Trabajador", TxtNomTra.Text);
                cmd.Parameters.AddWithValue("@Apellido_Paterno_Trabajador", TxtApePaTra.Text);
                cmd.Parameters.AddWithValue("@Apellido_Materno_Trabajador", TxtApeMaTra.Text);
                cmd.Parameters.AddWithValue("@Rfc_Trabajador", TxtRfcTra.Text);
                cmd.Parameters.AddWithValue("@Horario_Trabajador", TxtHorarioTra.Text);
                cmd.Parameters.AddWithValue("@Telefono_Trabajador", TxtTelTra.Text);
                cmd.Parameters.AddWithValue("@Estado_Trabajador", TxtEstadoTra.Text);
                cmd.Parameters.AddWithValue("@Nss_Trabajador", TxtNssTra.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                BtnEliminar.Enabled = false;
                TxtIdTra.Visible = false;
                BtnCancelar.Visible = false;
                TxtIdTra.Clear();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_Buscar_Trabajadores form_Buscar_Trabajadores = new form_Buscar_Trabajadores();
            form_Buscar_Trabajadores.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Trabajador";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 3);
                cmd.Parameters.AddWithValue("@Id_Trabajador", Convert.ToInt32(TxtIdTra.Text));


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Eliminado");
                BtnEliminar.Enabled = false;
                TxtIdTra.Visible = false;
                BtnCancelar.Visible = false;
                TxtIdTra.Clear();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            TxtIdTra.Visible = false;
            BtnCancelar.Visible = false;
            TxtIdTra.Clear();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            TxtApeMaTra.Clear();
            TxtApePaTra.Clear();
            TxtEstadoTra.Clear();
            TxtHorarioTra.Clear();
            TxtNomTra.Clear();
            TxtNssTra.Clear();
            TxtRfcTra.Clear();
            TxtTelTra.Clear();
        }
    }
}
