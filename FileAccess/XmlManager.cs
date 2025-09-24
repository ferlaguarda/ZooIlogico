using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FileAccess
{
    public class XmlManager : IFileManager
    {
        public void Guardar(string ruta, List<Persona> datos)
        {
            var serializer = new XmlSerializer(typeof(List<Persona>));
            //using var fs = new FileStream(ruta, FileMode.Create);
            using(var fs = new FileStream(ruta, FileMode.Create))
            {
                serializer.Serialize(fs, datos);
            }
           // serializer.Serialize(fs, datos);
        }

        public List<Persona> Leer(string ruta)
        {
            var serializer = new XmlSerializer(typeof(List<Persona>));
           // using var fs = new FileStream(ruta, FileMode.Open);
            using (var fs = new FileStream(ruta, FileMode.Open))
            {
                return (List<Persona>)serializer.Deserialize(fs);
            }            
        }
    }
}
