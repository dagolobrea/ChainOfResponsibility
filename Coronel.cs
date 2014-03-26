using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPatternEjemplo
{
    class Coronel : Unidad
    {
        private string _orden;

        public Coronel(string nombre, string orden)
            : base(nombre)
        {
            _orden = orden;
        }
        public override string Orden()
        {
            return (_orden != null ? _orden : base.Orden());
        }
        public override string ToString()
        {
            return ("Coronel " + base.ToString());
        }
    }
}
