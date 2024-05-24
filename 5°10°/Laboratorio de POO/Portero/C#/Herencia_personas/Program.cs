//Pasaje de paramentros de constructor hijo al constructor padre
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_personas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico medico = new Medico("Lucia", "Cirugia"); // Paso dos parametros al constructor Hijo
            Profesor profesor = new Profesor("Pablo", "Profesor Técnico");


        }
    }
}