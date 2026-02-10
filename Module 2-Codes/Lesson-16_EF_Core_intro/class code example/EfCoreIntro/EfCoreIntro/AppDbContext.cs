/****************************************************
 * REQUIRED NUGET PACKAGES (INSTALL FIRST)
 *
 * 1. Right-click the PROJECT name in Solution Explorer
 * 2. Select "Manage NuGet Packages..."
 * 3. Go to the "Browse" tab
 * 4. Install the following packages:
 *
 *    - Microsoft.EntityFrameworkCore
 *    - Microsoft.EntityFrameworkCore.Sqlite
 *    - Microsoft.EntityFrameworkCore.Sqlite.Core
 *
 * NOTE:
 * - No database server is required
 * - SQLite is just a file (app.db)

 ****************************************************/

using EfCoreIntro;
using Microsoft.EntityFrameworkCore;

// DbContext represents a SESSION with the database
// It knows:
//  - which database to use
//  - how to connect
//  - which tables exist
public class AppDbContext : DbContext
{
    // DbSet<Product> represents the Products table
    public DbSet<Product> Products => Set<Product>();

    // DbSet<Customer> represents the Customers table
    public DbSet<Customer> Customers => Set<Customer>();

    // This method configures the database connection
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as the database provider
        // "app.db" is a FILE on disk, not a server
        options.UseSqlite("Data Source=app.db");
    }
}
