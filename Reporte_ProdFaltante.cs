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
    public partial class Reporte_ProdFaltante : Form
    {
        public Reporte_ProdFaltante()
        {
            InitializeComponent();
        }

        private void Reporte_ProdFaltante_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_Prod_Faltante WHERE Stock_Producto <= Stock_Minimo_Producto;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);


                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DsProdFaltante");

                    if (dataSet.Tables["DsProdFaltante"].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar en el reporte.");
                        return;
                    }

                    reportViewer1.LocalReport.ReportPath = "ReportProsFaltante.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource("DsProdFaltante", dataSet.Tables["DsProdFaltante"]);
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
