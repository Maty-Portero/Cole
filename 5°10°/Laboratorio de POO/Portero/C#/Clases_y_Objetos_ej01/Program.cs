using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Objetos_ej01
{
    public class Personas
    {
        public string Nombre;
        public int dia;
        public int mes;
        public int año;
        public int edad;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Personas persona1, persona2, persona3;

            persona1 = new Personas();
            persona2 = new Personas();
            persona3 = new Personas();

            string nombre1;
            string nombre2;
            string nombre3;

            Console.WriteLine("Ingrese el nombre de la persona 1");
            nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la persona 2");
            nombre2 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la persona 3");
            nombre3 = Console.ReadLine();

            persona1.Nombre = nombre1;
            persona2.Nombre = nombre2;
            persona3.Nombre = nombre3;

            int dia1;
            int dia2;
            int dia3;
            string day1;
            string day2;
            string day3;

            Console.WriteLine("Ingrese el dia de la persona 1");
            day1 = Console.ReadLine();
            dia1 = int.Parse(day1);

            Console.WriteLine("Ingrese el dia de la persona 2");
            day2 = Console.ReadLine();
            dia2 = int.Parse(day2);

            Console.WriteLine("Ingrese el dia de la persona 3");
            day3 = Console.ReadLine();
            dia3 = int.Parse(day3);

            persona1.dia = dia1;
            persona2.dia = dia2;
            persona3.dia = dia3;

            int mes1;
            int mes2;
            int mes3;
            string mon1;
            string mon2;
            string mon3;

            Console.WriteLine("Ingrese el mes de la persona 1");
            mon1 = Console.ReadLine();
            mes1 = int.Parse(mon1);

            Console.WriteLine("Ingrese el mes de la persona 2");
            mon2 = Console.ReadLine();
            mes2= int.Parse(mon2);

            Console.WriteLine("Ingrese el mes de la persona 3");
            mon3 = Console.ReadLine();
            mes3 = int.Parse(mon3);

            persona1.mes = mes1;
            persona2.mes = mes2;
            persona3.mes = mes3;

            int año1;
            int año2;
            int año3;
            string year1;
            string year2;
            string year3;

            Console.WriteLine("Ingrese el año de la persona 1");
            year1 = Console.ReadLine();
            año1 = int.Parse(year1);

            Console.WriteLine("Ingrese el año de la persona 2");
            year2 = Console.ReadLine();
            año2 = int.Parse(year2);

            Console.WriteLine("Ingrese el año de la persona 3");
            year3 = Console.ReadLine();
            año3 = int.Parse(year3);

            persona1.año = año1;
            persona2.año = año2;
            persona3.año = año3;

            int edad1;
            int edad2;
            int edad3;
            string old1;
            string old2;
            string old3;

            Console.WriteLine("Ingrese la edad de la persona 1");
            old1 = Console.ReadLine();
            edad1 = int.Parse(old1);

            Console.WriteLine("Ingrese la edad de la persona 2");
            old2 = Console.ReadLine();
            edad2 = int.Parse(old2);

            Console.WriteLine("Ingrese la edad de la persona 3");
            old3 = Console.ReadLine();
            edad3 = int.Parse(old3);

            persona1.edad = edad1;
            persona2.edad = edad2;
            persona3.edad = edad3;

            if (persona1.edad >= persona2.edad && persona1.edad >= persona3.edad) 
            {
                Console.WriteLine("El mayor es {0}", persona1.Nombre);
            }
            else if (persona2.edad >= persona3.edad)
            {
                Console.WriteLine("El mayor es {0}", persona2.Nombre);
            }
            else
            {
                Console.WriteLine("El mayor es {0}", persona3.Nombre);
            }

            Console.WriteLine("La persona 1 se llama {0}, nacio el {1}/{2}/{3} y tiene {4} años", persona1.Nombre, persona1.dia, persona1.mes, persona1.año, persona1.edad);
            Console.WriteLine("La persona 2 se llama {0}, nacio el {1}/{2}/{3} y tiene {4} años", persona2.Nombre, persona2.dia, persona2.mes, persona2.año, persona2.edad);
            Console.WriteLine("La persona 3 se llama {0}, nacio el {1}/{2}/{3} y tiene {4} años", persona3.Nombre, persona3.dia, persona3.mes, persona3.año, persona3.edad);
            Console.ReadKey();

        }
    }
}
