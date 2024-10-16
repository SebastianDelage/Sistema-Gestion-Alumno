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

    public partial class Form1 : Form
    {
        private ConexionBBDD conectar;
        private string usuario;
        public Form1(string Usuario)
        {

            InitializeComponent();
            conectar = new ConexionBBDD();
            this.usuario = Usuario;
            this.Load += new EventHandler(label4_Click);
            this.Load += new EventHandler(label5_Click);
            CargarTabla();

            Conectarbbdd();
        }


        public void Conectarbbdd()
        {
            conectar.Abrir();
        }

        public void CargarTabla()
        {
            //llenado de datagrid
            string consulta = "Profesor_Y_Materia";
            SqlCommand comando = new SqlCommand(consulta,conectar.Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario",this.usuario);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtg_Pofesorxmateria.DataSource = dt;
            // ajuste de datagrid
            dtg_Pofesorxmateria.Columns[0].HeaderText = "Nombre";
            dtg_Pofesorxmateria.Columns[1].HeaderText = "Materia";

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos(this.usuario);
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblNota.Text = DateTime.Now.ToString("t");
        }


    
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notas formNotas = new Notas();
            this.Hide();
            DialogResult resultado = formNotas.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
