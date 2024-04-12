using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;

            Console.Write("Ingrese Horas trabajadas por el operario:");
            
            /*opcion 1
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);*/

            //opcion 2
            horasTrabajadas = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el pago por hora:");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horasTrabajadas * costoHora;
            Console.Write("El sueldo total del operario es:");
            Console.Write(sueldo);
            Console.ReadKey();

        }
    }
}
