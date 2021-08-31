namespace RestAPI.Models.RequestModels
{
    public class AddCommentRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Body { get; set; }
    }
}