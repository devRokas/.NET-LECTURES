using System;

namespace Lecture9
{
    class Person
    {
        private string Name;
        private string Surname;
        private int Age;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        private string GetName()
        {
            return Name;
        }

        private void SayName(string name)
        {
            Console.WriteLine(name);
        }
    }
}