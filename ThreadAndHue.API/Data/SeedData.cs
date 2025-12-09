using Microsoft.EntityFrameworkCore;
using ThreadAndHue.API.Models;

namespace ThreadAndHue.API.Data;

public static class SeedData
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (await context.Products.AnyAsync())
        {
            return; // DB has been seeded
        }

        var products = new List<Product>
        {
            // 1. Men's Oversized Tee
            new Product
            {
                Name = "The Heavyweight Oversized Tee",
                Description = "Crafted from 280gsm combed cotton, this oversized tee features a dropped shoulder design and a structured fit. The ultimate essential for a modern wardrobe.",
                BasePrice = 3500.00m,
                Category = "Men",
                CoverImage = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "100% Heavyweight Cotton (280gsm)",
                SizeGuide = "Oversized fit. Model is 6'1\" wearing size L.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Black", Size = "S", StockQuantity = 10, SKU = "M-TEE-BLK-S" },
                    new() { Color = "Black", Size = "M", StockQuantity = 15, SKU = "M-TEE-BLK-M" },
                    new() { Color = "Black", Size = "L", StockQuantity = 0, SKU = "M-TEE-BLK-L" },
                    new() { Color = "Off-White", Size = "M", StockQuantity = 8, SKU = "M-TEE-WHT-M" },
                    new() { Color = "Off-White", Size = "L", StockQuantity = 12, SKU = "M-TEE-WHT-L" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },
            
            // 2. Women's Wool Coat
            new Product
            {
                Name = "Structured Wool Blend Coat",
                Description = "A minimalist masterpiece. This double-breasted coat is tailored from a premium wool blend with a sharp lapel and hidden buttons.",
                BasePrice = 18000.00m,
                Category = "Women",
                CoverImage = "https://images.unsplash.com/photo-1539533018447-63fcce2678e3?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "70% Wool, 30% Polyamide. Lining: 100% Viscose.",
                SizeGuide = "Tailored fit. Fits true to size.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Charcoal", Size = "XS", StockQuantity = 5, SKU = "W-COAT-CHR-XS" },
                    new() { Color = "Charcoal", Size = "S", StockQuantity = 8, SKU = "W-COAT-CHR-S" },
                    new() { Color = "Camel", Size = "S", StockQuantity = 3, SKU = "W-COAT-CML-S" },
                    new() { Color = "Camel", Size = "M", StockQuantity = 6, SKU = "W-COAT-CML-M" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1539533018447-63fcce2678e3?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1515347619252-60a6bf4fffce?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 3. Men's Tapered Trousers
            new Product
            {
                Name = "Pleated Tapered Trousers",
                Description = "Smart-casual trousers with a single pleat and a relaxed tapered leg. Perfect for pairing with both sneakers and loafers.",
                BasePrice = 6500.00m,
                Category = "Men",
                CoverImage = "https://images.unsplash.com/photo-1473966968600-fa801b869a1a?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "65% Polyester, 35% Viscose",
                SizeGuide = "Relaxed fit. Cropped length.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Navy", Size = "30", StockQuantity = 10, SKU = "M-TRS-NVY-30" },
                    new() { Color = "Navy", Size = "32", StockQuantity = 15, SKU = "M-TRS-NVY-32" },
                    new() { Color = "Black", Size = "32", StockQuantity = 20, SKU = "M-TRS-BLK-32" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1473966968600-fa801b869a1a?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1504194921103-f8b80cadd5e4?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 4. Women's Silk Blouse
            new Product
            {
                Name = "Pure Silk Button-Up",
                Description = "Luxurious 100% silk blouse with a soft sheen. Features mother-of-pearl buttons and elongated cuffs.",
                BasePrice = 9500.00m,
                Category = "Women",
                CoverImage = "https://images.unsplash.com/photo-1551163943-3f6a2941dc29?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "100% Mulberry Silk",
                SizeGuide = "Fluid fit. Dry clean only.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Ivory", Size = "S", StockQuantity = 12, SKU = "W-BLS-IVY-S" },
                    new() { Color = "Ivory", Size = "M", StockQuantity = 8, SKU = "W-BLS-IVY-M" },
                    new() { Color = "Black", Size = "S", StockQuantity = 5, SKU = "W-BLS-BLK-S" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1551163943-3f6a2941dc29?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1605763240004-7e93b172d754?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 5. Men's Minimal Hoodie
            new Product
            {
                Name = "Essential Minimal Hoodie",
                Description = "Clean lines, premium heavyweight cotton. This relaxed-fit hoodie features a kangaroo pocket and ribbed cuffs. No logos, just quality.",
                BasePrice = 7000.00m,
                Category = "Men",
                CoverImage = "https://images.unsplash.com/photo-1556821840-3a63f95609a7?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "100% French Terry Cotton (350gsm)",
                SizeGuide = "Relaxed fit. Size up for oversized look.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Black", Size = "S", StockQuantity = 12, SKU = "M-HOD-BLK-S" },
                    new() { Color = "Black", Size = "M", StockQuantity = 18, SKU = "M-HOD-BLK-M" },
                    new() { Color = "Black", Size = "L", StockQuantity = 15, SKU = "M-HOD-BLK-L" },
                    new() { Color = "Gray", Size = "M", StockQuantity = 10, SKU = "M-HOD-GRY-M" },
                    new() { Color = "Gray", Size = "L", StockQuantity = 8, SKU = "M-HOD-GRY-L" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1556821840-3a63f95609a7?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1620799140408-edc6dcb6d633?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 6. Women's Cashmere Sweater
            new Product
            {
                Name = "Cashmere Crew Neck",
                Description = "Indulgent softness meets timeless design. This 100% cashmere sweater is lightweight yet warm, perfect for layering.",
                BasePrice = 15000.00m,
                Category = "Women",
                CoverImage = "https://images.unsplash.com/photo-1576566588028-4147f3842f27?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "100% Grade-A Mongolian Cashmere",
                SizeGuide = "Relaxed fit. Hand wash cold.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Cream", Size = "XS", StockQuantity = 6, SKU = "W-CSH-CRM-XS" },
                    new() { Color = "Cream", Size = "S", StockQuantity = 10, SKU = "W-CSH-CRM-S" },
                    new() { Color = "Black", Size = "S", StockQuantity = 8, SKU = "W-CSH-BLK-S" },
                    new() { Color = "Black", Size = "M", StockQuantity = 12, SKU = "W-CSH-BLK-M" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1576566588028-4147f3842f27?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 7. Men's Leather Jacket
            new Product
            {
                Name = "Italian Leather Moto Jacket",
                Description = "Timeless rebellion. Crafted from buttery-soft Italian lambskin with matte black hardware. Ages beautifully.",
                BasePrice = 35000.00m,
                Category = "Men",
                CoverImage = "https://images.unsplash.com/photo-1551028719-00167b16eac5?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "100% Italian Lambskin Leather. Lining: 100% Polyester",
                SizeGuide = "Slim fit. Take your regular size.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Black", Size = "S", StockQuantity = 3, SKU = "M-LTH-BLK-S" },
                    new() { Color = "Black", Size = "M", StockQuantity = 5, SKU = "M-LTH-BLK-M" },
                    new() { Color = "Black", Size = "L", StockQuantity = 4, SKU = "M-LTH-BLK-L" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1551028719-00167b16eac5?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1520975954732-35dd22299614?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            },

            // 8. Women's Wide Leg Pants
            new Product
            {
                Name = "High-Waisted Wide Leg Pant",
                Description = "Elegant drape with a flattering high waist. These wide-leg pants transition effortlessly from office to evening.",
                BasePrice = 8500.00m,
                Category = "Women",
                CoverImage = "https://images.unsplash.com/photo-1594938298603-c8148c4dae35?q=80&w=1000&auto=format&fit=crop",
                FabricComposition = "95% Polyester, 5% Elastane",
                SizeGuide = "High-rise, wide leg. Model wears size S.",
                Variants = new List<ProductVariant>
                {
                    new() { Color = "Black", Size = "XS", StockQuantity = 10, SKU = "W-WLP-BLK-XS" },
                    new() { Color = "Black", Size = "S", StockQuantity = 15, SKU = "W-WLP-BLK-S" },
                    new() { Color = "Black", Size = "M", StockQuantity = 12, SKU = "W-WLP-BLK-M" },
                    new() { Color = "Navy", Size = "S", StockQuantity = 8, SKU = "W-WLP-NVY-S" }
                },
                Images = new List<ProductImage>
                {
                    new() { ImageUrl = "https://images.unsplash.com/photo-1594938298603-c8148c4dae35?q=80&w=1000&auto=format&fit=crop", IsMain = true, DisplayOrder = 1 },
                    new() { ImageUrl = "https://images.unsplash.com/photo-1509551388413-e18d0ac5d495?q=80&w=1000&auto=format&fit=crop", IsMain = false, DisplayOrder = 2 }
                }
            }
        };

        context.Products.AddRange(products);
        await context.SaveChangesAsync();
    }
}
