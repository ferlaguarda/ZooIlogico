using System;

namespace Animales
{
    public class Animal
    {
        public string Nombre { get; set; }
        public TipoAnimal Tipo { get; set; }
        public int? Edad { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public TipoAlimentacion TipoAlimentacion { get; set; }
        public string Alimentacion { get; set; }
        public string Sonido { get; set; }

        public Animal()
        {
        }

        public Animal(string nombre, TipoAnimal tipo, int? edad, string especie, 
            string raza, TipoAlimentacion tipoAlimentacion, string alimentacion, 
            string sonido)
        {
            Nombre = nombre;
            Tipo = tipo;
            Edad = edad;
            Especie = especie;
            Raza = raza;
            TipoAlimentacion = tipoAlimentacion;
            Alimentacion = alimentacion;
            Sonido = sonido;
        }

        public Animal(string nombre, TipoAnimal tipo, string especie,
            TipoAlimentacion tipoAlimentacion, string sonido)
        {
            Nombre = nombre;
            Tipo = tipo;
            Especie = especie;
            TipoAlimentacion = tipoAlimentacion;
            Sonido = sonido;
        }


        public virtual string HacerSonido()
        {
            return "Solo soy el genérico.";
        }
    }
}
