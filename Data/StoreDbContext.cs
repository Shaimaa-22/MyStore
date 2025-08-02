using Microsoft.EntityFrameworkCore;
using MyStoreAPI.Models;

namespace MyStoreAPI.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
