using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrabajoFinal
{
    internal class ConexionBBDD
    {
       // string cadena = "Data Source = 192.168.0.100; Database=u23; User Id = u23; Password=u23";
        string cadena = "Data Source = DESKTOP-TS1BI4L\\SQLEXPRESS ; initial catalog= TrabajoFinal; Integrated Security=True";


        public SqlConnection conectar = new SqlConnection();

        public ConexionBBDD()
        {
            conectar = new SqlConnection(cadena);
        }

        public SqlConnection Conexion
        {
            get { return conectar; }
        }
        public void Abrir ()
        {
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cerar() 
        {
            conectar.Close();
        }
    }
}
