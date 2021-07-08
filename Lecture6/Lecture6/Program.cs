using System;
using System.Collections;
using System.Collections.Generic;

namespace Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new int[] { };
            //
            // var items = new ArrayList();
            // var car = new Car();
            //
            // items.Add("Name"); // index 0
            // items.Add(246546); // index 1
            // items.Add(car); // index 2
            //
            // foreach (var item in items)
            // {
            //     Console.WriteLine(item);
            // }
            
            // var numbers = new int[] { 1, 2, 3};

            // numbers[3] = 4;
            
            var names = new List<string>();
            //
            // names.Add("Name"); // index 0 
            // names.Add("Name2"); // index 1
            // names.Add("Name3"); // index 2
            //
            // names.Insert(0, "NewName");

            // var thirdItem = names[1];

            // names.Remove("Name");
            // names.RemoveAt(0);
            
            // names.RemoveAt(names.Count - 1);
            //
            // foreach (var name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // var isSuccessful = Enum.TryParse(typeof(WeekDays), "1", true, out var result);
            //
            // Console.WriteLine(Enum.GetName(typeof(WeekDays), "1"));

            var car = new Car();

            // if (car.WeekDay == WeekDays.Monday)
            // {
            //     Console.WriteLine("Tipas Monday");
            // }

            var weekDayInput = Console.ReadLine();
            var isSuccessful = Enum.TryParse(typeof(WeekDays), weekDayInput, true, out var weekDay);

            Console.WriteLine(weekDay);
            
            
            // 1. Suktis kairen
            // 2. Suktis desinen
            // 3. Info
            
        }
    }


    class Car
    {
        public string Monday = "Monday";
        public string Name = "AUTO";

        public void Test()
        {
            var user = new User
            {
                UserType = UserTypes.Admin,
                UserName = null,
                Id = default
            };

        }
    }
    
    
    
    // class ArrayList
    // {
    //     public object[] Items;
    //     public int Index = 0;
    //
    //     public ArrayList()
    //     {
    //         Items = new object[int.MaxValue];
    //     }
    //
    //     public void Add(object item)
    //     {
    //         Items[Index] = item;
    //         Index++;
    //     }
    // }
    //
}