using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Lecture_37.Models.Github.ResponseModels;

namespace Lecture_37
{
    class GithubClient : IGithubClient
    {
        private readonly HttpClient _httpClient;

        public GithubClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserResponseModel> GetUser(string username)
        {
            var url = $"/users/{username}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, url),
            };
            
            request.Headers.Add("User-Agent", "test");

            var response = await _httpClient.SendAsync(request);
            
            return await response.Content.ReadFromJsonAsync<UserResponseModel>();
        }
    }
}