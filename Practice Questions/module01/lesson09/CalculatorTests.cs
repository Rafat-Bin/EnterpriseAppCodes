namespace Lesson09.Tests
{
	// CalculatorTests.cs
	// Unit tests for the Calculator class using xUnit.
	/*
	 * ✔️ This sample demonstrates:
	 *		Setting up a class under test (Calculator).
	 *		Using [Fact] for test methods.
	 *		Writing assertions (Assert.Equal, Assert.Throws).
	 *		Testing both normal cases and an exception case.
	 */

	using System;
	using Xunit;

	public class CalculatorTests
	{
		private readonly Calculator _calculator = new Calculator();

		[Fact]
		public void Add_ReturnsCorrectSum()
		{
			int result = _calculator.Add(2, 3);
			Assert.Equal(5, result);
		}

		[Fact]
		public void Subtract_ReturnsCorrectDifference()
		{
			int result = _calculator.Subtract(10, 4);
			Assert.Equal(6, result);
		}

		[Fact]
		public void Multiply_ReturnsCorrectProduct()
		{
			int result = _calculator.Multiply(3, 4);
			Assert.Equal(12, result);
		}

		[Fact]
		public void Divide_ReturnsCorrectQuotient()
		{
			double result = _calculator.Divide(10, 2);
			Assert.Equal(5.0, result, precision: 1);
		}

		[Fact]
		public void Divide_ByZero_ThrowsException()
		{
			Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
		}
	}

}
