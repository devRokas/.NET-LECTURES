using System.Collections.Generic;
using System.Linq;
using Persistence.Models;

namespace Persistence.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private const string FileName = "users.txt";
        private readonly IFileClient _fileClient;

        public UsersRepository(IFileClient fileClient)
        {
            _fileClient = fileClient;
        }
        
        public IEnumerable<User> GetAll()
        {
            return _fileClient.ReadAll<User>(FileName);
        }

        public void Save(User note)
        {
            _fileClient.Append(FileName, note);
        }

        public void Edit(int id, string username, string password)
        {
            var allNotes = _fileClient.ReadAll<User>(FileName).ToList();
            var noteToUpdate = allNotes.First(note => note.Id == id);

            noteToUpdate.Username = username;
            noteToUpdate.Password = password;
            
            _fileClient.WriteAll(FileName, allNotes);
        }

        public void Delete(int id)
        {
            var allNotes = _fileClient.ReadAll<User>(FileName);
            var updatedNotes = allNotes.Where(note => note.Id != id);
         
            _fileClient.WriteAll(FileName, updatedNotes);
        }

        public void DeleteAll()
        {
            _fileClient.DeleteFileContents(FileName);
        }
    }
}