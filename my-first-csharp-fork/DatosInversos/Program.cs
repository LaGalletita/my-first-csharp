using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosInversos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables
            string dato1;
            string dato2;
            string dato3;
            string dato4;
            string dato5;

            // Pedir datos
            Console.WriteLine("Ingrese el dato A");
            dato1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el dato B");
            dato2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el dato C");
            dato3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el dato D");
            dato4 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el dato F");
            dato5 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");

            // Mostrar datos inversos al usuario

            Console.WriteLine("Sus datos inversos son:");
            Console.WriteLine(dato5 + " " + dato4 + " " + dato3 + " " + dato2 + " " + dato1);

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();

        }
    }
}