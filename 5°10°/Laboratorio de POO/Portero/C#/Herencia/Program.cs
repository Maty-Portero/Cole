using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canino perro1 = new Canino("alvin");
            Canino perro2 = new Canino("pepo");
            Felino gato = new Felino();

            Aves ave1 = new Aves();

            perro1.Nombre = "Pepo";

        }
    }
}