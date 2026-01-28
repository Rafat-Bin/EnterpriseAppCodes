// DecisionMakingDemo.cs
// Demonstrates control flow and decision making in C#.
Console.Write("Enter your numeric grade (0-100): ");
string input = Console.ReadLine();
int grade = int.Parse(input);

// Example of if / else if / else
if (grade >= 90)
{
    Console.WriteLine("You earned an A!");
}
else if (grade >= 80)
{
    Console.WriteLine("You earned a B.");
}
else if (grade >= 70)
{
    Console.WriteLine("You earned a C.");
}
else if (grade >= 60)
{
    Console.WriteLine("You earned a D.");
}
else
{
    Console.WriteLine("You earned an F.");
}

Console.WriteLine();

// Example of logical operators
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Are you a student? (yes/no): ");
string isStudentResponse = Console.ReadLine();
bool isStudent = isStudentResponse.ToLower() == "yes";

if (age < 18 || isStudent)
{
    Console.WriteLine("You are eligible for a student discount.");
}
else
{
    Console.WriteLine("Sorry, no discount available.");
}
