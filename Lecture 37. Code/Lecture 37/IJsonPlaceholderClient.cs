using System.Collections.Generic;
using System.Threading.Tasks;
using Lecture_37.Models.JsonPlaceholder.ResponseModels;

namespace Lecture_37
{
    public interface IJsonPlaceholderClient
    {
        Task<IEnumerable<PostResponseModel>> GetPosts();

        Task<PostResponseModel> GetPost(int id);
    }
}