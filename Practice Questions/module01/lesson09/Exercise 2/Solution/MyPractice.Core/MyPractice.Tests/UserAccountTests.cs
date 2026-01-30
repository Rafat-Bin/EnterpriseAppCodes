
using PracticeLab.Domain;
using Xunit;

namespace PracticeLab.Tests
{
    public class UserAccountTests
    {
        [Fact]
        public void LockAccount_SetsIsLockedToTrue()
        {
            // Arrange
            var account = new UserAccount("student1", 18);

            // Act
            account.LockAccount();

            // Assert
            Assert.True(account.IsLocked);
        }

        [Fact]
        public void UnlockAccount_SetsIsLockedToFalse()
        {
            // Arrange
            var account = new UserAccount("student1", 18);
            account.LockAccount();

            // Act
            account.UnlockAccount();

            // Assert
            Assert.False(account.IsLocked);
        }

        [Fact]
        public void ChangeUsername_ValidValue_UpdatesUsername()
        {
            // Arrange
            var account = new UserAccount("oldName", 20);

            // Act
            account.ChangeUsername("newName");

            // Assert
            Assert.Equal("newName", account.Username);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_InvalidUsername_ThrowsArgumentException(string invalidUsername)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new UserAccount(invalidUsername, 18));
        }

        [Theory]
        [InlineData(12)]
        [InlineData(0)]
        [InlineData(-5)]
        public void ChangeAge_InvalidAge_ThrowsArgumentOutOfRangeException(int invalidAge)
        {
            // Arrange
            var account = new UserAccount("student1", 18);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                account.ChangeAge(invalidAge));
        }
    }
}
