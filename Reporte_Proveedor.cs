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
    public partial class Reporte_Proveedor : Form
    {
        public Reporte_Proveedor()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_Datos_Prov";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);


                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DsProveedor");

                    if (dataSet.Tables["DsProveedor"].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar en el reporte.");
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = "ReportProveedor.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource("DsProveedor", dataSet.Tables["DsProveedor"]);
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
    }
}
