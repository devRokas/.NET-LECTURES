using System;
using System.Collections.Generic;

namespace LearningNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Generate(10);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public static IEnumerable<Person> Generate(int count)
        {
            var people = new List<Person>();

            for (var i = 0; i < count; i++)
            {
                people.Add(new Person
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Address = Faker.Address.StreetAddress(),
                    City = Faker.Address.City(),
                    Age = Faker.RandomNumber.Next(1, 100),
                    DateOfBirth = Faker.Identification.DateOfBirth()
                });
            }

            return people;
        }
    }
}