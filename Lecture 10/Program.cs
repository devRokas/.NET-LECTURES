using System;

namespace Lecture_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person("Rokas");
            
            // person.CheckName();
            //
            // person.ChangeName("Vardas");

            var father = new Father("Tevas");
            
            father.SayHello();

            var son = new Son("Sunus", 553);
            
            son.SayName();
            
            father.SayName();
            
            // son.SayHello();
            // Console.WriteLine(son);
            //
            // var grandpa = new Grandpa();

        }
    }

    // class Person
    // {
    //     private readonly string _name = "Testas"; // field
    //     private const string Surname = "Pavarde";
    //
    //     public Person(string name)
    //     {
    //         _name = name;
    //     }
    //
    //     public void CheckName()
    //     {
    //         if (_name == "Rokas")
    //         {
    //             Console.WriteLine("Teisingas vardas");
    //         }
    //     }

        // public void ChangeName(string newName)
        // {
        //     _name = newName;
        // }
    // }
    
    // Paveldejimas - inheritance
    public class Father : Grandpa
    {
        protected readonly string _name;
        protected readonly string _surname;

        public Father()
        {
            Console.WriteLine("Father is created");
        }
        
        public Father(string name)
        {
            _name = name;
        }
        
        public Father(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        
        public void SayHello()
        {
            Console.WriteLine("Hello from Father class");
        }

        public void SayName()
        {
            Console.WriteLine(_name);
        }
    }
    
    public class Son : Father
    {
        public string BestFriendsName = "Vardas";
        private string _name = "TESTAS";
        protected int _age;

        public Son(string name, int age)
        {
            _age = age;
        }

        public new void SayName()
        {
            Console.WriteLine($"{_name} {_age}");
        }
    }

    public class Grandpa
    {
        public string Watch = "Rolex";
    }
}