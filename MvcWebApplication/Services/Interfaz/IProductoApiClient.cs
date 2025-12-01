using MvcWebApplication.Models;

namespace MvcWebApplication.Services.Interfaz
{
    public interface IProductoApiClient
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto?> GetByIdAsync(int id);
        Task<int?> CreateAsync(ProductoCreateDto dto);
        Task<bool> UpdateAsync(int id, ProductoCreateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
