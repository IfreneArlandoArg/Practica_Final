using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public class Planta : SerVivo
    {
        public Planta(string pNombre):base(pNombre) 
        { 
        
        }

        public override string ToString()
        {
            return $"Planta, {Nombre}, {Fecha_Hora}";
        }


    }
}