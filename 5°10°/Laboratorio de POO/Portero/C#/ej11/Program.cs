using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //a
            int valor;
            string valorn;

            do
            {
                Console.WriteLine("Ingrese un valor de 0 a 999:");
                valorn = Console.ReadLine();
                valor = int.Parse(valorn);

                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 digitos");
                    Console.ReadKey();
                }
                else if (valor >= 10)
                {
                    Console.WriteLine("Tiene 2 digitos");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Tiene 1 digito");
                    Console.ReadKey();
                }

                while (valor != 0) ;

            }

            while (valor !=0);
            
            //b
            int value;
            int suma = 0;
            int cant = 0;
            int promedio;
            string valuen;

            do
            {
                Console.WriteLine("Ingrese un valor:");
                valuen = Console.ReadLine();
                value = int.Parse(valuen);

                if (value != 0)
                {
                    suma = suma + value;
                    cant++;
                }
            }while (value != 0);

            if (cant != 0)
            {
                promedio = suma / cant;

                Console.WriteLine("El promedio es:");
                Console.WriteLine(promedio);
            }
            else 
            {
                Console.WriteLine("No se ingresaron valores");
            }
            
            Console.ReadKey();
            */
            //c
            int cant1 = 0;
            int cant2 = 0;
            int cant3 = 0;
            int suma;
            string linea;
            float peso;

            do
            {
                Console.WriteLine("Ingrese el peso de la pieza (0 para finalizar):");
                linea = Console.ReadLine();
                peso = float.Parse(linea);

                if (peso > 10.2)
                {
                    cant1++;
                }
                else 
                {
                    if (peso >= 9.8)
                    {
                        cant2++;
                    }
                    else
                    {
                        if (peso > 0)
                        {
                            cant3++;
                        }
                    }
                }
                
            }while (peso!=0);

            suma = cant1 + cant2 + cant3;

            Console.Write("Piezas Aptas:");
            Console.WriteLine(cant2);

            Console.Write("Piezas con un peso superior a 10.2:");
            Console.WriteLine(cant1);

            Console.Write("Piezas con un peso inferior a 9.8:");
            Console.WriteLine(cant3);

            Console.Write("Cantidad de piezas procesadas:");
            Console.WriteLine(suma);

            Console.ReadLine();

        }
    }
}

