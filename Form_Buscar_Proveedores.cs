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
    public partial class Form_Buscar_Proveedores : Form
    {
        static Conexion c = new Conexion();
        string sConexion = Convert.ToString(c.conexion());
        public Form_Buscar_Proveedores()
        {
            InitializeComponent();
            this.proveedoresTableAdapter.Connection.ConnectionString = sConexion;
            button1.Enabled = false;
        }
        void rellenar()
        {
            try
            {
                this.proveedoresTableAdapter.FillBy(this.rEFACCIONRIADataSet3.Proveedores, TxtIdProv.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Form_Buscar_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEFACCIONRIADataSet3.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.rEFACCIONRIADataSet3.Proveedores);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form_Proveedores form_Buscar_Proveedores = new Form_Proveedores(Convert.ToInt32(LblIdProv.Text));
            form_Buscar_Proveedores.Show();
            this.Close();
        }

        private void TxtIdProv_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LblIdProv.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                LblIdProv.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                LblIdProv.Visible = false;
                button1.Enabled = false;
                LblIdProv.Text = "-1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Proveedores form_Buscar_Proveedores = new Form_Proveedores(-1);
            form_Buscar_Proveedores.Show();
            this.Close();
        }
    }
}
