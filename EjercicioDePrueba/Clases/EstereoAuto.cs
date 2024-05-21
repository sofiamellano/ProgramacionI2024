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
        public bool Encendido;
        public ModoEstereo Modo;
        public double Frecuencia;
        public string Cancion;
        public int PistaCD;
        public string DispositivoAuxiliar;

        //constructor
        public EstereoAuto(string color, string marca, double frecuencia, string cancion, int pistaCD, string dispositivoAuxiliar)
        {
            this.Encendido = false;
            this.Modo = ModoEstereo.Radio;
            this.Frecuencia = frecuencia;
            this.Cancion = cancion;
            this.PistaCD = pistaCD;
            this.color = color;
            this.marca = marca;
            this.DispositivoAuxiliar = dispositivoAuxiliar;
        }

        public void BotonEncender()
        {
            this.Encendido = !Encendido;
            if (Encendido)
                Console.WriteLine("El estéreo está encendido.");
            else
                Console.WriteLine("El estéreo está apagado.");

        }

        public void CambiarModo(ModoEstereo nuevoModo)
        {
            if (this.Encendido)
            {
                this.Modo = nuevoModo;
                //Console.WriteLine($"Modo {nuevoModo} seleccionado.");
            }
            else
                Console.WriteLine("Error: El estereo debe estar encencido!");
        }

        public void ElegirRadio(double nuevaFrecuencia)
        {
            if (this.Modo == ModoEstereo.Radio)
            {
                this.Frecuencia = nuevaFrecuencia;
                Console.WriteLine($"Frecuencia de radio elejida: {nuevaFrecuencia}");
            }
            else
            {
                Console.WriteLine("Error: No esta en modo Radio!");
            }
        }

        public void ElegirCancion(string nuevaCancion)
        {
            if (this.Modo == ModoEstereo.Bluetooth)
            {
                this.Cancion = nuevaCancion;
                //Console.WriteLine($"Reproduciendo la canción: {nuevaCancion}");
            }
            else
            {
                Console.WriteLine("Error: no esta en modo Bluethooth!");
            }
        }

        public void ElegirPista(int nuevaPista)
        {
            if (this.Modo == ModoEstereo.CD)
            {
                this.PistaCD = nuevaPista;
                //Console.WriteLine($"Reproduciendo la pista número: {nuevaPista}");
            }
            else
            {
                Console.WriteLine("Error: no esta en modo CD!");
            }
        }

        public void SeleccionarDispositivoAuxiliar(string nuevoDispositivo)
        {
            if (this.Modo == ModoEstereo.Auxiliar)
            {
                this.DispositivoAuxiliar = nuevoDispositivo;
                //Console.WriteLine($"Dispositivo auxiliar conectado: {nuevoDispositivo}");
            }
            else
            {
                Console.WriteLine("Error: El modo actual no es Auxiliar.");
            }
        }
    
        //metodo que muestra el display del estereo
        public void Display()
        {
            Console.WriteLine("********************");
            if (Encendido)
            {
                if (Modo == ModoEstereo.Radio)
                {
                    Console.WriteLine($"Modo: Radio, Frecuencia: {Frecuencia} FM");
                }
                else if (Modo == ModoEstereo.Bluetooth)
                {
                    Console.WriteLine($"Modo: Bluetooth, Canción: {Cancion}");
                }
                else if (Modo == ModoEstereo.CD)
                {
                    Console.WriteLine($"Modo: CD, Pista: {PistaCD}");
                }
                else if (Modo == ModoEstereo.Auxiliar)
                {
                    Console.WriteLine($"Modo: Auxiliar, Dispositivo: {DispositivoAuxiliar}");
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
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
