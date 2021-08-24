using System.Threading.Tasks;
using Lecture_37.Models.Github.ResponseModels;

namespace Lecture_37
{
    public interface IGithubClient
    {
        Task<UserResponseModel> GetUser(string username);
    }
}