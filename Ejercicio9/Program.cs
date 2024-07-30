using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9.Crear un programa que declare una variable constante 
             * y una variable normal.Asignar valores a ambas variables 
             * y mostrarlas en la consola.
             */

            // declaramos variable normal
            string normal = "Normal";

            // declaramos variable constante
            const string constante = "Constante";

            // Imprimimos en pantalla la variables
            Console.WriteLine($"\nVariable normal: {normal}");
            Console.WriteLine($"\nVariable constante: {constante}");

            Console.ReadKey();

        }
    }
}
