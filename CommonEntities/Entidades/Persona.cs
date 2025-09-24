using System;

namespace CommonEntities.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        //public override string ToString()
        //{
        //   return $"Id: {Id}, Nombre: {Nombre}, Edad: {Edad}";
        //}

        public override string ToString() 
            => $"{Id}|{Nombre}|{Apellido}|{FechaNacimiento}";
    }

}
