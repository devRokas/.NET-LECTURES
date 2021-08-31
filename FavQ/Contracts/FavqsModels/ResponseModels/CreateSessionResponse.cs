using System.Text.Json.Serialization;

namespace Contracts.FavqsModels.ResponseModels
{
    public class CreateSessionResponse
    {
        public string Login { get; set; }

        public string Email { get; set; }

        [JsonPropertyName("User-Token")]
        public string UserToken { get; set; }
    }
}