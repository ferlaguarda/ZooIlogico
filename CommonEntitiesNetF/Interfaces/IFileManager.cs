using System.Collections.Generic;

namespace CommonEntitiesNetF.Interfaces
{
    public interface IFileManager
    {
        void Guardar(string ruta, List<Persona> datos);
        List<Persona> Leer(string ruta);
    }
}
