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
    public partial class Form_Categoria : Form
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(Convert.ToString(c.conexion()));
        SqlCommand cmd = new SqlCommand();
        public Form_Categoria(int Id)
        {
            InitializeComponent();
            cmd.Connection = con;
            if (Id > -1)
            {
                TxtIdCat.Text = Id.ToString();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Categ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 1);
                cmd.Parameters.AddWithValue("@Id_Categoria", Convert.ToInt32(TxtIdCat.Text));
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtDescripcionCat.Text = reader["Descripcion_Categoria"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con ID " + TxtIdCat.Text);
                    }
                }

                con.Close();

                TxtIdCat.Visible = true;
                BtnEliminar.Enabled = true;
                button3.Visible = true;
                TxtIdCat.Text = Id.ToString();
            }
            else if (Id == -1)
            {
                TxtIdCat.Visible = false;
                BtnEliminar.Enabled = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Categ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 2);
                cmd.Parameters.AddWithValue("@Descripcion_Categoria", TxtDescripcionCat.Text);
                cmd.Parameters.AddWithValue("@Id_Categoria", TxtIdCat.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                BtnEliminar.Enabled = false;
                TxtIdCat.Visible = false;
                button3.Visible = false;
                TxtIdCat.Clear();
                TxtDescripcionCat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form_Categoria_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Buscar_Categoria Cat = new Form_Buscar_Categoria();
            Cat.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Datos_Categ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@OP", 3);
                cmd.Parameters.AddWithValue("@Id_Categoria", Convert.ToInt32(TxtIdCat.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Eliminado");
                BtnEliminar.Enabled = false;
                TxtIdCat.Visible = false;
                button3.Visible = false;
                TxtIdCat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            TxtIdCat.Visible = false;
            button3.Visible = false;
            TxtIdCat.Clear();
        }
    }
}
