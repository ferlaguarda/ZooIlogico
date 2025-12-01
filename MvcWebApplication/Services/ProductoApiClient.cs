using MvcWebApplication.Models;
using MvcWebApplication.Services.Interfaz;

namespace MvcWebApplication.Services
{
    public class ProductoApiClient : IProductoApiClient
    {
        private readonly HttpClient _http;

        public ProductoApiClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<int?> CreateAsync(ProductoCreateDto dto)
        {
            var response = await _http.PostAsJsonAsync("/Productos/Create", dto);
            if (!response.IsSuccessStatusCode)
                return null;

            var createdId = await response.Content.ReadFromJsonAsync<Dictionary<string,int>>();
            if(createdId != null && createdId.TryGetValue("id", out var id))
                return id;

            return null;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"/Productos/Create/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            var result = await _http.GetFromJsonAsync<IEnumerable<Producto>>("/Productos/GetAllProductos");
            return result ?? Enumerable.Empty<Producto>();
        }

        public async Task<Producto?> GetByIdAsync(int id)
        {
            var response = await _http.GetAsync($"/Productos/GetById/{id}");
            if(response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<Producto>();
            return null;
        }

        public async Task<bool> UpdateAsync(int id, ProductoCreateDto dto)
        {
            var response = await _http.PutAsJsonAsync($"/Productos/Update/{id}", dto);
            return response.IsSuccessStatusCode;
        }
    }
}
