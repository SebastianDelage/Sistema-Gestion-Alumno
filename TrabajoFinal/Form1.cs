using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
           
            InitializeComponent();
            conectar = new ConexionBBDD();
            this.Load += new EventHandler(label4_Click);
            this.Load += new EventHandler(label5_Click);
         
            Conectarbbdd();
        }

        public void Conectarbbdd()
        {
            conectar.Abrir();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumnos formAlumnos = new Alumnos();
            this.Hide();
            DialogResult resultado = formAlumnos.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("t");
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
    }
}
