using System;
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
            });

            return services.BuildServiceProvider();
        }
    }
}