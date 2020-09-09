using Catalog.Domain;
using Catalog.Persistence.Database.Configuration;
using Catalog.Services.Queries.DTO;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelConfig(modelBuilder);
            modelBuilder.HasDefaultSchema("Catalog");
            base.OnModelCreating(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}
