using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*10.Escribir un programa que muestre un ejemplo de cómo se puede 
             * modificar el valor de una variable en C#.
            */

            // mostramos lo que le vamos a enseñar al usuario
            Console.WriteLine("===   MODIFICAR VARIABLES   ===");
            Console.WriteLine("\nHola te voy a enseñar a modificar una variable en C#");

            // daclaramos la variable que contendrá los datos
            string nombre = "Jaime";
            char c = '"';

            // mostramos como se declara una variable
            Console.WriteLine("\nPara este programa cree una variable que se llama: nombre" +
                "\nY esta variable va a contener tu nombre. ");
            Console.WriteLine($"\n\nPor defecto tiene mi nombre: {nombre}");
            Console.WriteLine($"Y la declaré de esta forma: \n\n\t\t\tstring nombre = {c}Jaime{c}; ");

            // pedimos el nombre del usuario para utilizarlo como ejemplo
            Console.WriteLine("\nEscribe tu nombre: ");
            nombre = Console.ReadLine();

            // mostramos la forma de cambiar el valor de una variable
            Console.WriteLine($"\n\n{nombre} para modificar la variable solo debes \nasignar " +
                $"tu nombre en vez del mío así: \n\n\t\t\tstring nombre = {c}{nombre}{c};" +
                $"\n\nAhora tu nombre está dentro de la variable." +
                $"\nDe esta forma la variable habrá modificado su valor");
            Console.ReadKey();
            
        }
    }
}
