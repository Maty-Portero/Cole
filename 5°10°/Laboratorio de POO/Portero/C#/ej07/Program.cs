using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int promedio;
            string lineaA;
            string lineaB;
            string lineaC;

            Console.WriteLine("Ingrese la Nota 1:");
            lineaA = Console.ReadLine();
            nota1 = int.Parse(lineaA);

            Console.WriteLine("Ingrese la Nota 2:");
            lineaB = Console.ReadLine();
            nota2 = int.Parse(lineaB);

            Console.WriteLine("Ingrese la Nota 3:");
            lineaC = Console.ReadLine();
            nota3 = int.Parse(lineaC);

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7) 
            {
                Console.WriteLine("Promocionado");
                Console.ReadKey();
            }
            else if (promedio > 4 && promedio < 7) 
            {
                Console.WriteLine("Regular");
                Console.ReadKey();
            }
            else if(promedio < 4)
            {
                Console.WriteLine("Reprobado");
                Console.ReadKey();
            }

            Console.ReadKey();

        }
    }
}
