using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonas
{
    class Persona
    {

        String dpi;
        String nombre;
        private String apellido;
        DateTime FechaNacimiento;

        //Encapsulado
        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }

        public void PrimeraMayuscula()
        {

            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                nombre = nombreMayuscula.ToString();

            }

            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }


        }

        public void Espaciado()
        {
            
        }

        public int Edad()
        {

            DateTime actual = DateTime.Today;
            int edad = actual.Year - FechaNacimiento1.Year;

            return edad;

        }

        public void normalizarNombre()
        {


        }
    }
}
