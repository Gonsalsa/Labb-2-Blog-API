using Labb_2_Blog_API.Data.Enteties;

namespace Labb_2_Blog_API.Data.Interfaces
{
    public interface ICommentRepo
    {
        Task AddCommentAsync(Comment comment);
    }
}
