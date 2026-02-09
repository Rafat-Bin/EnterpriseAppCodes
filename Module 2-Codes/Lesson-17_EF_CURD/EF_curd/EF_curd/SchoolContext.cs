using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Module02.Lesson17.EfCoreCrudDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=school_crud_demo.db");

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