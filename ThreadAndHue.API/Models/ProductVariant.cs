using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ThreadAndHue.API.Models;

public class ProductVariant
{
    [Key]
    public int Id { get; set; }

    public int ProductId { get; set; }
    
    [JsonIgnore]
    public Product? Product { get; set; }

    [Required]
    [MaxLength(50)]
    public string Color { get; set; } = string.Empty;

    [Required]
    [MaxLength(10)]
    public string Size { get; set; } = string.Empty;

    public int StockQuantity { get; set; }

    [Required]
    [MaxLength(50)]
    public string SKU { get; set; } = string.Empty;
}
