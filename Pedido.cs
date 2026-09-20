using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaccionaria
{
    internal class Pedido
    {
        private string sConexion;
        public DataTable Detalles { get; set; }
        public int Id_Pedido { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public decimal Importe_Pedido { get; set; }
        public decimal Total_Pedido { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Trabajador;

        public Pedido(string conexion)
        {
            this.sConexion = conexion;
        }

        public string Guardar()
        {
            SqlConnection con = new SqlConnection(sConexion);
            con.Open();

            SqlCommand cmd = new SqlCommand("spPedido", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@op", 2);
            cmd.Parameters.AddWithValue("@Id_Pedido", Id_Pedido);
            cmd.Parameters.AddWithValue("@Fecha_Pedido", Fecha_Pedido);
            cmd.Parameters.AddWithValue("@Importe_Pedido", Importe_Pedido);
            cmd.Parameters.AddWithValue("@Status_Pedido", 1);
            cmd.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("@Id_Trabajador", Id_Trabajador);

            SqlParameter paramDetalles = new SqlParameter("@detalles", SqlDbType.Structured);
            paramDetalles.Value = Detalles;
            cmd.Parameters.Add(paramDetalles);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return "Pedido guardado con éxito";
            }
            catch (Exception ex)
            {
                con.Close();
                return "Error: " + ex.Message;
            }
        }
    }
}
