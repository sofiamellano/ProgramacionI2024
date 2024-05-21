using EjercicioDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    internal class EstereoAuto
    {
        //Campos
        private string color;
        private string marca;

        // Propiedades
        public bool encendido;
        public ModoEstereo modo;
        public double frecuencia;
        public string cancion;
        public int pistaCD;
        public string dispositivoAuxiliar;

        public EstereoAuto(string color, string marca, double frecuencia, string cancion, int pistaCD, string dispositivoAuxiliar)
        {
            this.encendido = false;
            this.modo = ModoEstereo.Radio;
            this.frecuencia = frecuencia;
            this.cancion = cancion;
            this.pistaCD = pistaCD;
            this.color = color; 
            this.marca = marca;
            this.dispositivoAuxiliar = dispositivoAuxiliar;
        }

        public void BotonEncender()
        {
            this.encendido = !encendido;
            if (encendido)
                Console.WriteLine("El estéreo está encendido.");
            else
                Console.WriteLine("El estéreo está apagado.");

        }

        public void CambiarModo(ModoEstereo nuevoModo)
        {
            if (this.encendido)
            {
                this.modo = nuevoModo;
                Console.WriteLine($"Modo {nuevoModo} seleccionado.");
            }
            else
                Console.WriteLine("Error: El estereo debe estar encencido!");
        }

        public void ElejirRadio (double nuevaFrecuencia)
        {
            if (this.modo == ModoEstereo.Radio)
            {
                this.frecuencia = nuevaFrecuencia;
                Console.WriteLine($"Frecuencia de radio elejida: {nuevaFrecuencia}");
            }
            else
            {
                Console.WriteLine("Error: No esta en modo Radio!");
            }
        }

        public void ElejirCancion (string nuevaCancion)
        {
            if (this.modo == ModoEstereo.Bluetooth)
            {
                this.cancion = nuevaCancion;
                Console.WriteLine($"Reproduciendo la canción: {nuevaCancion}");
            }
            else
            {
                Console.WriteLine("Error: no esta en modo Bluethooth!");
            }
        }

        public void ElejirPista (int nuevaPista)
        {
            if (this.modo == ModoEstereo.CD)
            {
                this.pistaCD = nuevaPista;
                Console.WriteLine($"Reproduciendo la pista número: {nuevaPista}");
            }
            else
            {
                Console.WriteLine("Error: no esta en modo CD!");
            }
        }

        public void Display()
        {
            if (encendido)
            {
                if (modo == ModoEstereo.Radio)
                {
                    Console.WriteLine($"Modo: Radio, Frecuencia: {frecuencia} FM");
                }
                else if (modo == ModoEstereo.Bluetooth)
                {
                    Console.WriteLine($"Modo: Bluetooth, Canción: {cancion}");
                }
                else if (modo == ModoEstereo.CD)
                {
                    Console.WriteLine($"Modo: CD, Pista: {pistaCD}");
                }
                else if (modo == ModoEstereo.Auxiliar)
                {
                    Console.WriteLine($"Modo: Auxiliar, Dispositivo: {dispositivoAuxiliar}");
                }
                else
                {
                    Console.WriteLine("El estéreo está encendido pero no hay modo seleccionado.");
                }
            }
            else
            {
                Console.WriteLine("El estéreo está apagado.");
            }
        }

        public void SeleccionarDispositivoAuxiliar(string nuevoDispositivo)
        {
            if (this.modo == ModoEstereo.Auxiliar)
            {
                this.dispositivoAuxiliar = nuevoDispositivo;
                Console.WriteLine($"Dispositivo auxiliar conectado: {nuevoDispositivo}");
            }
            else
            {
                Console.WriteLine("Error: El modo actual no es Auxiliar.");
            }
        }
    }
}
