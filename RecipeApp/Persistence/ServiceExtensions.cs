using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            return services
                .AddSqlClient()
                .AddRepositories();
        }
        
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddSingleton<IRecipesRepository, RecipesRepository>()
                .AddSingleton<IDescriptionsRepository, DescriptionsRepository>();
        }

        private static IServiceCollection AddSqlClient(this IServiceCollection services)
        {
            var fluentConnectionStringBuilder = new FluentConnectionStringBuilder();
            
            var connectionString = fluentConnectionStringBuilder
                .AddServer("localhost")
                .AddPort(3306)
                .AddUserId("root")
                .AddPassword("testas")
                .AddDatabase("LearningSQL")
                .BuildConnectionString(true);
            
            return services.AddTransient<ISqlClient>(_ => new SqlClient(connectionString));
        }
    }
}