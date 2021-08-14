using Microsoft.Extensions.DependencyInjection;

namespace NotesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var startup = new Startup();

            var serviceProvider = startup.ConfigureServices();

            var noteApp = serviceProvider.GetService<NoteApp>();

            noteApp.Start();
        }
    }
}