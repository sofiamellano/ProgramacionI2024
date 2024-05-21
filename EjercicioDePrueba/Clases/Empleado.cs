using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        protected Empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public virtual string ImprimirDatos()
        {
            return $"{Apellido} {Nombre}";
        }
    }
}
