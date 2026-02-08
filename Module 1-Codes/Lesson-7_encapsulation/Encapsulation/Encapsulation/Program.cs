//Example 1: NO Encapsulation( NOT GOOD PRACTICE)
class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = -25;   // Allowed (BAD)
        Console.WriteLine($"Age: {p.Age}");
    }
}

//  NOT GOOD PRACTICE
class Person
{
    public int Age;
}


//Example 2: Property Type 1 – get / set 

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = 25;
        p.Age = -25;   // Allowed
        Console.WriteLine($"Age: {p.Age}");
    }
}

//  OK PRACTICE (NO VALIDATION)
class Person
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

//Example 3: Property Type 2 – get / set WITH Validation ( GOOD PRACTICE)



class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = 30;

        try
        {
            p.Age = -10;   // Not allowed
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// GOOD PRACTICE
class Person
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new Exception("Enter valid values");
            _age = value;
        }
    }
}


//Example 4: Property Type 3 – Get-Only Property



class Program
{
    static void Main()
    {
        Person p = new Person("first@test.com");
        Console.WriteLine(p.Email);

        p.UpdateEmail("updated@test.com");
        Console.WriteLine(p.Email);

        // p.Email = "hack@test.com";  Compile-time error
    }
}

//  BEST PRACTICE
class Person
{
    private string _email;

    public string Email
    {
        get { return _email; }
        private set { _email = value; }
    }

    public Person(string email)
    {
        _email = email;
    }

    public void UpdateEmail(string newEmail)
    {
        Email = newEmail;
    }
}


 //Example 6: Why Encapsulation Matters



class Program
{
    static void Main()
    {
        BankAccountPublic bad = new BankAccountPublic();
        bad.Balance = -5000;   // Allowed (BAD)
        Console.WriteLine($"Bad Balance: {bad.Balance}");

        BankAccountSafe good = new BankAccountSafe(1000);
        good.Deposit(500);
        good.Withdraw(300);
        Console.WriteLine($"Safe Balance: {good.Balance}");
    }
}

//  NOT GOOD PRACTICE
class BankAccountPublic
{
    public decimal Balance;
}

//  GOOD PRACTICE
class BankAccountSafe
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
    }

    public BankAccountSafe(decimal startingBalance)
    {
        _balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
            _balance -= amount;
    }
}
