using Xunit;
using Domain;

namespace Domain.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor_ShouldSetProperties_WhenValidInput()
        {
            var person = new Person("Don", "Wel", "don@example.com");

            Assert.Equal("Don", person.FirstName);
            //Assert.Equal("Wel", person.LastName);
            //Assert.Equal("don@example.com", person.Email);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_ShouldThrow_WhenFirstNameInvalid(string firstName)
        {
            Assert.Throws<ArgumentNullException>(() =>
                new Person(firstName, "Wel", "don@example.com"));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_ShouldThrow_WhenLastNameInvalid(string lastName)
        {
            Assert.Throws<ArgumentNullException>(() =>
                new Person("Don", lastName, "don@example.com"));
        }

        [Fact]
        public void FirstName_Setter_ShouldUpdateValue()
        {
            var person = new Person("Don", "Wel", "don@example.com");

            person.FirstName = "Donna";

            Assert.Equal("Donna", person.FirstName);
        }

        [Fact]
        public void LastName_Setter_ShouldUpdateValue()
        {
            var person = new Person("Don", "Wel", "don@example.com");

            person.LastName = "Smith";

            Assert.Equal("Smith", person.LastName);
        }

        [Fact]
        public void FullName_ShouldReturn_LastCommaFirst()
        {
            var person = new Person("Don", "Wel", "don@example.com");

            Assert.Equal("Wel, Don", person.FullName);
        }
    }
}


