namespace Lesson08.ConsoleApp
{
	// InheritanceDemo.cs
	// Demonstrates inheritance, polymorphism, and composition vs. inheritance in C#.
	/*
	 * This demo highlights:
	 *	Inheritance: Circle and Rectangle inherit from Shape.
	 *	Polymorphism: Different objects share the same interface (GetArea, Describe) but behave differently.
	 *	Composition vs. Inheritance: A Car has an Engine, rather than inheriting from it.
	 * 
	 * */

	using System;
	using System.Collections.Generic;

	// Base class (parent)
	public abstract class Shape
	{
		public string Color { get; set; }

		public Shape(string color)
		{
			Color = color;
		}

		// Virtual/abstract method to be overridden by derived classes
		public abstract double GetArea();

		public virtual void Describe()
		{
			Console.WriteLine($"This is a {Color} shape.");
		}
	}

	// Derived class: Circle
	public class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle(string color, double radius) : base(color)
		{
			Radius = radius;
		}

		public override double GetArea() => Math.PI * Radius * Radius;

		public override void Describe()
		{
			Console.WriteLine($"This is a {Color} circle with radius {Radius}.");
		}
	}

	// Derived class: Rectangle
	public class Rectangle : Shape
	{
		public double Length { get; set; }
		public double Width { get; set; }

		public Rectangle(string color, double length, double width) : base(color)
		{
			Length = length;
			Width = width;
		}

		public override double GetArea() => Length * Width;

		public override void Describe()
		{
			Console.WriteLine($"This is a {Color} rectangle {Length} x {Width}.");
		}
	}

	// Example of composition (not inheritance)
	public class Car
	{
		public Engine Engine { get; }  // Car "has an" Engine (composition)

		public Car()
		{
			Engine = new Engine();
		}

		public void Drive()
		{
			Engine.Start();
			Console.WriteLine("The car is driving...");
		}
	}

	public class Engine
	{
		public void Start() => Console.WriteLine("Engine starting...");
	}

	public class InheritanceDemo
	{
		public static void Main()
		{
			Console.WriteLine("=== Inheritance and Polymorphism Demo ===");

			// Polymorphism in action
			List<Shape> shapes = new List<Shape>
		{
			new Circle("Red", 5),
			new Rectangle("Blue", 4, 6)
		};

			foreach (var shape in shapes)
			{
				shape.Describe();
				Console.WriteLine($"Area = {shape.GetArea():F2}");
				Console.WriteLine();
			}

			Console.WriteLine("=== Composition Example ===");
			var car = new Car();
			car.Drive();
		}
	}

}
