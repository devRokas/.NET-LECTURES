using System;

namespace Lecture_19
{
    public static class IntegerExtensions
    {
        public static void Print(this int number)
        {
            Console.WriteLine(number);
        }
        
        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static void IsGreater(this int a, int b)
        {
            if (b > a)
            {
                Console.WriteLine("Didesnis");
            }
            else
            {
                Console.WriteLine("Nedidesnis");
            }
        }
    }
}