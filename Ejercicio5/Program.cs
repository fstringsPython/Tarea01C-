using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5. Crear un programa que calcule el área y el volumen de una esfera. 
             * El programa debe solicitar al usuario el radio de la esfera.
             */

            //mostramos en pantalla lo que se va a realizar
            Console.WriteLine("Vamos a calcular el área y volumen de una esfera: ");
            
            // pedimos que el usuario ingrese los datos
            Console.WriteLine("\n\nIngresa el redio de la esfera: ");
            float radio = float.Parse(Console.ReadLine());

            // funciones para obtener área y volumen
            double area = ((4 * 3.14) * Math.Pow(radio, 2));
            double volumen = (((4 * 3.14) * Math.Pow(radio , 3))/3);

            // mostramos resultados en pantalla
            Console.WriteLine($"\n\nEl área de la esfera es: {area}");
            Console.WriteLine($"El volumen de la esfera es: {volumen}");
            
            Console.ReadKey();
        }
    }
}
