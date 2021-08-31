using System;
using System.Net.Http.Headers;
using FavQ.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace FavQ
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient<IFavqsClient, FavqsClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://favqs.com/api/");
                httpClient.DefaultRequestHeaders.Add("Authorization","Token token=b7d7140ad9e2741e0d5e4722385976a1");
            });

            return services.BuildServiceProvider();
        }
    }
}