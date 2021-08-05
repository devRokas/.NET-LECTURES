using System;

namespace Persistence.Models.WriteModels
{
    public class NoteWriteModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime DateCreated { get; set; }
        
        public string NoteTitlePLusCreationDate { get; set; }
    }
}