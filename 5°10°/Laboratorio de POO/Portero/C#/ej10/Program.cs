using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //a
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

            //b
            int x = 0;
            int promedio;
            string renglon;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el numero: ");
                renglon = Console.ReadLine();

                x = x + int.Parse(renglon);

            }

            promedio = x / 10;

            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
            
            //c
            int aprobados = 0;
            int reprobados = 0;
            string linea;
            int nota;

            for (int i = 0; i <=10; i++) 
            {
                Console.WriteLine("Ingrese la nota:");
                linea = Console.ReadLine();
                nota = int.Parse(linea);

                if (nota >= 7) 
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            Console.WriteLine("La cantidad de aprobados son: ");
            Console.WriteLine(aprobados);

            Console.WriteLine("La cantidad de reprobados son: ");
            Console.WriteLine(reprobados);

            Console.ReadKey();
            
            //d
            int mul3 = 0;
            int mul5 = 0;
            int mul35 = 0;
            int determinant;
            string determinante;

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("Ingrese un valor:");
                determinante = Console.ReadLine();
                determinant = int.Parse(determinante);
                
                if ((determinant % 3) == 0) 
                {
                    mul3 = mul3 + 1;
                }
                if ((determinant % 5) == 0)
                {
                    mul5 = mul5 + 1;
                }
            }

            Console.WriteLine("La cantidad de multiplos de 3 son: ");
            Console.WriteLine(mul3);

            Console.WriteLine("La cantidad de multiplos de 5 son: ");
            Console.WriteLine(mul5);

            Console.ReadKey();
            */
            //e
            int cantidad = 0;
            int valorn;
            int valor;
            string n;
            string value;

            Console.WriteLine("Ingrese una cantidad de numeros:");
            n = Console.ReadLine();
            valorn = int.Parse(n);

            for (int i = 0; i < valorn; i++) 
            {
                Console.WriteLine("Ingrese un valor:");
                value = Console.ReadLine();
                valor = int.Parse(value);

                if (valor >= 1000)
                {
                    cantidad = cantidad + 1;
                }
            }

            Console.WriteLine("La cantidad de numeros es:");
            Console.WriteLine(cantidad);
            Console.ReadKey();

        }
    }
}
