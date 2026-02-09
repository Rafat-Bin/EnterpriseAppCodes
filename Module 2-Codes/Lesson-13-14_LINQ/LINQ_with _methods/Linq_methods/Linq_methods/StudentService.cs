
using System.Linq;

namespace Linq_methods
{


    class StudentService
    {
        // ===============================
        // WHERE
        // ===============================
        public IEnumerable<Student> GetPassedStudents(IEnumerable<Student> students)
        {
            return students.Where(s => s.Marks >= 70);
        }

        public IEnumerable<Student> GetFailedStudents(IEnumerable<Student> students)
        {
            return students.Where(s => s.Marks < 40);
        }

        // ===============================
        // SELECT (PROJECTION)
        // ===============================
        public IEnumerable<string> GetStudentNames(IEnumerable<Student> students)
        {
            return students.Select(s => s.Name);
        }

        public IEnumerable<int> GetBonusMarks(IEnumerable<Student> students)
        {
            return students.Select(s => s.Marks + 5);
        }

        // ===============================
        // WHERE + SELECT
        // ===============================
        public IEnumerable<string> GetPassedStudentNames(IEnumerable<Student> students)
        {
            return students
                .Where(s => s.Marks >= 70)
                .Select(s => s.Name);
        }

        // ===============================
        // GROUP BY
        // ===============================
        public IEnumerable<IGrouping<string, Student>> GroupBySection(IEnumerable<Student> students)
        {
            return students.GroupBy(s => s.Section);
        }

        // ===============================
        // ORDER BY
        // ===============================
        public IEnumerable<Student> OrderByMarks(IEnumerable<Student> students)
        {
            return students.OrderBy(s => s.Marks);
        }

        // ===============================
        // AGGREGATES (NOT IEnumerable)
        // ===============================
        public int GetTotalStudents(IEnumerable<Student> students)
        {
            return students.Count();
        }

        public double GetAverageMarks(IEnumerable<Student> students)
        {
            return students.Average(s => s.Marks);
        }
    }
}
