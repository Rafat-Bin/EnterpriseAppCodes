

//-----Example 1-------

using Lesson09.Core;

namespace Lesson09.Core

{

    // Simple calculator class

    public class Calculator

    {

        // Adds two numbers

        public int Add(int a, int b)

        {

            return a + b;

        }



        // Checks if a number is positive

        public bool IsPositive(int number)

        {

            return number > 0;

        }



        // Divides two numbers

        // Throws an exception if b is zero

        public int Divide(int a, int b)

        {

            if (b == 0)

            {

                throw new DivideByZeroException("Cannot divide by zero");

            }



            return a / b;

        }

    }

}

using Xunit;

using Lesson09.Core;



namespace Lesson09.Tests

{

    public class CalculatorFactTests

    {

        [Fact]

        public void Add_TwoNumbers_ReturnsSum()

        {

            // Arrange

            var calculator = new Calculator();



            // Act

            int result = calculator.Add(2, 3);



            // Assert

            Assert.Equal(5, result);

        }







        [Fact]

        public void Add_TwoNewNumbers_ReturnsSum()

        {

            // Arrange

            var calculator = new Calculator();



            // Act

            int result = calculator.Add(7, 4);



            // Assert

            Assert.Equal(5, result);

        }





        public class CalculatorTheoryTests

        {

            // Same test logic, multiple input values

            [Theory]

            [InlineData(1, 2, 3)]

            [InlineData(7, 4, 11)]

            [InlineData(0, 0, 0)]

            [InlineData(-1, 1, 0)]

            public void Add_MultipleValues_ReturnsCorrectSum(int a, int b, int expected)

            {

                // Arrange

                var calculator = new Calculator();



                // Act

                int result = calculator.Add(a, b);



                // Assert

                Assert.Equal(expected, result);

            }

        }







        [Fact]

        public void IsPositive_PositiveNumber_ReturnsTrue()

        {

            var calculator = new Calculator();



            bool result = calculator.IsPositive(5);



            Assert.True(result);

        }



        [Fact]

        public void IsPositive_NegativeNumber_ReturnsFalse()

        {

            var calculator = new Calculator();



            bool result = calculator.IsPositive(-3);



            Assert.False(result);

        }



        [Fact]

        public void Divide_ByZero_ThrowsException()

        {

            var calculator = new Calculator();



            // Act & Assert

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));

        }

    }

}





//------Example 2-------

//Problem Statement



//Create a class called Wallet that stores an amount of money.



//The wallet should start with 0 money



//It should have a method to add money



//It should have a method to get the current amount

namespace Lesson09.Core

{

    // Wallet class that stores money

    public class Wallet

    {

        // Private field to store the amount of money

        // Starts with 0 by default

        private int _amount = 0;



        // Adds money to the wallet

        public void AddMoney(int money)

        {

            _amount += money;

        }



        // Returns the current amount of money

        public int GetAmount()

        {

            return _amount;

        }

    }

}

using Xunit;

using Lesson09.Core;



namespace Lesson09.Tests

{

    public class WalletTests

    {

        [Fact]

        public void AddMoney_IncreasesAmount()

        {

            // Arrange

            // Create a new wallet (starts with 0 money)

            var wallet = new Wallet();



            // Act

            // Add money to the wallet

            wallet.AddMoney(10);

            int result = wallet.GetAmount();



            // Assert

            // Verify the amount increased correctly

            Assert.Equal(10, result);

        }

    }

}



//-----Example 3-----



//Problem Statement



//Create a class called ScoreCounter to track a player’s score in a game.



//The score should be set when the object is created



//The class should allow points to be added



//The class should provide a way to get the current score



namespace Lesson09.Core

{

    // Tracks a player's score in a game

    public class ScoreCounter

    {

        // Stores the current score

        private int _score;



        // Constructor sets the starting score

        public ScoreCounter(int startingScore)

        {

            _score = startingScore;

        }



        // Adds points to the score

        public void AddPoints(int points)

        {

            _score += points;

        }



        // Returns the current score

        public int GetScore()

        {

            return _score;

        }

    }

}

using Xunit;

using Lesson09.Core;



namespace Lesson09.Tests

{

    public class ScoreCounterTests

    {

        [Fact]

        public void AddPoints_IncreasesScoreFromInitialValue()

        {

            // Arrange

            // Create a counter with an initial score

            var counter = new ScoreCounter(20);



            // Act

            // Add points to the score

            counter.AddPoints(5);

            int result = counter.GetScore();



            // Assert

            // Verify the score increased correctly

            Assert.Equal(25, result);

        }

    }

}



//------Example 4----



//Problem Statement



//Create a class called ParkingMeter that keeps track of parking time in minutes.



//The parking meter should start with an initial number of minutes



//Additional minutes can be added



//Only positive minutes can be added



//If zero or negative minutes are provided, an error should be raised



//The class should provide a method to get the current parking minutes



using System;



namespace Lesson09.Core

{

    // Represents a parking meter that tracks time in minutes

    public class ParkingMeter

    {

        // Stores the current parking minutes

        private int _minutes;



        // Constructor sets the initial parking time

        public ParkingMeter(int initialMinutes)

        {

            _minutes = initialMinutes;

        }



        // Adds additional minutes to the parking meter

        // Only positive values are allowed

        public void AddMinutes(int minutes)

        {

            if (minutes <= 0)

            {

                throw new ArgumentException("Minutes must be greater than zero");

            }



            _minutes += minutes;

        }



        // Returns the current parking minutes

        public int GetMinutes()

        {

            return _minutes;

        }

    }

}

using Xunit;



using Lesson09.Core;



namespace Lesson09.Tests

{

    public class ParkingMeterTests

    {

        [Fact]

        public void AddMinutes_AddsMinutesToInitialValue()

        {

            // Arrange

            var meter = new ParkingMeter(30);



            // Act

            meter.AddMinutes(15);

            int result = meter.GetMinutes();



            // Assert

            Assert.Equal(45, result);

        }



        [Fact]

        public void AddMinutes_ZeroOrNegative_ThrowsException()

        {

            // Arrange

            var meter = new ParkingMeter(30);



            // Act & Assert

            var exception = Assert.Throws<ArgumentException>(() =>

                meter.AddMinutes(0)

            );



            Assert.Equal("Minutes must be greater than zero", exception.Message);

        }

    }



}

	



//-----Example 5----

//Problem Statement



//Design a Temperature class that represents a temperature value in degrees Celsius.



//The class should:



//Store the temperature internally using a private variable



//Initialize the temperature through a constructor



//Expose the temperature using a public read-only property



//Prevent setting the temperature below absolute zero (-273.15°C)



//Throw an appropriate exception if an invalid temperature is provided



//Allow increasing the temperature by a given amount



//Keep all validation logic inside the class



//Prevent direct modification of the internal temperature value



using System;



namespace Lesson09.Core

{

    // Represents a temperature value in degrees Celsius

    public class Temperature

    {

        // Private field that stores the temperature

        private double _value;



        // Constructor initializes the temperature

        public Temperature(double initialValue)

        {

            Value = initialValue; // Use property to enforce validation

        }



        // Public read-only property

        public double Value

        {

            get { return _value; }

            private set

            {

                if (value < -273.15)

                {

                    throw new ArgumentException(

                        "Temperature cannot be below absolute zero"

                    );

                }



                _value = value;

            }

        }



        // Increases the temperature by a given amount

        public void Increase(double amount)

        {

            Value += amount; // Validation still applies

        }

    }

}

using Xunit;



using Lesson09.Core;



namespace Lesson09.Tests

{

    public class TemperatureTests

    {

        [Fact]

        public void Increase_RaisesTemperature()

        {

            // Arrange

            var temperature = new Temperature(20);



            // Act

            temperature.Increase(5);

            double result = temperature.Value;



            // Assert

            Assert.Equal(25, result, 1);

        }

        [Fact]

        public void SettingBelowAbsoluteZero_ThrowsException()

        {

            // Act & Assert

            var exception = Assert.Throws<ArgumentException>(() =>

                new Temperature(-300)

            );



            Assert.Equal(

                "Temperature cannot be below absolute zero",

                exception.Message

            );

        }

    }

}

//------ Example 6 ------

// Problem Statement

// Create a class called Product that represents an item in a store.

// The product should store a name and a price.

// The name should be stored using a property with get and set.

// The price should be stored using a property with get and set.

// The name must not be null, empty, or whitespace.

// The price must be greater than zero.

// If an invalid name or price is provided, an exception should be thrown.

// All validation logic should be handled inside the class.

// The class should not allow direct access to the internal fields.

//------ Example 6 ------



namespace Lesson09.Core
{
    // Represents an item in a store
    public class Product
    {
        // Private fields to store data
        private string _name;
        private decimal _price;

        // Constructor initializes the product
        public Product(string name, decimal price)
        {
            Name = name;     // Uses setter validation
            Price = price;   // Uses setter validation
        }

        // Gets or sets the product name
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Product name cannot be null or empty"
                    );
                }

                _name = value;
            }
        }

        // Gets or sets the product price
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Price must be greater than zero"
                    );
                }

                _price = value;
            }
        }
    }
}


using Xunit;
using Lesson09.Core;

namespace Lesson09.Tests
{
    public class ProductTests
    {
        [Fact]
        public void SettingValidName_UpdatesName()
        {
            // Arrange & Act
            var product = new Product("Book", 10);

         
            // Assert
            Assert.Equal("Book", product.Name);
        }

        [Fact]
        public void SettingValidPrice_UpdatesPrice()
        {
            // Arrange & 
            var product = new Product("Pen", 2);


            // Assert
            Assert.Equal(2, product.Price);
        }

        [Fact]
        public void Constructor_InvalidName_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new Product("", 10)
            );
        }

        [Fact]
        public void Constructor_InvalidPrice_ThrowsException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Product("Item", -3)
            );
        }
    }
}
