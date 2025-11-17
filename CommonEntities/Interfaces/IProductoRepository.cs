using CommonEntities.DTO;
using CommonEntities.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonEntities.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllProductosAsync();
        Task<Producto> GetProductoPorId(int id);
        Task<int> CrearProducto(AgregarProductoDto nuevoProducto);
        Task<bool> ActualizarProducto(int id, AgregarProductoDto productoActualizado);
        Task<bool> BorrarProducto(int id);
    }
}
