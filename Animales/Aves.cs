using System;
using System.Collections.Generic;
using System.Text;

namespace Animales
{
    public class Aves : Animal
    {
        public bool Migratoria { get; set; }
        public bool PuedeVolar { get; set; }
        public string EpocaDeMigracion { get; set; }

        public Aves() : base()
        {
            Tipo = TipoAnimal.Ave;
        }

        public Aves(string nombre, int? edad, string especie, string raza,
            TipoAlimentacion tipoAlimentacion, string alimentacion, string sonido,
            bool migratoria, bool puedeVolar, string epocaDeMigración)
            : base(nombre, TipoAnimal.Ave, edad, especie, raza,
                  tipoAlimentacion, alimentacion, sonido)
        {
            Migratoria = migratoria;
            PuedeVolar = puedeVolar;
            EpocaDeMigracion = epocaDeMigración;
        }

        public override string HacerSonido()
        {
            return $"Soy un {Nombre} y hago {Sonido}";
        }

        override public string ToString()
        {
            return $"Ave: {Nombre}, Edad: {Edad} años, Especie: {Especie}, Raza: {Raza}, " +
                   $"Alimentación: {Alimentacion} ({TipoAlimentacion}), Sonido: {Sonido}, " +
                   $"Migratoria: {Migratoria}, Puede volar: {PuedeVolar}, " +
                   $"Época de migración: {EpocaDeMigracion}";
        }
    }
}
