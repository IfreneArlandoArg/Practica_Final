using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public class Carnivoro : Animal
    {
        List<Herbivoro> Alimentos = new List<Herbivoro>();
        public Carnivoro(string pNombre):base(pNombre)  
        { 
        
        }

        public List<Herbivoro> getAlimentos()
        {
            return Alimentos;
        }

        public override void Comer(SerVivo pSerVivo)
        {
            if (pSerVivo is Planta)
                throw new Exception($"{this.Nombre} es un carnivoro sólo come herbivoros.");

            if (pSerVivo is Carnivoro)
                throw new Exception($"{this.Nombre} es un carnivoro sólo come herbivoros\nNo come otros grandes felinos.");

            Alimentos.Add(pSerVivo as Herbivoro);
        }

        public override string ToString()
        {
            return $"Carnivoro, {Nombre}, {Fecha_Hora}";
        }
    }
}