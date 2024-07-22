using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_2do_Parcial
{
    public class Guarderia : Iordenar
    {
        List<Darsena> DarsenasDisponibles;
        List<Embarcacion> Embarcaciones;
        List<Alquiler> Alquileres;

        public event EventHandler SinDarsenasDisponibles;
        public Guarderia() 
        { 
          DarsenasDisponibles = new List<Darsena>();
          Alquileres = new List<Alquiler>();
          Embarcaciones = new List<Embarcacion>();
        }

        public void ordenarPorNombre() 
        { 
            Embarcaciones = Embarcaciones.OrderBy(emb => emb.NombreRegistrado).ToList();
        }
        public void ordenarPorNumero() 
        {
            DarsenasDisponibles = DarsenasDisponibles.OrderBy(Dar => Dar.Numero).ToList();
        }

        public List<Embarcacion> ObtenerListaEmbarcaciones()
        {
            return Embarcaciones;
        }

        public void AgregarEmbarcacion(Embarcacion pEmbarcacion)
        {
            if (DarsenasDisponibles.Count == 0)
            {
                OnSinDarsenasDisponibles();
            }
            else
            {
                Embarcaciones.Add(pEmbarcacion);
            }
            
        }

        public void RemoveEmbarcacion(Embarcacion pEmbarcacion)
        {
            Embarcaciones.Remove(pEmbarcacion);
        }

        public List<Darsena> ObtenerListaDarsenasDisponibles() 
        { 
           return DarsenasDisponibles;
        }

        public void AgregarDarsena(Darsena pDarsena) 
        { 
           DarsenasDisponibles.Add(pDarsena);
        }

        public void RemoveDarsena(Darsena pDarsena) 
        { 
           DarsenasDisponibles.Remove(pDarsena);
        }

        public List<Alquiler> ObtenerListaAlquileres()
        {
            return Alquileres;
        }

        public void AgregarAlquiler(Alquiler pAlquiler)
        {
            if (DarsenasDisponibles.Count == 0) 
            {
                OnSinDarsenasDisponibles();
            } 
            else 
            {
                Alquileres.Add(pAlquiler);

                Embarcaciones.Remove(pAlquiler.EmbarcacionAsignada);
                DarsenasDisponibles.Remove(pAlquiler.DarsenaAlquilada);

            }
        }

        public void RemoveAlquiler(Alquiler pAlquiler)
        {
            Alquileres.Remove(pAlquiler);
        }

        public void OnSinDarsenasDisponibles() 
        {
            SinDarsenasDisponibles?.Invoke(this, EventArgs.Empty);
        }



    }
}