//Basic list
class Program

{

    static void Main()

    {

        List<int> numbers = new List<int> { 2, 3, 5, 6 };



        foreach (int n in numbers)

        {

            Console.WriteLine(n);

        }

    }

}


//-------without LINQ
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 5, 6 };

        List<int> result = new List<int>();

        foreach (int n in numbers)
        {
            if (n > 3)
            {
                result.Add(n);
            }
        }

        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}


/// <summary>
/// same code with linq
/// </summary>
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 5, 6 };

        var result = numbers.Where(n => n > 3);

        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}


//Create objects FIRST, then add to list..





class Student

{

    public string Name { get; set; }

    public int Marks { get; set; }

}



class Program

{

    static void Main()

    {

        // Create students first

        Student s1 = new Student();

        s1.Name = "Bin";

        s1.Marks = 11;



        Student s2 = new Student();

        s2.Name = "Ali";

        s2.Marks = 85;



        Student s3 = new Student();

        s3.Name = "Sara";

        s3.Marks = 72;



        // Create list and add students

        List<Student> students = new List<Student>();

        students.Add(s1);

        students.Add(s2);

        students.Add(s3);



        // Output

        foreach (var s in students)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }

    }

}



//Create objects DIRECTLY inside the list (clean & common)





class Student

{

    public string Name { get; set; }

    public int Marks { get; set; }

}



class Program

{

    static void Main()

    {

        // Create list with students

        var students = new List<Student>

        {

            new Student { Name = "Bin", Marks = 11 },

            new Student { Name = "Ali", Marks = 85 },

            new Student { Name = "Sara", Marks = 72 }

        };



        // Filter students WITHOUT LINQ

        var passedStudents = new List<Student>();



        foreach (var s in students)

        {

            if (s.Marks >= 70)

            {

                passedStudents.Add(s);

            }

        }



        // Output

        foreach (var s in passedStudents)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }

    }

}









using System.Linq;



class Student

{

    public string Name { get; set; }

    public int Marks { get; set; }

    public string Section { get; set; }

}



class Program

{

    static void Main()

    {

        // ===============================

        // DATA SOURCE

        // ===============================



        var students = new List<Student>

        {

            new Student { Name = "Bin",  Marks = 11, Section = "A" },

            new Student { Name = "Ali",  Marks = 85, Section = "A" },

            new Student { Name = "Sara", Marks = 72, Section = "B" },

            new Student { Name = "Aman", Marks = 85, Section = "B" },

            new Student { Name = "Zara", Marks = 40, Section = "C" },

            new Student { Name = "John", Marks = 65, Section = "C" }

        };

        // =====================================================
        // NOTE 
        // -----------------------------------------------------
        // Any LINQ query (Where, Select, OrderBy, GroupBy)
        // returns IEnumerable<T> by default.
        //
        // Using 'var' OR 'IEnumerable<T>' is the SAME.
        // =====================================================

        // ===============================

        // WHERE — METHOD SYNTAX

        // ===============================

       //IEnumerable<Student> passedStudents = students.Where(s => s.Marks >= 70);
       //same
        var passedStudents = students.Where(s => s.Marks >= 70);

        Console.WriteLine("\nPassed Students (Method Syntax):");

        foreach (var s in passedStudents)

            Console.WriteLine($"{s.Name} - {s.Marks}");


       // IEnumerable<Student> failedStudents = students.Where(s => s.Marks < 40);
       //Same
        var failedStudents = students.Where(s => s.Marks < 40);

        Console.WriteLine("\nFailed Students:");

        foreach (var s in failedStudents)

            Console.WriteLine($"{s.Name} - {s.Marks}");



        var averageStudents = students.Where(s => s.Marks >= 40 && s.Marks < 70);

        Console.WriteLine("\nAverage Students:");

        foreach (var s in averageStudents)

            Console.WriteLine($"{s.Name} - {s.Marks}");







        // ===============================

        // WHERE — QUERY (SQL) SYNTAX

        // ===============================



        var passedStudentsQuery =

            from s in students

            where s.Marks >= 70

            select s;



        Console.WriteLine("\nPassed Students (Query Syntax):");

        foreach (var s in passedStudentsQuery)

            Console.WriteLine($"{s.Name} - {s.Marks}");



        // ===============================

        // SELECT — METHOD SYNTAX

        // ===============================

       // IEnumerable<string> names = students.Select(s => s.Name);
        //Same
        var names = students.Select(s => s.Name);

        Console.WriteLine("\nOnly Names:");

        foreach (var name in names)

            Console.WriteLine(name);



        // IEnumerable<int> marks = students.Select(s => s.Marks);

        var marks = students.Select(s => s.Marks);

        Console.WriteLine("\nOnly Marks:");

        foreach (var m in marks)

            Console.WriteLine(m);



        var bonusMarks = students.Select(s => s.Marks + 5);

        Console.WriteLine("\nMarks With Bonus (+5):");

        foreach (var m in bonusMarks)

            Console.WriteLine(m);







        // ===============================

        // SELECT — QUERY (SQL) SYNTAX

        // ===============================


        // IEnumerable<int> bonusMarksQuery = from s in students select s.Marks + 5;


        var bonusMarksQuery =

            from s in students

            select s.Marks + 5;



        Console.WriteLine("\nBonus Marks (Query Syntax):");

        foreach (var m in bonusMarksQuery)

            Console.WriteLine(m);



        // ===============================

        // WHERE + SELECT — METHOD SYNTAX

        // ===============================

        //IEnumerable<string> passedNames = students.Where(s => s.Marks >= 70).Select(s => s.Name);

        var passedNames = students

            .Where(s => s.Marks >= 70)

            .Select(s => s.Name);



        Console.WriteLine("\nPassed Student Names:");

        foreach (var name in passedNames)

            Console.WriteLine(name);



        // ===============================

        // WHERE + SELECT — QUERY (SQL) SYNTAX

        // ===============================



        var passedNamesQuery =

            from s in students

            where s.Marks >= 70

            select s.Name;



        Console.WriteLine("\nPassed Student Names (Query Syntax):");

        foreach (var name in passedNamesQuery)

            Console.WriteLine(name);



        // ===============================

        // GROUP BY SECTION

        // ===============================


        // IEnumerable<IGrouping<string, Student>> groupBySection =
        //    students.GroupBy(s => s.Section);
        var groupBySection = students.GroupBy(s => s.Section);

        Console.WriteLine("\nGroup By Section:");



        foreach (var group in groupBySection)

        {

            Console.WriteLine($"Section {group.Key}");

            foreach (var s in group)

                Console.WriteLine($"   {s.Name} - {s.Marks}");

        }





        // ===============================

        // ORDER BY — METHOD SYNTAX

        // ===============================

        //IEnumerable<Student> orderByMarks =
        //  students.OrderBy(s => s.Marks);

        var orderByMarks =

            students.OrderBy(s => s.Marks);



        Console.WriteLine("\nOrder By Marks (Ascending):");

        foreach (var s in orderByMarks)

            Console.WriteLine($"{s.Name} - {s.Marks}");



        // ===============================

        // ORDER BY DESCENDING

        // ===============================



        var orderByMarksDesc =

            students.OrderByDescending(s => s.Marks);



        Console.WriteLine("\nOrder By Marks (Descending):");

        foreach (var s in orderByMarksDesc)

            Console.WriteLine($"{s.Name} - {s.Marks}");



        // ===============================

        // ORDER BY + THEN BY

        // ===============================



        var orderByMarksThenName =

            students.OrderByDescending(s => s.Marks)

                    .ThenBy(s => s.Name);



        Console.WriteLine("\nOrder By Marks DESC, Then By Name ASC:");

        foreach (var s in orderByMarksThenName)

            Console.WriteLine($"{s.Name} - {s.Marks}");



        // ===============================

        // ORDER BY + THEN BY DESCENDING

        // ===============================



        var orderBySectionThenMarksDesc =

            students.OrderBy(s => s.Section)

                    .ThenByDescending(s => s.Marks);



        Console.WriteLine("\nOrder By Section ASC, Then By Marks DESC:");

        foreach (var s in orderBySectionThenMarksDesc)

            Console.WriteLine($"{s.Name} - {s.Marks} - Section {s.Section}");







        // ===============================

        // AGGREGATE FUNCTIONS

        // MIN | MAX | COUNT | AVERAGE

        // ===============================



        // COUNT

        int totalStudents = students.Count();

        Console.WriteLine($"\nTotal Students: {totalStudents}");



        // MIN

        int minMarks = students.Min(s => s.Marks);

        Console.WriteLine($"Minimum Marks: {minMarks}");



        // MAX

        int maxMarks = students.Max(s => s.Marks);

        Console.WriteLine($"Maximum Marks: {maxMarks}");



        // AVERAGE

        double averageMarks = students.Average(s => s.Marks);

        Console.WriteLine($"Average Marks: {averageMarks}");



        // ===============================

        // AGGREGATES WITH WHERE

        // ===============================



        int passedCount = students.Count(s => s.Marks >= 70);

        Console.WriteLine($"\nPassed Students Count: {passedCount}");



        double passedAverage =

            students.Where(s => s.Marks >= 70)

                    .Average(s => s.Marks);



        Console.WriteLine($"Average Marks of Passed Students: {passedAverage}");



        // ===============================

        // AGGREGATES WITH GROUP BY

        // ===============================



        var sectionStats =

            students.GroupBy(s => s.Section);



        Console.WriteLine("\nSection-wise Statistics:");



        foreach (var group in sectionStats)

        {

            Console.WriteLine($"Section {group.Key}");

            Console.WriteLine($"   Count   : {group.Count()}");

            Console.WriteLine($"   Min     : {group.Min(s => s.Marks)}");

            Console.WriteLine($"   Max     : {group.Max(s => s.Marks)}");

            Console.WriteLine($"   Average : {group.Average(s => s.Marks)}");

        }

    }



}

