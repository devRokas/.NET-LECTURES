using System;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;

namespace Lecture_37
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            services.AddHttpClient<IGithubClient, GithubClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://api.github.com");
            });
            
            services.AddHttpClient<IJsonPlaceholderClient, JsonPlaceholderClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Token token=");
            });

            services.AddSingleton<IJsonPlaceholderService, JsonPlaceholderService>();

            return services.BuildServiceProvider();
        }
    }
}