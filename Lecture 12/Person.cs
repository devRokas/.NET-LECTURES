using System;

namespace Lecture_12
{
    public class Person
    {
        protected readonly string _name;
        protected readonly string _surname;

        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

       // object -> Person 
       
        public override bool Equals(object obj)
        {
            var person = (Person) obj;
        
            return _name == person._name && _surname == person._surname;
        }
        
        public virtual bool IsPersonEqual(Person person)
        {
            return _name == person._name && _surname == person._surname;
        }
    }
}