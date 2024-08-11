# Practicas 2024 UAI POO 2do Parcial

**Parte práctica 2do Parcial - Enunciado**

Una guardería náutica necesita un sistema para poder administrar sus alquileres. Cada alquiler tiene un plazo mínimo de 24 Hs, y los costos dependen del tipo de embarcación que amarre. Las embarcaciones habilitadas para la guarderia son:
* Velero
* Lancha
* Crucero

En todos los casos se conoce el nombre registrado de la misma, el color, y la potencia del motor expresada en Kw.

Para los veleros el costo de amarre es un 50% mayor a la lancha, y para los cruceros el costo es el 80% a la lancha pero se le adiciona un seguro de $1000 por día

Se requiere un sistema desarrollado en C# que permita:
* Alta y modificación de embarcaciones
* Alta de därsenas
* Informar mediante un evento cuando no haya más dársenas disponibles 
* Listar las därsenas ordenadas por número
* Listar las embarcaciones ordenadas por nombre

Requerimientos de aprobación:
* Uso de DLL
* Uso de Herencia y Polimorfismo Uso de eventos
* Implementar interfaz todos los ordenamientos
