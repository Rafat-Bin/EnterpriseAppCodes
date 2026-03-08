using lesson25_EF_Core_Blazor.Models;
using Microsoft.EntityFrameworkCore;


namespace lesson25_EF_Core_Blazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
