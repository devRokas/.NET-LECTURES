using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture_30
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var sw = new Stopwatch();
            // sw.Start();
            //
            F1();
            await F2();
            await F3();

            var tasks = new List<Task>
            {
                F1(),
                F2(),
                F3()
            };
            
            await Task.WhenAll(tasks);
            //
            // sw.Stop();
            //
            // var elapsed = sw.ElapsedMilliseconds;

            var result = await Add(2, 5);

            Console.WriteLine(result);
            //
            // Console.WriteLine($"elapsed: {elapsed} ms");
        }
        
        // static void F1() 
        // {
        //     Console.WriteLine("f1 called");
        //     Thread.Sleep(4000);
        // }
        //
        // static void F2() 
        // {
        //     Console.WriteLine("f2 called");
        //     Thread.Sleep(7000);
        // }
        //
        // static void F3() 
        // {
        //     Console.WriteLine("f3 called");
        //     Thread.Sleep(2000);
        // }

        // public static async Task<Bread> BakeBread()
        // {
        //     Task.Delay(4000);
        //
        //     return new Bread();
        // }

        public static async Task<int> Add(int a, int b)
        {
            // awaited http call ir gauciau data
            
            return a + b;
        }

        static async Task F1() 
        {
            await Task.Delay(4000);
            Console.WriteLine("f1 finished");
        }
        
        static async Task F2() 
        {
            await Task.Delay(7000);
            Console.WriteLine("f2 finished");
        }
        
        static async Task F3() 
        {
            await Task.Delay(2000);
            Console.WriteLine("f3 finished");
        }

    }
}