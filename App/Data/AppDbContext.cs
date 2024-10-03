using Microsoft.EntityFrameworkCore;
using ProductApp.Models;

namespace ProductApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.1M, Total = 10 },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.2M, Total = 20 },
                new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 30.3M, Total = 30 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
