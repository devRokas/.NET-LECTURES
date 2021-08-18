using System;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace RecipeApp
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services
                .AddPersistence()
                .AddDomain();

            services.AddSingleton<RecipeApp>();

            return services.BuildServiceProvider();
        }
    }
}