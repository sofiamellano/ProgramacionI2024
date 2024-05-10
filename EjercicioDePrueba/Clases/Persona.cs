using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    internal class Persona
    {
        private string nombre;
        private string direccion;
        private int año_nac;

        public Persona(string nombre, string direccion, int año_nac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.año_nac = año_nac;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }
    }
}
