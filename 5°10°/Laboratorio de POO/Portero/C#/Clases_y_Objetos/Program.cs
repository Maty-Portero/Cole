using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos
{
    public class Auto
    {
        public int puertas;
        public string color;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1, auto2;
            auto1 = new Auto();
            auto2 = new Auto();

            auto1.puertas = 2;
            auto2.puertas = 4;

            Console.WriteLine("El auto 1 tiene {0} puertas", auto1.puertas);
            Console.WriteLine("El auto 2 tiene {0} puertas", auto2.puertas);
            //Console.WriteLine("El auto 2 tiene {0} puertas y el auto 2 tiene {1} puertas", auto1.puertas, auto2.puertas);
            Console.ReadKey();
        }
    }
}
