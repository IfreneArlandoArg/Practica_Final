using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_FInal_2024_UAI
{
    public abstract class Animal : SerVivo
    {
        
        public Animal(string pNombre) : base(pNombre) 
        { 
        
        }
        public abstract void Comer(SerVivo pSerVivo);

        

    }
}