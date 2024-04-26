
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        // PedirNombreYSaludar();
        // CalcualarDiasDeVida();
        //ImprimirMinimoDe4();
        //TipodeTriangulo();
        FechaValida();

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

    // 3) Leer tres valores que corresponden a un día, un mes y un año y 
    // determinar si se trata de una fecha válida o no.

    private static void FechaValida()
    {
        int dia, mes, año;

        Console.Write("Ingrese un dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de un mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un año: ");
        año = int.Parse(Console.ReadLine());

        bool Valida = true;

        if (dia < 1 || dia > 31)
        {
            Console.WriteLine("No es un dia valido");
            Valida = false;
        }
        else if (mes < 1 || mes > 12)
        {
            Console.WriteLine("No es un mes valido");
            Valida = false;
        } else if (año <= 0)
        {
            Console.WriteLine("No es un año valido");
            Valida = false;
        }

        if (Valida)
        {
            Console.WriteLine("La fecha ingresada es válida.");
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es válida.");
        }

    }




}
