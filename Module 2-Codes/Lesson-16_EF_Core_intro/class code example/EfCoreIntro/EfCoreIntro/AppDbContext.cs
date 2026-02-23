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
using System;

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



    // TWO WAYS to configure the SQLite database connection in EF Core
    // ---------------------------------------------------------------
    // Students: You only need ONE of these approaches in your project.
    // The first is the SIMPLE way. The second is the ROBUST way that
    // avoids path issues when running from different environments.

    // ---------------------------------------------------------------
    // WAY 1 (Simple / Easy) Showed during class:
    // Hard-code the SQLite file name. EF will create the file
    // in the current working directory.
    // Good for small demos and quick labs.
    // ---------------------------------------------------------------

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    // Use SQLite as the database provider
    //    // "app.db" will be created in the working directory
    //    options.UseSqlite("Data Source=app.db");
    //}


    // ---------------------------------------------------------------
    // WAY 2 (Recommended / Robust):
    // Dynamically build the full file path so the DB is always created
    // in the project root folder. This prevents common errors like:
    //   "SQLite Error: no such table"
    // which can happen when Visual Studio and `dotnet run` use
    // different working directories.
    // ---------------------------------------------------------------
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Build a consistent absolute path to the database file
        var dbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, // bin/Debug/... folder
            "..", "..", "..",                      // move up to project root
            "app.db");                          // database file name

        dbPath = Path.GetFullPath(dbPath); // normalize the path

        // Use SQLite with the resolved file path
        options.UseSqlite($"Data Source={dbPath}");
    }
}
