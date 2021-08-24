using System.Text.Json.Serialization;

namespace Lecture_37.Models.JsonPlaceholder.ResponseModels
{
    public class PostResponseModel
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("body")]
        public string Body { get; set; }
        
        public override string ToString()
        {
            return $"{UserId} {Id} {Title} {Body}";
        }
    }
}