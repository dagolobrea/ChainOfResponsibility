using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPatternEjemplo
{
    public class Soldado : Unidad
    {
        public Soldado(string nombre) : base(nombre)
        {

        }
        public override string ToString()
        {
            return ("Soldado " + base.ToString());
        }

    }
}
