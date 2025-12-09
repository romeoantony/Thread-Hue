using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThreadAndHue.API.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal BasePrice { get; set; }

    [Required]
    [MaxLength(50)]
    public string Category { get; set; } = string.Empty; // e.g., "Men", "Women", "Accessories"

    [Required]
    public string CoverImage { get; set; } = string.Empty;

    public string FabricComposition { get; set; } = string.Empty;
    
    public string SizeGuide { get; set; } = string.Empty;

    public ICollection<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
}
