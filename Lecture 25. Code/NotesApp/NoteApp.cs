using System;
using System.IO;
using Persistence.Repositories;

namespace NotesApp
{
    public class NoteApp
    {
        private readonly INotesRepository _notesRepository;

        public NoteApp(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public void Start()
        {
                string text;
                var title = string.Empty;
                while (true)
                {
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("1 - Show all notes");
                    Console.WriteLine("2 - Save note");
                    Console.WriteLine("3 - Edit note");
                    Console.WriteLine("4 - Delete note");
                    Console.WriteLine("5 - Delete all notes");
                    Console.WriteLine("6 - Exit");
                    
                    var chosenCommand = Console.ReadLine();
                    switch (chosenCommand)
                    {
                        case "1":
                            // show all notes
                            var allNotes = _notesRepository.GetAll();
                            foreach (var note in allNotes)
                            {
                                if (note.Text.Length > 100)
                                {
                                    Console.WriteLine(note.ToString());
                                }
                            }
                            
                            break;
                        case "2":
                            Console.WriteLine("Enter note Title:");
                            title = Console.ReadLine();
                            Console.WriteLine("Enter note Text: ");
                            text = Console.ReadLine();

                            File.WriteAllLines("", new string[] {text});

                            // Create note
                            break;
                        case "3":
                            Console.WriteLine("Enter note ID");
                            Console.WriteLine("Enter new note Title");
                            title = (Console.ReadLine());
                            Console.WriteLine("Enter new note Text");
                            text = (Console.ReadLine());

                            // Edit note
                            break;

                        case "4":
                            Console.WriteLine("Enter note ID:");

                            // Delete note
                            break;
                        case "5":
                            // Delete all notes
                            break;
                        case "6":
                            return;
                    }
            }
        }
    }
}