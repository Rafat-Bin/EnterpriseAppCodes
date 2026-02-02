namespace Domain
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(FirstName));

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(LastName));

                _lastName = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                // Email rules are minimal on purpose
                _email = value;
            }
        }

        public string FullName
        {
            get { return _lastName + ", " + _firstName; }
        }
    }
}