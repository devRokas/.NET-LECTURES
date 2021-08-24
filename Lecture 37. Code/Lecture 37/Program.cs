using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Lecture_37
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();

            var jsonPlaceholderClient = serviceProvider.GetService<IJsonPlaceholderClient>();
            
            var githubClient = serviceProvider.GetService<IGithubClient>();
            
            var post = await jsonPlaceholderClient.GetPost(5);
            var devRokas = await githubClient.GetUser("devRokas");
        }
    }
}