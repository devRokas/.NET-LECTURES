using System;
using System.Collections.Generic;
using System.Linq;
using Persistence.Models;
using Persistence.Repositories;

namespace Domain.Services
{
    public class NotesService : INotesService
    {
        private readonly List<string> _swearWords;
        private readonly INotesRepository _notesRepository;

        public NotesService(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
            _swearWords = new List<string>
            {
                "Car",
                "Tree",
                "Walk",
                "Dog",
                "Dirty"
            };
        }

        public IEnumerable<Note> GetAll()
        {
            var allNotes = _notesRepository.GetAll();
            var validNotes = allNotes.Where(note => note.Text.Length >= 10);
            
            return validNotes;
        }

        public void Create(Note note)
        {
            var isNoteInvalid = _swearWords.Any(swearWord => note.Text.Contains(swearWord));
            
            if (isNoteInvalid)
            {
                throw new Exception("Note is invalid!");
            }

            _notesRepository.Save(note);
        }

        public void Edit(int id, string title, string text)
        {
            _notesRepository.Edit(id, title, text);
        }

        public void DeleteById(int id)
        {
            _notesRepository.Delete(id);
        }

        public int ClearAll()
        {
            return _notesRepository.DeleteAll();
        }
    }
}