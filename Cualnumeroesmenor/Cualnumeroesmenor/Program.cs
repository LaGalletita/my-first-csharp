using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cualnumeroesmenor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables
            int num1;
            int num2;
            int num3;

            // Pedir numeros a calcular
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            // Hacer los calculos
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("");
                Console.WriteLine("El numero " + num1 + " es menor");
            }
            
            else 
            {
                if (num2 < num3 && num2 < num1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El numero " + num2 + " es menor");
                }
                
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El numero " + num3 + " es menor");
                }
            }

            // Esperar a que el usuario vea su resultado hasta presionar una tecla
            Console.ReadKey();

        }
    }
}
