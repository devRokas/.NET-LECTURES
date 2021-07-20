namespace Lecture_14
{
    public abstract class Person
    {
        protected readonly string _name;
        protected readonly string _surname;

        protected Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public abstract void PrintInfo();
    }
}