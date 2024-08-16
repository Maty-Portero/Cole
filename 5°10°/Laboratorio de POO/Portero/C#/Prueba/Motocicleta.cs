using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Motocicleta : Vehiculo
    {
        bool tieneSideCar;

        public bool TieneSideCar { get { return tieneSideCar; } set { tieneSideCar = value; } }

        public Motocicleta(string marca, string modelo, bool tieneSideCar) : base(marca, modelo)
        {
            this.tieneSideCar = tieneSideCar;
        }

        public override void ObtenerInformacion(string marc, string model, bool tieneSideCar)
        {
            Console.WriteLine(marc + " - " + model + " - " + tieneSideCar);
        }
    }
}
