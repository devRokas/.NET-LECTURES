using System;

namespace Persistence.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Text} {DateCreated}";
        }
    }
}