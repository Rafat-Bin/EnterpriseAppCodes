

namespace Module02.Lesson17.EfCoreCrudDemo
{
    public class Course
    {
        public int Id { get; set; }                 // PK
        public string Code { get; set; } = "";      // e.g., "SDEV2301"
        public string Name { get; set; } = "";      // e.g., "Enterprise App Dev"
        public int Credits { get; set; } = 3;

        // Navigation: one-to-many
        public List<Student> Students { get; set; } = new();
    }
}