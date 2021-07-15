using System;

namespace Lecture_11
{
    public class Student : Person
    {
        private readonly int _studentId;

        // public Student(string name, string surname) : base(name, surname)
        // {
        // }
        
        public Student(string name, string surname) : base(name, surname)
        {
            // _studentId = studentId;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        public void ChangeName(string newName)
        {
            _name = newName;
        }

        public void SayHello()
        {
            Console.WriteLine($"{base.GetName()} says hello");
        }

        public string PrintStudentInfo()
        {
            return $"Student: {_name} {_surname} {_studentId}";
        }

        public override string ToString()
        {
            return $"Student: {_name} {_surname} {_studentId}";
        }
    }
}