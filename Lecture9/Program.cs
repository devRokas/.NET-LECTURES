using System;

namespace Lecture9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation
            const string name = "Rokas";
            var person = new Person("Rokas", "Dam", 55);
            
            person.SetName("Vardas");
            // person.GetName();
            
            // API - application programming interface

            // Console.WriteLine(person.GetName());

            var book = new Book();

            // book.Author = "Vardas";

            book.Title = "Pavadinimas";

            // Console.WriteLine(book.Author);
        }
    }
}