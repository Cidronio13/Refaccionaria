using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Refaccionaria
{
    public partial class Form_Venta : Form
    {
        int Cont = 0;
        List<int> ArregloIdCliente = new List<int>();
        List<int> ArregloIdProducto = new List<int>();
        List<int> ArregloIdMetodo = new List<int>();
        List<int> ArregloIdTrabajador = new List<int>();
        private dsVentaDet dsVentaDet = new dsVentaDet();
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(c.conexion());
        string sConexion = Convert.ToString(c.conexion());
        int idDetalle = 0, Id_Prod;
        System.Windows.Forms.RadioButton radioButtonNo = new System.Windows.Forms.RadioButton();
        System.Windows.Forms.RadioButton radioButtonYes = new System.Windows.Forms.RadioButton();
        public Form_Venta(int id_Prod)
        {
            InitializeComponent();
            Id_Prod = id_Prod;
            this.sConexion = sConexion;
            consecutivo();
            idDetalle = consecutivoDetalle();

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            Cont = 0;
            cargarComboBox("Nom_Cliente", "Nombre", "Cliente", cbCliente, "Id_Cliente");
            cargarComboBox("Descripcion_Producto", "Nombre", "Productos", cbProducto, "Id_Producto");
            cargarComboBox("Descripcion_Metodo_Pago", "Metodo", "Metodo_De_Pago", cbMetodoPago, "Id_Metodo_Pago");
            cargarComboBox("Nom_Trabajador", "Nombre", "Trabajador", cbTrabajador, "Id_Trabajador");
            //cbProducto.Text = Convert.ToString(Id_Prod);
            cbProducto.SelectedIndex = ArregloIdProducto.IndexOf(Id_Prod);
            dtDetalle.DataSource = dsVentaDet.spVentaDet;

            
            radioButtonYes.Text = "Sí";
            radioButtonYes.Location = new Point(10, 20);
            radioButtonYes.Checked = true;
            groupBox1.Controls.Add(radioButtonYes);

            
            radioButtonNo.Text = "No";
            radioButtonNo.Location = new Point(10, 50);
            groupBox1.Controls.Add(radioButtonNo);
            this.reportViewer1.RefreshReport();
        }
        void cargarComboBox(string value, string display, string tabla, ComboBox combo, string Coso)
        {
            string consulta = $"SELECT * FROM {tabla}";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(sConexion))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(consulta, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    combo.Items.Clear();
                    if (Cont == 0)
                    {
                        while (reader.Read())
                        {
                            ArregloIdCliente.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 1)
                    {
                        while (reader.Read())
                        {
                            ArregloIdProducto.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 2)
                    {
                        while (reader.Read())
                        {
                            ArregloIdMetodo.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                    else if (Cont == 3)
                    {
                        while (reader.Read())
                        {
                            ArregloIdTrabajador.Add(Convert.ToInt16(reader[Coso]));
                            combo.Items.Add(Convert.ToString(reader[value]));
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            Cont++;
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            //da.Fill(dt);
            //con.Close();
            //combo.DataSource = dt;
            //combo.DisplayMember = display;
            //combo.ValueMember = value;

            //using (SqlConnection connection = new SqlConnection(Connection))
            //{
            //    try
            //    {
            //        connection.Open();

            //        SqlCommand command = new SqlCommand(query, connection);

            //        SqlDataReader reader = command.ExecuteReader();

            //        CmbRegimen.Items.Clear();

            //        while (reader.Read())
            //        {
            //            ArregloIdRegimen.Add(Convert.ToInt16(reader["Id_Regimen"]));
            //            CmbRegimen.Items.Add(reader["Descripcion_Regimen"].ToString());
            //        }

            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }
        void consecutivo()
        {
            string consulta = "SELECT ISNULL(MAX(Id_Venta) + 1, 1) AS maxid FROM Venta";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtID.Text = lector["maxid"].ToString();
            }
            con.Close();
        }

        int consecutivoDetalle()
        {
            string consulta = "SELECT ISNULL(MAX(Id_Venta), 0) AS maxid FROM Venta_Detallle";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            int id = 0;
            if (lector.Read())
            {
                id = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta x = new Venta(sConexion);
                x.Detalles = dsVentaDet.spVentaDet;
                x.Id_Pedido = int.Parse(txtID.Text);
                x.Fecha_Pedido = dtpFechaVenta.Value;
                x.Importe_Pedido = decimal.Parse(txtImporte.Text);
                x.Total_Pedido = decimal.Parse(txtTotal.Text);
                x.Id_Cliente = int.Parse(ArregloIdCliente[cbCliente.SelectedIndex].ToString());
                x.Id_Metodo_Pago = int.Parse(ArregloIdMetodo[cbMetodoPago.SelectedIndex].ToString());
                x.Id_Trabajador = int.Parse(ArregloIdTrabajador[cbTrabajador.SelectedIndex].ToString());
                MessageBox.Show(x.Guardar());
                if (radioButtonYes.Checked)
                {
                    Imprimir();
                }
                else if (radioButtonNo.Checked)
                {
                    
                }
                dtDetalle.ClearSelection();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                dsVentaDet.spVentaDetRow row = dsVentaDet.spVentaDet.NewspVentaDetRow();
                row.Id_Venta = int.Parse(txtID.Text);
                row.Id_Producto = int.Parse(ArregloIdProducto[cbProducto.SelectedIndex].ToString());
                row.Cantidad_Venta = int.Parse(txtCantidad.Text);
                row.Precio_Venta = decimal.Parse(txtPrecio.Text);
                row.Total_Venta = row.Cantidad_Venta * row.Precio_Venta;
                dsVentaDet.spVentaDet.AddspVentaDetRow(row);
                dtDetalle.Refresh();
                txtImporte.Text = (Double.Parse(txtTotal.Text) + Double.Parse(txtImporte.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtTotal.Text = (Double.Parse(txtPrecio.Text) * Double.Parse(txtCantidad.Text)).ToString();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtTotal.Text = (Double.Parse(txtPrecio.Text) * Double.Parse(txtCantidad.Text)).ToString();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT Precio_Producto AS Precio FROM Productos WHERE Id_Producto = "+ int.Parse(ArregloIdProducto[cbProducto.SelectedIndex].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtPrecio.Text = lector["Precio"].ToString();
            }
            con.Close();
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            int Coso = 2;
            Form_Buscar_Producto form_Buscar_Producto = new Form_Buscar_Producto(Coso);
            form_Buscar_Producto.Show();
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            dsVentaDet.spVentaDet.Rows.Clear();
            txtPrecio.Text = "0";
            txtImporte.Text = "0";
            txtCantidad.Clear();
            txtID.Clear();
            txtTotal.Text =  "0";
            cbCliente.Text = "";
            cbMetodoPago.Text = "";
            cbProducto.Text = "";
            cbTrabajador.Text = "";
            consecutivo();
        }
        void Imprimir()
        {
            Generar();
            byte[] pdfBytes = reportViewer1.LocalReport.Render(
                "PDF",
                null,
                out string mimeType,
                out string encoding,
                out string fileNameExtension,
                out string[] streams,
                out Warning[] warnings);

            string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReporteGenerado.pdf");
            File.WriteAllBytes(outputFilePath, pdfBytes);

            MessageBox.Show($"Ticket Generado Con Exito En El Escritorio");
        }
        void Generar()
        {
            try
            {
                Conexion c = new Conexion();
                string connectionString = Convert.ToString(c.conexion());
                string query = "SELECT * FROM VW_REGISTRO_VENTA WHERE Id_Venta = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@Id", int.Parse(txtID.Text));
                    //adapter.SelectCommand.Parameters.AddWithValue("@FechaVentaFinal", DtFechaFinal.Value.Date);

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
