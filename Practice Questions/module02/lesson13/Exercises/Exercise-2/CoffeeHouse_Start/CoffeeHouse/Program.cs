namespace CoffeeHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Coffee> order = PopulateData();
            
            bool runProgram = true;

            while (runProgram)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SortDrinksByPrice(order);
                        break;
                    case "2":
                        GroupDrinks(order);
                        break;
                    case "3":
                        FilterDrinks(order);
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }
            }
        }
        static void SortDrinksByPrice(List<Coffee> order)
        {
            throw new NotImplementedException();
        }

        #region Group Drinks Methods
        static void GroupDrinks(List<Coffee> order)
        {
            PrintGroupDrinksMenu();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    GroupDrinksByPrice(order);
                    break;
                case "2":
                    GroupDrinksBySize(order);
                    break;
                case "3":
                    GroupDrinksByHasMilk(order);
                    break;
                case "4":
                    GroupDrinksByRoast(order);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }

        static void GroupDrinksByPrice(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        static void GroupDrinksBySize(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        static void GroupDrinksByHasMilk(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        static void GroupDrinksByRoast(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Filtering Methods
        static void FilterDrinks(List<Coffee> order)
        {
            PrintFilterDrinksMenu();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FilterByPrice(order);
                    break;
                case "2":
                    FilterBySize(order);
                    break;
                case "3":
                    FilterByMilkContent(order);
                    break;
                case "4":
                    CountRoasts(order);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }

        static void FilterByPrice(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        static void FilterBySize(List<Coffee> order)
        {
            throw new NotImplementedException();
        }
        static void FilterByMilkContent(List<Coffee> order)
        {
            throw new NotImplementedException();

        }
        static void CountRoasts(List<Coffee> order)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Print Menu Methods
        static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Sort Drinks by Price.");
            Console.WriteLine("2. Group Drinks.");
            Console.WriteLine("3. Filter the drinks in the order.");
            Console.WriteLine("4. Clear Screen.");
            Console.WriteLine("5. Quit.");
            Console.Write("Enter your choice: ");
        }
        static void PrintGroupDrinksMenu()
        {
            Console.WriteLine("How would you like to group the drinks?");
            Console.WriteLine("1. By Price.");
            Console.WriteLine("2. By Size.");
            Console.WriteLine("3. By Milk Content.");
            Console.WriteLine("4. By Roast.");
            Console.Write("Enter your choice: ");
        }
        static void PrintFilterDrinksMenu()
        {
            Console.WriteLine("How would you like to filter the drinks?");
            Console.WriteLine("1. By Price.");
            Console.WriteLine("2. By Size.");
            Console.WriteLine("3. By Milk Content.");
            Console.WriteLine("4. Count number of drinks by Roast.");
            Console.Write("Enter your choice: ");
        }
        #endregion
        static List<Coffee> PopulateData()
        {
            return new List<Coffee>()
            {
                new Coffee(6.99, "Large", true, "Dark"),
                new Coffee(8.99, "Extra Large", true, "Dark"),
                new Coffee(8.99, "Extra Large", true, "Dark"),
                new Coffee(4.99, "Small", false, "Medium"),
                new Coffee(4.99, "Small", false, "Medium"),
                new Coffee(6.49, "Medium", false, "Dark"),
                new Coffee(5.99, "Small", true, "Light"),
                new Coffee(5.99, "Small", true, "Dark"),
                new Coffee(7.99, "Extra Large", false, "Light"),
                new Coffee(7.99, "Extra Large", false, "Dark"),
                new Coffee(6.99, "Medium", false, "Light"),
                new Coffee(6.99, "Large", true, "Light"),
                new Coffee(8.99, "Extra Large", true, "Medium"),
                new Coffee(6.99, "Medium", true, "Dark"),
                new Coffee(5.99, "Small", true, "Dark")
            };
        }
    }
}
