using System;
using System.Threading.Tasks;
using Lecture_37.Models;
using Lecture_37.Models.JsonPlaceholder.RequestModels;

namespace Lecture_37
{
    public class JsonPlaceholderService : IJsonPlaceholderService
    {
        private readonly IJsonPlaceholderClient _jsonPlaceholderClient;

        public JsonPlaceholderService(IJsonPlaceholderClient jsonPlaceholderClient)
        {
            _jsonPlaceholderClient = jsonPlaceholderClient;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _jsonPlaceholderClient.GetUser(1);

            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                DateModified = DateTime.Now
            };
        }

        public Task CreateUser(User user)
        {
            var request = new CreateUserRequestModel
            {
                Name = user.Name,
                Username = user.Username
            };

            return _jsonPlaceholderClient.CreateUser(request);
        }
    }

    public interface IJsonPlaceholderService
    {
        Task<User> GetUser(int id);

        Task CreateUser(User user);
    }
}