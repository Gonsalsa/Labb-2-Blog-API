using Labb_2_Blog_API.Context;
using Labb_2_Blog_API.Data.Enteties;
using Labb_2_Blog_API.Data.Interfaces;

namespace Labb_2_Blog_API.Data.Repos
{
    public class CommentRepo : ICommentRepo
    {
        private readonly AppDbContext _context;

        public CommentRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddCommentAsync(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }
    }
}
