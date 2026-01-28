using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.ConsoleApp.Guided
{
	// AbstractionDemo_Guided.cs
	// Guided exercise: Practice using abstract classes and interfaces in C#.

	using System;

	// TODO: Define an abstract class Animal
	// - Add a read-only property Name (string)
	// - Add a constructor that sets Name
	// - Add an abstract method Speak()
	// - Add a virtual method Describe() that prints "This is an animal named {Name}."


	// TODO: Define a Dog class that inherits from Animal
	// - Implement Speak() to print "{Name} says: Woof!"
	// - Override Describe() to print "{Name} is a loyal dog."


	// TODO: Define a Cat class that inherits from Animal
	// - Implement Speak() to print "{Name} says: Meow!"
	// - Use the base Describe() implementation


	// TODO: Define an interface IMovable
	// - Add a method Move()


	// TODO: Define a Car class that implements IMovable
	// - Implement Move() to print "The car drives on the road."


	// TODO: Define a Bird class that inherits from Animal AND implements IMovable
	// - Implement Speak() to print "{Name} chirps: Tweet!"
	// - Implement Move() to print "{Name} flies in the sky."


	public class AbstractionDemo_Guided
	{
		public static void Main()
		{
			Console.WriteLine("=== Abstract Classes Example ===");

			// TODO: Create a Dog and a Cat (use Animal references)
			// - Call Describe() and Speak() on each


			Console.WriteLine("\n=== Interfaces Example ===");

			// TODO: Create a Car and a Bird (as IMovable references)
			// - Call Move() on each


			Console.WriteLine("\n=== Combined Example ===");

			// TODO: Create a Bird as an Animal reference
			// - Call Describe() and Speak()
			// - Cast it to IMovable and call Move()
		}
	}


}
