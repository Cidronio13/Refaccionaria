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
    public partial class Form_Buscar_Cli : Form
    {
        static Conexion c = new Conexion();
        string sConexion = Convert.ToString(c.conexion());
        public Form_Buscar_Cli()
        {
            InitializeComponent();
            this.clienteTableAdapter.Connection.ConnectionString = sConexion;
            LblCliID.Visible = false;
            button1.Enabled = false;
        }

        private void Form_Buscar_Cli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEFACCIONRIADataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.rEFACCIONRIADataSet.Cliente);

        }

        void rellenar()
        {
            try
            {
                this.clienteTableAdapter.FillBy(this.rEFACCIONRIADataSet.Cliente, TxtFiltro.Text);
                //LblCliID.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LblCliID.Text);
            Form_Clientes Cli = new Form_Clientes(id);
            Cli.ShowDialog();
            this.Close();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LblCliID.Text =dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                LblCliID.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                LblCliID.Visible = false;
                button1.Enabled = false;
                LblCliID.Text = "-1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form_Clientes Cli = new Form_Clientes(-1);
            Cli.ShowDialog();
            this.Close();
        }
    }
}
