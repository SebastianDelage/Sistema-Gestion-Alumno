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


    public partial class Login : Form
    {
        bool oculta = true;

        private ConexionBBDD conectar;

        public Login()
        {
            InitializeComponent();
            conectar = new ConexionBBDD();
            conectar.Abrir();
        }

        private void pbOjo_Click(object sender, EventArgs e)
        {
            if (oculta)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
            oculta = !oculta;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            conectar.Cerrar();
            this.Close();
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {

            string Contraseña = txtContraseña.Text;
            string Usuario = txtUsuario.Text;

            // Condiciones
            if (conectar.Conexion.State == System.Data.ConnectionState.Closed)
            {
                conectar.Abrir();
            }

            string consulta = "BuscarPerfil";
            using (SqlCommand comando = new SqlCommand(consulta, conectar.Conexion))
            {




                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                SqlParameter paramSalida = new SqlParameter("@id_perfil", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                comando.Parameters.Add(paramSalida);

                comando.ExecuteNonQuery();




                if (paramSalida.Value != DBNull.Value)
                {
                    int idPerfil = (int)paramSalida.Value;


                    switch (idPerfil)
                    {
                        case 1:

                            break;
                        case 2:
                            Form1 frmProfesores = new Form1(Usuario);
                            this.Hide();
                            DialogResult result = frmProfesores.ShowDialog();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                }
                else
                {

                    MessageBox.Show("No se encontró un perfil con ese usuario.");
                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
