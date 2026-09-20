using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaccionaria
{
    internal class Venta
    {
        private string sConexion;
        public DataTable Detalles { get; set; }
        public int Id_Pedido { get; set; }
        public DateTime Fecha_Pedido { get; set; }
        public decimal Importe_Pedido { get; set; }
        public decimal Total_Pedido { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Metodo_Pago { get; set; }
        public int Id_Trabajador;

        public Venta(string conexion)
        {
            this.sConexion = conexion;
        }

        public string Guardar()
        {
            SqlConnection con = new SqlConnection(sConexion);
            con.Open();

            SqlCommand cmd = new SqlCommand("spVenta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@op", 2);
            cmd.Parameters.AddWithValue("@Id_Venta", Id_Pedido);
            cmd.Parameters.AddWithValue("@Fecha_Venta", Fecha_Pedido);
            cmd.Parameters.AddWithValue("@Importe_Venta", Importe_Pedido);
            cmd.Parameters.AddWithValue("@Total_Venta", Total_Pedido);
            cmd.Parameters.AddWithValue("@Status_Venta", 1);
            cmd.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("@Id_Metodo_Pago", Id_Metodo_Pago);
            cmd.Parameters.AddWithValue("@Id_Trabajador", Id_Trabajador);

            SqlParameter paramDetalles = new SqlParameter("@detalles", SqlDbType.Structured);
            paramDetalles.Value = Detalles;
            cmd.Parameters.Add(paramDetalles);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return "Venta guardada con éxito";
            }
            catch (Exception ex)
            {
                con.Close();
                return "Error: " + ex.Message;
            }
        }
    }
}
