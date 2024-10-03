using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(20)]
        public required string Name { get; set; }

        [Required()]
        [StringLength(100)]
        public required string Description { get; set; }

        [Required()]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required()]
        public int Total { get; set; }
    }
}
