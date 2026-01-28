namespace Lesson09.Tests.Guided
{
	// CalculatorTests_Guided.cs
	// Guided exercise: write xUnit tests (Arrange / Act / Assert) for Calculator.

	using System;
	using Xunit;

	public class CalculatorTests_Guided
	{
		// TIP: Use one shared instance or create a new one in each test.
		private readonly Calculator _calculator = new Calculator();

		[Fact]
		public void Add_ReturnsCorrectSum()
		{
			// TODO Arrange: choose inputs (e.g., 2 and 3)
			// int a = ...
			// int b = ...

			// TODO Act: call _calculator.Add(a, b)
			// var result = ...

			// TODO Assert: verify expected sum (e.g., 5)
			// Assert.Equal(..., result);
		}

		[Fact]
		public void Subtract_ReturnsCorrectDifference()
		{
			// TODO Arrange
			// int a = ...
			// int b = ...

			// TODO Act
			// var result = ...

			// TODO Assert
			// Assert.Equal(..., result);
		}

		[Fact]
		public void Multiply_ReturnsCorrectProduct()
		{
			// TODO Arrange
			// int a = ...
			// int b = ...

			// TODO Act
			// var result = ...

			// TODO Assert
			// Assert.Equal(..., result);
		}

		[Fact]
		public void Divide_ReturnsCorrectQuotient()
		{
			// TODO Arrange
			// int a = ...
			// int b = ...

			// TODO Act
			// double result = ...

			// TODO Assert
			// Use precision argument for floating-point comparisons.
			// Assert.Equal(expected: ..., actual: result, precision: 3);
		}

		[Fact]
		public void Divide_ByZero_ThrowsException()
		{
			// TODO Arrange
			// int a = ...
			// int b = 0;

			// TODO Assert (no Act step needed when using Assert.Throws)
			// Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
		}

		// OPTIONAL: Convert simple cases to a Theory with InlineData
		// [Theory]
		// [InlineData(2, 3, 5)]
		// [InlineData(-1, 1, 0)]
		// public void Add_Theory_Works(int a, int b, int expected)
		// {
		//     var result = _calculator.Add(a, b);
		//     Assert.Equal(expected, result);
		// }
	}


}
