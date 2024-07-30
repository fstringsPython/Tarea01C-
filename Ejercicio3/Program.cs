using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 3. Desarrollar un programa que convierta grados Celsius a Fahrenheit 
             * y viceversa. El programa debe solicitar al usuario la temperatura en 
             * Celsius o Fahrenheit y realizar la conversión correspondiente.
             */


            /* Le mostramos en pantalla al usuario la información
             */
            Console.WriteLine("===   Convertidor de temperaturas   ===");

            //Le pedimos que elija una opción
            Console.WriteLine("\n\nElija la opción: \nA. Celsius a Fahrenheit" +
                "\nB. Fahrenheit a Celsius");
            string opcion = Console.ReadLine();
            opcion = opcion.ToLower();

            //creamos una sentencia switch para trabajar por casos
            switch (opcion) {
                //en caso de que la opción sea A
                case "a":
                    Console.WriteLine("\n\nIngrese los grados Celsius");
                    int grados = int.Parse(Console.ReadLine());
                    double funcion = ((1.8 * grados) + 32);
                    Console.WriteLine($"\n\n{grados} grados Celsius corresponden a {funcion} grados Fahrenheit");
                    break;
                //en caso de que la opción sea B
                case "b":
                    Console.WriteLine("\n\nIngrese los grados Fahrenheit");
                    int grados1 = int.Parse(Console.ReadLine());
                    double funcion1 = (((grados1-32)*5)/9);
                    Console.WriteLine($"\n\n{grados1} grados Fahrenheit corresponden a {funcion1} grados Celsius");
                    break;
                //en caso de que la opción ingresada no sea correcta
                default:
                    Console.WriteLine($"\n\n{opcion} no es una opción.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
