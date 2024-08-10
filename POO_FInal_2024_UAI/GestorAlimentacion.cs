using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public class GestorAlimentacion
    {
        List<Animal> Animales = new List<Animal>();
        List<SerVivo> Alimentos = new List<SerVivo>();

        public List<Animal> getAnimales() 
        { 
            return Animales;
        }
        public List<SerVivo> getAlimentos() 
        {
            return Alimentos;    
        }

        public void AddAnimales(Animal pAnimal) 
        { 
          Animales.Add(pAnimal);
        }
        public void AddAlimentos(SerVivo pAlimento) 
        { 
           Alimentos.Add(pAlimento);
        }



    }
}