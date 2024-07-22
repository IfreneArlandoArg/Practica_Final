using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Embarcacion
    {
        public string NombreRegistrado { get; set; }
        public string Color { get; set; }
        public double PotenciaMotor { get; set; }

        public double Costo { get; set; }

        public Embarcacion(string pNombre, string pColor, double pPotencia, double pCosto) 
        { 
          NombreRegistrado = pNombre;
          Color = pColor;
          PotenciaMotor = pPotencia;
          Costo = pCosto;
        }

        public virtual void CalcularCosto() { }

        

    }
}