using System;
using System.Runtime.InteropServices;

namespace Lecture_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // var student = new Student("Vardas", "Pavarde");

            // upcasting
            // Person rokas = (Person) student;
            //
            // rokas.PrintInfo();
            //
            // student.ChangeName("Naujas vardas");
            //
            // rokas.PrintInfo();
            // student.PrintInfo();
            
            // Downcasting
            // var velStudentas = (Student) rokas;


            // Pointer - dsflndlsfknl-122-dsfsflkn
            // var studentas = new Student("Rokas", "Dam");
            //
            // var rokas = studentas;
            //
            // studentas.PrintInfo();
            // studentas.ChangeName("Naujas vardas");
            //
            // rokas.PrintInfo();

            
            
            
            // int a = 2;
            //
            // int b = a;
            //
            // a = 3;
            //
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            //

            // String name = "vardas";
            // String pavarde = name;
            //
            // name = "Rokas";
            //
            // Console.WriteLine(name);
            // Console.WriteLine(pavarde);

            var romas = new Student("Romas", "Dam");
            
            romas.PrintInfo();
            
            ChangeName(romas);
            
            romas.PrintInfo();

            
            
            var a = 2;
            
            var b = Add2(a);

            Console.WriteLine(a);
            Console.WriteLine(b);


            // velStudentas.PrintStudentInfo();


            // var olegas = new Person("Olegas", "Pavarde");
            //
            // olegas.PrintInfo();
            //
            // var studentasOlegas = olegas as Student;
            //
            // studentasOlegas.PrintInfo();

            // Object -> Person -> Student


            // int a = 5;
            // var b = (double) a;

            // student.PrintInfo();
            // var info = student.ToString();

            // Person person = new Student("Vardenis", "Pavardenis", 12);

            // Console.WriteLine(student.ToString());
        }

        public static void ChangeName(Student student)
        {
            student.ChangeName("Rokas");
        }

        public static int Add2(int a)
        {
            a += 2;

            return a;
        }
    }
}