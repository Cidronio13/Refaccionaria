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
    public partial class Reporte_Compra : Form
    {
        public Reporte_Compra()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_INFORMACION_COMPRA WHERE Fecha_Compra >= @FechaCompra AND Fecha_Compra <= @FechaVentaFinal";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@FechaCompra", DtFecha.Value.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaVentaFinal", DtFechaFinal.Value.Date);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DsCompra");

                    if (dataSet.Tables["DsCompra"].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar en el reporte.");
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = "ReportCompra.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource("DsCompra", dataSet.Tables["DsCompra"]);
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

        private void Reporte_Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
