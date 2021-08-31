using System;

namespace RestAPI.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Body { get; set; }
    }
}