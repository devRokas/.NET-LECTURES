namespace Lecture_28
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{CustomerId} {FirstName} {LastName} {Email}";
        }
    }
}