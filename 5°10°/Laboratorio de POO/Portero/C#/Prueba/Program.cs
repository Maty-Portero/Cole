using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            for (int i = 0; i < 2; i++)
            {
                vehiculos.Add(new Coche("", "", 4));
                vehiculos.Add(new Coche("", "", 3));
                vehiculos.Add(new Motocicleta("", "", true));
                vehiculos.Add(new Motocicleta("", "", false));
            }

            foreach (Vehiculo v in vehiculos)
            {
                v.ObtenerInformacion(v.Marca, v.Modelo);
            }

            Console.ReadKey();
        }
    }
}
