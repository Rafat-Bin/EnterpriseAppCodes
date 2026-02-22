namespace Module02.Lesson13.DemoSolution
{
	// LinqDemo_Solution.cs
	// Solution: LINQ queries with both query syntax and method syntax.

	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Student
	{
		public string Name { get; set; }
		public int Grade { get; set; }
	}

	public class LinqDemo_Solution
	{
		public static void Main()
		{
			Console.WriteLine("=== LINQ Solution ===");

			// Sample collection
			var students = new List<Student>
			{
				new Student { Name = "Alice", Grade = 85 },
				new Student { Name = "Bob", Grade = 72 },
				new Student { Name = "Charlie", Grade = 90 },
				new Student { Name = "Diana", Grade = 60 },
				new Student { Name = "Evan", Grade = 95 }
			};

			// 1. Query syntax: passing students (Grade >= 70, sorted desc)
			var passingQuery =
				from s in students
				where s.Grade >= 70
				orderby s.Grade descending
				select s;

			Console.WriteLine("\nQuery Syntax: Passing Students (Grade >= 70, sorted desc):");
			foreach (var s in passingQuery)
			{
				Console.WriteLine($"{s.Name} - {s.Grade}");
			}

			// 2. Method syntax: passing students (Grade >= 70, sorted desc)
			var passingMethod = students
				.Where(s => s.Grade >= 70)
				.OrderByDescending(s => s.Grade);

			Console.WriteLine("\nMethod Syntax: Passing Students (Grade >= 70, sorted desc):");
			foreach (var s in passingMethod)
			{
				Console.WriteLine($"{s.Name} - {s.Grade}");
			}

			// 3. Projection: Select only student names
			var names = students.Select(s => s.Name);

			Console.WriteLine("\nProjection: Student Names:");
			foreach (var name in names)
			{
				Console.WriteLine(name);
			}

			// 4. Grouping: Group by Pass/Fail
			var groups = from s in students
						 group s by (s.Grade >= 70 ? "Pass" : "Fail") into g
						 select g;

			Console.WriteLine("\nGrouping: Students by Pass/Fail:");
			foreach (var group in groups)
			{
				Console.WriteLine($"{group.Key}:");
				foreach (var s in group)
				{
					Console.WriteLine($"  {s.Name} - {s.Grade}");
				}
			}
		}
	}


}
