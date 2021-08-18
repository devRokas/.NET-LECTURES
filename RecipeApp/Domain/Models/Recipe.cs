using System;
using Contracts.Enums;

namespace Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Difficulty Difficulty { get; set; }

        public TimeSpan TimeToComplete { get; set; }

        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Description: {Description}; Difficulty: {Difficulty}; TimeToComplete: {TimeToComplete}; DateCreated: {DateCreated:d}";
        }
    }
}