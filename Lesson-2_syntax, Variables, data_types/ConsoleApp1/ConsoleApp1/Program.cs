using System;

class CSharpFundamentalsDemo
{
    static void Main(string[] args)
    {
        // First C# Program
        Console.WriteLine("Welcome to C# Fundamentals Demo!");
        Console.WriteLine("Hello World");

        // Declaring Variables
        int count = 5;
        double price = 9.99;
        bool isActive = true;

        Console.WriteLine($"Count = {count}");
        Console.WriteLine($"Price = {price}");
        Console.WriteLine($"Is Active = {isActive}");

        // Static Typing Example
        var number = 10;      // compiler knows this is int
        // number = "ten";    // compile-time error

        // Integer vs Floating Division
        double result1 = 5 / 2;
        double result2 = 5.0 / 2;

        Console.WriteLine($"5 / 2 = {result1}");
        Console.WriteLine($"5.0 / 2 = {result2}");

        // Output and Escape Sequences
        Console.WriteLine("Item\tPrice");
        Console.WriteLine("Pen\t1.50\n");

        // Formatting Output
        string name = "Alex";
        int age = 20;

        Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
        Console.WriteLine("My name is {0} and I am {1} years old.", name, age);
        Console.WriteLine($"My name is {name} and I am {age} years old.");

        // Choosing Numeric Types
        int students = 25;
        double average = 87.5;
        decimal salary = 2450.75m;

        Console.WriteLine($"Students: {students}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Salary: {salary}");

        // Arithmetic Operators
        double basePay = 25;
        double hours = 40;
        double overtimeHours = 10;
        double overtimeRate = 37.5;

        double wages = (basePay * hours) + (overtimeRate * overtimeHours);
        Console.WriteLine($"Total Wages: {wages}");

        // Math Class Methods
        double power = Math.Pow(2, 3);
        double root = Math.Sqrt(9);
        double rounded1 = Math.Round(1.3768);
        double rounded2 = Math.Round(1.3768, 2);

        Console.WriteLine($"2^3 = {power}");
        Console.WriteLine($"Sqrt(9) = {root}");
        Console.WriteLine($"Round(1.3768) = {rounded1}");
        Console.WriteLine($"Round(1.3768, 2) = {rounded2}");

        // Combined Assignment Operators
        int x = 10;
        x += 5;
        x *= 2;
        Console.WriteLine($"Combined result = {x}");

        // Type Conversion (Casting)
        double doubleMark = 88.88;
        int intMark = (int)doubleMark;
        double finalResult = (double)intMark / 10;

        Console.WriteLine($"Double Mark = {doubleMark}");
        Console.WriteLine($"Int Mark = {intMark}");
        Console.WriteLine($"Final Result = {finalResult}");

        // Named Constants
        const double GstRate = 0.05;
        const int MinAge = 18;

        Console.WriteLine($"GST Rate = {GstRate}");
        Console.WriteLine($"Minimum Age = {MinAge}");

        // String Class Example
        string greeting = "Good morning";
        string user = "Student";
        Console.WriteLine($"{greeting}, {user}");

        // Reading Keyboard Input
        Console.Write("Enter your name: ");
        string inputName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int inputAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {inputName}, you are {inputAge} years old.\n");

        // Comments Example
        // This is a single-line comment
        /*
           This is a multi-line comment.
           The compiler ignores comments.
        */

        Console.WriteLine("End of C# Fundamentals Demo.");
    }
}
