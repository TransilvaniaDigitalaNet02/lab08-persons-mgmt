namespace PersonsManagement
{
    public class Person
    {
        public Person(
            string lastName,
            string firstName,
            DateTime dateOfBirth,
            Address address)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public string LastName { get; }

        public string FirstName { get; }

        public DateTime DateOfBirth { get; }

        public long Age
        {
            get
            {
                long yearsDiff = DateTimeCalculator.YearsDiff(DateTime.Today, DateOfBirth);
                return yearsDiff;
            }
        }

        public Address Address { get; private set; }

    }
}
