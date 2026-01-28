using PetStore.Animals;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                PrintMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAnimal();
                        break;
                    case "2":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

        }
        static void PrintMainMenu()
        {
            Console.WriteLine("Pet Store.");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Quit");
            Console.Write("Enter choice: ");
        }
        static void PrintSelectMenu()
        {
            Console.WriteLine("Select Animal");
            Console.WriteLine("1. Add dog.");
            Console.WriteLine("2. Add cat.");
            Console.WriteLine("3. Add bird.");
            Console.Write("Enter choice: ");
        }

        static void AddAnimal()
        {
            PrintSelectMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddDog();
                    break;
                case "2":
                    AddCat();
                    break;
                case "3":
                    AddBird();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        static void AddDog()
        {
            string name = GetString("Enter the name: ");
            int age = GetInt("Enter the age: ");
            string breed = GetString("Enter the breed: ");

            Dog dog = new Dog(name, age, breed);
            Console.WriteLine($"Added {dog}");
            dog.MakeNoise();
        }
        static void AddCat()
        {
            string name = GetString("Enter the name: ");
            int age = GetInt("Enter the age: ");
            string breed = GetString("Enter the breed: ");

            Cat cat = new Cat(name, age, breed);
            Console.WriteLine($"Added {cat}");
            cat.MakeNoise();
        }
        static void AddBird()
        {
            string name = GetString("Enter the name: ");
            int age = GetInt("Enter the age: ");
            string breed = GetString("Enter the species: ");

            Bird bird = new Bird(name, age, breed);
            Console.WriteLine($"Added {bird}");
            bird.MakeNoise();
        }

        static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static int GetInt(string prompt) 
        {
            bool success = false;
            int age = 0;

            do
            {
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out age);
                if (!success)
                    Console.WriteLine("Invalid input.");

            } while (!success);
            return age;
        }

    }
}
