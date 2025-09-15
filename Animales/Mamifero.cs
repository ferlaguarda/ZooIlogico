using System;
using System.Collections.Generic;
using System.Text;

namespace Animales
{
    public class Mamifero : Animal
    {
        public int TiempoGestacion { get; set; } // en días
        public bool TienePelo { get; set; }
        
        public Mamifero() : base()
        {
            Tipo = TipoAnimal.Mamifero;
        }
        public Mamifero(string nombre, int? edad, string especie, string raza,
            TipoAlimentacion tipoAlimentacion, string alimentacion, string sonido,
            int tiempoGestacion, bool tienePelo)
            : base(nombre, TipoAnimal.Mamifero, edad, especie, raza,
                  tipoAlimentacion, alimentacion, sonido)
        {
            TiempoGestacion = tiempoGestacion;
            TienePelo = tienePelo;
        }

        public override string HacerSonido()
        {
            return $"Soy un {Nombre} y hago {Sonido}";
        }

        public override string ToString()
        {
            return $"Mamífero: {Nombre}, Edad: {Edad} años, Especie: {Especie}, Raza: {Raza}, " +
                   $"Alimentación: {Alimentacion} ({TipoAlimentacion}), Sonido: {Sonido}, " +
                   $"Tiempo de gestación: {TiempoGestacion} días, Tiene pelo: {TienePelo}";
        }
    }
}
