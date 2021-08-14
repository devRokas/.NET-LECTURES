using System.Collections.Generic;
using Persistence.Models;

namespace Persistence.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private const string TableName = "Notes";
        private readonly ISqlClient _sqlClient;
        
        public NotesRepository(ISqlClient sqlClient)
        {
            _sqlClient = sqlClient;
        }
        // CRUD
        // Create - execute
        // Read - query
        // Update - execute
        // Delete - execute

        public IEnumerable<Note> GetAll()
        {
            var sql = $"SELECT * FROM {TableName}";
            
            return _sqlClient.Query<Note>(sql);
        }

        public int Save(Note note)
        {
            var sql = $"INSERT INTO {TableName} (Title, Text, DateCreated) Values (@Title, @Text, @DateCreated)";
            
            return _sqlClient.Execute(sql, note);
        }

        public int Edit(int id, string title, string text)
        {
            var sql = @$"UPDATE {TableName} SET
                        Title = @Title,
                        Text = @Text
                        WHERE Id = @Id";

            return _sqlClient.Execute(sql, new
            {
                Id = id,
                Title = title,
                Text = text
            });
        }

        public int Delete(int id)
        {
            var sql = $"DELETE FROM {TableName} WHERE Id = @Id";

            return _sqlClient.Execute(sql, new {Id = id});
        }

        public int DeleteAll()
        {
            var sql = $"DELETE FROM {TableName}";

            return _sqlClient.Execute(sql);
        }
    }
}