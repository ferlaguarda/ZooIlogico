using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FileAccess
{
    public class JsonManager : IFileManager
    {
        public void Guardar(string ruta, List<Persona> datos)
        {
            string json = JsonConvert.SerializeObject(datos);
            File.WriteAllText(ruta, json);
        }

        public List<Persona> Leer(string ruta)
        {
            string json = File.ReadAllText(ruta);
            if (!string.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<List<Persona>>(json)!; 
            }
            return new List<Persona>();
        }
    }
}
