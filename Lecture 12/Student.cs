namespace Lecture_12
{
    public class Student : Person
    {
        public Student(string name, string surname) : base(name, surname)
        {
        }
        
        public override bool IsPersonEqual(Person person)
        {
            return _name == person._name && _surname == person._surname;
        }
    }
}