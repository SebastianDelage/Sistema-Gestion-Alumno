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

namespace TrabajoFinal
{
    public partial class Alumnos : Form
    {
        private ConexionBBDD conectar;
        public Alumnos()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            CargarTabla();

        }

        public void CargarTabla()
        {

            string consulta = "select * from Alumnos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conectar.Cerar();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            DialogResult resultado = frm1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar.Abrir();
            string consulta = "ModificarAlumno";
            SqlCommand comando = new SqlCommand(consulta);
            comando.Parameters.AddWithValue("@Nombre", textBox1.Text);
            comando.Parameters.AddWithValue("@matricula", textBox2.Text);
            comando.Parameters.AddWithValue("@email", textBox3.Text);
            comando.Parameters.AddWithValue("@telefono", textBox4.Text);

            MessageBox.Show("modificado correctamente");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
