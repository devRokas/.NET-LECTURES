using System;
using System.Collections.Generic;
using System.Linq;
using RestAPI.Models;

namespace RestAPI.Persistence
{
    class CommentsRepository : ICommentsRepository
    {
        private readonly List<Comment> _comments;

        public CommentsRepository()
        {
            _comments = new List<Comment>();
        }

        public IEnumerable<Comment> GetAll()
        {
            return _comments;
        }

        public Comment Get(Guid id)
        {
            return _comments.FirstOrDefault(comment => comment.Id == id);
        }

        public void Add(Comment comment)
        {
            _comments.Add(comment);
        }

        public Comment Update(Guid id, string email, string body)
        {
            var comment = _comments.First(comment => comment.Id == id);

            comment.Email = email;
            comment.Body = body;

            return comment;
        }

        public void Delete(Guid id)
        {
            var commentToDelete = _comments.FirstOrDefault(comment => comment.Id == id);
            _comments.Remove(commentToDelete);
        }
    }
}