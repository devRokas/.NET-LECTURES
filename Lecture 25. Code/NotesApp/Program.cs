using Domain.Services;
using Persistence;
using Persistence.Repositories;

namespace NotesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fileClient = new FileClient();
            
            var notesRepository = new NotesRepository(fileClient);
   
            var notesService = new NotesService(notesRepository);

            var noteApp = new NoteApp(notesService);
            
            noteApp.Start();
        }
    }
}