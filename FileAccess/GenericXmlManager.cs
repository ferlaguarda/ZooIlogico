using CommonEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FileAccess
{
    public class GenericXmlManager<T> : IGenericFileManager<T>
    {
        public void Guardar(string ruta, List<T> datos)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            //using var fs = new FileStream(ruta, FileMode.Create);
            using (var fs = new FileStream(ruta, FileMode.Create))
            {
                serializer.Serialize(fs, datos);
            }
            // serializer.Serialize(fs, datos);
        }

        public List<T> Leer(string ruta)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            // using var fs = new FileStream(ruta, FileMode.Open);
            using (var fs = new FileStream(ruta, FileMode.Open))
            {
                return (List<T>)serializer.Deserialize(fs);
            }
        }
    }
}
