using System;
using System.Collections.Generic;

/* =========================================================
   STEP 1: Normal Inheritance with virtual
   Virtual Method (Optional Override)
   ========================================================= */

class Animal_Virtual
{
    // virtual = child MAY override this
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog_Virtual : Animal_Virtual
{
    // override is OPTIONAL
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

/*
static void Main()
{
    Animal_Virtual a1 = new Animal_Virtual();
    Animal_Virtual a2 = new Dog_Virtual();

    a1.Speak(); // Animal makes a sound
    a2.Speak(); // Dog barks
}
*/


/* =========================================================
   STEP 2: Abstract Class (Forced Override)
   Abstract Method (Mandatory Override)
   ========================================================= */

abstract class Animal_Abstract
{
    // abstract = NO body
    // child MUST implement this
    public abstract void Speak();
}

class Dog_Abstract : Animal_Abstract
{
    // REQUIRED override
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

/*
static void Main()
{
    // Animal_Abstract a = new Animal_Abstract();  NOT allowed

    Animal_Abstract a = new Dog_Abstract();
    a.Speak(); // Dog barks
}
*/


/* =========================================================
   STEP 3: Mixing Abstract + Normal Methods
   Why Abstract Classes Exist
   ========================================================= */

abstract class Animal_Mixed
{
    // shared behavior
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }

    // forced behavior
    public abstract void Speak();
}

class Dog_Mixed : Animal_Mixed
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

/*
static void Main()
{
    Animal_Mixed dog = new Dog_Mixed();
    dog.Sleep(); // shared behavior
    dog.Speak(); // forced behavior
}
*/


/* =========================================================
   STEP 4: Interface (Pure Rules)
   Interface = Strict Contract
   ========================================================= */

interface IAnimal
{
    // NO implementation
    // just method rules
    void Speak();
}

class Dog_Interface : IAnimal
{
    // MUST implement ALL interface methods
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

/*
static void Main()
{
    IAnimal animal = new Dog_Interface();
    animal.Speak(); // Dog barks
}
*/


/* =========================================================
   STEP 5: Interface Polymorphism (Big Payoff)
   Why Interfaces Matter
   ========================================================= */

class Cat_Interface : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}


/* =========================================================
   STEP 6: Interface Polymorphism with Collection
   Real-world usage
   ========================================================= */

interface IPayment
{
    void Pay();
}

class CreditCard : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using Credit Card");
    }
}

class PayPal : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using PayPal");
    }
}


/* =========================================================
   ACTIVE MAIN METHOD
   (Change this to demo different steps)
   ========================================================= */

class Program
{
    static void Main()
    {
        // --- Step 1 demo ---
        Animal_Virtual a1 = new Animal_Virtual();
        Animal_Virtual a2 = new Dog_Virtual();
        a1.Speak();
        a2.Speak();

        Console.WriteLine();

        // --- Step 2 demo ---
        Animal_Abstract a3 = new Dog_Abstract();
        a3.Speak();

        Console.WriteLine();

        // --- Step 3 demo ---
        Animal_Mixed a4 = new Dog_Mixed();
        a4.Sleep();
        a4.Speak();

        Console.WriteLine();

        // --- Step 4 & 5 demo ---
        IAnimal i1 = new Dog_Interface();
        IAnimal i2 = new Cat_Interface();
        i1.Speak();
        i2.Speak();

        Console.WriteLine();

        // --- Step 6 demo ---
        List<IPayment> payments = new List<IPayment>
        {
            new CreditCard(),
            new PayPal()
        };

        foreach (IPayment p in payments)
        {
            p.Pay();
        }
    }
}
