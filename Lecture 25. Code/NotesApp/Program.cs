using System;
using System.Collections.Generic;
using Persistence;
using Persistence.Models;
using Persistence.Repositories;

namespace NotesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //
            // var notes = new List<Note>
            // {
            //     new Note
            //     {
            //         Id = 1,
            //         Title = "First note",
            //         Text = "Text of our first note",
            //         DateCreated = DateTime.Now
            //     }
            // };
            //
            // fileClient.WriteAll<Note>("notes.txt", notes);
            //
            // var notesFromFile = fileClient.ReadAll<Note>("notes.txt");
            //
            // foreach (var note in notesFromFile)
            // {
            //     Console.WriteLine(note.Id);
            //     Console.WriteLine(note.Title);
            //     Console.WriteLine(note.Text);
            //     Console.WriteLine(note.DateCreated);
            // }
            //
            // var note = new Note
            // {
            //     Id = 1,
            //     Title = "First note",
            //     Text = "Text of our first note",
            //     DateCreated = DateTime.Now
            // };
            //
            // var fileClient = new FileClient();
            // var notesRepository = new NotesRepository(fileClient);
            //
            // notesRepository.Save(note);
            //
            // // notesRepository.Edit(1, "Updated title", "Updated note text");
            //
            // var retrievedNotes = notesRepository.GetAll();
            //
            // foreach (var retrievedNote in retrievedNotes)
            // {
            //     Console.WriteLine(retrievedNote.Id);
            //     Console.WriteLine(retrievedNote.Title);
            //     Console.WriteLine(retrievedNote.Text);
            //     Console.WriteLine(retrievedNote.DateCreated);
            // }
            
            var fileClient = new FileClient();
            var notesRepository = new NotesRepository(fileClient);

            var noteApp = new NoteApp(notesRepository);
            
            noteApp.Start();
        }
    }
}