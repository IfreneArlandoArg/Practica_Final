using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public class Herbivoro: Animal
    {
        List<Planta> Alimentos = new List<Planta>();

        public Herbivoro(string pNombre):base(pNombre) 
        { 
        
        }
        public List<Planta> getAlimentos() 
        {
            return Alimentos;
        }

        public override void Comer(SerVivo pSerVivo) 
        {
            if (pSerVivo is Animal)
                throw new Exception($"{this.Nombre} es un herbivoro sólo come planta.");

            Alimentos.Add(pSerVivo as Planta);
        }

        public override string ToString() 
        {
            return $"Herbivoro, {Nombre}, {Fecha_Hora}";
        }
    }
}