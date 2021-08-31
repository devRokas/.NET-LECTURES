using RestAPI.Models;
using RestAPI.Models.ResponseModels;

namespace RestAPI
{
    public static class Extensions
    {
        public static CommentResponse MapToCommentResponse(this Comment comment)
        {
            return new CommentResponse
            {
                Id = comment.Id,
                Name = comment.Name,
                Email = comment.Email,
                Body = comment.Body
            };
        }
    }
}