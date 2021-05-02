using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraoperacionesbasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;

            // Pedir numeros
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            // Hacer los procesos de suma, resta, multiplicacion y division
            num3 = num1 + num2;
            num4 = num1 - num2;
            num5 = num1 * num2;
            num6 = num1 / num2;

            // Mostrar los resultados al usuario

            Console.WriteLine("La suma de " + num1 + " y " + num2 + " da como resultado " + num3);

            Console.WriteLine("");

            Console.WriteLine("La resta de " + num1 + " y " + num2 + " da como resultado " + num4);

            Console.WriteLine("");

            Console.WriteLine("La multiplicacion de " + num1 + " y " + num2 + " da como resultado " + num5);

            Console.WriteLine("");

            Console.WriteLine("La division de " + num1 + " y " + num2 + " da como resultado " + num6);

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();

        }
    }
}
