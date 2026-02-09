

namespace EfCoreIntro
{
    // This class represents a TABLE in the database
    // Each instance of Product represents ONE ROW
    public class Product
    {
        // EF Core recognizes "Id" as the primary key by convention
        public int Id { get; set; }

        // Column: Product name
        public string Name { get; set; } = string.Empty;

        // Column: Product price
        public decimal Price { get; set; }
    }
}
