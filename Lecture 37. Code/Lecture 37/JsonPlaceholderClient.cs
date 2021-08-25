using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Lecture_37.Models.JsonPlaceholder.RequestModels;
using Lecture_37.Models.JsonPlaceholder.ResponseModels;

namespace Lecture_37
{
    class JsonPlaceholderClient : IJsonPlaceholderClient
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceholderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<PostResponseModel>> GetPosts()
        {
            const string url = "/posts";

            return _httpClient.GetFromJsonAsync<IEnumerable<PostResponseModel>>(url);
        }

        public async Task<PostResponseModel> GetPost(int id)
        {
            var url = $"/posts?id={id}";

            var result = await _httpClient.GetFromJsonAsync<IEnumerable<PostResponseModel>>(url);
            
            return result.First();
        }

        public Task<IEnumerable<UserResponseModel>> GetUsers()
        {
            const string url = "/users";

            return _httpClient.GetFromJsonAsync<IEnumerable<UserResponseModel>>(url);
        }

        public Task<UserResponseModel> GetUser(int id)
        {
            var url = $"/users/{id}";

            return _httpClient.GetFromJsonAsync<UserResponseModel>(url);
        }

        public Task<IEnumerable<TodoResponseModel>> GetTodoItems(int userId)
        {
            var url = $"/todos?userId={userId}";

            var request = new HttpRequestMessage();

            return _httpClient.GetFromJsonAsync<IEnumerable<TodoResponseModel>>(url);
        }

        public Task<IEnumerable<TodoResponseModel>> GetTodosByStatus(int userId, bool isCompleted)
        {
            var url = $"/todos?userId={userId}&completed={isCompleted.ToString().ToLower()}";

            return _httpClient.GetFromJsonAsync<IEnumerable<TodoResponseModel>>(url);
        }

        public Task CreateUser(CreateUserRequestModel request)
        {
            const string url =  "/users";

            return _httpClient.PostAsJsonAsync(url, request);
        }
    }
}