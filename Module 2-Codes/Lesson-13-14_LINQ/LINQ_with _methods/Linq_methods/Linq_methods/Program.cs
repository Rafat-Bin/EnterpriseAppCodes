using Linq_methods;


class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Bin",  Marks = 11, Section = "A" },
            new Student { Name = "Ali",  Marks = 85, Section = "A" },
            new Student { Name = "Sara", Marks = 72, Section = "B" },
            new Student { Name = "Aman", Marks = 85, Section = "B" },
            new Student { Name = "Zara", Marks = 40, Section = "C" },
            new Student { Name = "John", Marks = 65, Section = "C" }
        };

        StudentService service = new StudentService();

        // ===============================
        // USING LINQ FROM SERVICE
        // ===============================
        var passedStudents = service.GetPassedStudents(students);

        Console.WriteLine("Passed Students:");
        foreach (var s in passedStudents)
            Console.WriteLine($"{s.Name} - {s.Marks}");

        var bonusMarks = service.GetBonusMarks(students);

        Console.WriteLine("\nBonus Marks:");
        foreach (var m in bonusMarks)
            Console.WriteLine(m);

        var grouped = service.GroupBySection(students);

        Console.WriteLine("\nGrouped By Section:");
        foreach (var group in grouped)
        {
            Console.WriteLine($"Section {group.Key}");
            foreach (var s in group)
                Console.WriteLine($"   {s.Name}");
        }
    }
}