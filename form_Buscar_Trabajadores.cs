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
    public partial class form_Buscar_Trabajadores : Form
    {
        static Conexion c = new Conexion();
        string sConexion = Convert.ToString(c.conexion());
        public form_Buscar_Trabajadores()
        {
            InitializeComponent();
            this.trabajadorTableAdapter.Connection.ConnectionString = sConexion;
            button1.Enabled = false;
        }
        void rellenar()
        {
            try
            {
                this.trabajadorTableAdapter.FillBy(this.rEFACCIONRIADataSet4.Trabajador, TxtFiltro.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void form_Buscar_Trabajadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEFACCIONRIADataSet4.Trabajador' Puede moverla o quitarla según sea necesario.
            this.trabajadorTableAdapter.Fill(this.rEFACCIONRIADataSet4.Trabajador);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Trabajadores form_Trabajadores = new Form_Trabajadores(Convert.ToInt32(LblIdTra.Text));
            form_Trabajadores.Show();
            this.Close();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void DgvBuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvBuTra.SelectedRows.Count > 0)
            {
                LblIdTra.Text = DgvBuTra.SelectedRows[0].Cells["ID"].Value.ToString();
                LblIdTra.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                LblIdTra.Visible = false;
                button1.Enabled = false;
                LblIdTra.Text = "-1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Trabajadores form_Trabajadores = new Form_Trabajadores(-1);
            form_Trabajadores.Show();
            this.Close();
        }
    }
}
