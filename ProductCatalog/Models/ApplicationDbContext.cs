using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models.Entities;

namespace ProductCatalog.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
