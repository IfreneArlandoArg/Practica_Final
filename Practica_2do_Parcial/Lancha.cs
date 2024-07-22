using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Lancha: Embarcacion
    {
        public Lancha(string pNombre, string pColor, double pPotencia, double pCosto) : base(pNombre, pColor, pPotencia, pCosto)
        {

        }

        public override string ToString()
        {
            return $"Lancha {NombreRegistrado}, Costo {Costo}";
        }
    }
}