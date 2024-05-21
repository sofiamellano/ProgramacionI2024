using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    internal class Gerente : Empleado
    {
        public Gerente(string nombre, string apellido) : base(nombre, apellido)
        {
        }
        public override string ImprimirDatos()
        {
            return "Gerente: "+ base.ImprimirDatos();
        }
    }
}
