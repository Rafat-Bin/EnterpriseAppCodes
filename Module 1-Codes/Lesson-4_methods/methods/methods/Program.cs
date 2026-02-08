// Using int.TryParse for Safe Input
static void ReadAgeSafely()
{
    Console.Write("Enter your age: ");
    string input = Console.ReadLine();

    bool success = int.TryParse(input, out int age);

    if (success)
    {
        Console.WriteLine($"Your age is {age}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a whole number.");
    }
}



using System;

class MethodsDemo
{
    static void Main()
    {
        // Calling a Void Method
        DisplayBanner();

        // Calling a Value-Returning Method
        int total = Add(5, 3);
        Console.WriteLine($"Total = {total}");

        // Parameters vs Arguments
        int product = Multiply(4, 5);
        Console.WriteLine($"Product = {product}");

        // Passing Multiple Parameters
        double area = CalculateArea(4.5, 3.2);
        Console.WriteLine($"Area = {area}");

        // Pass-By-Value Demonstration
        int value = 10;
        Increment(value);
        Console.WriteLine($"Value after Increment method = {value}");

        // Using Returned Values Meaningfully
        int sumResult = Sum(10, 20);
        Console.WriteLine($"Sum result = {sumResult}");

        // Method Overloading
        Console.WriteLine(Max(3, 7));
        Console.WriteLine(Max(2.5, 9.1));
        Console.WriteLine(Max(4.2, 7.8, 1.5));

        // Cup Converter Case Study
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResults(cups, ounces);

        Console.WriteLine("End of Methods Demo.");
    }

    // Void Method
    static void DisplayBanner()
    {
        Console.WriteLine("Welcome to the Methods Demo\n");
    }

    // Value-Returning Method
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Parameters vs Arguments
    static int Multiply(int x, int y)
    {
        return x * y;
    }

    // Passing Multiple Parameters
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    // Pass-By-Value Example
    static void Increment(int num)
    {
        num++;
    }

    // Returning Values from Methods
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Method Overloading (int)
    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    // Method Overloading (double)
    static double Max(double a, double b)
    {
        return a > b ? a : b;
    }

    // Method Overloading (three values)
    static double Max(double a, double b, double c)
    {
        return Max(Max(a, b), c);
    }

    // Cup Converter – Get Input
    static double GetCups()
    {
        Console.WriteLine("\nThis program converts cups to fluid ounces.");
        Console.WriteLine("1 cup = 8 fluid ounces");
        Console.Write("Enter number of cups: ");
        return double.Parse(Console.ReadLine());
    }

    // Cup Converter – Conversion Logic
    static double CupsToOunces(double numCups)
    {
        return numCups * 8.0;
    }

    // Cup Converter – Display Results
    static void DisplayResults(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups equals {ounces} fluid ounces.");
    }
}
