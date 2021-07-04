
using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var i = 2;
            // i += 3;
            // Console.WriteLine(i += 2);
            // Console.WriteLine(i -= 2);
            // Console.WriteLine(i *= 2);
            // Console.WriteLine(i /= 2);
            // Console.WriteLine(i %= 2);

            // Console.WriteLine(2 == 3);
            // Console.WriteLine(2 != 3);
            // Console.WriteLine(2 > 3);
            // Console.WriteLine(2 < 3);
            // Console.WriteLine(3 <= 3);
            // Console.WriteLine(3 >= 3);
            //
            // Console.WriteLine(2 == 3 && 2 == 2);
            // Console.WriteLine(2 == 3 || 2 == 2);
            // Console.WriteLine(!true);

            // Console.Write("Enter first number: ");
            // var firstNumber = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter second number: ");
            // var secondNumber = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine($"Addition: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            // Console.WriteLine($"Subtraction: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");

            // int a = 5;
            // double dbl = a;

            // long a = 17;
            // int b = (int) a;

            // Console.Write("Enter your age: ");
            // var age = Convert.ToInt32(Console.ReadLine());
            
            // if (age == 18)
            // {
            //     Console.WriteLine("Congrats!");
            // } else if (age == 21)
            // {
            //     Console.WriteLine("Congrats 2!");
            // }
            // else
            // {
            //     Console.WriteLine("Too bad");
            // }
            
            // var isLegalAge = age >= 18 ? "Legal" : "Illegal";
            //
            // Console.WriteLine(isLegalAge);

            // Console.Write("Day number: ");
            // var dayNumber = Convert.ToInt32(Console.ReadLine());
            //
            // switch (dayNumber)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break;
            //     default:
            //         Console.WriteLine("Unknown");
            //         break;
            // }
            //
            //
            // int i = 0;
            // while (i < 5) 
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            
            // for (statement 1; statement 2; statement 3) 
            // {
            //     // code block to be executed
            // }
            
            // for (var i = 0; i < 5; i++) 
            // {
            //     Console.WriteLine(i);
            // }

            var cars = new [] { "BMW", "AUDI" };

            var testas = cars[0];
            
            cars[0] = "MAZDA";

            var testas2 = cars[0];

            Console.WriteLine(testas);
            Console.WriteLine(testas2);
            Console.WriteLine();
            Array.ForEach(cars, Console.Write);

            for (var i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            
            // 2 + 2 
        }
    }
}