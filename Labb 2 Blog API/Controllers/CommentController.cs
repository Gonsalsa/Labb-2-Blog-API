using Labb_2_Blog_API.Core.Interface;
using Labb_2_Blog_API.Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2_Blog_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(AddCommentDTO dto, int userId)
        {
            var ok = await _commentService.AddCommentAsync(dto, userId);

            if (!ok)
            {
                return BadRequest("Could not add comment");

            }
            else
            {
                return Ok("Comment added");
            }
        }
    }
}
