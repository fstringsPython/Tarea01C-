using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*2. Crear un programa que solicite al usuario dos números 
             * enteros y luego muestre el mayor y el menor de los dos números.*/


            //sacamos la información de lo que vamos a pedir en pantalla
            Console.WriteLine("Hola Ingresa un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número entero: ");
            int num2 = int.Parse(Console.ReadLine());


            //declaramos las sentencias que funcionarán para saber cual es mayor o menor
            if (num1 > num2) {
                Console.WriteLine($"\n\n{num1} es mayor que {num2}");
            }
            else
            {
                Console.WriteLine($"\n\n{num2} es mayor que {num1}");
            }

            Console.ReadKey();

        }
    }
}
