using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services.Queries.DTO
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            
            entityBuilder.HasData(SeedProducts());
        }

        private static List<Product> SeedProducts()
        {
            var products = new List<Product>();
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000)
                });
            }
            return products;
        }
    }
}
