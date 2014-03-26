using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPatternEjemplo
{
    public class Unidad
    {
        private Unidad _mando;
        private string _nombre;

        public Unidad(string nombre)
        {
            _nombre = nombre;
            _mando = null;
        }
        public virtual string ToString()
        {
            return _nombre;
        }
        public virtual string Orden()
        {
            return (_mando != null ? _mando.Orden() : "sin orden");
        }
        public void EstablecerMando(Unidad mando)
        {
            _mando = mando;
        }
    }
}
