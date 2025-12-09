using ThreadAndHue.API.DTOs;
using ThreadAndHue.API.Repositories;

namespace ThreadAndHue.API.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(string? category, decimal? minPrice, decimal? maxPrice, string? size)
    {
        var products = await _repository.GetAllAsync(category, minPrice, maxPrice, size);

        return products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            BasePrice = p.BasePrice,
            Category = p.Category,
            CoverImage = p.CoverImage,
            HoverImage = p.Images.FirstOrDefault(i => i.DisplayOrder == 2)?.ImageUrl,
            AvailableSizes = p.Variants
                .Where(v => v.StockQuantity > 0)
                .Select(v => v.Size)
                .Distinct()
                .OrderBy(s => s) // Simple sort, might need custom logic for S, M, L
                .ToList()
        });
    }

    public async Task<ProductDetailDto?> GetProductByIdAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product == null) return null;

        return new ProductDetailDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            BasePrice = product.BasePrice,
            Category = product.Category,
            FabricComposition = product.FabricComposition,
            SizeGuide = product.SizeGuide,
            Variants = product.Variants.Select(v => new ProductVariantDto
            {
                Id = v.Id,
                Color = v.Color,
                Size = v.Size,
                StockQuantity = v.StockQuantity,
                SKU = v.SKU
            }).ToList(),
            Images = product.Images.OrderBy(i => i.DisplayOrder).Select(i => new ProductImageDto
            {
                Id = i.Id,
                ImageUrl = i.ImageUrl,
                IsMain = i.IsMain,
                DisplayOrder = i.DisplayOrder
            }).ToList()
        };
    }
}
