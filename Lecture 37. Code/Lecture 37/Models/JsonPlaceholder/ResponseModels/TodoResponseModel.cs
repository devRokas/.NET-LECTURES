using System;

namespace Lecture_37.Models.JsonPlaceholder.ResponseModels
{
    public class TodoResponseModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{Id} {UserId} {Title} {Completed}";
        }
    }
}