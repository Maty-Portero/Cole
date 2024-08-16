using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Coche : Vehiculo
    {
        int numeroPuertas;
        public int NumeroPuertas {  get { return numeroPuertas; } set { numeroPuertas = value; } }

        public Coche(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
        }
        override public void ObtenerInformacion(string marc, string model, int numP)
        {
            Console.WriteLine(marc + " - " + model + " - " + numP);
        }
    }
}
