using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Desarrollar un programa que realice las operaciones básicas 
             * aritméticas (suma, resta, multiplicación y división) con dos 
             * números ingresados por el usuario.
             */

            // mostramos en pantalla lo que hace el programa
            Console.WriteLine("Vamos a realizar las principales operaciones" +
                "\nCon 2 números ingresados\n\n");

            // pedimos los datos para cada una de las variables
            Console.WriteLine("Ingresa el primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            // declaramos las funciones de cada variable
            double suma = num1 + num2;
            double resta = num1 - num2;
            double mult = num1 * num2;
            double div = num1 / num2;

            // sacamos a pantalla los resultados
            Console.WriteLine($"\n\nLa suma de {num1} + {num2} es:  {suma}");
            Console.WriteLine($"La resta de {num1} - {num2} es:  {resta}");
            Console.WriteLine($"La multiplicaión de {num1} * {num2} es:  {mult}");
            Console.WriteLine($"La división de {num1} / {num2} es:  {div}");

            Console.ReadKey();


        }
        
    }
}
