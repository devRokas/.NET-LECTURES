using System;

namespace Lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Student("Vardas");
            
            person.SayAbstractHello();
        }
    }

    public abstract class Person
    {
        protected readonly string _name;
        protected readonly string _surname = "Surname";

        public Person(string name)
        {
            _name = name;
        }
        
        public virtual void SayHello()
        {
            Console.WriteLine("Saying hello from abstract class");
        }

        public abstract void SayAbstractHello();

        public void SimpleSayHello()
        {
            
        }
    }

    public class Student : Person
    {
        // public override void SayHello()
        // {
        //     Console.WriteLine("hello");
        // }

        public override void SayAbstractHello()
        {
            Console.WriteLine($"Abstract hello {_surname}");
        }

        public Student(string name) : base(name)
        {
        }
    }

    public class Seniunas : Student
    {
        public Seniunas(string name) : base(name)
        {
        }

        public override void SayAbstractHello()
        {
            base.SayAbstractHello();
        }
    }
}