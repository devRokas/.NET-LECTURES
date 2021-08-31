using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Contracts.FavqsModels.Entities
{
    public class Quote
    {
        public int Id { get; set; }

        [JsonPropertyName("favorites_count")]
        public int FavoritesCount { get; set; }

        public bool Dialogue { get; set; }

        public bool Favorite { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public string Url { get; set; }

        [JsonPropertyName("upvotes_count")]
        public int UpVotesCount { get; set; }
        
        [JsonPropertyName("downvotes_count")]
        public int DownVotesCount { get; set; }

        public string Author { get; set; }

        [JsonPropertyName("author_permalink")]
        public string AuthorPermalink { get; set; }

        public string Body { get; set; }
    }
}