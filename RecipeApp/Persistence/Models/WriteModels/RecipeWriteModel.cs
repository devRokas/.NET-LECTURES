using System;
using Contracts.Enums;

namespace Persistence.Models.WriteModels
{
    public class RecipeWriteModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Difficulty Difficulty { get; set; }

        public TimeSpan TimeToComplete { get; set; }

        public DateTime DateCreated { get; set; }
    }
}