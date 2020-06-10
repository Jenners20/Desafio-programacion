using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //: Usar el operador condicional para calcular el menor de dos numeros.

            Console.WriteLine("Ingrese un numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero<numero2)
            {
                Console.WriteLine();
                Console.WriteLine("El numero menor es: " + numero);
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero menor es:" + numero2);
            }
            if (numero==numero2)
            {
                Console.WriteLine();
                Console.WriteLine("Los numeros son iguales ");

            }
            Console.ReadKey();
        }
    }
}
