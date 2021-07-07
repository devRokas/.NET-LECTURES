using System;

namespace Lecture_4.Code
{
    public class Person
    {
        public static string Name;
        public string Surname;
        public int Age;

        public static int PersonCount;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            
            PersonCount++;
        }

        public Person(string name)
        {
            PersonCount++;
        }

        public static void HelloWorld()
        {
            Name = "";
            Console.WriteLine("Hello world!");
        }
    }
}