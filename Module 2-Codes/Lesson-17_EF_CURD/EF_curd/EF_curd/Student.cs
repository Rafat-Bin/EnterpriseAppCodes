namespace Module02.Lesson17.EfCoreCrudDemo
{
    public class Student
    {
        public int Id { get; set; }                 // PK
        public string Name { get; set; } = "";
        public int Age { get; set; }

        // FK + Navigation back to Course
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}