using System.ComponentModel.DataAnnotations;

namespace MvcWebApplication.Models
{
    public class ProductoCreateDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = "";

        [Range(0.01, 999999)]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
    }
}
