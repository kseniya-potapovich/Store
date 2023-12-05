using Microsoft.EntityFrameworkCore;
using Store.Entities;

namespace Store.Data;
public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; } 
}
