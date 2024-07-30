using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11. Crear un programa que explique la 
             * importancia de usar nombres de variables 
             * descriptivos en C#.
             */

            // Mostramos que vamos a enseñar
            Console.WriteLine("===   NOMBRES EN VARIABLES ===");

            // Pedimos nombre de usuario para utilizar como ejemplo
            Console.WriteLine("\nHola escribe tu nombre: ");
            string nombre = Console.ReadLine();
            char c = '"';

            // Importancia de colocar nombres descriptivos
            Console.WriteLine($"\n\nMucho gusto {nombre} recuerda que las variables\n" +
                $"Son el tipo de dato más utilizado en un programa." +
                $"\nEntonces deberemos entender lo importante que es utilizar" +
                $"\nnombres descriptivos en ellas, esto quiere decir que se apeguen\n" +
                $"o tengan similitud con lo que se va a guardar dentro");

            // ejemplo 1
            Console.WriteLine($"\n\nAl escribir este programa declaré" +
                $" una variable que se llama: nombre\n" +
                $"\n\n\t\t\tstring nombre = {c}{c}"+
                $"\n\nComo puedes observar utilicé un nombre referente a lo que iba a guardar." +
                $"\nEn este caso tu nombre.");
            // ejemplo 2
            Console.WriteLine("\n\nAhora escribe tu edad: ");
            int edad = int.Parse( Console.ReadLine() );
            Console.WriteLine($"\n\nYa veo tienes {edad} años." +
                $"\nSi utilizas la lógica sabrás que nombre le puse a esta variable" +
                $"\nLo sabes?" +
                $"\n\nSi utilicé la palabra edad como nombre para la variable así:" +
                $"\n\n\t\t\t int edad = 0;");
            
            // importancia
            Console.WriteLine("\n\nCon estos ejemplos te mostré la lógica que tiene" +
                "\nponer nombres descriptivos a las variables.\n" +
                "Esto te servirá para localizar y entender rápidamente que se aloja allí.");

            Console.ReadKey();

        }
    }
}
