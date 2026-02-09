using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Module02.Lesson17.EfCoreCrudDemo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== EF Core CRUD + Relationships Demo ===");

            using var db = new SchoolContext();

            // Demo-only setup
            db.Database.EnsureDeleted();   // remove after first run if you want data persistence
            db.Database.EnsureCreated();

            // 1) CREATE -------------------------------------------------------
            var course = new Course
            {
                Code = "SDEV2301",
                Name = "Enterprise App Dev",
                Credits = 3
            };

            db.Courses.Add(course);

            db.Students.AddRange(
                new Student { Name = "Alice", Age = 20, Course = course },
                new Student { Name = "Bob", Age = 22, Course = course },
                new Student { Name = "Cara", Age = 19, Course = course }
            );

            db.SaveChanges();
            Console.WriteLine("Created course + 3 students.");

            // 2) READ ---------------------------------------------------------
            var loadedCourse = db.Courses
                .Include(c => c.Students)
                .Single(c => c.Code == "SDEV2301");

            Console.WriteLine($"\nREAD: {loadedCourse.Code} - {loadedCourse.Name}");
            foreach (var s in loadedCourse.Students)
                Console.WriteLine($" - {s.Name}, Age {s.Age}");

            // 3) UPDATE -------------------------------------------------------
            loadedCourse.Credits = 4;
            var bob = loadedCourse.Students.Single(s => s.Name == "Bob");
            bob.Age = 23;

            db.SaveChanges();
            Console.WriteLine("\nUPDATE: Credits updated, Bob's age updated.");

            // 4) DELETE -------------------------------------------------------
            var cara = loadedCourse.Students.Single(s => s.Name == "Cara");
            db.Students.Remove(cara);
            db.SaveChanges();
            Console.WriteLine("\nDELETE: Removed Cara.");

            db.Courses.Remove(loadedCourse);
            db.SaveChanges();
            Console.WriteLine("DELETE: Removed course (cascade delete).");

            // 5) VERIFY -------------------------------------------------------
            Console.WriteLine($"\nCounts -> Courses: {db.Courses.Count()}, Students: {db.Students.Count()}");
            Console.WriteLine("\nDemo complete.");
        }
    }
}