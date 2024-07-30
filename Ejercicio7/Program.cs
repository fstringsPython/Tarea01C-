using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7. Escribir un programa que compare dos números ingresados 
             * por el usuario y muestre si son iguales, mayores o menores.
             */

            // Mostramos en pantalla lo que hace el programa
            Console.WriteLine("Vamos a ver si dos números son iguales mayores o menores!");

            // Pedimos que el usuario ingrese la información
            Console.WriteLine("\n\nIngrese el primero número");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo número");
            float num2 = float.Parse(Console.ReadLine());

            // usamos sentencias de comparación con if - else
            // con sus respuestas
            if (num1 == num2)
            {
                Console.WriteLine($"\n\n{num1} y {num2} son iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"\n\n{num1} es mayor que {num2}");
            }
            else {
                Console.WriteLine($"\n\n{num1} es menor que {num2}");
            }
            Console.ReadKey();
        }
    }
}
