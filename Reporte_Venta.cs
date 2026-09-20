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
    public partial class Reporte_Venta : Form
    {
        public Reporte_Venta()
        {
            InitializeComponent();
        }

        private void Reporte_Venta_Load(object sender, EventArgs e)
        {
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_REGISTRO_VENTA WHERE Fecha_Venta >= @FechaVenta AND Fecha_Venta <= @FechaVentaFinal";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@FechaVenta", DtFecha.Value.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaVentaFinal", DtFechaFinal.Value.Date);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DsVenta");

                    if (dataSet.Tables["DsVenta"].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar en el reporte.");
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = "ReportVenta.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource("DsVenta", dataSet.Tables["DsVenta"]);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                }

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
