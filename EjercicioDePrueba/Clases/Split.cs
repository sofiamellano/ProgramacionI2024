using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    internal class Split
    {
        // declaramos los campos y propiedades
        
        //CAMPOS: son las variables privadas de la clase
        private string color;
        private int frigorias;
        private string marca;
        private bool encendido = false;

        //PROPIEDADES: son las variables publicas de la clase y van en mayuscula
        public int temperatura; //se pueden acceder desde afuera de la clase o sea externamente
        public string modo;

        //CONSTRUCTOR: metodo que se ejecuta cuando la classe se crea, se instancia en memoria, es decir cuando se construye el objeto.
        public Split(string pColor, int pFrigorias, string pMarca)
        {
            this.color = pColor;
            this.frigorias = pFrigorias;
            this.marca = pMarca;

            this.temperatura = 24;
            this.modo = "Cool";
            this.encendido = false;
        }

        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }

        public void SubirTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura++;
            }
            else
            {
                Console.WriteLine("Error: El split está apagado");
            }
        }

        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }
            else
            {
                Console.WriteLine("Error: El split está apagado");
            }
        }

        public void CambiarModo(string modo)
        {
            if (this.encendido)
                this.modo = modo;
            else
                Console.WriteLine("Error: El split debe estar encendido!");
        }
    }
}
