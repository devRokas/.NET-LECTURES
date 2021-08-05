using System;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Models;
using Persistence.Repositories;

namespace NotesApp
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            services.AddTransient<IFileClient, FileClient>();
            services.AddTransient<IFileClient, SuperFileClient>();
            
            services.AddTransient<IGDPRRepository, NotesRepository>();
            services.AddTransient<IGDPRRepository, UsersRepository>();
            
            services.AddSingleton<INotesRepository, NotesRepository>();
            services.AddSingleton<INotesService, NotesService>();

            services.AddSingleton<NoteApp>();

            return services.BuildServiceProvider();
        }
    }
}