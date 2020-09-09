using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);
            entityBuilder.HasData(SeedProducts());
        }

        private static List<ProductInStock> SeedProducts()
        {
            var products = new List<ProductInStock>();
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 100)
                });
            }
            return products;
        }
    }
}
