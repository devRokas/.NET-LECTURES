using System;
using Contracts.Enums;

namespace Persistence.Models.ReadModels
{
    public class RecipeReadModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Difficulty Difficulty { get; set; }

        public TimeSpan TimeToComplete { get; set; }

        public DateTime DateCreated { get; set; }
    }
}