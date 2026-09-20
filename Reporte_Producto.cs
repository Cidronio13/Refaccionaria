using Microsoft.Reporting.WinForms;
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
    public partial class Reporte_Producto : Form
    {
        List<int> ArregloIdProveedor = new List<int>();
        static Conexion c = new Conexion();
        public Reporte_Producto()
        {
            InitializeComponent();
            cargarComboBox("Nombre_Proveedor", "Nombre", "Proveedores", CmbProveedor, "Id_Proveedor");
            CmbProveedor.SelectedIndex = 0;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_Datos_Prod WHERE Proveedor = @Nombre";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@Nombre", Convert.ToString(CmbProveedor.Text));

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DsProducto");

                    if (dataSet.Tables["DsProducto"].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar en el reporte.");
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = "ReportProducto.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource("DsProducto", dataSet.Tables["DsProducto"]);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                }

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                    while (reader.Read())
                    {
                        ArregloIdProveedor.Add(Convert.ToInt16(reader[Coso]));
                        combo.Items.Add(Convert.ToString(reader[value]));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
