using System;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Models;

namespace NotesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var startup = new Startup();

            var serviceProvider = startup.ConfigureServices();

            var noteApp = serviceProvider.GetService<NoteApp>();

            var fileService = serviceProvider.GetService<IFileClient>();

            var notes = fileService.ReadAll<Note>("notes.txt");

            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
            
            

            // noteApp.Start();
        }
    }
}