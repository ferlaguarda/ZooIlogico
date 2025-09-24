using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileAccess
{
    public class TextManager : IFileManager
    {
        public void Guardar(string ruta, List<Persona> datos)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (var persona in datos) 
                {
                    sw.WriteLine(persona.ToString());
                }
            }
        }

        public List<Persona> Leer(string ruta)
        {
            List<Persona> datos = new List<Persona>();
            foreach (var linea in File.ReadAllLines(ruta))
            {
                var partes = linea.Split('|');
                Persona persona = new Persona
                {
                    Id = int.Parse(partes[0]),
                    Nombre = partes[1],
                    Edad = int.Parse(partes[2])
                };
                datos.Add(persona);
            }
            return datos;
        }
    }
}
