using System;
using System.Text.Json.Serialization;
using Lecture_4.Code.Classes;

namespace Lecture_4.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // var car1Name = "BMW";
            // var car1Age = 10;
            //
            // var car2Name = "MAZDA";
            // var car2Age = 15;

            // string name = "";
            // int skc = 1;
            //
            // var car1 = new Car();
            //
            // car1.Name = "BWM";
            // car1.Age = 10;
            
            // var person1 = new Person();
            
            // Console.WriteLine(factorial_Recursion(5));
            
            
            var car1 = new Car("BMW", 12);
            var car2 = new Car("MAZDA");
            var car3 = new Car();
            //
            // var person = new Person();
            //
            // Person[] a =
            // {
            //     new Person()
            // };
            //
            // Console.WriteLine(Calculator.Add(2, 2));
            //
            // var cars = new Car[]
            // {
            //     car1, car2, car3
            // };
            //
            // foreach (var car in cars)
            // {
            //     Console.WriteLine($"{car.Name} {car.Age}");
            // }

            var person = new Person("Jonas", "Jonas", 342);
            var person1 = new Person("Jonas", "Jonas", 342);
            var person2 = new Person("Jonas", "Jonas", 342);
            var person3 = new Person("Jonas");
            //
            // Person.HelloWorld();

            // var result = Calculator.Add(5, 7);

            Console.WriteLine(Person.PersonCount);

        }
        
        // public static double factorial_Recursion(int number)
        // {
        //     if (number == 1)
        //     {
        //         return 1;
        //     }
        //
        //     var result = factorial_Recursion(number - 1);
        //     
        //     return number * result;
        // }
    }
}