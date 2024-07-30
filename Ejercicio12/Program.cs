using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12. Desarrollar un programa que muestre un ejemplo 
             * de cómo se puede declarar una variable 
             * con un tipo de dato específico en C#.
             */

            char c = '"';
            // Enseñamos algunos tipos de variables
            Console.WriteLine("===   TIPOS DE VARIABLES   ===");
            Console.WriteLine("\n*** Hola al igual que en varios Lenguajes de programación\n" +
                "en C# debemos declarar el tipo de dato específico que vamos a guardar\n" +
                "en una variable como por ejemplo:" +
                "\n\n\t\t\tint \n\t\t\tstring \n\t\t\tchar \n\t\t\tbool");

            // Declaración de nombres
            Console.WriteLine("\n*** Entonces sabiendo el tipo de variable que vamos a declarar" +
                "\nTendremos que darle un nombre, así:\n" +
                "\n\t\t\tint numero \n\t\t\tstring nombre \n\t\t\tchar vocal \n\t\t\tbool lunes ");

            // Asignación de valores
            Console.WriteLine("\n*** Por último le daremos el valor que aloja " +
                "\ncada variable de ser necesario, así:" +
                "\n\n\t\t\tint numero = 25;" +
                $"\n\t\t\tstring nombre = {c}Juan{c};" +
                $"\n\t\t\tchar vocal = 'e';" +
                $"\n\t\t\tbool lunes = true;");

            // recordando uso de punto y coma
            Console.WriteLine($"\n*** Importante acabar la declaración con un punto y coma: {c};{c}");

            Console.ReadKey();
        }
    }
}
