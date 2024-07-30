using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Desarrollar un programa que calcule el módulo (residuo) 
             * de la división entre dos números ingresados por el usuario.
             */

            //Mostramos lo que hace el programa
            Console.WriteLine("Te vamos a mostrar el resto de una división");

            // pedimos datos al usuario
            Console.WriteLine("\n\nIngrese el primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            // función que entrega el módulo
            double modulo = num1 % num2;

            // sacamos la respuesta en pantalla
            Console.WriteLine($"\n\nEl resto de la división entre {num1} y {num2} es: {modulo}");

            Console.ReadKey();
        }
    }
}
