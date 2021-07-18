using System;

namespace Lecture_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Rokas", "Dam");
            var person2 = new Person("Rokas", "Dam");

            var personObj = (object) person;
            var personObj2 = (object) person2;
            
            var isEqual = personObj.Equals(personObj2);
            
            if (isEqual)
            {
                Console.WriteLine("Lygus");
            }
            else
            {
                Console.WriteLine("Nelygus");
            }

            // var a = 2;
            // var b = 3;
            //
            // var isPrimitiveEqual = a.Equals(b);
            //
            // if (isPrimitiveEqual)
            // {
            //     Console.WriteLine("Lygus");
            // }
            // else
            // {
            //     Console.WriteLine("Nelygus");
            // }
        }
    }
}