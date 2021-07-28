using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // var words = new List<string>
            // {
            //     "delegates",
            //     "operators",
            //     "parameter",
            //     "class",
            //     "true",
            //     "bool"
            // };
            //
            // var shortWords = words.Where(word => word.Length < 5);
            //
            // var wordWithId = words.Select(word => $"{word} {Guid.NewGuid()}");
            //
            // var finalWords = words
            //     .Where(word => word.Length < 5)
            //     .Select(word => $"{word} {Guid.NewGuid()}");
            //
            // foreach (var word in finalWords)
            // {
            //     Console.WriteLine(word);
            // }


            // var dictionary = new Dictionary<string, int>();
            //
            // dictionary.Add("Vardas", 100);
            // dictionary.Add("Zmogus", 340);
            //
            // var vardas = dictionary["Vardas"];
            // var zmogus = dictionary["Zmogus"];
            //
            // Console.WriteLine(vardas);
            // Console.WriteLine(zmogus);
            //
            // var keys = dictionary.Keys;
            //
            // foreach (var key in keys)
            // {
            //     Console.WriteLine(key);
            // }

            // var dictionary = new Dictionary<Guid, string>();
            //
            // dictionary.Add(Guid.NewGuid(), "User1");
            //
            // var person = new Person();
            //
            // person.Name = "Rokas";
            

            // var intDataStore = new DataStore<int>();
            // var stringDataStore = new DataStore<string>();

            // intDataStore.Data = 5532324;
            // stringDataStore.Data = "2342342";

            // var customDictionary = new CustomDictionary<int, string, bool>();
            //
            // customDictionary.Key = 53465;
            // customDictionary.Value = "65465";
            //
            // Console.WriteLine(customDictionary.Value);
            // Console.WriteLine(customDictionary.Key);


            var list = new List<string>();
            
            var customList = new CustomList<string>();
            
            customList.Add("Operator");
            customList.Add("boolean");
            customList.Add("Vardas");
            customList.Add("Zodis");
            customList.Add("Dar vienas zodis");
            
            for (int i = 0; i < customList.Length; i++)
            {
                Console.WriteLine(customList.Get(i));
            }








        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //
        // class Printer<T> where T : class, new()
        // {
        //     public T Data { get; set; }
        //     
        //     public void Print<T>(T tekstas)
        //     {
        //         Console.WriteLine(tekstas);
        //     }
        // }
        //
    }
    
    
}