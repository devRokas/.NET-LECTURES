using System.Text.Json.Serialization;
using Contracts.FavqsModels.Entities;

namespace Contracts.FavqsModels.RequestModels
{
    public class AddQuoteRequest
    {
        [JsonPropertyName("quote")]
        public SingleQuote Quote { get; set; }
    }
}