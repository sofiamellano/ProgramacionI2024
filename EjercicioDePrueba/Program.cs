
using EjercicioDePrueba.Clases;
using EjercicioDePrueba.Enums;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography;

public class ProgramEjercicios
{
    private static void Main(string[] args)
    {
        // PedirNombreYSaludar();
       // CalcualarDiasDeVida();
        //ImprimirMinimoDe4();
        //TipodeTriangulo();
        //HorasQueFaltanTrabajar();
        //fechavalida();
        //calcularValorPago();
        //pruebaDeObjetoSplit();
        //pruebaDeObjetoPersonas();
        //pruebaDeObjetoPavaElectrica();
        //PruebaPavaElectrica();
        //PruebaEsteroAuto();
        //PruebaDeClasesAbstractasYHerencia();
        //PruebaCalculadoraPasajePorReferencia();
        //Console.WriteLine(ControlFechaValida(28,02,2023));
        //Console.WriteLine(CalcualarDiasDeVida(1, 1, 1));
    }

    private static void PruebaCalculadoraPasajePorReferencia()
    {
        int a = 123;
        int b = 10;
        int total = 0;
        Calculadora calculadora = new Calculadora();
        calculadora.Sumar(a, b, ref total);
        Console.WriteLine($"La suma total es: {total}");
    }

    private static void PruebaDeClasesAbstractasYHerencia()
    {
        Gerente Juan = new Gerente("Juan" , "Gonzalez"); 
        Console.WriteLine(Juan.ImprimirDatos());
    }

    private static void PruebaEsteroAuto()
    {
        EstereoAuto miEstereo = new EstereoAuto("negro", "Sony", 101.1, "Textos Frios", 5,"Celu");
        miEstereo.BotonEncender();
        miEstereo.CambiarModo(ModoEstereo.Radio);
        miEstereo.ElegirRadio(97.7);
        miEstereo.Display();
        miEstereo.CambiarModo(ModoEstereo.Bluetooth);
        miEstereo.ElegirCancion("La Vida Moderna");
        miEstereo.Display();
        miEstereo.CambiarModo(ModoEstereo.CD);
        miEstereo.ElegirPista(10);
        miEstereo.Display();
        miEstereo.CambiarModo(ModoEstereo.Auxiliar);
        miEstereo.SeleccionarDispositivoAuxiliar("Celu");
        miEstereo.Display();
        miEstereo.BotonEncender();
    }

    private static void PruebaPavaElectrica()
    {
        PavaElectrica miPava = new PavaElectrica("Liliana", "Plateado", "Acero inoxidable");
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Maximo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");
        Thread.Sleep(2000);
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Minimo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");
    }
   

    private static void pruebaDeObjetoPersonas()
    {
        Persona Albert = new Persona("Albert Einstein", "9 De Julio 2222", 1879);
        Persona Robert = new Persona("Robert Oppenheimer", "Manhttan 1111", 1904 );

        Robert.Decir("Albert, sabes como se despiden los quimicos?");
        Albert.Decir("No, ni idea.");
        Robert.Decir("Acido un placer :)");
    }

    private static void pruebaDeObjetoSplit()
    {
        //instanciamos el objeto Split
        Split miSplit = new Split("Blanco", 3000, "Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Deshumidificacion");
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es: " + miSplit.modo);
    }

    private static void calcularValorPago()
    {
        double valorCuota;
        int nroDia;

        Console.Write("Ingrese el valor de la cuota: ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el dia de pago: ");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;

            case >= 6 and <= 10:
                valorCuota = valorCuota + (valorCuota * 0.1);
                break;

            case >= 11 and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;

            case >= 21 and <= 31:
                valorCuota = valorCuota + (valorCuota * 0.15);
                break;
        }

        Console.WriteLine(valorCuota);
    }

    // 3) Leer tres valores que corresponden a un día, un mes y un año y 
    // determinar si se trata de una fecha válida o no.
    private static void fechavalida()
    {
        int dia, mes, año;
        bool DiaValido = true;
        bool MesValido = true;
        bool AñoValido = true;


        Console.Write("Ingrese el día: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        año = int.Parse(Console.ReadLine());

        // abril (4) - junio (6) - septiembre (9) - noviembre (11)  = 30 dias
        //año bisiesto = año % 4

        if (dia >= 1 && dia <= 31)
        {
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia <= 30)
                {
                    DiaValido = true;
                }
                else
                {
                    DiaValido = false;
                }
            }
            else
            {
                if (mes == 2)  //si es febrero
                {
                    if (año % 4 == 0)  //si es bisiesto
                    {
                        if (dia > 29)
                        {
                            DiaValido = false;
                        }
                        else
                        {
                            DiaValido = true;
                        }
                    }
                    else
                    {
                        if (dia <= 28)
                        {
                            DiaValido = true;
                        }
                        else
                        {
                            DiaValido = false;
                        }
                    }
                }
                else  //si no es febrero
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        DiaValido = true;
                    }
                    else
                    {
                        DiaValido = false;
                    }
                   
                }
            }
        }
        else
        {
            DiaValido = false;
        }

        if (mes >= 1 && mes <= 12)
        {
            MesValido = true;
        }
        else
        {
            MesValido = false;
        }

        if (año >= 1)
        {
            AñoValido = true;
        }
        else
        {
            AñoValido = false;
        }

        if (DiaValido == true && MesValido == true && AñoValido== true)
        {
            Console.WriteLine("La fecha es valida!");
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es válida.");
        }
    }
    private static void HorasQueFaltanTrabajar()
    {
        int horasTrabajadas, horasFaltantes;
        string dia;

        Console.Write("Ingrese horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese dia trabajado: ");
        dia = Console.ReadLine();

        horasFaltantes = 5 - horasTrabajadas;
        
        if (dia == "jueves")
        {
            horasFaltantes = horasFaltantes + 2;
        }

        Console.WriteLine($"Las horas faltantes son: {horasFaltantes}");
    }

    //Creamos un metodo que pida el nombre y apellido del usuario y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]
    private static void PedirNombreYSaludar()
    {
        string nombre,apellido;

        Console.Write("Ingrese su Nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su Apellido: ");
        apellido = Console.ReadLine();

        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    //Creamos un metodo que nos pida los años, meses y dias de vida y muestre al final la cantidad y total de dias de vida
    private static void CalcualarDiasDeVida()
    {
        //Declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida: ");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida: ");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus dias de vida: ");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los dias de vida totales son: {diasDeVida}");
    }
    public static int CalcualarDiasDeVida(int años, int meses, int dias)
    {
        return (años * 365) + (meses * 30) + dias;
    }

    private static void ImprimirMinimoDe4()
    {
        int num1, num2, num3, num4;

        Console.Write("Ingrese el 1er numero: ");
        num1 = int.Parse(Console.ReadLine()); // int.Parse transformamos el texto en numero 

        Console.Write("Ingrese el 2do numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 3er numero: ");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 4to numero: ");
        num4 = int.Parse(Console.ReadLine());

        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine($"El numero mas chico es el 1ero: {num1}");

        if (num2 < num1 && num2 < num3 && num2 < num4)
            Console.WriteLine($"El numero mas chico es el 2do: {num2}");

        if (num3 < num1 && num3 < num2 && num3 < num4)
            Console.WriteLine($"El numero mas chico es el 3ro: {num3}");

        if (num4 < num1 && num4 < num2 && num4 < num3)
            Console.WriteLine($"El numero mas chico es el 4to: {num4}");
    }

    // 2) Realizar un programa que pida los valores de los tres lados de 
    //un triángulo e imprima si el mismo es equilátero, isósceles o
    //escaleno.Hacer el diagrama de flujo correspondiente.

    private static void TipodeTriangulo()
    {
        int lado1, lado2, lado3;

        Console.Write("Ingrese la medida del 1er lado: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la medida del 2do lado: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la medida del 3er lado: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Es Triangulo es Equilatero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es Isosceles");
        }
        else
        {
            Console.WriteLine("El Triangulo es Escaleno");
        }
    }
    public static string Triangulo(int lado1, int lado2, int lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            return "Equilatero";
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            return "Isosceles";
        }
        else
        {
            return "Escaleno";
        }
    }

    public static bool ControlFechaValida(int dia, int mes, int año)
    {
        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            return true;

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            return true;

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            return true;

        else
            return false;

    }
}
