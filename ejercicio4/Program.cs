using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4. Escribir un programa que calcule el área y el perímetro 
            de un cuadrado. El programa debe solicitar al 
            usuario la longitud de un lado del cuadrado.
             */

            //pedimos la información al usuario
            Console.WriteLine("===   Perímetro de un Cuadrado   ===");
            Console.WriteLine("\n\nIngrese el lado de un cuadrado: ");
            float lado = float.Parse(Console.ReadLine());

            //declaramos la funcion y sacamos el resultado a pantalla
            float perimetro = lado * 4;
            Console.WriteLine($"\n\nel perímetro del cuadrado es {perimetro}");

            Console.ReadKey();
        }
    }
}
