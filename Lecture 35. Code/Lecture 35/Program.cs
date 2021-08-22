using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lecture_35
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            var httpClient = new HttpClient();
            //
            // var request = new HttpRequestMessage();
            //
            // request.Method = HttpMethod.Get;
            // request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts");
            //
            // var response = await httpClient.SendAsync(request);

            // if ((int)response.StatusCode >= 200 && (int) response.StatusCode < 300)
            // {
            //     throw new Exception("Request failed");
            // }
            
            // var responseString = await response.Content.ReadAsStringAsync();
            //
            // var posts = JsonSerializer.Deserialize<List<Post>>(responseString);
            //
            // foreach (var post in posts)
            // {
            //     Console.WriteLine(post);
            // }

            // var posts = await httpClient.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");

            // var posts = await response.Content.ReadFromJsonAsync<List<Post>>();

            // foreach (var post in posts)
            // {
            //     Console.WriteLine(post);
            // }

            var post = new PostRequestModel
            {
                UserId = 1,
                Title = "foo",
                Body = "bar"
            };

            var postJson = JsonSerializer.Serialize(post);

            Console.WriteLine(postJson);

            var request = new HttpRequestMessage();

            request.RequestUri = new Uri(url);
            request.Method = HttpMethod.Post;
            request.Content = new StringContent(postJson, Encoding.UTF8, "application/json");
            
            var response = await httpClient.SendAsync(request);

            // var postResponse = await response.Content.ReadFromJsonAsync<PostResponseModel>();

            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }

    class PostResponseModel
    {
        public int UserId { get; set; }
        
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Body { get; set; }

        public override string ToString()
        {
            return $"{UserId} {Id} {Title}";
        }
    }

    class PostRequestModel
    {
        public int UserId { get; set; }
        
        public string Title { get; set; }
        
        public string Body { get; set; }
    }
}