using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Lecture_19
{
    static class Program
    {
        static void Main(string[] args)
        {
        //     int a = 2;
        //     int b = 6;
        //     
        //     a.Print();
        //     
        //     var result = a.Add(b);
        //     
        //     Console.WriteLine(result);
        //
        //     var product = new Product(1, 2)
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Pienas",
        //         Type = "Pieno produktai",
        //         Price = 14
        //     };
        //     
        //     product.Print();
        //     
        //     product.ChangeName("Varske");
        //     
        //     product.Print();
        //     
        //     ProductExtensions.Print(product);
        //     
        //     ProductExtensions.Hello();

        // Console.Write("Iveskite skaiciu a: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Iveskite skaiciu b: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        //
        // a.IsGreater(b);
        
            // LINQ
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            
            var evenNumbers = numbers.Where((num) => num % 2 == 0);

            // foreach (var evenNumber in evenNumbers)
            // {
            //     Console.WriteLine(evenNumber);
            // }
            
            var studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
            };

            // var agedStudents = studentList.Select((student) => new Student
            // {
            //     StudentID = student.StudentID,
            //     StudentName = student.StudentName,
            //     Age = student.Age * 2
            // });
            //
            // var agedStudents = new List<Student>();
            //
            // foreach (var student in studentList)
            // {
            //     var agedStudent = new Student
            //     {
            //         StudentID = student.StudentID,
            //         StudentName = student.StudentName,
            //         Age = student.Age * 2
            //     };
            //
            //     agedStudents.Add(agedStudent);
            // }
            
            // var agedStudents2 = studentList.Select((student) =>
            // {
            //     return student.Age *= 2;
            // });

            // foreach (var student in studentList)
            // {
            //     Console.WriteLine(student.Age);
            // }

            // var student3 = studentList.FirstOrDefault(student => student.StudentID == 3);
            //
            // Console.WriteLine(student3.StudentName);
            //
            // var isOldEnough = studentList.All(student => student.Age >= 18);
            //
            // Console.WriteLine(isOldEnough ? "Tinkamas amzius": "Per jaunas");
            //
            // Console.WriteLine(studentList.Any(student => student.Age == 35));
            
            var agedStudents = studentList
                .Select((student) => new Student
            {
                StudentID = student.StudentID,
                StudentName = student.StudentName,
                Age = student.Age * 2
            }).Where(student => student.Age > 20);
            
            foreach (var student in agedStudents)
            {
                Console.WriteLine($"{student.StudentID} {student.StudentName} {student.Age}");
            }
        }

        class Student
        {
            public int StudentID { get; set; }

            public string StudentName { get; set; }

            public int Age { get; set; }
        }
    }
}