using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Persona
    {
        //declaro las variables
        public string nombre;
        public DateTime fechaNac;
        public DateTime anoActual;
        public TimeSpan periodo;
        public CultureInfo format;

        //metodo edad
        public int Edad()
        {
            anoActual = DateTime.Now; //pongo el año de la pc en la variable anoActual
            periodo = anoActual - fechaNac; //hago una diferencia entre el año actual y la fecha de nacimiento
            return (int)(periodo.Days / 365); //aproximado de años
        }

        //Constructor de Persona
        public Persona(string nombre, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNac = DateTime.Parse(fechaNacimiento); //parseo la fecha de nacimiento
        }
    }
}
