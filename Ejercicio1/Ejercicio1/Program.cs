using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que use el operador condicional para mostrar
             el valor absoluto de un numero de la siguiente forma: si el número es positivo, se mostrará tal cual;
             si es negativo, se mostrará el signo cambiado.*/
            int Numero = 0;

            Console.Write("Ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            if (Numero < 0)
            {
                Console.WriteLine("El numero ingresado es: " + Numero);
                Console.WriteLine();
                Console.WriteLine("El valor absoluto es: " + Math.Abs(Numero));
            }
            else
            {
                Console.WriteLine("El número ingresado es: " + Numero);
                Console.WriteLine();
                Console.WriteLine("Por lo tanto no se registró ningún cambio...");
            }

            Console.ReadKey();
        }
    }
}
