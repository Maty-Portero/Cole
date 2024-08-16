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
            //ej6.01

            /*Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo 
              informar su suma y diferencia, en caso contrario informar el producto y la división del 
              primero respecto al segundo.*/
            /*
            //declaro las variables
            int num1, num2, suma, resta, prod, div;
            string linea1, linea2;

            //ingreso de datos
            Console.WriteLine("Ingrese el primer número: ");
            linea1 = Console.ReadLine();
            num1 = int.Parse(linea1);

            Console.WriteLine("Ingrese el segundo número: ");
            linea2 = Console.ReadLine();
            num2 = int.Parse(linea2);

            //calculo de las operaciones
            suma = num1 + num2;
            resta = num1 - num2;
            prod = num1 * num2;
            div = num1 / num2;

            //condicionales y muestra de resultados
            if (num1 > num2)
            {
                Console.WriteLine("La suma de los números es: " + suma);
                Console.WriteLine("La diferencia de los números es: " + resta);
                Console.ReadKey();
            }

            if (num1 < num2)
            {
                Console.WriteLine("El producto de los números es: " + prod);
                Console.WriteLine("La division de los números es: " + div);
                Console.ReadKey();
            }
            */
            //---------------------------------------------------------------------------------

            //ej6.02

            /*Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete 
              mostrar un mensaje "Promocionado".*/
            /*
            //declaro de variables
            int nota1, nota2, nota3, suma, promedio;
            string lineac, lineac2, lineac3;

            //ingreso de valores
            Console.WriteLine("Ingrese la primera nota del alumno: ");
            lineac = Console.ReadLine();
            nota1 = int.Parse(lineac);

            Console.WriteLine("Ingrese la segunda nota del alumno: ");
            lineac2 = Console.ReadLine();
            nota2 = int.Parse(lineac2);

            Console.WriteLine("Ingrese la tercera nota del alumno: ");
            lineac3 = Console.ReadLine();
            nota3 = int.Parse(lineac3);

            //calculo del promedio
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;

            //condicionales y muestra de resultados
            if (promedio >= 7) 
            {
                Console.WriteLine("Promocionado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No Promocionado");
                Console.ReadKey();
            }
            */
            //----------------------------------------------------------------------------

            //ej6.03

            /*Se ingresa por teclado un número positivo de uno o dos dígitos(1..99) mostrar un 
              mensaje indicando si el número tiene uno o dos dígitos. (Tener en cuenta que condición 
              debe cumplirse para tener dos dígitos, un número entero).*/
            
            //declaro de variables
            int num;
            string linead;

            //ingreso de valores
            Console.WriteLine("Ingresa un número: ");
            linead = Console.ReadLine();
            num = int.Parse(linead);

            //condicionales y muestra de resultados
            if (num >= 1 && num <= 99)
            {
                if (num >= 1 && num <= 9)
                {
                    Console.WriteLine("El numero es de 1 digito.");
                }
                else if (num >= 10 && num <= 99)
                {
                    Console.WriteLine("El numero es de 2 digitos.");
                }
            }
            else
            {
                Console.WriteLine("El número no es válido.");
            }
            Console.ReadKey();
        }
    }
}
