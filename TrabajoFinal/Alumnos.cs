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
        private string usuario;
        public Alumnos(string usuario)
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = usuario;
            //CargarTabla();

        }

        public void CargarTabla()
        {

            string consulta = "select * from Alumnos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectar.Conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_verAlumnos.DataSource = dt;
            conectar.Cerrar();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(this.usuario);
            this.Hide();
            DialogResult resultado = frm1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string consulta = "BuscarAlumno";
            SqlCommand comando = new SqlCommand(consulta, conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@dni", txtDni.Text);
            comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_verAlumnos.DataSource= dt;

        }
    }
}
