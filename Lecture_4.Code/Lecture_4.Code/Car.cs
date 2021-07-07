namespace Lecture_4.Code
{
    class Car
    {
        public string Name;
        public int Age = 10;
        

        public Car()
        {
        }

        public Car(string name)
        {
            Name = name;
        }
        
        public Car(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}