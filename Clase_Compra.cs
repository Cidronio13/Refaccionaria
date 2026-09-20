using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaccionaria
{
    internal class Clase_Compra
    {
        private string sConexion;
        public DataTable Detalles { get; set; }
        public int Id_Compra { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public decimal Importe_Compra { get; set; }
        public decimal Total_Compra { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Trabajador, Id_Producto, Cantidad_Compra;
        public decimal Precio_Compra;

        public Clase_Compra(string conexion)
        {
            this.sConexion = conexion;
        }

        public string Guardar()
        {
            SqlConnection con = new SqlConnection(sConexion);
            con.Open();

            SqlCommand cmd = new SqlCommand("spCompra", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@op", 2);
            cmd.Parameters.AddWithValue("@Id_Compra", Id_Compra);
            cmd.Parameters.AddWithValue("@Fecha_Compra", Fecha_Compra);
            cmd.Parameters.AddWithValue("@Importe_Compra", Importe_Compra);
            cmd.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            cmd.Parameters.AddWithValue("@Id_Producto", Id_Producto);
            cmd.Parameters.AddWithValue("@Cantidad_Compra", Cantidad_Compra);
            cmd.Parameters.AddWithValue("@Precio_Compra", Precio_Compra);

            SqlParameter paramDetalles = new SqlParameter("@detalles", SqlDbType.Structured);
            paramDetalles.Value = Detalles;
            cmd.Parameters.Add(paramDetalles);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return "Compra guardada con éxito";
            }
            catch (Exception ex)
            {
                con.Close();
                return "Error: " + ex.Message;
            }
        }
    }
}
