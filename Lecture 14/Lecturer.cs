using System;

namespace Lecture_14
{
    public class Lecturer : Person
    {
        private readonly int _age;

        public Lecturer(int age, string name, string surname) : base(name, surname)
        {
            _age = age;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Lecturer: {_name} {_surname} {_age}");
        }
    }
}