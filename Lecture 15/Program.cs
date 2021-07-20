using System;

namespace Lecture_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsDeveloper = new JavascriptDeveloper();
            var cSharpDeveloper = new CSharpDeveloper();
            
            ShowProgrammerInfo(cSharpDeveloper);
        }

        public static void ShowProgrammerInfo(IProgrammer programmer)
        {
            programmer.Code();
        }
    }

    interface IHuman
    {
        void Speak();
    }

    public class JavascriptDeveloper : IProgrammer, IHuman
    {
        public void Code()
        {
            Console.WriteLine("My favourite language is Javascript");
        }

        public void Speak()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TypeScriptDeveloper : JavascriptDeveloper
    {
        public TypeScriptDeveloper()
        {
            Code();
            Speak();
        }
    }
    
    public class CSharpDeveloper : IProgrammer, IHuman
    {
        public void Code()
        {
            Console.WriteLine("My favourite language is C#");
        }

        public void Speak()
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // static void Main(string[] args)
    // {
    //     var possitiveNumber = new PossitiveNumber();
    //
    //     // PrintInfo(possitiveNumber);
    //
    //     var evenNumber = new EvenNumber();
    //     
    //     PrintInfo(evenNumber);
    // }
    //
    // public static void PrintInfo(Number number)
    // {
    //     var numbers = number.Generate();
    //
    //     var sum = number.GetSum();
    //
    //     foreach (var n in numbers)
    //     {
    //         Console.WriteLine(n);
    //     }
    //
    //     Console.WriteLine("SUMA:" + sum);
    // }
}