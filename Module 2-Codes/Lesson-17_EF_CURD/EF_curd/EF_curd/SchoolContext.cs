using Microsoft.EntityFrameworkCore;
using System;

namespace Module02.Lesson17.EfCoreCrudDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();

        // TWO WAYS to configure the SQLite database connection in EF Core
        // ---------------------------------------------------------------
        // Students: You only need ONE of these approaches in your project.
        // The first is the SIMPLE way. The second is the ROBUST way that
        // avoids path issues when running from different environments.

        // ---------------------------------------------------------------
        // WAY 1 (Simple / Easy) showed during class:
        // Hard-code the SQLite file name. EF will create the file
        // in the current working directory.
        // Good for small demos and quick labs.
        // ---------------------------------------------------------------

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // Use SQLite as the database provider
        //    // "app.db" will be created in the working directory
        //    options.UseSqlite("Data Source=school_crud_demo.db");
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
                "school_crud_demo.db");                          // database file name

            dbPath = Path.GetFullPath(dbPath); // normalize the path

            // Use SQLite with the resolved file path
            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(b =>
            {
                b.Property(c => c.Code).IsRequired().HasMaxLength(20);
                b.Property(c => c.Name).IsRequired().HasMaxLength(100);

                b.HasMany(c => c.Students)
                 .WithOne(s => s.Course!)
                 .HasForeignKey(s => s.CourseId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Student>(b =>
            {
                b.Property(s => s.Name).IsRequired().HasMaxLength(100);
            });
        }
    }
}