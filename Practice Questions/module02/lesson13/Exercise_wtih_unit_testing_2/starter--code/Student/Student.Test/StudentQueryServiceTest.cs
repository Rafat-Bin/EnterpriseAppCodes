using PracticeLab.Domain;
using Xunit;

namespace PracticeLab.Tests
{
    public class StudentQueryServiceTests
    {
        private static List<Student> Seed() => new()
        {
            new() { Id=1, Name="Alice", IsActive=true,  GPA=3.9, Major="CS" },
            new() { Id=2, Name="Bob",   IsActive=false, GPA=2.5, Major="Math" },
            new() { Id=3, Name="Carol", IsActive=true,  GPA=3.9, Major="CS" },
            new() { Id=4, Name="Dan",   IsActive=true,  GPA=3.2, Major="Physics" }
        };

        private readonly StudentQueryService _service = new();

        [Fact]
        public void GetActiveStudents_ReturnsOnlyActiveStudents()
        {
            var students = Seed();

            var result = _service.GetActiveStudents(students);

            // TODO: Assert only active students returned
        }

        [Fact]
        public void SortByGpaDescending_SortsByGpaThenName()
        {
            var students = Seed();

            var result = _service.SortByGpaDescending(students);

            // TODO: Assert order: Alice, Carol, Dan, Bob
        }

        [Fact]
        public void ProjectForHonorRoll_ReturnsNameAndGpaPairs()
        {
            var students = Seed();

            var result = _service.ProjectForHonorRoll(students);

            // TODO: Assert projection shape and values
        }

        [Fact]
        public void GetActiveStudents_WhenNull_ThrowsArgumentNullException()
        {
            IEnumerable<Student>? students = null;

            // TODO: Assert exception
        }
    }
}