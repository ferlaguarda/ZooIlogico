using System.Collections.Generic;

namespace CommonEntities.Interfaces
{
    public interface IGenericFileManager<T>
    {
        void Guardar(string ruta, List<T> datos);
        List<T> Leer(string ruta);
    }
}
