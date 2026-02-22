namespace Module02.Lesson13.Demo_Guided
{
	// LinqDemo_Guided.cs
	// Guided exercise: Practice writing LINQ queries with both query syntax and method syntax.

	using System;
	using System.Collections.Generic;

	public class Student
	{
		public string Name { get; set; }
		public int Grade { get; set; }
	}

	public class LinqDemo_Guided
	{
		public static void Main()
		{
			Console.WriteLine("=== LINQ Guided Exercise ===");

			// Sample collection
			var students = new List<Student>
		{
			new Student { Name = "Alice", Grade = 85 },
			new Student { Name = "Bob", Grade = 72 },
			new Student { Name = "Charlie", Grade = 90 },
			new Student { Name = "Diana", Grade = 60 },
			new Student { Name = "Evan", Grade = 95 }
		};

			// TODO 1: Write a query syntax LINQ expression
			// Task: Select students with Grade >= 70, ordered descending by grade.
			// Example structure:
			// var passingQuery =
			//     from s in students
			//     where ...
			//     orderby ...
			//     select s;
			//
			// Print the results in a foreach loop.


			// TODO 2: Write the equivalent method syntax LINQ query
			// Task: Select students with Grade >= 70, ordered descending by grade.
			// Example structure:
			// var passingMethod = students
			//     .Where(...)
			//     .OrderByDescending(...);
			//
			// Print the results in a foreach loop.


			// TODO 3: Projection
			// Task: Use Select to get only student names.
			// Print all the names.


			// TODO 4: Grouping
			// Task: Group students by "Pass" (>=70) and "Fail" (<70).
			// Hint: group s by (condition ? "Pass" : "Fail")
			// Print out the group key and all student names in that group.
		}
	}


}
