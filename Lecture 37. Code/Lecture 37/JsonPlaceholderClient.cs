using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
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
    }
}