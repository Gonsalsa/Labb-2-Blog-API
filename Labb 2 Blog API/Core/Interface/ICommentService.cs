using Labb_2_Blog_API.Data.DTO;

namespace Labb_2_Blog_API.Core.Interface
{
    public interface ICommentService
    {
        Task<bool> AddCommentAsync(AddCommentDTO dto, int userID);
    }
}
