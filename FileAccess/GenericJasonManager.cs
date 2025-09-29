using CommonEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileAccess
{
    public class GenericJasonManager<T> : IGenericFileManager<T>
    {
        public void Guardar(string ruta, List<T> datos)
        {
            string json = JsonConvert.SerializeObject(datos);
            File.WriteAllText(ruta, json);
        }

        public List<T> Leer(string ruta)
        {
            string json = File.ReadAllText(ruta);
            if (!string.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<List<T>>(json)!;
            }
            return new List<T>();
        }
    }
}
