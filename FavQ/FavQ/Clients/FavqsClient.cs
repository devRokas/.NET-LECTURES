using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Contracts.FavqsModels.Entities;
using Contracts.FavqsModels.RequestModels;
using Contracts.FavqsModels.ResponseModels;

namespace FavQ.Clients
{
    class FavqsClient : IFavqsClient
    {
        private readonly HttpClient _httpClient;

        public FavqsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CreateSessionResponse> CreateSession(CreateSessionRequest request)
        {
            // "https://favqs.com/api/session"
            var url = "session";
            
            var response = await _httpClient.PostAsJsonAsync(url, request);

            return await response.Content.ReadFromJsonAsync<CreateSessionResponse>();
        }

        public Task<Quote> GetQuote(int id)
        {
            var url = $"quotes/{id}";

            return _httpClient.GetFromJsonAsync<Quote>(url);
        }

        public async Task<Quote> AddQuote(string userToken, AddQuoteRequest request)
        {
            const string url = "quotes";

            var httpRequest = new HttpRequestMessage
            {
                Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Post,
                RequestUri = new Uri(_httpClient.BaseAddress, url)
            };
            
            httpRequest.Headers.Add("User-Token", userToken);

            var response = await _httpClient.SendAsync(httpRequest);

            return await response.Content.ReadFromJsonAsync<Quote>();
        }
    }
}