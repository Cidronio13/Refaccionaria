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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int EstadoTrab = 3;
            SqlConnection ConexionBaseDatos;
            Conexion c = new Conexion();
            ConexionBaseDatos = new SqlConnection(Convert.ToString(c.conexion()));
            ConexionBaseDatos.Open();
            String SQL = "SELECT Estado_Trabajador FROM TRABAJADOR WHERE Nom_Trabajador = '" + TxtUsuario.Text + "' and Rfc_Trabajador = " + TxtContraseña.Text;
            using (SqlCommand command = new SqlCommand(SQL, ConexionBaseDatos))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EstadoTrab = Convert.ToInt32(reader.GetBoolean(0));
                    }
                }
            }
            if (EstadoTrab == 1)
            {
                ConexionBaseDatos.Close();
                Form_Pr_Menu x = new Form_Pr_Menu();
                x.Show();
            }
            else if(EstadoTrab == 0)
            {
                MessageBox.Show("Trabajador inactivo");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
            TxtContraseña.Clear();
            TxtUsuario.Clear();
            ConexionBaseDatos.Close();
        }
    }
}
