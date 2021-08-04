using System.Collections.Generic;
using Persistence.Models;

namespace Persistence.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAll();

        void Save(User note);

        void Edit(int id, string username, string password);

        void Delete(int id);

        void DeleteAll();
    }
}