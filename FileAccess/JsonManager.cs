using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;

namespace FileAccess
{
    public class JsonManager : IFileManager
    {
        public void Guardar(string ruta, List<Persona> datos)
        {
            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText(ruta, json);
        }

        public List<Persona> Leer(string ruta)
        {
            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Persona>>(json);
        }
    }
}
