using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public class SerVivo
    {
        public string Nombre { get; set; }
        public DateTime Fecha_Hora { get; set; }
        

        public SerVivo(string pNombre) 
        { 
            Nombre = pNombre;
            Fecha_Hora = DateTime.Now;
        
        }
    }
}