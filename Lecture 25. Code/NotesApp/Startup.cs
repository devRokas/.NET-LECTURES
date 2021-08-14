using System;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using Persistence;
using Persistence.Repositories;

namespace NotesApp
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            AddSql(services);
            services.AddSingleton<INotesRepository, NotesRepository>();
            services.AddSingleton<INotesService, NotesService>();
            services.AddSingleton<NoteApp>();
            
            return services.BuildServiceProvider();
        }

        private IServiceCollection AddSql(IServiceCollection services)
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder();

            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.Port = 3306;
            connectionStringBuilder.UserID = "root";
            connectionStringBuilder.Password = "testas";
            connectionStringBuilder.Database = "LearningSQL";

            var connectionString = connectionStringBuilder.GetConnectionString(true);

            services.AddTransient<ISqlClient>(_ => new SqlClient(connectionString));

            return services;
        }
    }
}