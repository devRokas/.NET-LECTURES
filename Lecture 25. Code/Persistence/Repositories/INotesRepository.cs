using System.Collections.Generic;
using Persistence.Models;

namespace Persistence.Repositories
{
    public interface INotesRepository
    {
        IEnumerable<Note> GetAll();

        int Save(Note note);

        int Edit(int id, string title, string text);

        int Delete(int id);

        int DeleteAll();
    }
}