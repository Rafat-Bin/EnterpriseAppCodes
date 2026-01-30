

namespace PracticeLab.Domain
{
    public class UserAccount
    {
        public string Username { get; private set; }
        public int Age { get; private set; }
        public bool IsLocked { get; private set; }

        public UserAccount(string username, int age)
        {
            ValidateUsername(username);
            ValidateAge(age);

            Username = username;
            Age = age;
            IsLocked = false;
        }

        public void LockAccount()
        {
            IsLocked = true;
        }

        public void UnlockAccount()
        {
            IsLocked = false;
        }

        public void ChangeUsername(string newUsername)
        {
            ValidateUsername(newUsername);
            Username = newUsername;
        }

        public void ChangeAge(int newAge)
        {
            ValidateAge(newAge);
            Age = newAge;
        }

        private void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException(
                    "Username cannot be null, empty, or whitespace.");
            }
        }

        private void ValidateAge(int age)
        {
            if (age < 13)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(age),
                    "User must be at least 13 years old.");
            }
        }
    }
}
