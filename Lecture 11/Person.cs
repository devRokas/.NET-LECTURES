using System;

namespace Lecture_11
{
    public class Person
    {
        protected string _name;
        protected readonly string _surname;

        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetSurname()
        {
            return _surname;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Person: {_name} {_surname}");
        }
    }
}