using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09.Tests
{
	// Calculator.cs
	// A simple class to demonstrate unit testing with xUnit.

	using System;

	public class Calculator
	{
		public int Add(int a, int b) => a + b;

		public int Subtract(int a, int b) => a - b;

		public int Multiply(int a, int b) => a * b;

		public double Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Cannot divide by zero.");
			return (double)a / b;
		}
	}

}
