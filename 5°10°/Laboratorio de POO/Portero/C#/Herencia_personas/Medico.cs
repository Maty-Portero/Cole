using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_personas
{
    public class Medico : Persona
    {
        private string diciplina;

        public Medico(string nom, string dic) : base(nom) // Base es el constructor Padre en este caso Persona
        {
            this.diciplina = dic;
        }

    }
}
