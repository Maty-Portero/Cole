using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_personas
{
    public class Profesor : Persona
    {
        private string titulo;
        public Profesor(string nom, string tit) : base(nom)
        {

        }
    }
}
