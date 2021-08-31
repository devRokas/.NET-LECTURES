using System.Text.Json.Serialization;

namespace Contracts.FavqsModels.Entities
{
    public class SingleQuote
    {
        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}