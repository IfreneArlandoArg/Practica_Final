using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Darsena
    {
        public int Numero { get; set; }

        public Darsena(int pNumero) 
        { 
           Numero = pNumero;
        }

        public override string ToString()
        {
            return $"Darsena {Numero}";
        }
    }
}