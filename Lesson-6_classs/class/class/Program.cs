using System;

class ClassesAndObjectsDemo
{
    static void Main(string[] args)
    {
        // Creating an Object from a Class
        Car myCar = new Car("Toyota", 2018);
        myCar.Drive();

        // Using a Class with a Constructor
        Student s1 = new Student("Alex", 20);
        s1.PrintInfo();

        // Properties with Validation
        Driver d = new Driver();
        d.Age = 16;   // Invalid
        d.Age = 25;   // Valid

        // Fields vs Properties
        Person p = new Person();
        p.Age = 16;   // Invalid
        p.Age = 30;   // Valid
        p.PrintInfo();

        // Access Modifiers Example
        BankAccount account = new BankAccount();
        account.Deposit(-100); // Invalid
        account.Deposit(500);  // Valid
        account.PrintBalance();

        // Static vs Non-Static Members
        int squareResult = MathHelper.Square(5);
        MathHelper helper = new MathHelper();
        int cubeResult = helper.Cube(5);

        Console.WriteLine($"Square: {squareResult}");
        Console.WriteLine($"Cube: {cubeResult}");

        Console.WriteLine("End of Classes & Objects Demo.");
    }
}

// Basic Class with Fields and Method
class Car
{
    public string Brand;
    public int Year;

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Drive()
    {
        Console.WriteLine($"{Brand} car is driving");
    }
}

// Class with Constructor and Method
class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Property with Validation
class Driver
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18)
                age = value;
            else
                Console.WriteLine("Age must be 18 or older.");
        }
    }
}

// Fields vs Properties
class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 18)
                age = value;
            else
                Console.WriteLine("Age must be 18 or older.");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Age: {age}");
    }
}

// Access Modifiers Example
class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Invalid deposit amount.");
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }
}

// Static vs Non-Static Example
class MathHelper
{
    public static int Square(int x)
    {
        return x * x;
    }

    public int Cube(int x)
    {
        return x * x * x;
    }
}
