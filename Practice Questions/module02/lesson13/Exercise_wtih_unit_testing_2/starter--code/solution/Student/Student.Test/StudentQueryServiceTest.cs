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
            // Arrange
            var students = Seed();

            // Act
            var result = _service.GetActiveStudents(students).ToList();

            // Assert
            Assert.All(result, s => Assert.True(s.IsActive));
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void SortByGpaDescending_SortsByGpaThenName()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.SortByGpaDescending(students).ToList();

            // Assert
            Assert.Equal("Alice", result[0].Name); // GPA 3.9, Name A
            Assert.Equal("Carol", result[1].Name); // GPA 3.9, Name C
            Assert.Equal("Dan", result[2].Name);   // GPA 3.2
            Assert.Equal("Bob", result[3].Name);   // GPA 2.5
        }

        [Fact]
        public void ProjectForHonorRoll_ReturnsNameAndGpaPairs()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.ProjectForHonorRoll(students).ToList();

            // Assert
            Assert.Equal(students.Count, result.Count);
            Assert.Equal("Alice", result[0].Name);
            Assert.Equal(3.9, result[0].GPA);
        }

        [Fact]
        public void GetActiveStudents_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _service.GetActiveStudents(students!));
        }

        [Fact]
        public void SortByGpaDescending_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _service.SortByGpaDescending(students!));
        }

        [Fact]
        public void ProjectForHonorRoll_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _service.ProjectForHonorRoll(students!));
        }

        // BONUS
        [Fact]
        public void GroupAndCountByMajor_ReturnsCountsPerMajor()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.GroupAndCountByMajor(students).ToList();

            // Assert
            Assert.Contains(result, r => r.Major == "CS" && r.Count == 2);
            Assert.Contains(result, r => r.Major == "Math" && r.Count == 1);
            Assert.Contains(result, r => r.Major == "Physics" && r.Count == 1);
        }
    }
}