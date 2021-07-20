using System;

namespace Lecture_14
{
    public class Student : Person
    {
        private readonly Guid _studenId;
        
        public Student(string name, string surname) : base(name, surname)
        {
            _studenId = Guid.NewGuid();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Student: {_name} {_surname} {_studenId}");
        }

        public void PrintId()
        {
            Console.WriteLine(_studenId);
        }
    }
}