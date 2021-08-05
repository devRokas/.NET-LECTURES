using System;

namespace LearningNuget
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Address} {City} {Age} {DateOfBirth:d}";
        }
    }
}