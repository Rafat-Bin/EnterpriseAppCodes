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







//Apply LINQ Where() to Student objects



using System.Linq; //mandatory



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







        //----------Where--------



        // LINQ: filter students who passed

        var passedStudents = students.Where(s => s.Marks >= 70);



        // Output

        foreach (var s in passedStudents)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);







        }



        //same thing with (query syntax) (SQL-like Structure)

        var passedStudents =

            from s in students

            where s.Mark >= 70

            select s;

        foreach (var name in passedStudents)



        {



            Console.WriteLine(name);



        }



        //Students who FAILED

        var failedStudents = students.Where(s => s.Marks < 40);



        foreach (var s in failedStudents)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }



        //Students with marks BETWEEN two values

        var averageStudents = students.Where(s => s.Marks >= 40 && s.Marks < 70);



        foreach (var s in averageStudents)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }





        //Students whose name starts with a letter

        var sNames = students.Where(s => s.Name.StartsWith("S"));



        foreach (var s in sNames)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }





        //Students whose name length is more than 3

        var longNames = students.Where(s => s.Name.Length > 3);



        foreach (var s in longNames)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }





        //Combine string + number conditions

        var specialStudents = students.Where(s => s.Marks > 70 && s.Name.Contains("a"));



        foreach (var s in specialStudents)

        {

            Console.WriteLine(s.Name + " - " + s.Marks);

        }









        // --------------SELECT-----------



        //Select ONE property

        var names = students.Select(s => s.Name);



        foreach (string name in names)

        {

            Console.WriteLine(name);

        }



        var marks = students.Select(s => s.Marks);



        foreach (var m in marks)

        {

            Console.WriteLine(m);

        }





        //Select with CALCULATION

        var bonusMarks = students.Select(s => s.Marks + 5);



        foreach (var m in bonusMarks)

        {

            Console.WriteLine(m);

        }



        //same thing with (query syntax) (SQL-like Structure)

        var bonusMarks =

            from s in students

            select s.Marks + 5;



        //Select formatted text

        var result = students.Select(s => s.Name + " scored " + s.Marks);



        foreach (var r in result)

        {

            Console.WriteLine(r);

        }



        //Where + Select

        var passedNames = students.Where(s => s.Marks >= 70).Select(s => s.Name);



        foreach (var name in passedNames)

        {

            Console.WriteLine(name);

        }

        // Where + Select (query syntax)

        var passedNames =

            from s in students

            where s.Marks >= 70

            select s.Name;



        foreach (var name in passedNames)

        {

            Console.WriteLine(name);

        }



    }