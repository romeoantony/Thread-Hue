using ThreadAndHue.API.DTOs;

namespace ThreadAndHue.API.Services;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllProductsAsync(string? category, decimal? minPrice, decimal? maxPrice, string? size);
    Task<ProductDetailDto?> GetProductByIdAsync(int id);
}
