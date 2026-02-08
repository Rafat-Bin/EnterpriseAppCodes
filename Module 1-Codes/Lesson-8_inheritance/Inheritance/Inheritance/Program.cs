

/*
====================================================
EXAMPLE 1: BASIC INHERITANCE (GOOD PRACTICE)
IS-A relationship: Dog is an Animal
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         Dog dog = new Dog();
//         Cat cat = new Cat();
//
//         dog.Eat();
//         cat.Eat();
//     }
// }
//
// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("The animal is eating.");
//     }
// }
//
// class Dog : Animal
// {
// }
//
// class Cat : Animal
// {
// }



/*
====================================================
EXAMPLE 2: VIRTUAL METHOD & OVERRIDE (GOOD PRACTICE)
Demonstrates default behavior + child replacement
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         Animal dog = new Dog();
//         Animal cat = new Cat();
//
//         dog.Speak();
//         cat.Speak();
//     }
// }
//
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("The animal makes a sound.");
//     }
// }
//
// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Bark!");
//     }
// }
//
// class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meow!");
//     }
// }



/*
====================================================
EXAMPLE 3: POLYMORPHISM (GOOD PRACTICE)
Base reference, child object
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         Animal a1 = new Dog();
//         Animal a2 = new Cat();
//
//         a1.Speak();
//         a2.Speak();
//     }
// }
//
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal sound");
//     }
// }
//
// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Bark!");
//     }
// }
//
// class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meow!");
//     }
// }



/*
====================================================
EXAMPLE 4: POLYMORPHISM WITH COLLECTIONS (GOOD PRACTICE)
One base type, many forms
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         List<Animal> animals = new List<Animal>();
//         animals.Add(new Dog());
//         animals.Add(new Cat());
//         animals.Add(new Dog());
//
//         foreach (Animal animal in animals)
//         {
//             animal.Speak();
//         }
//     }
// }
//
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal sound");
//     }
// }
//
// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Bark!");
//     }
// }
//
// class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meow!");
//     }
// }



/*
====================================================
EXAMPLE 5: METHOD OVERLOADING (NOT INHERITANCE)
Compile-time behavior
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         Calculator c = new Calculator();
//         Console.WriteLine(c.Add(2, 3));
//         Console.WriteLine(c.Add(2.5, 3.5));
//     }
// }
//
// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }
//
//     public double Add(double a, double b)
//     {
//         return a + b;
//     }
// }



/*
====================================================
EXAMPLE 6: BAD INHERITANCE (NOT GOOD PRACTICE)
Violates IS-A rule
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         BadCar car = new BadCar();
//         car.Start();   // Makes no logical sense
//     }
// }
//
// class Engine
// {
//     public void Start()
//     {
//         Console.WriteLine("Engine started.");
//     }
// }
//
// // BAD: A Car is NOT an Engine
// class BadCar : Engine
// {
// }



/*
====================================================
EXAMPLE 7: COMPOSITION (BEST PRACTICE)
HAS-A relationship
====================================================
*/

// class Program
// {
//     static void Main()
//     {
//         GoodCar car = new GoodCar();
//         car.StartCar();
//     }
// }
//
// class Engine
// {
//     public void Start()
//     {
//         Console.WriteLine("Engine started.");
//     }
// }
//
// //  GOOD: Car HAS an Engine
// class GoodCar
// {
//     private Engine engine = new Engine();
//
//     public void StartCar()
//     {
//         engine.Start();
//         Console.WriteLine("Car is moving.");
//     }
// }
