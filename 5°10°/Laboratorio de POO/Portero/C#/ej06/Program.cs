using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            float sueldo;
            string linea;

            Console.WriteLine("Ingrese el sueldo");
            linea = Console.ReadLine();

            sueldo = float.Parse(linea);

            if (sueldo > 3000) 
            {
                Console.WriteLine("Tenes que pagar impuestos");
                Console.ReadKey();
            }
            
            Console.ReadKey();


            //b
            int num1;
            int num2;
            string lineaA;
            string lineaB;

            Console.WriteLine("Ingrese el numero 1");
            lineaA = Console.ReadLine();

            num1 = int.Parse(lineaA);

            Console.WriteLine("Ingrese el numero 2");
            lineaB = Console.ReadLine();

            num2 = int.Parse(lineaB);

            if (num1 > num2)
            {
                Console.WriteLine("EL mayor es el:");
                Console.WriteLine(num1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("EL mayor es el:");
                Console.WriteLine(num2);
                Console.ReadLine();
            }

            Console.ReadKey();

        }
    }
}
