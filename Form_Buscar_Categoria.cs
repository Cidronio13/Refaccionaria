using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria
{
    public partial class Form_Buscar_Categoria : Form
    {
        static Conexion c = new Conexion();
        string sConexion = Convert.ToString(c.conexion());
        public Form_Buscar_Categoria()
        {
            InitializeComponent();
            this.categoria_ProductoTableAdapter.Connection.ConnectionString = sConexion;
            button1.Enabled = false;
        }

        private void Form_Buscar_Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEFACCIONRIADataSet1.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter.Fill(this.rEFACCIONRIADataSet1.Categoria_Producto);

        }
        void rellenar()
        {
            try
            {
                this.categoria_ProductoTableAdapter.FillBy(this.rEFACCIONRIADataSet1.Categoria_Producto, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form_Categoria form_Categoria = new Form_Categoria(Convert.ToInt32(LblProdId.Text));
            form_Categoria.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void DgvBuCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvBuCat.SelectedRows.Count > 0)
            {
                LblProdId.Text = DgvBuCat.SelectedRows[0].Cells["ID"].Value.ToString();
                LblProdId.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                LblProdId.Visible = false;
                button1.Enabled = false;
                LblProdId.Text = "-1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Categoria form_Categoria = new Form_Categoria(-1);
            form_Categoria.Show();
            this.Close();
        }
    }
}
