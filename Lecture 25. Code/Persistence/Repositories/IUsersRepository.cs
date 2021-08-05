using System.Collections.Generic;
using Persistence.Models;
using Persistence.Models.ReadModels;

namespace Persistence.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAll();
        
        IEnumerable<UserShortInfoReadModel> GetAllUserInfo();


        void Save(User note);

        void Edit(int id, string username, string password);

        void Delete(int id);

        void DeleteAll();
    }
}