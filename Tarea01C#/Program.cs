using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             1. Escribir un programa que declare variables para almacenar el nombre, 
            la edad y la estatura de una persona. Asignar valores a las variables y 
            luego mostrarlos en la consola.
             */

            //sacamos información a pantalla
            //y declaramos las variables que contendrán la información ingresada
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura: ");
            float estatura = float.Parse(Console.ReadLine());

            //mostramos la información ingresada por el usuario
            Console.WriteLine($"\n\nHola {nombre} tienes {edad} años y tu estatura es: {estatura}m");
            Console.ReadKey();
        }
    }
}
