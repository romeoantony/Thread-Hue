using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ThreadAndHue.API.Models;

public class ProductImage
{
    [Key]
    public int Id { get; set; }

    public int ProductId { get; set; }

    [JsonIgnore]
    public Product? Product { get; set; }

    [Required]
    public string ImageUrl { get; set; } = string.Empty;

    public bool IsMain { get; set; }

    public int DisplayOrder { get; set; } // 1 = Main, 2 = Hover, etc.
}
