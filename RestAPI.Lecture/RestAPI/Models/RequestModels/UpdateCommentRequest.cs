using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models.RequestModels
{
    public class UpdateCommentRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Body { get; set; }
    }
}