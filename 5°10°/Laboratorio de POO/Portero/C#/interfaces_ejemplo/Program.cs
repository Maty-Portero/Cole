using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_ejemplo
{

    interface IAves
    {
        string Name { get; }
        void comer(int cantidad);
    }

    interface IVolar
    {
        string Name { get; }
        void volar(int altura);
    }

    class Pajaro : IAves, IVolar
    {
        public int cantidadComida = 0;
        public void comer(int cantidad)
        {

        }
        public void volar(int altura)
        {

        }
        public string Name { get; }
    }

    class Ñandu : IAves
    {
        public int cantidadComida = 0;
        public void comer(int cantidad)
        {
            cantidadComida += cantidad;
        }
        public string Name { get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
