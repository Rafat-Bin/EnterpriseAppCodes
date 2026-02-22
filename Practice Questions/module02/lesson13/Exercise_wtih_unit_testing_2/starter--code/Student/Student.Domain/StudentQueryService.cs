using System;
using System.Collections.Generic;

namespace PracticeLab.Domain
{
    public class StudentQueryService
    {
        public IEnumerable<Student> GetActiveStudents(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> SortByGpaDescending(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<(string Name, double GPA)> ProjectForHonorRoll(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

    
    }
}