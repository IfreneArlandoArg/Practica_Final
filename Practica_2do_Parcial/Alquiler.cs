using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Alquiler
    {
        public Darsena DarsenaAlquilada { get; set; }

        public Embarcacion EmbarcacionAsignada { get; set; }

        public Alquiler(Darsena pDarsena, Embarcacion pEmbarcacion) 
        { 
            DarsenaAlquilada = pDarsena;
            EmbarcacionAsignada = pEmbarcacion;
        }

        public override string ToString()
        {
            return $"Embarcación {EmbarcacionAsignada.NombreRegistrado} - Darsena {DarsenaAlquilada.Numero} - Costo {EmbarcacionAsignada.Costo}";
        }

    }
}