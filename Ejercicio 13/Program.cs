using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Crear un programa que muestre un ejemplo 
             * de cómo se puede inicializar una variable 
             * con un valor predeterminado en C#.*/

            char c = '"';
            Console.WriteLine("===   INICIALIZAR VARIABLES   ===" +
                "\n===   CON UN VALOR PREDETERMINADO   ===");
            Console.WriteLine("\nInciar una variable con un valor predeterminado" +
                "\nSignifica que la variable ya tiene un valor asignado por defecto" +
                $"\nPor ejemplo: \n\n\t\t\tint num1 = 15; \n\t\t\tstring marca = {c}ZARA{c};" +
                $"\n\t\t\tfloat pi = 3.14; \n\t\t\tchar arroba = '@';");

            Console.WriteLine("\n\nComo puedes observar, cada una de las variables anteriores" +
                "\nfueron ya inicializadas con un valor predeterminado");

            Console.ReadKey();
        }
    }
}
