using Microsoft.AspNetCore.Mvc;
using MvcWebApplication.Models;
using MvcWebApplication.Services.Interfaz;

namespace MvcWebApplication.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoApiClient _api;

        public ProductosController(IProductoApiClient api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            var productos = await _api.GetAllAsync();
            return View(productos);
        }

        public IActionResult Create()
        {
            return View(new ProductoCreateDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoCreateDto model)
        {
            if(!ModelState.IsValid)
                return View(model);

            var newProductoId = await _api.CreateAsync(model);
            if ((newProductoId is null))
            {
                ModelState.AddModelError(string.Empty, "Ocurrió un error al crear el producto.");
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var producto = await _api.GetByIdAsync(id);
            if (producto is null)
                return NotFound();
            return View(producto);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
