using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPatternEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Unidad smith  = new Coronel("Smith", null);
            //Unidad truman = new Coronel("Truman", "Tomar posición enemiga");
            Unidad truman = new Coronel("Truman", null);
            Unidad trumanPlus = new Coronel("TrumanPlus", "Retomar posición enemiga");
            Unidad ryan   = new Soldado("Ryan");
            Unidad rambo  = new Soldado("Rambo");
 
            Console.WriteLine(rambo.Orden());    // rambo ->

            truman.EstablecerMando(trumanPlus);

            rambo.EstablecerMando(truman);
            Console.WriteLine(rambo.Orden());    // rambo -> truman
 
            ryan.EstablecerMando(rambo);
            Console.WriteLine(ryan.Orden());     // ryan -> rambo -> truman

            Console.ReadLine();
        }
    }
}
