using CommonEntities.Entidades;
using System.Collections.Generic;

namespace CommonEntities.Interfaces
{
    public interface IFileManager
    {
        void Guardar(string ruta, List<Persona> datos);
        List<Persona> Leer(string ruta);
    }

    public interface IRepositorio<T>
    {
        void Guardar(string ruta, List<T> datos);
        List<T> Leer(string ruta);
    }
}
