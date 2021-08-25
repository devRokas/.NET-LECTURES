using System;

namespace Lecture_37.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public DateTime DateModified { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Username} {DateModified:d}";
        }
    }
}