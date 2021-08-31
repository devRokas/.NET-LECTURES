using System;

namespace RestAPI.Models.ResponseModels
{
    public class CommentResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Body { get; set; }
    }
}