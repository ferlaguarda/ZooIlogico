using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CommonEntities.DTO
{
    public class AgregarProductoDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        [Range(0, 100000)]
        public int Stock { get; set; }
    }
}
