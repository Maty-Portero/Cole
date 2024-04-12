using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            string linea;
            int superficie;

            Console.WriteLine("Inserte el valor del Lado");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            superficie = lado * lado;

            Console.WriteLine(superficie);
            Console.ReadKey();
        }
    }
}
