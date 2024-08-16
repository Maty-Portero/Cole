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

            //ej5.01

            /*Realizar la carga del lado de un cuadrado, mostrar por pantalla 
              el perímetro del mismo (El perímetro de un cuadrado se calcula 
              multiplicando el valor del lado por cuatro).*/
            
            //declaro las variables
            int lado, perimetro;
            string linea;

            //ingreso los valores
            Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            //calculo el perimetro
            perimetro = lado * 4;

            //muestro el resultado
            Console.WriteLine("El perímetro es: " + perimetro);
            Console.ReadKey();

            //-----------------------------------------------------------------

            //ej5.02

            /*Escribir un programa en el cual se ingresen cuatro números, 
              calcular e informar la suma de los dos primeros y el producto 
              del tercero y el cuarto.*/
            
            //declaro las variables
            int num1, num2, num3, num4, suma, producto;
            string linea1, linea2, linea3, linea4;

            //ingreso de valores
            Console.WriteLine("Ingrese el numero 1: ");
            linea1 = Console.ReadLine();
            num1 = int.Parse(linea1);

            Console.WriteLine("Ingrese el numero 2: ");
            linea2 = Console.ReadLine();
            num2 = int.Parse(linea2);

            Console.WriteLine("Ingrese el numero 3: ");
            linea3 = Console.ReadLine();
            num3 = int.Parse(linea3);

            Console.WriteLine("Ingrese el numero 4: ");
            linea4 = Console.ReadLine();
            num4 = int.Parse(linea4);

            //calculo la suma y el producto
            suma = num1 + num2;
            producto = num3 * num4;

            //muestro los resultados
            Console.WriteLine("La suma de los numeros 1 y 2 es: " + suma);
            Console.WriteLine("El producto de los numeros 3 y 4 es: " + producto);
            Console.ReadKey();

            //-----------------------------------------------------------------

            //ej5.03

            /*Realizar un programa que lea cuatro valores numéricos e 
              informar su suma y promedio.*/
            
            //declaro las variables
            int  numa = 0, numb = 5, numc = 80, numd = 100, suma, promedio;

            //calculo la suma y el promedio
            suma = numa + numb + numc + numd;
            promedio = suma / 4;

            //muestro los resultados
            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.WriteLine("El promedio de los numeros es: " + promedio);
            Console.ReadKey();

            //-----------------------------------------------------------------

            //ej5.04

            /*Se debe desarrollar un programa que pida el ingreso del precio de 
              un artículo y la cantidad que lleva el cliente. Mostrar lo que debe 
              abonar el comprador.*/

            //declaro las variable
            int precio, cantidad, precioAbonar;
            string lineaA, lineaB;

            //ingreso de valores
            Console.WriteLine("Ingrese el precio del producto: ");
            lineaA = Console.ReadLine();
            precio = int.Parse(lineaA);

            Console.WriteLine("Ingrese la cantidad de productos: ");
            lineaB = Console.ReadLine();
            cantidad = int.Parse(lineaB);

            //calculo del abono
            precioAbonar = precio * cantidad;

            //muestro los resultados
            Console.WriteLine("El precio a abonar es: " + precioAbonar);
            Console.ReadKey();
        }
    }
}
