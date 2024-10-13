using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private int Dni {  get; set; }
        public string DomicilioCalle {  get; set; }
        public int DomicilioNumero { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        private string Usuario { get; set; }
        private string Contraseña { get; set; }
        public int Id_perfil { get; set; }
        public DateOnly Fecha_ingreso { get; set; }
        public DateOnly Fecha_egreso { get; set; }


    }
}
