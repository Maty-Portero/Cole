using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;
            int producto;
            string linea;
            string lineb;

            Console.WriteLine("Ingrese el numero 1:");

            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el numero 2:");

            lineb = Console.ReadLine();
            num2 = int.Parse(lineb);

            suma = num1 + num2;
            producto = num1 * num2;

            Console.WriteLine("La suma:");
            Console.WriteLine(suma);

            Console.WriteLine("El producto:");
            Console.WriteLine(producto);

            Console.ReadLine();

        }
    }
}
