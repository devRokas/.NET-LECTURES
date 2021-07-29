using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_21
{
    // class Program
    // {
    //     // delegate <return type> <delegate-name> <parameter list>
    //     public delegate int MyDelegate(string text); 
    //         
    //     static void Main(string[] args)
    //     {
    //         MyDelegate myDelegate = GetTextLength;
    //
    //         myDelegate += GetTextLengthHalf;
    //
    //         Console.WriteLine(myDelegate("Vardas"));
    //     }
    //
    //     
    //     public static int GetTextLength(string text)
    //     {
    //         return text.Length;
    //     }
    //
    //     public static int GetTextLengthHalf(string text)
    //     {
    //         return text.Length / 2;
    //     }
    // }

    // namespace DelegateAppl
    // {
    //     class TestDelegate
    //     {
    //         delegate int NumberChanger(int n);
    //
    //         public delegate bool FilterDelegate(string text);
    //
    //         static int num = 10;
    //
    //         public static int AddNum(int p)
    //         {
    //             num += p;
    //             return num;
    //         }
    //
    //         public static int MultNum(int q)
    //         {
    //             num *= q;
    //             return num;
    //         }
    //
    //         public static int getNum()
    //         {
    //             return num;
    //         }
    //
    //         static void Main(string[] args)
    //         {
    //             //create delegate instances
    //             NumberChanger myDelegate = (p) =>
    //             {
    //                 num += p;
    //                 
    //                 return num;
    //             };
    //
    //
    //             var list = new List<string>();
    //
    //
    //             list.Where(Filter);
    //             
    //             myDelegate += MultNum;
    //
    //             //calling the methods using the delegate objects
    //             myDelegate(5);
    //             Console.WriteLine("Value of Num: {0}", getNum());
    //             Console.ReadKey();
    //             
    //             
    //             Where((text) => text.Length < 5);
    //         }
    //
    //         public static bool Filter(string text)
    //         {
    //             return text.Length > 2;
    //         }
    //         
    //         public static void Where(FilterDelegate filter)
    //         {
    //             filter("");
    //         }
    //     }
    // }

    // // public static class Program
    // // {
    // //     public delegate bool NumbersFilter(int number);
    // //
    // //     public static Func<int, int> Numbers;
    // //     
    // //     
    // //     public static void Main(string[] args)
    // //     {
    // //         var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
    // //
    // //         NumbersFilter filterDelegate = FilterNumber;
    // //
    // //         var filteredNumbersOur = numbers.CustomWhere((num) => num < 2);
    // //         var filterNumbersLINQ = numbers.Where((num) => num < 2);
    // //
    // //         foreach (var filteredNumber in filterNumbersLINQ)
    // //         {
    // //             Console.WriteLine(filteredNumber);
    // //         }
    // //     }
    // //
    // //     public static List<int> CustomWhere(this List<int> numbers, NumbersFilter filter)
    // //     {
    // //         var filteredNumbers = new List<int>();
    // //
    // //         foreach (var number in numbers)
    // //         {
    // //             var isOkay = filter(number);
    // //             if (isOkay)
    // //             {
    // //                 filteredNumbers.Add(number);
    // //             }
    // //         }
    // //
    // //         return filteredNumbers;
    // //     }
    // //
    // //     public static bool FilterNumber(int number)
    // //     {
    // //         return number < 4 && number % 2 == 0;
    // //     }
    // }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public class Program
    {
        // public delegate void PrintDelegate();
        // public static Action PrintDelegate;

        public static void Main(string[] args)
        {
            // string vardas = "Vardas";
            // Action<string, int> printTextDelegate = PrintText;
            //
            // Action printDelegate = () => { Console.WriteLine("HEllo"); };
            //
            // printDelegate += () => { Console.WriteLine(" World"); };
            //
            // printDelegate();
            //
            // // Action<string> printTextDelegate = (text) => { Console.WriteLine(text); };
            //
            // printTextDelegate += (text, num) =>
            // {
            //     Console.WriteLine(text);
            //     Console.WriteLine(text);
            // };
            //
            // printTextDelegate("Vardas", 23213);
            //
            // Func<string, int, bool> funcDelegate = (text, num) =>
            // {
            //     return text.Length < num;
            // };
            //
            // funcDelegate += (text, num) =>
            // {
            //     return 2 < 6;
            // };
            //
            // Console.WriteLine(funcDelegate("Vardas", 12));

            Func<int, int, int, int> delegatas;
            
            Predicate<int> ourPredicate = (num) =>
            {
                return true;
            };
        }

        public List<int> FilterNumber(List<int> numbers, Predicate<int> filter)
        {
            var filteredNumbers = new List<int>();
            
            foreach (var number in numbers)
            {
                var isOkay = filter(number);
                if (isOkay)
                {
                    filteredNumbers.Add(number);
                }
            }
            
            return filteredNumbers;
        }
        

        public static void PrintText(string text, int numb)
        {
            Console.WriteLine(text);
        }
    }
}