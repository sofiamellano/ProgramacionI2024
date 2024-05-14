using EjercicioDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Clases
{
    internal class PavaElectrica
        {
            // Campos
            private string marca;
            private string color;
            private string material;
            private double capacidad_litros;


            // Propiedades
            public ModoEnum Modo;
            public bool Encendido;
            public int Temperatura_del_agua;

            public PavaElectrica(string marca, string color, string material)
            {
                this.marca = marca;
                this.color = color;
                this.material = material;
                this.capacidad_litros = 1.7;

                this.Temperatura_del_agua = 0;
                this.Encendido = false;
                this.Modo = ModoEnum.Minimo;
            }

            public void PresionarBotonEncendido()
            {
                this.Encendido = !this.Encendido;
            this.Temperatura_del_agua = 0;
            }

            public void CambiarModo(ModoEnum modo)
            {
                if (this.Encendido)
                    this.Modo = modo;
                else
                    Console.WriteLine("Error: la pava debe estar prendida");
            }

            public void CalentarAgua()
            {
                if (Encendido)
                {
                    if (Modo == ModoEnum.Minimo)
                    {
                        while (Temperatura_del_agua < 85)
                        {
                            Temperatura_del_agua++;
                            Console.Clear();
                            Console.WriteLine($"Pava calentando.... temperatura: {Temperatura_del_agua}");
                            Thread.Sleep(100);
                            
                        }
                        if (Temperatura_del_agua == 85)
                            PresionarBotonEncendido();
                    }
                    else
                    {
                        while (Temperatura_del_agua < 105)
                        {
                            Temperatura_del_agua++;
                            Console.Clear();
                            Console.WriteLine($"Pava calentando.... temperatura: {Temperatura_del_agua}");
                            Thread.Sleep(100);
                            
                    }
                        if (Temperatura_del_agua == 105)
                            PresionarBotonEncendido();
                    }
                }
                else
                {
                    Console.WriteLine("Error: la pava debe estar prendida");
                }
            }
        }
    }

