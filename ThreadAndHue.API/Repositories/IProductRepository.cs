using ThreadAndHue.API.Models;

namespace ThreadAndHue.API.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync(string? category, decimal? minPrice, decimal? maxPrice, string? size);
    Task<Product?> GetByIdAsync(int id);
}
