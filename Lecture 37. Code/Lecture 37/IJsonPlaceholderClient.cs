using System.Collections.Generic;
using System.Threading.Tasks;
using Lecture_37.Models;
using Lecture_37.Models.JsonPlaceholder.RequestModels;
using Lecture_37.Models.JsonPlaceholder.ResponseModels;

namespace Lecture_37
{
    public interface IJsonPlaceholderClient
    {
        Task<IEnumerable<PostResponseModel>> GetPosts();

        Task<PostResponseModel> GetPost(int id);

        Task<IEnumerable<UserResponseModel>> GetUsers();

        Task<UserResponseModel> GetUser(int id);

        Task<IEnumerable<TodoResponseModel>> GetTodoItems(int userId);
        
        Task<IEnumerable<TodoResponseModel>> GetTodosByStatus(int userId, bool isCompleted);

        Task CreateUser(CreateUserRequestModel request);
    }
}