using System;

class ControlStructuresDemo
{
    static void Main(string[] args)
    {
        // Boolean Conditions in C#
        int x = 5;
        if (x > 0)
        {
            Console.WriteLine("x is positive");
        }

        // Comparison Operators
        int a = 10;
        int b = 20;
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a < b);
        Console.WriteLine(a > b);

        // if / else Statement
        int age = 17;
        if (age >= 18)
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access denied");
        }

        // Nested if Statements
        bool isAuthenticated = true;
        bool hasPermission = false;

        if (isAuthenticated)
        {
            if (hasPermission)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Insufficient permissions");
            }
        }
        else
        {
            Console.WriteLine("User not authenticated");
        }

        // switch Statement
        int day = 2;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Unknown day");
                break;
        }

        // while Loop
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count);
            count++;
        }

        // for Loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // do-while Loop
        int input;
        do
        {
            Console.WriteLine("Enter a number greater than 0:");
            input = int.Parse(Console.ReadLine());
        }
        while (input <= 0);

        // Logical Operators
        bool hasConsent = true;
        if (age > 19 && hasConsent)
        {
            Console.WriteLine("Condition passed");
        }

        // Increment and Decrement Operators
        int y = 4;
        Console.WriteLine(y++);
        Console.WriteLine(++y);

        // Sentinel Value Loop
        Console.Write("Enter an integer (0 to stop): ");
        int data = int.Parse(Console.ReadLine());
        int sum = 0;

        while (data != 0)
        {
            sum += data;
            Console.Write("Enter an integer (0 to stop): ");
            data = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum is " + sum);

        // break and continue
        for (int n = 1; n <= 10; n++)
        {
            if (n == 5)
                continue;

            if (n == 9)
                break;

            Console.WriteLine(n);
        }

        Console.WriteLine("End of Control Structures Demo.");
    }
}
