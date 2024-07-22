using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Velero: Embarcacion
    {
        public Velero(string pNombre, string pColor, double pPotencia, double pCosto) : base(pNombre, pColor, pPotencia, pCosto)
        {

        }

        public override void CalcularCosto()
        {
            Costo += Costo * 0.5;
        }

        public override string ToString()
        {
            return $"Velero {NombreRegistrado}, Costo {Costo}";
        }

    }
}