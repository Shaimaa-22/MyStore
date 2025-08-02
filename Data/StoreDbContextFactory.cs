using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyStoreAPI.Data
{
    public class StoreDbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StoreDbContext>();

            // لازم تكتبي هنا نفس الاتصال الموجود في appsettings.json
optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=myapp;Username=postgres;Password=Shaimaadwedar@2003");

            return new StoreDbContext(optionsBuilder.Options);
        }
    }
}
