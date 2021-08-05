using System.Collections.Generic;
using System.Linq;
using Persistence.Models;

namespace Persistence.Repositories
{
    public class NotesRepository : INotesRepository, IGDPRRepository
    {
        private const string FileName = "notes.txt";
        private readonly IFileClient _fileClient;

        public NotesRepository(IFileClient fileClient)
        {
            _fileClient = fileClient;
        }
        
        public IEnumerable<Note> GetAll()
        {
            return _fileClient.ReadAll<Note>(FileName);
        }

        public void Save(Note note)
        {
            _fileClient.Append(FileName, note);
        }

        public void Edit(int id, string title, string text)
        {
            var allNotes = _fileClient.ReadAll<Note>(FileName).ToList();
            var noteToUpdate = allNotes.First(note => note.Id == id);

            noteToUpdate.Title = title;
            noteToUpdate.Text = text;
            
            _fileClient.WriteAll(FileName, allNotes);
        }

        public void Delete(int id)
        {
            var allNotes = _fileClient.ReadAll<Note>(FileName);
            var updatedNotes = allNotes.Where(note => note.Id != id);
         
            _fileClient.WriteAll(FileName, updatedNotes);
        }

        public void DeleteAll()
        {
            _fileClient.DeleteFileContents(FileName);
        }
    }
}