using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLab.Domain
{
    public class StudentQueryService
    {
        // US1 – Filter Active Students
        public IEnumerable<Student> GetActiveStudents(IEnumerable<Student> students)
        {
            if (students == null)
                throw new ArgumentNullException(nameof(students));

            return students.Where(s => s.IsActive);
        }

        // US2 – Sort by GPA Descending, then Name Ascending
        public IEnumerable<Student> SortByGpaDescending(IEnumerable<Student> students)
        {
            if (students == null)
                throw new ArgumentNullException(nameof(students));

            return students
                .OrderByDescending(s => s.GPA)
                .ThenBy(s => s.Name);
        }

        // US3 – Projection for Honor Roll
        public IEnumerable<(string Name, double GPA)> ProjectForHonorRoll(IEnumerable<Student> students)
        {
            if (students == null)
                throw new ArgumentNullException(nameof(students));

            return students.Select(s => (s.Name, s.GPA));
        }

        // BONUS – Group and Count by Major
        public IEnumerable<(string Major, int Count)> GroupAndCountByMajor(IEnumerable<Student> students)
        {
            if (students == null)
                throw new ArgumentNullException(nameof(students));

            return students
                .GroupBy(s => s.Major)
                .Select(g => (Major: g.Key, Count: g.Count()));
        }
    }
}