using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            int num1;
            int num2;
            int num3;
            string lineaA;
            string lineaB;
            string lineaC;

            Console.WriteLine("Ingrese el numero 1:");
            lineaA = Console.ReadLine();
            num1 = int.Parse(lineaA);

            Console.WriteLine("Ingrese el numero 2:");
            lineaB = Console.ReadLine();
            num2 = int.Parse(lineaB);

            Console.WriteLine("Ingrese el numero 3:");
            lineaC = Console.ReadLine();
            num3 = int.Parse(lineaC);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El mayor es:");
                Console.WriteLine(num1);
                Console.ReadKey();
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El mayor es:");
                Console.WriteLine(num2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El mayor es:");
                Console.WriteLine(num3);
                Console.ReadKey();
            }

            Console.ReadKey();


            //b
            int dia;
            int mes;
            int año;
            string lineaD;
            string lineaE;
            string lineaF;

            Console.WriteLine("Ingrese el dia:");
            lineaD = Console.ReadLine();
            dia = int.Parse(lineaD);

            Console.WriteLine("Ingrese el mes:");
            lineaE = Console.ReadLine();
            mes = int.Parse(lineaE);

            Console.WriteLine("Ingrese el año:");
            lineaF = Console.ReadLine();
            año = int.Parse(lineaF);

            if (mes == 1 || mes == 2 || mes == 3) 
            {
                Console.WriteLine("Corresponde al primer trimestre");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No corresponde al primer trimestre");
                Console.ReadKey();
            }

            Console.ReadKey();

        }
    }
}
