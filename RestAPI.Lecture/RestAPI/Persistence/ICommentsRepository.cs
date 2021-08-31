using System;
using System.Collections.Generic;
using RestAPI.Models;

namespace RestAPI.Persistence
{
    public interface ICommentsRepository
    {
        IEnumerable<Comment> GetAll();
        
        Comment Get(Guid id);

        void Add(Comment comment);

        Comment Update(Guid id, string email, string body);

        void Delete(Guid id);
    }
}