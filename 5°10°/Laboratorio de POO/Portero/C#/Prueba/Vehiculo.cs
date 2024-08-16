using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    abstract class Vehiculo
    {
        string marca;
        string modelo;

        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        virtual public string ObtenerInformacion(string marc, string model)
        {
            string info = marc + " - " + model;
            return info;
        }
    }
}
