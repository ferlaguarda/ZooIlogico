#region Using
using CommonEntities.DTO;
using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using Microsoft.AspNetCore.Mvc; 
#endregion

namespace WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repository;

        public ProductosController(IProductoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductos()
        {
            var productos = await _repository.GetAllProductosAsync();
            return Ok(productos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            var p = await _repository.GetProductoPorId(id);
            return p is null ? NotFound() : Ok(p);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AgregarProductoDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var id = await _repository.CrearProducto(dto);
            return CreatedAtAction(nameof(GetById), new { id }, new { id });
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] AgregarProductoDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var ok = await _repository.ActualizarProducto(id, dto);
            return ok ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var ok = await _repository.BorrarProducto(id);
            return ok ? NoContent() : NotFound();
        }
    }
}
