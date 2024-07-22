using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Crucero : Embarcacion
    {
        public Crucero(string pNombre, string pColor, double pPotencia, double pCosto) : base(pNombre, pColor, pPotencia, pCosto) 
        { 
        
        }

        public override void CalcularCosto()
        {
            Costo += Costo * 0.8;
        }

        public override string ToString()
        {
            return $"Crucero {NombreRegistrado}, Costo {Costo}";
        }
    }
}