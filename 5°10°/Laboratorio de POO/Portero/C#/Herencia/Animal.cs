using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Animal
    {
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre != value)
                {
                    nombre = "none";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public void comer()
        {


        }
        public void caminar()
        {


        }


    }
}