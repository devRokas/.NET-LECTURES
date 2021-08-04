using System;
using Domain.Services;
using Persistence.Models;

namespace NotesApp
{
    public class NoteApp
    {
        private readonly INotesService _notesService;
        
        public NoteApp(INotesService notesService)
        {
            _notesService = notesService;
        }

        public void Start()
        {
                string text;
                string title;
                int id;
                
                while (true)
                {
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("1 - Show all notes");
                    Console.WriteLine("2 - Create note");
                    Console.WriteLine("3 - Edit note");
                    Console.WriteLine("4 - Delete note");
                    Console.WriteLine("5 - Delete all notes");
                    Console.WriteLine("6 - Exit");
                    
                    var chosenCommand = Console.ReadLine();
                    switch (chosenCommand)
                    {
                        case "1":
                            var allNotes = _notesService.GetAll();

                            foreach (var note in allNotes)
                            {
                                Console.WriteLine(note);
                            }
                            break;
                        case "2":
                            Console.WriteLine("Enter note ID");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter note Title:");
                            title = Console.ReadLine();
                            Console.WriteLine("Enter note Text: ");
                            text = Console.ReadLine();
                            
                            _notesService.Create(new Note
                            {
                                Id = id,
                                Title = title,
                                Text = text,
                                DateCreated = DateTime.Now
                            });
                            break;
                        case "3":
                            Console.WriteLine("Enter note ID");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new note Title");
                            title = Console.ReadLine();
                            Console.WriteLine("Enter new note Text");
                            text = Console.ReadLine();
                            
                            _notesService.Edit(id, title, text);
                            break;
                        case "4":
                            Console.WriteLine("Enter note ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            
                            _notesService.DeleteById(id);
                            break;
                        case "5":
                            _notesService.ClearAll();
                            Console.WriteLine("All notes were deleted");
                            break;
                        case "6":
                            return;
                    }
                }
        }
    }
}