using CommonEntities.Entidades;
using System.Collections.Generic;

namespace CommonEntities.Interfaces
{
    public interface IFileManager
    {
        void Guardar(string ruta, List<Persona> datos);
        List<Persona> Leer(string ruta);
    }

}
