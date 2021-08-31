using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Models.RequestModels;
using RestAPI.Models.ResponseModels;
using RestAPI.Persistence;

namespace RestAPI.Controllers
{
    // var repository = new CommentsRepository();

    // Incoming request {get, post, put}
    // Map route (url) which method responsible for handling that request
    // var controller = new Controller(repository)
    // controller.GetComments()
 
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsRepository _commentsRepository;
        public CommentsController(ICommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }
        
        [HttpGet]
        [Route("comments")]
        public IEnumerable<Comment> GetComments()
        {
            return _commentsRepository.GetAll();
        }

        [HttpGet]
        [Route("comments/{commentId}")]
        public ActionResult<Comment> GetComment(Guid commentId)
        {
            var comment = _commentsRepository.Get(commentId);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }
        
        [HttpPost]
        [Route("comments")]
        public ActionResult<CommentResponse> AddComment([FromBody] AddCommentRequest request)
        {
            var comment = new Comment
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Body = request.Body
            };
            
            _commentsRepository.Add(comment);
            
            return CreatedAtAction("GetComment", new { commentId = comment.Id }, comment.MapToCommentResponse());
        }

        [HttpPut]
        [Route("comments/{commentId}")]
        public ActionResult<CommentResponse> UpdateComment(Guid commentId, UpdateCommentRequest request)
        {
            if (request is null)
            {
                return BadRequest();
            }

            var commentToUpdate = _commentsRepository.Get(commentId);

            if (commentToUpdate is null)
            {
                return NotFound();
            }
            
            var updatedComment = _commentsRepository.Update(commentId, request.Email, request.Body);

            return updatedComment.MapToCommentResponse();
        }

        [HttpDelete]
        [Route("comments/{commentId}")]
        public IActionResult DeleteComment(Guid commentId)
        {
            var commentToDelete = _commentsRepository.Get(commentId);

            if (commentToDelete is null)
            {
                return NotFound();
            }
            
            _commentsRepository.Delete(commentId);

            return NoContent();
        }
    }
}