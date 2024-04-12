using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //a
            int x = 1;

            Console.WriteLine(x);
            while (x > 0 && x < 100)
            {
                x = x + 1;
                Console.WriteLine(x);
                Console.ReadKey();
            }

            //b
            int n;
            int y = 1;
            string linea;

            Console.WriteLine("Ingrese el valor de n:");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            while (y <= n) 
            {
                Console.WriteLine(y);
                y = y + 1;
                Console.ReadKey();

            }

            //c
            int x = 0;
            string renglon;

            for(int i=0; i < 10; i++) 
            {
                Console.Write("Ingrese el numero: ");
                renglon = Console.ReadLine();
                
                x = x + int.Parse(renglon);

            }
            
            Console.Write("El promedio es: " x / 10);
            Console.ReadKey();
            
            //d
            int z = 1;
            int numpiezas = 0;
            float largopieza;
            string piezas;
            string largo;

            Console.WriteLine("Ingrese una cantidad de piezas:");
            piezas = Console.ReadLine();
            numpiezas = int.Parse(piezas);

            for (int j= 1; j <= numpiezas; j++) 
            {
                Console.WriteLine("Ingrese el largo:");
                largopieza = float.Parse(Console.ReadLine());

                if (largopieza >= 1.20 && largopieza <= 1.30)
                {
                    numpiezas = numpiezas + 1;
                    z = z + 1;
                }
            }

            Console.WriteLine("La cantidad de piezas aptas es: ");
            Console.WriteLine(z);
            Console.ReadKey();

        }
    }
}
