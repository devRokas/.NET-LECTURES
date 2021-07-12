using System;

namespace Lecture9
{
    class Book
    {
        private string _title; // field
        private string _title2;
        
        public string Title // properties
        {
            get => _title;
            set
            {
                _title = value;
                Console.WriteLine(value);
            }
        }

        // private string _title;
        //
        // public string Title
        // {
        //     get => _title;
        //     set => _title = value;
        // }

        public string Author { get; set; }
    }
}