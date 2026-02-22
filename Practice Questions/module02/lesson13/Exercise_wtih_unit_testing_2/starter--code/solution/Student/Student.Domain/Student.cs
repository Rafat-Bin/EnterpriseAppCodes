namespace PracticeLab.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsActive { get; set; }
        public double GPA { get; set; }
        public string Major { get; set; } = "";
    }
}