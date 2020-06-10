using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que escriba en pantalla los numeros 
             * pares del 23 al 7 en orden descendente, usando while.*/

            int numeros = 23;
            double par = 0;

            Console.WriteLine();
            Console.WriteLine("Los numeros del 23 al 7 en orden descendente son: ");
            Console.WriteLine();

            while (numeros>7)
            {
                numeros = numeros - 1;
                par = numeros % 2;
                if (par==0)
                {
                    Console.WriteLine(numeros);
                }
                
            }
            Console.ReadKey();
        }
    }
}
